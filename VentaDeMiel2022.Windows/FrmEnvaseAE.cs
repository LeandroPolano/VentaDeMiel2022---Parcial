using Microsoft.Win32;
using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using VentaDeMiel2022.Entidades.Entidades;
using VentaDeMiel2022.Servicios.Servicios;
using VentaDeMiel2022.Servicios.Servicios.Facades;
using VentaDeMiel2022.Windows.Helpers;

namespace VentaDeMiel2022.Windows
{
    public partial class FrmEnvaseAE : Form
    {
        private byte[] miImagen = null;
        private string imagenNoDisponible = Environment.CurrentDirectory + @"\Imagenes\ImagenNoDisponible.jpg";

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            //servicio=new ServicioTipoEnvases();
            HelperCombos.CargarDatosComboTipoEnvase(ref TipoEnvasesComboBox);
            if (envase != null)
            {
                EnvaseTextBox.Text = envase.Descripcion;
                PrecioVtaTextBox.Text = envase.Precio.ToString();
                StockNumericUpDown.Value = envase.Stock;
                TipoEnvasesComboBox.SelectedValue = envase.TipoEnvaseId;

                if (envase.Imagen != null)
                {
                    MemoryStream ms = new MemoryStream(envase.Imagen);
                    Bitmap bmp = new Bitmap(ms);
                    ImagenPictureBox.Image = bmp;
                }
                else
                {
                    ImagenPictureBox.Image = Image.FromFile(imagenNoDisponible);
                }
            }
        }

        public FrmEnvaseAE()
        {
            InitializeComponent();
        }

        private Envase envase;
        public Envase GetEnvase()
        {
            return envase;
        }

        private void CancelarIconButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void OKIconButton_Click(object sender, EventArgs e)
        {
            if (ValidarDatos())
            {
                if (envase == null)
                {
                    envase = new Envase();
                }

                envase.Descripcion = EnvaseTextBox.Text;
                envase.TipoEnvaseId = ((TipoEnvase)TipoEnvasesComboBox.SelectedItem).TipoEnvaseId;
                envase.Precio = decimal.Parse(PrecioVtaTextBox.Text);
                envase.Stock = (int)StockNumericUpDown.Value;

                if (miImagen != null)
                {
                    envase.Imagen = miImagen;
                }
                DialogResult = DialogResult.OK;
            }
        }

        private bool ValidarDatos()
        {
            bool valido = true;
            errorProvider1.Clear();
            if (string.IsNullOrEmpty(EnvaseTextBox.Text.Trim()))
            {
                valido = false;
                errorProvider1.SetError(EnvaseTextBox, "La descripción es requerida");
            }

            if (!decimal.TryParse(PrecioVtaTextBox.Text, out decimal precioResult))
            {
                valido = false;
                errorProvider1.SetError(PrecioVtaTextBox, "Precio mal ingresado");
            }
            else if (precioResult <= 0 || precioResult > decimal.MaxValue)
            {
                valido = false;
                errorProvider1.SetError(PrecioVtaTextBox, "Precio fuera del rango permitido");
            }

            if (TipoEnvasesComboBox.SelectedIndex == 0)
            {
                valido = false;
                errorProvider1.SetError(TipoEnvasesComboBox, "Debe seleccionar un tipo de envase");
            }

            return valido;
        }

        public void SetEnvase(Envase envase)
        {
            this.envase = envase;
        }

        private void BuscarIconButton_Click(object sender, EventArgs e)
        {
            openFileDialog1.InitialDirectory = Environment.CurrentDirectory + @"\Imagenes\";
            openFileDialog1.Filter = "Archivos jpg (*.jpg)|*.jpg|Archivos png (*.png)|*.png|Archivos jfif (*.jfif)|*.jfif";
            openFileDialog1.FilterIndex = 1;
            openFileDialog1.RestoreDirectory = true;
            DialogResult dr = openFileDialog1.ShowDialog(this);

            if (dr == DialogResult.OK)
            {
                if (openFileDialog1.FileName == null)
                {
                    return;
                }

                Stream miStream = openFileDialog1.OpenFile();
                using (MemoryStream ms = new MemoryStream())
                {
                    miStream.CopyTo(ms);
                    miImagen = ms.ToArray();

                    Bitmap bmp = new Bitmap(ms);
                    ImagenPictureBox.Image = bmp;
                }
            }
        }
    }
}
