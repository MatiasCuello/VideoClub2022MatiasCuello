using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VideoClub.Entidades.Entidades;
using VideoClub.Servicios.Servicios;
using VideoClub.Servicios.Servicios.Facades;
using VideoClub.Windows.Helper;
using VideoClub.Windows.Helpers;

namespace VideoClub.Windows
{
    public partial class frmPeliculas : Form
    {
        public frmPeliculas()
        {
            InitializeComponent();
        }

        private void CerrarToolStripButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private IServicioPeliculas servicio;
        private List<Pelicula> lista;
        private Pelicula pelicula;

        private void frmPeliculas_Load(object sender, EventArgs e)
        {
            servicio = new ServicioPeliculas(null,null,null);
            RecargarGrilla();
        }

        private void NuevoToolStripButton_Click(object sender, EventArgs e)
        {
            frmPeliculasAE frm = new frmPeliculasAE() { Text = "Agregar Pelicula" };
            DialogResult dr = frm.ShowDialog(this);
            if (dr == DialogResult.Cancel)
            {
                return;
            }
            try
            {
                Pelicula pelicula = frm.GetPelicula();
                if (!servicio.Existe(pelicula))
                {
                    servicio.Guardar(pelicula);
                    RecargarGrilla();

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

        private void RecargarGrilla()
        {
            try
            {
                lista = servicio.GetLista(null, null, null, null);
                HelperForm.MostrarDatosEnGrilla(DatosDataGridView, lista);
            }
            catch (Exception exception)
            {
                HelperMensaje.Mensaje(TipoMensaje.Error, exception.Message, "Error");
            }
        }

        private void BorrarToolStripButton_Click(object sender, EventArgs e)
        {
            if (DatosDataGridView.SelectedRows.Count == 0)
            {
                return;
            }
            var r = DatosDataGridView.SelectedRows[0];
            Pelicula p = (Pelicula)r.Tag;
            DialogResult dr = HelperMensaje.Mensaje($"¿Desea borrar la pelicula seleccionada?",
              "Confirmar Eliminacion");
            if (dr == DialogResult.No)
            {
                return;
            }
            try
            {

                servicio.Borrar(p.PeliculaId);
                HelperGrilla.BorrarFila(DatosDataGridView, r);
                HelperMensaje.Mensaje(TipoMensaje.OK, "Registro eliminado",
                    "Mensaje");

            }
            catch (Exception exception)
            {
                HelperMensaje.Mensaje(TipoMensaje.Error, exception.Message,
                    "Error");
            }
        }


        private void EditarToolStripButton_Click(object sender, EventArgs e)
        {
            if (DatosDataGridView.SelectedRows.Count == 0)
            {
                return;
            }
            var r = DatosDataGridView.SelectedRows[0];
            Pelicula p = (Pelicula)r.Tag;
            //Pelicula PeliAuxiliar = (Pelicula)p.Clone();
            try
            {
                frmPeliculasAE frm = new frmPeliculasAE()
                { Text = "Editar Pelicula" };
                frm.SetPelicula(p);
                DialogResult dr = frm.ShowDialog(this);
                if (dr == DialogResult.Cancel)
                {
                    return;
                }

                p = frm.GetPelicula();
                if (!servicio.Existe(p))
                {
                    servicio.Guardar(p);
                    HelperGrilla.SetearFila(r, p);
                    HelperMensaje.Mensaje(TipoMensaje.OK, "Pelicula editada", "Mensaje");
                }
                else
                {
                    //HelperGrilla.SetearFila(r, PeliAuxiliar);
                    HelperMensaje.Mensaje(TipoMensaje.Error, "Pelicula Existente", "Error");
                }

            }
            catch (Exception exception)
            {
                //HelperGrilla.SetearFila(r, PeliAuxiliar);

                HelperMensaje.Mensaje(TipoMensaje.Error, exception.Message, "Error");
            }
        }
    }
}

