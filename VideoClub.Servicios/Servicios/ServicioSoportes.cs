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
    public class ServicioSoportes:IServicioSoportes
    {
        private readonly IRepositorioSoportes repositorio;

        public ServicioSoportes()
        {
            repositorio = new RepositorioSoportes();
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
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
    }
}
