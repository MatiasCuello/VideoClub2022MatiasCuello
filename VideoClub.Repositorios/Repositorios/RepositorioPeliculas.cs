using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VideoClub.Entidades.Entidades;

namespace VideoClub.Repositorios.Repositorios.Facades
{
    public class RepositorioPeliculas:IRepositorioPeliculas
    {
        private VideoClubDbContext context;

        public RepositorioPeliculas(VideoClubDbContext context)
        {
            this.context = context;
        }
   

        public void Borrar(int peliculaId)
        {
            try
            {
                var peliculaEnDb = context.Peliculas
                    .SingleOrDefault(p => p.PeliculaId == peliculaId);
                if (peliculaEnDb == null)
                {
                    throw new Exception("El codigo de la pelicula es inexistente");
                }

                context.Entry(peliculaEnDb).State = EntityState.Deleted;
                //context.SaveChanges();
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        //public bool EstaRelacionado(Pelicula pelicula)
        //{
        //    try
        //    {
        //        return context.Peliculas
        //            .Any(p => p.PeliculaId == pelicula.PeliculaId);
        //    }
        //    catch (Exception e)
        //    {
        //        throw new Exception(e.Message);
        //    }
        //}

        public bool Existe(Pelicula pelicula)
        {
            try
            {
                if (pelicula.PeliculaId == 0)
                {
                    return context.Peliculas
                        .Any(p => p.Titulo == pelicula.Titulo);
                }

                return context.Peliculas.Any(p => p.Titulo == pelicula.Titulo &&
                                                    p.GeneroId == pelicula.GeneroId &&
                                                    p.DuracionEnMinutos != pelicula.DuracionEnMinutos);
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public List<Pelicula> GetLista()
        {
            try
            {
                return context.Peliculas
                    .Include(p => p.Calificacion)
                        .Include(p => p.Estado)
                        .Include(p => p.Genero)
                        .Include(p => p.Soporte)
                    .ToList();
                //var query = context.Peliculas
                //    .Include(p => p.Calificacion)
                //    .Include(p => p.Estado)
                //    .Include(p => p.Genero)
                //    .Include(p => p.Soporte);

                //if (calificacion != null || estado != null || genero != null ||soporte != null)
                //{
                //    query = query.Where(p => p.CalificacionId == calificacion.CalificacionId);
                //    query = query.Where(p => p.EstadoId == estado.EstadoId);
                //    query = query.Where(p => p.GeneroId == genero.GeneroId);
                //    query = query.Where(p => p.SoporteId == soporte.SoporteId);
                //}
                //return query.AsNoTracking().ToList();

            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public void Guardar(Pelicula pelicula)
        {
            try
            {
                if (pelicula.Calificacion != null)
                {
                    context.Calificaciones.Attach(pelicula.Calificacion);
                }
                if (pelicula.Genero != null)
                {
                    context.Generos.Attach(pelicula.Genero);
                }
                if (pelicula.Estado != null)
                {
                    context.Estados.Attach(pelicula.Estado);
                }
                if (pelicula.Soporte != null)
                {
                    context.Soportes.Attach(pelicula.Soporte);
                }
                if (pelicula.PeliculaId == 0)
                {
                    context.Peliculas.Add(pelicula);
                }
                else
                {
                    var peliculaInDb = context.Peliculas.SingleOrDefault(p => p.PeliculaId == pelicula.PeliculaId);
                    if (peliculaInDb == null)
                    {
                        throw new Exception("El codigo de la Pelicula es inexistente");
                    }
                    peliculaInDb.FechaIncorporacion = pelicula.FechaIncorporacion;
                    peliculaInDb.Titulo = pelicula.Titulo;
                    peliculaInDb.GeneroId = pelicula.GeneroId;
                    peliculaInDb.EstadoId = pelicula.EstadoId;
                    peliculaInDb.DuracionEnMinutos = pelicula.DuracionEnMinutos;
                    peliculaInDb.CalificacionId = pelicula.CalificacionId;
                    peliculaInDb.SoporteId=pelicula.SoporteId;
                    peliculaInDb.Activa = pelicula.Activa;

                    context.Entry(pelicula).State = EntityState.Modified;

                }

                //context.SaveChanges();
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
    }
}
