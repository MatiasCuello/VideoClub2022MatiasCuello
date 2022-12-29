using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using VideoClub.Entidades.Entidades;
using VideoClub.Servicios.Servicios;
using VideoClub.Servicios.Servicios.Facades;
using VideoClub.WebMVC.App_Start;
using VideoClub.WebMVC.Models.Soporte;

namespace VideoClub.WebMVC.Controllers
{
    public class SoporteController : Controller
    {
        // GET: Soporte
        private readonly IServicioSoportes servicio;
        private readonly IMapper mapper;
        public SoporteController(ServicioSoportes servicio)
        {
            this.servicio = servicio;
            mapper = AutoMapperConfig.Mapper;
        }

        [HttpGet]
        public JsonResult ListarSoportes()
        {
            var lista = servicio.GetLista();
            return Json(new { data = lista }, JsonRequestBehavior.AllowGet);
        }
        public ActionResult Index()
        {
            var lista = servicio.GetLista();
            return View(lista);
        }
        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(SoporteEditVm soporteEditVm)
        {
            if (!ModelState.IsValid)
            {
                return View(soporteEditVm);
            }
            try
            {
                Soporte soporte = mapper.Map<Soporte>(soporteEditVm);
                if (servicio.Existe(soporte))
                {
                    ModelState.AddModelError(string.Empty, "Soporte existente!!!");
                    return View(soporteEditVm);
                }
                servicio.Guardar(soporte);
                return RedirectToAction("Index");
            }
            catch (Exception e)
            {
                ModelState.AddModelError(string.Empty, e.Message);
                return View(soporteEditVm);
            }
        }
        [HttpGet]
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            Soporte soporte = servicio.GetSoportePorId(id.Value);
            if (soporte == null)
            {
                return HttpNotFound("El codigo del soporte no existe!");
            }

            SoporteEditVm soporteEditVm = mapper.Map<SoporteEditVm>(soporte);
            return View(soporteEditVm);

        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(SoporteEditVm soporteEditVm)
        {
            if (!ModelState.IsValid)
            {
                return View(soporteEditVm);
            }

            Soporte soporte = mapper.Map<Soporte>(soporteEditVm);
            try
            {
                if (servicio.Existe(soporte))
                {
                    ModelState.AddModelError(string.Empty, "Soporte existente!");
                    return View(soporteEditVm);
                }
                servicio.Guardar(soporte);
                return RedirectToAction("Index");
            }
            catch (Exception e)
            {
                ModelState.AddModelError(string.Empty, e.Message);
                return View(soporteEditVm);
            }
        }
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);

            }

            Soporte soporte = servicio.GetSoportePorId(id.Value);
            if (soporte == null)
            {
                return HttpNotFound("El codigo de la calificacion no existe!");
            }

            SoporteEditVm soporteEditVm = mapper.Map<SoporteEditVm>(soporte);
            return View(soporteEditVm);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirm(int id)
        {
            Soporte soporte = servicio.GetSoportePorId(id);
            try
            {
                if (servicio.EstaRelacionado(soporte))
                {
                    SoporteEditVm soporteEditVm = mapper.Map<SoporteEditVm>(soporte);
                    ModelState.AddModelError(string.Empty, "Soporte relacionada!");
                    return View(soporteEditVm);
                }

                servicio.Borrar(soporte);
                return RedirectToAction("Index");
            }
            catch (Exception e)
            {
                SoporteEditVm soporteEditVm = mapper.Map<SoporteEditVm>(soporte);
                ModelState.AddModelError(string.Empty, e.Message);
                return View(soporteEditVm);
            }
        }
    }
}