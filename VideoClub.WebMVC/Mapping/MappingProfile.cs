using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using VideoClub.Entidades.Entidades;
using VideoClub.WebMVC.Models.Calificacion;
using VideoClub.WebMVC.Models.Genero;

namespace VideoClub.WebMVC.Mapping
{
    public class MappingProfile:Profile
    {
        public MappingProfile()
        {
            LoadCalificacionMapping();
        }

        private void LoadCalificacionMapping()
        {
            CreateMap<Calificacion, CalificacionEditVm>().ReverseMap();
            CreateMap<Genero, GeneroEditVm>().ReverseMap();

        }
    }
}