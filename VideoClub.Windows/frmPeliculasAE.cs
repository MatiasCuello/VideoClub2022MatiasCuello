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
using VideoClub.Windows.Helpers;

namespace VideoClub.Windows
{
    public partial class frmPeliculasAE : Form
    {
        public frmPeliculasAE()
        {
            InitializeComponent();
        }
        private Pelicula pelicula;

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            var servicio = new ServicioPeliculas();
            HelperCombos.CargarDatosComboGeneros(ref GenerosComboBox);
            HelperCombos.CargarDatosComboEstados(ref EstadosComboBox);
            HelperCombos.CargarDatosComboCalificaciones(ref CalificacionesComboBox);
            HelperCombos.CargarDatosComboSoportes(ref SoportesComboBox);
            if (pelicula != null)
            {
                TituloTextBox.Text = pelicula.Titulo;
                GenerosComboBox.SelectedValue = pelicula.GeneroId;
                FechaDateTimePicker.Value = pelicula.FechaIncorporacion;
                EstadosComboBox.SelectedValue = pelicula.EstadoId;
                CalificacionesComboBox.SelectedValue = pelicula.CalificacionId;
                DuracionTextBox.Text = pelicula.DuracionEnMinutos.ToString();
                SoportesComboBox.SelectedValue = pelicula.SoporteId;
                ActivoCheckBox.Checked = pelicula.Activa;
            }
        }

     

        public Pelicula GetPelicula()
        {
            return pelicula;
        }

        private void frmPeliculasAE_Load(object sender, EventArgs e)
        {

        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void OkButton_Click(object sender, EventArgs e)
        {

            if (ValidarDatos())
            {
                if (pelicula == null)
                {
                    pelicula = new Pelicula();
                }
                pelicula.Titulo = TituloTextBox.Text;
                pelicula.Genero = ((Genero)GenerosComboBox.SelectedItem);
                pelicula.FechaIncorporacion  =FechaDateTimePicker.Value;
                pelicula.Estado = ((Estado)EstadosComboBox.SelectedItem);
                pelicula.Calificacion = ((Calificacion)CalificacionesComboBox.SelectedItem);
                pelicula.DuracionEnMinutos = int.Parse(DuracionTextBox.Text);
                pelicula.Soporte= ((Soporte)SoportesComboBox.SelectedItem);
                if (pelicula.Activa == ActivoCheckBox.Checked)
                {
                    pelicula.Activa = true;
                    pelicula.Alquilado = false;
                }
                DialogResult = DialogResult.OK;
            }
        }

        private bool ValidarDatos()
        {
            bool valido = true;
            errorProvider1.Clear();
            if (string.IsNullOrEmpty(TituloTextBox.Text.Trim()))
            {
                valido = false;
                errorProvider1.SetError(TituloTextBox, "El Titulo es requerido");
            }

            if (GenerosComboBox.SelectedIndex == 0)
            {
                valido = false;
                errorProvider1.SetError(GenerosComboBox, "Debe seleccionar un genero");
            }

            if (string.IsNullOrEmpty(DuracionTextBox.Text.Trim()))
            {
                valido = false;
                errorProvider1.SetError(DuracionTextBox, "El tiempo de duracion es requerido");
            }
            if (EstadosComboBox.SelectedIndex == 0)
            {
                valido = false;
                errorProvider1.SetError(EstadosComboBox, "Debe seleccionar un Estado");
            }

            if (CalificacionesComboBox.SelectedIndex == 0)
            {
                valido = false;
                errorProvider1.SetError(CalificacionesComboBox, "Debe seleccionar una Calificacion");
            }

            if (SoportesComboBox.SelectedIndex == 0)
            {
                valido = false;
                errorProvider1.SetError(SoportesComboBox, "Debe seleccionar un Soporte");
            }

            return valido;
        }

        public void SetPelicula(Pelicula pelicula)
        {
            this.pelicula = pelicula;
        }
    }
}
