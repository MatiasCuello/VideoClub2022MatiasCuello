using System;
using System.Collections.Generic;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Mvc;
using AutoMapper;
using Newtonsoft.Json;
using VideoClub.Entidades.Entidades;
using VideoClub.Servicios.Servicios.Facades;
using VideoClub.WebMVC.App_Start;
using VideoClub.WebMVC.Models.Pelicula;

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
            var lista = servicio.GetLista();
            var listaVm = mapper.Map<List<PeliculaListVm>>(lista);
            return Json(new { data = listaVm }, JsonRequestBehavior.AllowGet);
        }

        [HttpPost]
        public JsonResult GuardarPelicula(string objeto)
        {
            object resultado = null;
            string mensaje = string.Empty;
            try
            {
                Pelicula peliculaRecibida = new Pelicula();
                peliculaRecibida = JsonConvert.DeserializeObject<Pelicula>(objeto);
                //Pelicula peliculaAGuardar = new Pelicula()
                //{
                //    PeliculaId = peliculaRecibida.PeliculaId,
                //    Titulo = peliculaRecibida.Titulo,
                //    GeneroId = peliculaRecibida.GeneroId,
                //    FechaIncorporacion = peliculaRecibida.FechaIncorporacion,
                //    EstadoId = peliculaRecibida.EstadoId,
                //    DuracionEnMinutos = peliculaRecibida.DuracionEnMinutos,
                //    CalificacionId = peliculaRecibida.CalificacionId,
                //    SoporteId = peliculaRecibida.SoporteId,
                //    Alquilado = peliculaRecibida.Alquilado,
                //    Activa = peliculaRecibida.Activa

                //};



                peliculaRecibida.FechaIncorporacion=DateTime.Now;
                mensaje = ValidarPelicula(peliculaRecibida);
                if (mensaje == String.Empty)
                {
                    if (!servicio.Existe(peliculaRecibida))
                    {
                        servicio.Guardar(peliculaRecibida);
                        resultado = peliculaRecibida.PeliculaId;
                        mensaje = "Pelicula agregada/editada";
                    }
                    else
                    {
                        resultado = 0;
                        mensaje = "Pelicula repetida!";
                    }
                }
                else
                {
                    resultado = 0;
                }
            }
            catch (Exception e)
            {
                resultado = 0;
                mensaje = e.Message;

            }

            return Json(new { resultado = resultado, mensaje = mensaje }, JsonRequestBehavior.AllowGet);
        }

        private string ValidarPelicula(Pelicula pelicula)
        {
            StringBuilder sb = new StringBuilder();
            if (string.IsNullOrEmpty(pelicula.Titulo))
            {
                sb.AppendLine("El titulo de la pelicula es requerido");
            }

            if (pelicula.GeneroId == 0)
            {
                sb.AppendLine("Debe seleccionar un genero");
            }
            if (pelicula.EstadoId == 0)
            {
                sb.AppendLine("Debe seleccionar un estado");
            }
            if (pelicula.CalificacionId == 0)
            {
                sb.AppendLine("Debe seleccionar una calificacion");
            }
            if (pelicula.SoporteId == 0)
            {
                sb.AppendLine("Debe seleccionar un soporte");
            }
            return sb.ToString();
        }
        //[HttpPost]
        //public JsonResult EliminarPelicula(int id)
        //{
        //    bool respuesta = false;
        //    string mensaje = string.Empty;
        //    try
        //    {
        //        Pelicula p = servicio.GetPeliculaPorId(id);
        //        if (!servicio.EstaRelacionada(c))
        //        {
        //            servicio.Borrar(p);
        //            respuesta = true;
        //            mensaje = "Pelicuka eliminada";
        //        }
        //        else
        //        {
        //            respuesta = false;
        //            mensaje = "Pelicula relacionada... No se pudo eliminar el registro";
        //        }
        //    }
        //    catch (Exception e)
        //    {
        //        respuesta = false;
        //        mensaje = e.Message;
        //    }

        //    return Json(new { resultado = respuesta, mensaje = mensaje }, JsonRequestBehavior.AllowGet);
        //}

    }
}