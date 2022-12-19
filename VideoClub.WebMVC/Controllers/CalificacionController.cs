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
using VideoClub.WebMVC.Models.Calificacion;

namespace VideoClub.WebMVC.Controllers
{
    public class CalificacionController : Controller
    {
        // GET: Calificacion
        private readonly IServicioCalificaciones servicio;
        private readonly IMapper mapper;
        public CalificacionController()
        {
            servicio = new ServicioCalificaciones();
            mapper = AutoMapperConfig.Mapper;
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
        public ActionResult Create(CalificacionEditVm calificacionEditVm)
        {
            if (!ModelState.IsValid)
            {
                return View(calificacionEditVm);
            }
            try
            {
                Calificacion calificacion = mapper.Map<Calificacion>(calificacionEditVm);
                if (servicio.Existe(calificacion))
                {
                    ModelState.AddModelError(string.Empty, "Calificacion existente!!!");
                    return View(calificacionEditVm);
                }
                servicio.Guardar(calificacion);
                return RedirectToAction("Index");
            }
            catch (Exception e)
            {
                ModelState.AddModelError(string.Empty, e.Message);
                return View(calificacionEditVm);
            }
        }
        [HttpGet]
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            Calificacion calificacion = servicio.GetCalificacionPorId(id.Value);
            if (calificacion == null)
            {
                return HttpNotFound("El codigo de la Calificacion no existe!");
            }

            CalificacionEditVm calificacionEditVm = mapper.Map<CalificacionEditVm>(calificacion);
            return View(calificacionEditVm);

        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(CalificacionEditVm calificacionEditVm)
        {
            if (!ModelState.IsValid)
            {
                return View(calificacionEditVm);
            }

            Calificacion calificacion = mapper.Map<Calificacion>(calificacionEditVm);
            try
            {
                if (servicio.Existe(calificacion))
                {
                    ModelState.AddModelError(string.Empty, "Calificacion existente!");
                    return View(calificacionEditVm);
                }
                servicio.Guardar(calificacion);
                return RedirectToAction("Index");
            }
            catch (Exception e)
            {
                ModelState.AddModelError(string.Empty, e.Message);
                return View(calificacionEditVm);
            }
        }
        [HttpGet]
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);

            }

            Calificacion calificacion = servicio.GetCalificacionPorId(id.Value);
            if (calificacion == null)
            {
                return HttpNotFound("El codigo de la calificacion no existe!");
            }

            CalificacionEditVm calificacionEditVm = mapper.Map<CalificacionEditVm>(calificacion);
            return View(calificacionEditVm);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirm(int id)
        {
            Calificacion calificacion = servicio.GetCalificacionPorId(id);
            try
            {
                if (servicio.EstaRelacionado(calificacion))
                {
                    CalificacionEditVm calificacionEditVm = mapper.Map<CalificacionEditVm>(calificacion);
                    ModelState.AddModelError(string.Empty, "Calificacion relacionada!");
                    return View(calificacionEditVm);
                }

                servicio.Borrar(calificacion);
                return RedirectToAction("Index");
            }
            catch (Exception e)
            {
                CalificacionEditVm calificacionEditVm = mapper.Map<CalificacionEditVm>(calificacion);
                ModelState.AddModelError(string.Empty, e.Message);
                return View(calificacionEditVm);
            }
        }
    }
}