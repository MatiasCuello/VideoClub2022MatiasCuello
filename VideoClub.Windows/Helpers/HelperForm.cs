using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VideoClub.Windows.Helper;

namespace VideoClub.Windows.Helpers
{
    public class HelperForm
    {
        public static void MostrarDatosEnGrilla<T>(DataGridView dataGridView, List<T> objList)
        {
            //DatosDataGridView.Rows.Clear();
            HelperGrilla.LimpiarGrilla(dataGridView);
            foreach (var obj in objList)
            {
                //var r = ConstruirFila();
                var r = HelperGrilla.ConstruirFila(dataGridView);
                HelperGrilla.SetearFila(r, obj);
                HelperGrilla.AgregarFila(dataGridView, r);
            }
        }
    }
}
