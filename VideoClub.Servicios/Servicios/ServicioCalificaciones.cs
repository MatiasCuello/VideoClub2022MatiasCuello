    using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VideoClub.Entidades.Entidades;
    using VideoClub.Repositorios;
    using VideoClub.Repositorios.Repositorios;
using VideoClub.Repositorios.Repositorios.Facades;
using VideoClub.Servicios.Servicios.Facades;

namespace VideoClub.Servicios.Servicios
{
    public class ServicioCalificaciones : IServicioCalificaciones
    {
        private readonly IRepositorioCalificaciones repositorio;
        private readonly VideoClubDbContext context;
        private readonly UnitOfWork unitOfWork;

        public ServicioCalificaciones(RepositorioCalificaciones repositorio,VideoClubDbContext context, UnitOfWork unitOfWork)
        {
            this.repositorio = repositorio;
            this.context = context;
            this.unitOfWork = unitOfWork;

        }

        public void Borrar(Calificacion calificacion)
        {
            try
            {
                repositorio.Borrar(calificacion);
                unitOfWork.Save();
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public bool EstaRelacionado(Calificacion calificacion)
        {
            try
            {
                return repositorio.EstaRelacionado(calificacion);
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public bool Existe(Calificacion calificacion)
        {
            try
            {
                return repositorio.Existe(calificacion);
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public Calificacion GetCalificacionPorId(int id)
        {
            try
            {
                return repositorio.GetCalificacionPorId(id);
            }
            catch (Exception e)
            {

                throw new Exception(e.Message);
            }
        }

        public List<Calificacion> GetLista()
        {
            try
            {
                return repositorio.GetLista();
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public void Guardar(Calificacion calificacion)
        {
            try
            {
                repositorio.Guardar(calificacion);
                unitOfWork.Save();
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
    }
}
