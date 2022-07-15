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
using VentaDeMiel2022.Servicio.Servicios;
using VentaDeMiel2022.Servicio.Servicios.Facades;
using VentaDeMiel2022.Windows.Helpers;

namespace VentaDeMiel2022.Windows
{
    public partial class FrmClienteAE : Form
    {
        public FrmClienteAE()
        {
            InitializeComponent();
        }

        private IServicioClientes servicio;

        private Cliente cliente;
        public Cliente GetCliente()
        {
            return cliente;
        }
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            servicio = new ServicioCliente();
            HelperCombos.CargarDatosComboTipoDocumento(ref TipoDeDocumentoComboBox);
            //HelperCombos.CargarDatosComboLocalidad(ref LocalidadComboBox);
            //HelperCombos.CargarDatosComboProvincia(ref ProvinciaComboBox);
            HelperCombos.CargarDatosComboPais(ref PaisComboBox);

            if (cliente != null)
            {
                NombreTextBox.Text = cliente.Nombre;
                ApellidoTextBox.Text = cliente.Apellido;
                TipoDeDocumentoComboBox.SelectedValue = cliente.TipoDeDocumentoId;
                NroDocumentoTextBox.Text = cliente.NroDocumento;
                DireccionTextBox.Text = cliente.Direccion;
                LocalidadComboBox.SelectedValue = cliente.LocalidadId;
                ProvinciaComboBox.SelectedValue = cliente.ProvinciaId;
                PaisComboBox.SelectedValue = cliente.PaisId;
                TelefonoFijoTextBox.Text = cliente.TelefonoFijo;
                TelefonoMovilTextBox.Text = cliente.TelefonoMovil;
                CorreoElectronicoTextBox.Text = cliente.CorreoElectronico;


            }

        }
        private void GuardarIconButton_Click(object sender, EventArgs e)
        {
            if (ValidarDatos())
            {
                if (ValidarDatos())
                {
                    if (cliente == null)
                    {
                        cliente = new Cliente();
                    }

                    cliente.Nombre = NombreTextBox.Text;
                    cliente.Apellido = ApellidoTextBox.Text;
                    cliente.TipoDeDocumentoId = ((TipoDeDocumento)TipoDeDocumentoComboBox.SelectedItem).TipoDeDocumentoId;
                    cliente.TipoDeDocumento = (TipoDeDocumento)TipoDeDocumentoComboBox.SelectedItem;
                    cliente.NroDocumento = NroDocumentoTextBox.Text;
                    cliente.Direccion = DireccionTextBox.Text;
                    cliente.LocalidadId = ((Localidad)LocalidadComboBox.SelectedItem).LocalidadId;
                    cliente.NombreLocalidad = (Localidad)LocalidadComboBox.SelectedItem;
                    cliente.ProvinciaId = ((Provincia)ProvinciaComboBox.SelectedItem).ProvinciaId;
                    cliente.NombreProvincia = (Provincia)ProvinciaComboBox.SelectedItem;
                    cliente.PaisId = ((Pais)PaisComboBox.SelectedItem).PaisId;
                    cliente.NombrePais = (Pais)PaisComboBox.SelectedItem;
                    cliente.TelefonoFijo = TelefonoFijoTextBox.Text;
                    cliente.TelefonoMovil = TelefonoMovilTextBox.Text;
                    cliente.CorreoElectronico = CorreoElectronicoTextBox.Text;


                    DialogResult = DialogResult.OK;
                }
            }
        }
        private bool ValidarDatos()
        {
            bool valido = true;
            errorProvider1.Clear();
            if (string.IsNullOrEmpty(NombreTextBox.Text.Trim()))
            {
                valido = false;
                errorProvider1.SetError(NombreTextBox, "El Nombre es requerido");
            }
            if (string.IsNullOrEmpty(ApellidoTextBox.Text.Trim()))
            {
                valido = false;
                errorProvider1.SetError(ApellidoTextBox, "El Apellido es requerido");
            }
            if (string.IsNullOrEmpty(NroDocumentoTextBox.Text.Trim()))
            {
                valido = false;
                errorProvider1.SetError(NroDocumentoTextBox, "El Numero de documento es requerido");
            }
            if (string.IsNullOrEmpty(DireccionTextBox.Text.Trim()))
            {
                valido = false;
                errorProvider1.SetError(DireccionTextBox, "La Direccion es requerida");
            }
         
           
            if (TipoDeDocumentoComboBox.SelectedIndex == 0)
            {
                valido = false;
                errorProvider1.SetError(TipoDeDocumentoComboBox, "Debe seleccionar un Tipo De Documento");
            }
            if (LocalidadComboBox.SelectedIndex == 0)
            {
                valido = false;
                errorProvider1.SetError(LocalidadComboBox, "Debe seleccionar una localidad");
            }
            if (ProvinciaComboBox.SelectedIndex == 0)
            {
                valido = false;
                errorProvider1.SetError(ProvinciaComboBox, "Debe seleccionar una provincia");
            }
            if (PaisComboBox.SelectedIndex == 0)
            {
                valido = false;
                errorProvider1.SetError(PaisComboBox, "Debe seleccionar un pais");
            }

            return valido;
        }

        private void CancelarIconButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        public void SetCliente(Cliente cliente1)
        {
            this.cliente = cliente1;
        }

        private Provincia provincia = null;
        private void ProvinciaComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ProvinciaComboBox.SelectedIndex!=0)
            {
                provincia = (Provincia)ProvinciaComboBox.SelectedItem;
                HelperCombos.CargarDatosComboLocalidad(ref LocalidadComboBox, provincia);
            }
            else
            {
                LocalidadComboBox.DataSource = null;
                provincia = null;
            }
        }

        private Pais pais = null;
        private void PaisComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (PaisComboBox.SelectedIndex != 0)
            {
                pais = (Pais)PaisComboBox.SelectedItem;
                HelperCombos.CargarDatosComboProvincia(ref ProvinciaComboBox, pais);

            }
            else
            {
                ProvinciaComboBox.DataSource = null;
                pais = null;
            }
        }

        private void FrmClienteAE_Load(object sender, EventArgs e)
        {

        }
    }
}
