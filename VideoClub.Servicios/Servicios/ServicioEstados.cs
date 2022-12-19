using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VideoClub.Entidades.Entidades;
using VideoClub.Repositorios.Repositorios;
using VideoClub.Repositorios.Repositorios.Facades;
using VideoClub.Servicios.Servicios.Facades;

namespace VideoClub.Servicios.Servicios
{
    public class ServicioEstados:IServicioEstados
    {
        private readonly IRepositorioEstados repositorio;

        public ServicioEstados()
        {
            repositorio = new RepositorioEstados();
        }

        public bool EstaRelacionado(Estado estado)
        {
            try
            {
                return repositorio.EstaRelacionado(estado);
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public bool Existe(Estado estado)
        {
            try
            {
                return repositorio.Existe(estado);
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public Estado GetEstadoPorId(int id)
        {
            try
            {
                return repositorio.GetEstadoPorId(id);
            }
            catch (Exception e)
            {

                throw new Exception(e.Message);
            }
        }

        public List<Estado> GetLista()
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

        public void Guardar(Estado estado)
        {
            try
            {
                repositorio.Guardar(estado);
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
    }
}
