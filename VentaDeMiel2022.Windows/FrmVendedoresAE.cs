using System;
using System.Windows.Forms;
using VentaDeMiel2022.Entidades.Entidades;

namespace VentaDeMiel2022.Windows
{
    public partial class FrmVendedoresAE : Form
    {
        public FrmVendedoresAE()
        {
            InitializeComponent();
        }
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            if (vendedor != null)
            {
                NombreTextBox.Text = vendedor.Nombre;
                ApellidoTextBox.Text = vendedor.Apellido;
                FechaDeNacimientoDateTimePicker.Value =vendedor.FechaNacimiento.Date;
                NroDocumentoTextBox.Text = vendedor.NroDocumento;
                DireccionTextBox.Text = vendedor.Direccion;
                TelefonoFijoTextBox.Text = vendedor.TelefonoFijo;
                TelefonoMovilTextBox.Text = vendedor.TelefonoMovil;
                CorreoElectronicoTextBox.Text = vendedor.Correo;
               
            }
        }
        private Vendedor vendedor;
        public Vendedor GetTipo()
        {
            return vendedor;
        }

        public void SetTipo(Vendedor vendedor1)
        {
            this.vendedor = vendedor1;
        }

        private void OKIconButton_Click(object sender, EventArgs e)
        {
            if (ValidarDatos())
            {
                if (vendedor == null)
                {
                    vendedor = new Vendedor();
                }

                vendedor.Nombre = NombreTextBox.Text;
                vendedor.Apellido = ApellidoTextBox.Text;
                vendedor.FechaNacimiento =FechaDeNacimientoDateTimePicker.Value;
                vendedor.NroDocumento = NroDocumentoTextBox.Text;
                vendedor.Direccion = DireccionTextBox.Text;
                vendedor.TelefonoFijo = TelefonoFijoTextBox.Text;
                vendedor.TelefonoMovil = TelefonoMovilTextBox.Text;
                vendedor.Correo = CorreoElectronicoTextBox.Text;
               
                
                
                

                DialogResult = DialogResult.OK;

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
            if (string.IsNullOrEmpty(FechaDeNacimientoDateTimePicker.Text.Trim()))
            {
                valido = false;
                errorProvider1.SetError(FechaDeNacimientoDateTimePicker, "La Fecha de nacimiento es requerida");
            }
            if (string.IsNullOrEmpty(NroDocumentoTextBox.Text.Trim()))
            {
                valido = false;
                errorProvider1.SetError(NroDocumentoTextBox, "El Numero de documento es requerido");
            }
            if (string.IsNullOrEmpty(DireccionTextBox.Text.Trim()))
            {
                valido = false;
                errorProvider1.SetError(DireccionTextBox, "La direccion es requerida");
            }
            if (string.IsNullOrEmpty(TelefonoFijoTextBox.Text.Trim()))
            {
                valido = false;
                errorProvider1.SetError(TelefonoFijoTextBox, "Por razones de comunicacion (Telefono Fijo requerido)");
            }
            if (string.IsNullOrEmpty(TelefonoMovilTextBox.Text.Trim()))
            {
                valido = false;
                errorProvider1.SetError(TelefonoMovilTextBox, "Por razones de comunicacion (Telefono Movil requerido)");
            }
            if (string.IsNullOrEmpty(CorreoElectronicoTextBox.Text.Trim()))
            {
                valido = false;
                errorProvider1.SetError(CorreoElectronicoTextBox, "Por razones de comunicacion (El Correo requerido)");
            }


            return valido;
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void FrmVendedoresAE_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
