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
    public class ServicioGeneros:IServicioGeneros
    {
        private readonly IRepositorioGeneros repositorio;

        public ServicioGeneros()
        {
            repositorio = new RepositorioGeneros();
        }

        public bool EstaRelacionado(Genero genero)
        {
            try
            {
                return repositorio.EstaRelacionado(genero);
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public bool Existe(Genero genero)
        {
            try
            {
                return repositorio.Existe(genero);
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public Genero GetGeneroPorId(int id)
        {
            try
            {
                return repositorio.GetGeneroPorId(id);
            }
            catch (Exception e)
            {

                throw new Exception(e.Message);
            }
        }

        public List<Genero> GetLista()
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

        public void Guardar(Genero genero)
        {
            try
            {
                repositorio.Guardar(genero);
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
    }
}
