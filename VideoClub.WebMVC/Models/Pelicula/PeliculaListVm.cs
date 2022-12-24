using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace VideoClub.WebMVC.Models.Pelicula
{
    public class PeliculaListVm
    {

        public int PeliculaId { get; set; }
        public string Titulo { get; set; }

        [DisplayName("Genero")]

        public int GeneroId { get; set; }

        [DisplayName("Fecha")]
        public DateTime FechaIncorporacion { get; set; } = DateTime.Now;

        [DisplayName("Estado")]

        public int EstadoId { get; set; }

        [DisplayName("Duración(min)")]
        public int DuracionEnMinutos { get; set; }

        [DisplayName("Calificación")]
        public int CalificacionId { get; set; }

        [DisplayName("Soporte")]
        public int SoporteId { get; set; }
        public bool Activa { get; set; } = true;
        public bool Alquilado { get; set; } = false;


    }
}