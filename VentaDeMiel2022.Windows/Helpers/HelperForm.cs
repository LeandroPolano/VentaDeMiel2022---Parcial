using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VentaDeMiel2022.Windows.Helpers
{
    public static class HelperForm 
    {
        public static void MostrarDatosEnGrilla<P>(DataGridView dataGridView, List<P> objList)
        {
            //DatosDataGridView.Rows.Clear();
            HelperGrid.LimpiarGrilla(dataGridView);
            foreach (var obj in objList)
            {
                //var r = ConstruirFila();
                var r = HelperGrid.ConstruirFila(dataGridView);
                HelperGrid.SetearFila(r, obj);
                HelperGrid.AgregarFila(dataGridView, r);
            }
        }

}
}
