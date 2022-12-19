using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VideoClub.Entidades.Entidades
{
    public class Pelicula:ICloneable
    {
        public int PeliculaId { get; set; }
        public string Titulo { get; set; }
        public int GeneroId { get; set; }
        public DateTime FechaIncorporacion { get; set; }
        public int EstadoId { get; set; }
        public int DuracionEnMinutos { get; set; }
        public int CalificacionId { get; set; }
        public int SoporteId { get; set; }
        public bool Alquilado { get; set; } = false;
        public bool Activa { get; set; } = true;

        public Genero Genero { get; set; }
        public Estado Estado { get; set; }
        public Calificacion Calificacion { get; set; }
        public Soporte Soporte { get; set; }

        public object Clone()
        {
            return this.MemberwiseClone();
        }
    }
}
