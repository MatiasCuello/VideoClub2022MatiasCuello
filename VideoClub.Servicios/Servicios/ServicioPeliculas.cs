using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VideoClub.Entidades.Entidades;
using VideoClub.Repositorios;
using VideoClub.Repositorios.Repositorios.Facades;
using VideoClub.Servicios.Servicios.Facades;

namespace VideoClub.Servicios.Servicios
{
    public class ServicioPeliculas : IServicioPeliculas
    {
        private readonly RepositorioPeliculas repositorio;
        private readonly VideoClubDbContext context;
        private readonly UnitOfWork unitOfWork;

        public ServicioPeliculas(RepositorioPeliculas repositorio,VideoClubDbContext context,UnitOfWork unitOfWork)
        {
            this.repositorio = repositorio;
            this.context = context;
            this.unitOfWork = unitOfWork;

        }

        public List<Pelicula> GetLista(Calificacion calificacion, Estado estado, Genero genero, Soporte soporte)
        {
            try
            {
                return repositorio.GetLista(calificacion,estado,genero,soporte);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }

        public void Guardar(Pelicula pelicula)
        {
            try
            {
                repositorio.Guardar(pelicula);
                unitOfWork.Save();
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
        public void Borrar(int peliculaId)
        {
            try
            {
                repositorio.Borrar(peliculaId);
                unitOfWork.Save();
                
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
        //        return repositorio.EstaRelacionado(pelicula);
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
                return repositorio.Existe(pelicula);
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
    }
}
