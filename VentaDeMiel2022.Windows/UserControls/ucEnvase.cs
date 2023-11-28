using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace VentaDeMiel2022.Windows.UserControls
{
    public partial class ucEnvase : UserControl
    {
        private string imagenNoDisponible = Environment.CurrentDirectory + @"\Imagenes\ImagenNoDisponible.jpg";

        public ucEnvase()
        {
            InitializeComponent();
        }

        public int EnvaseId { get; set; }

        public string Descripcion
        {
            set { DescripcionLabel.Text = value; }
        }

        public string Precio
        {
            set { PrecioLabel.Text = value; }
        }

        public byte[] Imagen
        {
            set
            {
                if (value == null)
                {
                    ImagenPictureBox.Image = Image.FromFile(imagenNoDisponible);
                }
                else
                {
                    MemoryStream ms = new MemoryStream(value);
                    Bitmap bmp = new Bitmap(ms);
                    ImagenPictureBox.Image = bmp;
                }

            }
        }

        private void ucEnvase_MouseEnter(object sender, EventArgs e)
        {
            this.BackColor = Color.Silver;
        }

        private void ucEnvase_MouseLeave(object sender, EventArgs e)
        {
            this.BackColor = Color.White;
        }
    }
}
