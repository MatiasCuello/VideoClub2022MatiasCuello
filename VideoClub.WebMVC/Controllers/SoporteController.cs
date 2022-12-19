using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using VideoClub.Servicios.Servicios;
using VideoClub.Servicios.Servicios.Facades;

namespace VideoClub.WebMVC.Controllers
{
    public class SoporteController : Controller
    {
        // GET: Soporte
        private readonly IServicioSoportes servicio;
        public SoporteController()
        {
            servicio = new ServicioSoportes();
        }
        public ActionResult Index()
        {
            var lista = servicio.GetLista();
            return View(lista);
        }
    }
}