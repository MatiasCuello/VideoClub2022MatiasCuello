using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AutoMapper;
using VideoClub.Servicios.Servicios.Facades;

namespace VideoClub.WebMVC.Controllers
{
    public class EstadoController : Controller
    {
        // GET: Estado

        private readonly IServicioEstados servicio;
        private readonly IMapper mapper;

        public EstadoController(IServicioEstados servicio, IMapper mapper)
        {
            this.servicio = servicio;
            this.mapper = mapper;   
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