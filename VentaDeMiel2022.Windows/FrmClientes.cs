using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FontAwesome.Sharp;
using VentaDeMiel2022.Entidades.Entidades;
using VentaDeMiel2022.Entidades.Enum;
using VentaDeMiel2022.Servicio.Servicios;
using VentaDeMiel2022.Servicio.Servicios.Facades;
using VentaDeMiel2022.Windows.Helpers;

namespace VentaDeMiel2022.Windows
{
    public partial class FrmClientes : Form
    {
        public FrmClientes()
        {
            InitializeComponent();
        }
        private IServicioClientes servicio;
        private List<Cliente> lista;
        private IconButton botonOrdenActual;
        private void NuevoIconButton_Click(object sender, EventArgs e)
        {
            FrmClienteAE frm = new FrmClienteAE() { Text = "Clientes" };
            DialogResult dr = frm.ShowDialog(this);
            if (dr == DialogResult.Cancel)
            {
                return;
            }
            try
            {
                Cliente cliente = frm.GetCliente();
                if (!servicio.Existe(cliente))
                {
                    servicio.Guardar(cliente);
                    DataGridViewRow r = HelperGrid.ConstruirFila(DatosDataGridView);
                    HelperGrid.SetearFila(r, cliente);
                    HelperGrid.AgregarFila(DatosDataGridView, r);
                    HelperMensaje.Mensaje(TipoMensaje.OK, "Registro agregado", "Mensaje");
                }
                else
                {
                    HelperMensaje.Mensaje(TipoMensaje.Error, "Registro repetido!!", "Error");
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public TipoDeDocumento td;
        public Localidad L;
        public Provincia pr;
        public Pais p;
        public Orden orden;
        private void FrmClientes_Load(object sender, EventArgs e)
        {
            servicio = new ServicioCliente();
            RecargarGrilla();
        }
        private void RecargarGrilla()
        {
            try
            {
                lista = servicio.GetLista();
                HelperForm.MostrarDatosEnGrilla(DatosDataGridView, lista);
            }
            catch (Exception exception)
            {
                HelperMensaje.Mensaje(TipoMensaje.Error, exception.Message, "Error");
            }
        }

        private void BorrarIconButton_Click(object sender, EventArgs e)
        {
            if (DatosDataGridView.SelectedRows.Count == 0)
            {
                return;
            }

            var r = DatosDataGridView.SelectedRows[0];
            Cliente p = (Cliente)r.Tag;
            DialogResult dr = HelperMensaje.Mensaje($"¿Desea borrar el cliente: {p.Nombre} {p.Apellido} Documento: {p.NroDocumento}?",
                "Confirmar Borrado");
            if (dr == DialogResult.No)
            {
                return;
            }

            try
            {
                if (!servicio.EstaRelacionado(p))
                {
                    servicio.Borrar(p.ClienteId);
                    HelperGrid.BorrarFila(DatosDataGridView, r);
                    HelperMensaje.Mensaje(TipoMensaje.OK, "Registro eliminado",
                        "Mensaje");
                }
                else
                {
                    HelperMensaje.Mensaje(TipoMensaje.Error, "Registro relacionado" + Environment.NewLine + "Baja denegada",
                        "Error");

                }
            }
            catch (Exception exception)
            {
                HelperMensaje.Mensaje(TipoMensaje.Error, exception.Message,
                    "Error");
            }
        }

        private void EditarIconButton_Click(object sender, EventArgs e)
        {
            if (DatosDataGridView.SelectedRows.Count == 0)
            {
                return;
            }
            var r = DatosDataGridView.SelectedRows[0];
            Cliente l = (Cliente)r.Tag;
            Cliente lAuxiliar = (Cliente)l.Clone();

            try
            {
                FrmClienteAE frm = new FrmClienteAE() { Text = "Editar un cliente" };
                frm.SetCliente(l);
                DialogResult dr = frm.ShowDialog(this);
                if (dr == DialogResult.Cancel)
                {
                    return;
                }

                l = frm.GetCliente();
                if (!servicio.Existe(l))
                {
                    servicio.Guardar(l);
                    HelperGrid.SetearFila(r, l);
                    HelperMensaje.Mensaje(TipoMensaje.OK, "Cliente editado", "Mensaje");
                }
                else
                {
                    HelperGrid.SetearFila(r, lAuxiliar);
                    HelperMensaje.Mensaje(TipoMensaje.Error, "Cliente existente", "Error");
                }

            }
            catch (Exception exception)
            {
                HelperGrid.SetearFila(r, lAuxiliar);

                HelperMensaje.Mensaje(TipoMensaje.Error, exception.Message, "Error");
            }
        }

        private void CerrarButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
