using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace VideoClub.WebMVC.Models.Pelicula
{
    public class PeliculaEditVm
    {
        public int PeliculaId { get; set; }
        [Required(ErrorMessage = "El campo {0} es requerido")]
        [StringLength(50, ErrorMessage = "el campo {0} debe tener entre {2} y {1} caracteres", MinimumLength = 2)]
        public string Titulo { get; set; }

        [DisplayName("Genero")]
        [Required(ErrorMessage = "El campo {0} es requerido")]
        [Range(1, int.MaxValue, ErrorMessage = "Debe seleccionar un Genero")]
        public int GeneroId { get; set; }

        [DisplayName("Fecha")]
        [Required(ErrorMessage = "El campo {0} es requerido")]
        
        public DateTime FechaIncorporacion { get; set; } = DateTime.Now.Date;

        [DisplayName("Estado")]
        [Required(ErrorMessage = "El campo {0} es requerido")]
        [Range(1, int.MaxValue, ErrorMessage = "Debe seleccionar un Estado")]
        public int EstadoId { get; set; }

        [DisplayName("Duracion(min)")]
        [Required(ErrorMessage = "El campo {0} es requerido")]
        public int DuracionEnMinutos { get; set; }

        [DisplayName("Calificacion")]
        [Required(ErrorMessage = "El campo {0} es requerido")]
        [Range(1, int.MaxValue, ErrorMessage = "Debe seleccionar una Calificacion")]
        public int CalificacionId { get; set; }

        [DisplayName("Soporte")]
        [Required(ErrorMessage = "El campo {0} es requerido")]
        [Range(1, int.MaxValue, ErrorMessage = "Debe seleccionar un Soporte")]
        public int SoporteId { get; set; }
        public bool Alquilado { get; set; } = false;
        public bool Activa { get; set; } = true;

        public List<Entidades.Entidades.Genero> Generos { get; set; }
        public List<Entidades.Entidades.Estado> Estados { get; set; }
        public List<Entidades.Entidades.Calificacion> Calificaciones { get; set; }

        public List<Entidades.Entidades.Soporte> Soportes { get; set; }
    }
}