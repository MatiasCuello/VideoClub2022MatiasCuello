using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VideoClub.Entidades.Entidades;
using VideoClub.Servicios.Servicios;
using VideoClub.Servicios.Servicios.Facades;

namespace VideoClub.Windows.Helpers
{
    public class HelperCombos
    {
        public static void CargarDatosComboGeneros(ref ComboBox combo)
        {
            IServicioGeneros servicio = new ServicioGeneros();
            var lista = servicio.GetLista();
            Genero generoDefault = new Genero()
            {
                GeneroId = 0,
                Descripcion = "<Seleccionar Genero>"
            };
            lista.Insert(0, generoDefault);
            combo.DataSource = lista;
            combo.DisplayMember = "Descripcion";
            combo.ValueMember = "GeneroId";
            combo.SelectedIndex = 0;
        }

        public static void CargarDatosComboEstados(ref ComboBox combo)
        {
            IServicioEstados servicio = new ServicioEstados();
            var lista = servicio.GetLista();
            Estado estadoDefault = new Estado()
            {
                EstadoId = 0,
                Descripcion = "<Seleccionar Estado>"
            };
            lista.Insert(0, estadoDefault);
            combo.DataSource = lista;
            combo.DisplayMember = "Descripcion";
            combo.ValueMember = "EstadoId";
            combo.SelectedIndex = 0;
        }
        public static void CargarDatosComboCalificaciones(ref ComboBox combo)
        {
            IServicioCalificaciones servicio = new ServicioCalificaciones();
            var lista = servicio.GetLista();
            Calificacion calificaionDefault = new Calificacion()
            {
                CalificacionId = 0,
                Descripcion = "<Seleccionar Calificacion>"
            };
            lista.Insert(0, calificaionDefault);
            combo.DataSource = lista;
            combo.DisplayMember = "Descripcion";
            combo.ValueMember = "CalificacionId";
            combo.SelectedIndex = 0;
        }
        public static void CargarDatosComboSoportes(ref ComboBox combo)
        {
            IServicioSoportes servicio = new ServicioSoportes();
            var lista = servicio.GetLista();
            Soporte soporteDefault = new Soporte()
            {
                SoporteId = 0,
                Descripcion = "<Seleccionar Soporte>"
            };
            lista.Insert(0, soporteDefault);
            combo.DataSource = lista;
            combo.DisplayMember = "Descripcion";
            combo.ValueMember = "SoporteId";
            combo.SelectedIndex = 0;
        }
    }
}
