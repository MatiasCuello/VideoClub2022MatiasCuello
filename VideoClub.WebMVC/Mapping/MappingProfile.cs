using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using VideoClub.Entidades.Entidades;
using VideoClub.WebMVC.Models.Calificacion;
using VideoClub.WebMVC.Models.Genero;
using VideoClub.WebMVC.Models.Pelicula;
using VideoClub.WebMVC.Models.Soporte;

namespace VideoClub.WebMVC.Mapping
{
    public class MappingProfile:Profile
    {
        public MappingProfile()
        {
            LoadCalificacionMapping();
            LoadPeliculasMapping();
        }

        private void LoadPeliculasMapping()
        {
            CreateMap<Pelicula, PeliculaListVm>()
                .ForMember(dest => dest.FechaIncorporacion,
                    opt => opt.MapFrom(src => src.FechaIncorporacion.ToShortDateString()));
            CreateMap<Pelicula, PeliculaListVm>()
                .ForMember(dest => dest.Calificacion,
                    opt => opt.MapFrom(src => src.Calificacion));
            CreateMap<Pelicula, PeliculaListVm>()
                .ForMember(dest => dest.Genero,
                    opt => opt.MapFrom(src => src.Genero));
            CreateMap<Pelicula, PeliculaListVm>()
                .ForMember(dest => dest.Soporte,
                    opt => opt.MapFrom(src => src.Soporte));
            CreateMap<Pelicula, PeliculaListVm>()
                .ForMember(dest => dest.Estado,
                    opt => opt.MapFrom(src => src.Estado));

        }

        private void LoadCalificacionMapping()
        {
            CreateMap<Calificacion, CalificacionEditVm>().ReverseMap();
        }

        private void LoadGeneroMapping()
        {
            CreateMap<Genero, GeneroEditVm>().ReverseMap();

        }

        private void LoadSoporteMapping()
        {
            CreateMap<Soporte, SoporteEditVm>().ReverseMap();
        }

    }
}