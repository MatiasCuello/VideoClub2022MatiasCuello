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
using VideoClub.WebMVC.Models.Genero;

namespace VideoClub.WebMVC.Controllers
{
    public class GeneroController : Controller
    {
        // GET: Genero
        private readonly IServicioGeneros servicio;
        private readonly IMapper mapper;
        public GeneroController(ServicioGeneros servicio)
        {
            this.servicio = servicio;
            mapper = AutoMapperConfig.Mapper;
        }
        public ActionResult Index()
        {
            var lista = servicio.GetLista();
            return View(lista);
        }
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(GeneroEditVm generoEditVm)
        {
            if (!ModelState.IsValid)
            {
                return View(generoEditVm);
            }
            try
            {
                Genero genero = mapper.Map<Genero>(generoEditVm);
                if (servicio.Existe(genero))
                {
                    ModelState.AddModelError(string.Empty, "Genero existente!!!");
                    return View(generoEditVm);
                }
                servicio.Guardar(genero);
                return RedirectToAction("Index");
            }
            catch (Exception e)
            {
                ModelState.AddModelError(string.Empty, e.Message);
                return View(generoEditVm);
            }
        }
        [HttpGet]
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            Genero genero = servicio.GetGeneroPorId(id.Value);
            if (genero == null)
            {
                return HttpNotFound("El codigo del Genero no existe!");
            }

            GeneroEditVm generoEditVm = mapper.Map<GeneroEditVm>(genero);
            return View(generoEditVm);

        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(GeneroEditVm generoEditVm)
        {
            if (!ModelState.IsValid)
            {
                return View(generoEditVm);
            }

            Genero genero = mapper.Map<Genero>(generoEditVm);
            try
            {
                if (servicio.Existe(genero))
                {
                    ModelState.AddModelError(string.Empty, "Genero existente!");
                    return View(generoEditVm);
                }
                servicio.Guardar(genero);
                return RedirectToAction("Index");
            }
            catch (Exception e)
            {
                ModelState.AddModelError(string.Empty, e.Message);
                return View(generoEditVm);
            }
        }
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);

            }

            Genero genero = servicio.GetGeneroPorId(id.Value);
            if (genero == null)
            {
                return HttpNotFound("El codigo del genero no existe!");
            }

            GeneroEditVm calificacionEditVm = mapper.Map<GeneroEditVm>(genero);
            return View(calificacionEditVm);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirm(int id)
        {
            Genero genero = servicio.GetGeneroPorId(id);
            try
            {
                if (servicio.EstaRelacionado(genero))
                {
                    GeneroEditVm generoEditVm = mapper.Map<GeneroEditVm>(genero);
                    ModelState.AddModelError(string.Empty, "Genero relacionado!");
                    return View(generoEditVm);
                }

                servicio.Borrar(genero);
                return RedirectToAction("Index");
            }
            catch (Exception e)
            {
                GeneroEditVm generoEditVm = mapper.Map<GeneroEditVm>(genero);
                ModelState.AddModelError(string.Empty, e.Message);
                return View(generoEditVm);
            }
        }
    }
}