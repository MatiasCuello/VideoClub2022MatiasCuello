using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VideoClub.Entidades.Entidades;

namespace VideoClub.Windows.Helper
{
    public class HelperGrilla
    {
        public static void BorrarFila(DataGridView dataGridView, DataGridViewRow r)
        {
            dataGridView.Rows.Remove(r);
        }
        public static void AgregarFila(DataGridView dataGridView, DataGridViewRow r)
        {
            dataGridView.Rows.Add(r);
        }
        public static void LimpiarGrilla(DataGridView dataGridView)
        {
            dataGridView.Rows.Clear();
        }

        public static DataGridViewRow ConstruirFila(DataGridView dataGridView)
        {
            var r = new DataGridViewRow();
            r.CreateCells(dataGridView);
            return r;

        }

        public static void SetearFila(DataGridViewRow r, object obj)
        {
            switch (obj)
            {
                case Pelicula p:
                    r.Cells[0].Value = ((Pelicula)obj).FechaIncorporacion;
                    r.Cells[1].Value = ((Pelicula)obj).Titulo;
                    r.Cells[2].Value = ((Pelicula)obj).Genero.Descripcion;
                    r.Cells[3].Value = ((Pelicula)obj).Estado.Descripcion;
                    r.Cells[4].Value = ((Pelicula)obj).DuracionEnMinutos;
                    r.Cells[5].Value = ((Pelicula)obj).Calificacion.Descripcion;
                    r.Cells[6].Value = ((Pelicula)obj).Soporte.Descripcion;
                    r.Cells[7].Value = ((Pelicula)obj).Alquilado;
                    r.Cells[8].Value = ((Pelicula)obj).Activa;

                    r.Tag = p;
                    break;

            }
        }
    }
}
