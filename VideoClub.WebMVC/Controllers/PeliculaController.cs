using System;
using System.Collections.Generic;
using System.Drawing.Printing;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AutoMapper;
using VideoClub.Servicios.Servicios.Facades;
using VideoClub.WebMVC.App_Start;

namespace VideoClub.WebMVC.Controllers
{
    public class PeliculaController : Controller
    {
        private readonly IServicioPeliculas servicio;
        private readonly IServicioCalificaciones servicioCalificaciones;
        private readonly IServicioEstados servicioEstados;
        private readonly IServicioSoportes servicioSoportes;
        private readonly IServicioGeneros servicioGeneros;
        private readonly IMapper mapper;

        public PeliculaController(IServicioPeliculas servicio, IServicioCalificaciones servicioCalificaciones, IServicioEstados servicioEstados, IServicioSoportes servicioSoportes, IServicioGeneros servicioGeneros)
        {
            this.servicio = servicio;
            this.servicioCalificaciones = servicioCalificaciones;
            this.servicioEstados = servicioEstados;
            this.servicioSoportes = servicioSoportes;
            this.servicioGeneros = servicioGeneros;
            mapper = AutoMapperConfig.Mapper;
        }
        // GET: Pelicula
        public ActionResult Index()
        { 
            return View();
        }

        [HttpGet]
        public JsonResult ListarPeliculas()
        {
            var lista = servicio.GetLista(null,null,null,null);
            return Json(new { data = lista }, JsonRequestBehavior.AllowGet);
        }
    }
}