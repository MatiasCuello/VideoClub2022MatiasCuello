using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AutoMapper;
using VideoClub.Servicios.Servicios;
using VideoClub.Servicios.Servicios.Facades;
using VideoClub.WebMVC.App_Start;

namespace VideoClub.WebMVC.Controllers
{
    public class EstadoController : Controller
    {
        // GET: Estado

        private readonly IServicioEstados servicio;
        private readonly IMapper mapper;

        public EstadoController(ServicioEstados servicio)
        {
            this.servicio = servicio;
            mapper = AutoMapperConfig.Mapper;
        }
        // GET: Pelicula
        [HttpGet]
        public JsonResult ListarEstados()
        {
            var lista = servicio.GetLista();
            return Json(new { data = lista }, JsonRequestBehavior.AllowGet);
        }
        public ActionResult Index()
        {
            return View();
        }

    }
}