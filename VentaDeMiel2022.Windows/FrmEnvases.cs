using FontAwesome.Sharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VentaDeMiel2022.Entidades.Entidades;
using VentaDeMiel2022.Entidades.Enum;
using VentaDeMiel2022.Servicios.Servicios.Facades;
using VentaDeMiel2022.Windows.Helpers;

namespace VentaDeMiel2022.Windows
{
    public partial class FrmEnvases : Form
    {
        private IconButton botonOrdenActual;
        public FrmEnvases(IServicioEnvases servicio)
        {
            InitializeComponent();
            this.servicio = servicio;
        }
        private void CerrarIconButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private IServicioEnvases servicio;
        private List<Envase> lista;
        private void frmEnvases_Load(object sender, EventArgs e)
        {
            //servicio=new ServicioEnvases();
            RecargarGrilla(Orden.BD);
        }

        private void RecargarGrilla(Orden orden)
        {
            try
            {
                lista = servicio.GetLista(null, orden);
                HelperForm.MostrarDatosEnGrilla(DatosDataGridView, lista);
                //MostrarDatosEnGrilla();
            }
            catch (Exception exception)
            {
                HelperMensaje.Mensaje(TipoMensaje.Error, exception.Message, "Error");
            }
        }


        private void NuevoIconButton_Click(object sender, EventArgs e)
        {
            FrmEnvaseAE frm = new FrmEnvaseAE() { Text = "Agregar Envase" };
            DialogResult dr = frm.ShowDialog(this);
            if (dr == DialogResult.Cancel)
            {
                return;
            }

            try
            {
                Envase envase = frm.GetEnvase();
                if (!servicio.Existe(envase))
                {
                    servicio.Guardar(envase);
                    RecargarGrilla(Orden.BD);
                    //DataGridViewRow r = HelperGrid.ConstruirFila(DatosDataGridView);
                    //HelperGrid.SetearFila(r, envase);
                    //HelperGrid.AgregarFila(DatosDataGridView, r);
                    HelperMensaje.Mensaje(TipoMensaje.OK, "Registro agregado", "Mensaje");

                }
                else
                {
                    HelperMensaje.Mensaje(TipoMensaje.Error, "Registro repetido!!", "Error");
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "Mensaje", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }


        private void BorrarIconButton_Click(object sender, EventArgs e)
        {
            if (DatosDataGridView.SelectedRows.Count == 0)
            {
                return;
            }

            var r = DatosDataGridView.SelectedRows[0];
            Envase p = (Envase)r.Tag;
            DialogResult dr = HelperMensaje.Mensaje($"¿Desea borrar el envase {p.Descripcion}?",
                "Confirmar Borrado");
            if (dr == DialogResult.No)
            {
                return;
            }

            try
            {
                if (!servicio.EstaRelacionado(p))
                {
                    servicio.Borrar(p.EnvaseId);
                    HelperGrid.BorrarFila(DatosDataGridView, r);
                    HelperMensaje.Mensaje(TipoMensaje.OK, "Registro eliminado",
                        "Mensaje");
                }
                else
                {
                    HelperMensaje.Mensaje(TipoMensaje.Error, "Registro relacionado" + Environment.NewLine + "Baja denegada!!!",
                        "Error");

                }
            }
            catch (Exception exception)
            {
                HelperMensaje.Mensaje(TipoMensaje.Error, exception.Message,
                    "Error");
            }
        }

        private void FiltrariconButton_Click(object sender, EventArgs e)
        {
            if (FiltrariconButton.BackColor == Color.Transparent)
            {
                frmBuscarPorTipoDeEnvase frm = new frmBuscarPorTipoDeEnvase() { Text = "Seleccione un tipo de envase" };
                DialogResult dr = frm.ShowDialog(this);
                if (dr == DialogResult.Cancel)
                {
                    return;
                }

                try
                {
                    TipoEnvase tp = frm.GetTipo();
                    lista = servicio.GetLista(tp, Orden.BD);
                    HelperForm.MostrarDatosEnGrilla(DatosDataGridView, lista);
                    FiltrariconButton.BackColor = Color.OrangeRed;
                }
                catch (Exception exception)
                {
                    HelperMensaje.Mensaje(TipoMensaje.Error, exception.Message, "Error");
                }

            }
            else
            {
                lista = servicio.GetLista(null, Orden.BD);
                HelperForm.MostrarDatosEnGrilla(DatosDataGridView, lista);
                FiltrariconButton.BackColor = Color.Transparent;
            }
        }

        private void OredenarAZPorEnvaseiconButton_Click(object sender, EventArgs e)
        {
            if (botonOrdenActual != (IconButton)sender)
            {
                RecargarGrilla(Orden.AZ);
            }
            else
            {
                RecargarGrilla(Orden.BD);
            }
            ManejarColorBotonOrden((IconButton)sender);
            //try
            //{
            //    lista = servicio.GetLista(null, Orden.AZ);
            //    HelperForm.MostrarDatosEnGrilla(DatosDataGridView,lista);
            //}
            //catch (Exception exception)
            //{
            //    HelperMensaje.Mensaje(TipoMensaje.Error, exception.Message, "Error");
            //}
        }

        private void ManejarColorBotonOrden(IconButton sender)
        {
            if (botonOrdenActual == null)
            {
                botonOrdenActual = sender;
                botonOrdenActual.BackColor = Color.OrangeRed;
            }
            else
            {
                if (botonOrdenActual == sender)
                {
                    botonOrdenActual = null;
                    sender.BackColor = Color.Transparent;
                }
                else
                {
                    botonOrdenActual.BackColor = Color.Transparent;
                    botonOrdenActual = sender;
                    botonOrdenActual.BackColor = Color.OrangeRed;
                }
            }
        }

        private void OrdenarZAPorEnvaseiconButton_Click(object sender, EventArgs e)
        {
            if (botonOrdenActual != (IconButton)sender)
            {
                RecargarGrilla(Orden.ZA);

            }
            else
            {
                RecargarGrilla(Orden.BD);
            }
            ManejarColorBotonOrden((IconButton)sender);
            //try
            //{
            //    lista = servicio.GetLista(null, Orden.ZA);
            //    HelperForm.MostrarDatosEnGrilla(DatosDataGridView, lista);
            //}
            //catch (Exception exception)
            //{
            //    HelperMensaje.Mensaje(TipoMensaje.Error, exception.Message, "Error");
            //}

        }

        private void OrdenarPrecioAsciIconButton_Click(object sender, EventArgs e)
        {
            if (botonOrdenActual != (IconButton)sender)
            {
                RecargarGrilla(Orden.ASC);

            }
            else
            {
                RecargarGrilla(Orden.BD);
            }

            ManejarColorBotonOrden((IconButton)sender);


            //try
            //{
            //    lista = servicio.GetLista(null, Orden.ASC);
            //    HelperForm.MostrarDatosEnGrilla(DatosDataGridView, lista);
            //}
            //catch (Exception exception)
            //{
            //    HelperMensaje.Mensaje(TipoMensaje.Error, exception.Message, "Error");
            //}

        }

        private void PrecioDescIconButton_Click(object sender, EventArgs e)
        {
            if (botonOrdenActual != (IconButton)sender)
            {
                RecargarGrilla(Orden.DESC);

            }
            else
            {
                RecargarGrilla(Orden.BD);
            }

            ManejarColorBotonOrden((IconButton)sender);


            //try
            //{
            //    lista = servicio.GetLista(null, Orden.DESC);
            //    HelperForm.MostrarDatosEnGrilla(DatosDataGridView, lista);
            //}
            //catch (Exception exception)
            //{
            //    HelperMensaje.Mensaje(TipoMensaje.Error, exception.Message, "Error");
            //}

        }

        private void EditarIconButton_Click(object sender, EventArgs e)
        {
            if (DatosDataGridView.SelectedRows.Count == 0)
            {
                return;
            }
            var r = DatosDataGridView.SelectedRows[0];
            Envase p = (Envase)r.Tag;
            Envase pAuxiliar = (Envase)p.Clone();

            try
            {
                FrmEnvaseAE frm = new FrmEnvaseAE() { Text = "Editar un Envase" };
                frm.SetEnvase(p);
                DialogResult dr = frm.ShowDialog(this);
                if (dr == DialogResult.Cancel)
                {
                    return;
                }

                p = frm.GetEnvase();
                if (!servicio.Existe(p))
                {
                    servicio.Guardar(p);
                    HelperGrid.SetearFila(r, p);
                    HelperMensaje.Mensaje(TipoMensaje.OK, "Envase editado", "Mensaje");
                }
                else
                {
                    HelperGrid.SetearFila(r, pAuxiliar);
                    HelperMensaje.Mensaje(TipoMensaje.Error, "Envase existente..", "Error");
                }

            }
            catch (Exception exception)
            {
                HelperGrid.SetearFila(r, pAuxiliar);

                HelperMensaje.Mensaje(TipoMensaje.Error, exception.Message, "Error");
            }
        }
    
}
}
