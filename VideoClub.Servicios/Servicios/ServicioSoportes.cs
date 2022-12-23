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
    public class ServicioSoportes:IServicioSoportes
    {
        private readonly IRepositorioSoportes repositorio;
        private readonly VideoClubDbContext context;
        private readonly UnitOfWork unitOfWork;

        public ServicioSoportes(RepositorioSoportes repositorio, VideoClubDbContext context, UnitOfWork unitOfWork)
        {
            this.repositorio = repositorio;
            this.context = context;
            this.unitOfWork = unitOfWork;
        }

        public void Borrar(Soporte soporte)
        {
            try
            {
                repositorio.Borrar(soporte);
                unitOfWork.Save();
            }
            catch (Exception e)
            {

                throw new Exception(e.Message);
            }
        }

        public bool EstaRelacionado(Soporte soporte)
        {
            try
            {
                return repositorio.EstaRelacionado(soporte);
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public bool Existe(Soporte soporte)
        {
            try
            {
                return repositorio.Existe(soporte);
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public List<Soporte> GetLista()
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

        public Soporte GetSoportePorId(int id)
        {
            try
            {
                return repositorio.GetSoportePorId(id);
            }
            catch (Exception e)
            {

                throw new Exception(e.Message);
            }
        }

        public void Guardar(Soporte soporte)
        {
            try
            {
                repositorio.Guardar(soporte);
                unitOfWork.Save();
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
    }
}
