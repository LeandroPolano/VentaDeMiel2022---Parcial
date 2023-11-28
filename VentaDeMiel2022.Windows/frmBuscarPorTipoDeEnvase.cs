using System;
using System.Windows.Forms;
using VentaDeMiel2022.Entidades.Entidades;
using VentaDeMiel2022.Windows.Helpers;

namespace VentaDeMiel2022.Windows
{
    public partial class frmBuscarPorTipoDeEnvase : Form
    {
        public frmBuscarPorTipoDeEnvase()
        {
            InitializeComponent();
        }

        private TipoEnvase tipoEnvase;

        private void frmBuscarPorTipoDeEnvase_Load(object sender, EventArgs e)
        {
            HelperCombos.CargarDatosComboTipoEnvase(ref TipoEnvasesComboBox);
        }

        private void CancelarIconButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void OKIconButton_Click(object sender, EventArgs e)
        {
            if (ValidarDatos())
            {
                DialogResult = DialogResult.OK;
            }
        }

        private bool ValidarDatos()
        {
            bool valido = true;
            errorProvider1.Clear();
            if (TipoEnvasesComboBox.SelectedIndex == 0)
            {
                valido = false;
                errorProvider1.SetError(TipoEnvasesComboBox, "Debe seleccionar un tipo de envase");
            }

            return valido;
        }

        private void TipoEnvasesComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (TipoEnvasesComboBox.SelectedIndex > 0)
            {
                tipoEnvase = (TipoEnvase)TipoEnvasesComboBox.SelectedItem;
            }
            else
            {
                tipoEnvase = null;
            }
        }

        public TipoEnvase GetTipo()
        {
            return tipoEnvase;
        }
    }
}
