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
                        mensaje = "Pelicula existente!!!";
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

    }
}