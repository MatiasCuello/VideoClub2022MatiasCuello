using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VideoClub.Entidades.Entidades;
using VideoClub.Repositorios.Repositorios.Facades;

namespace VideoClub.Repositorios.Repositorios
{
    public class RepositorioEstados : IRepositorioEstados
    {
        private VideoClubDbContext context;

        public RepositorioEstados(VideoClubDbContext context)
        {
            this.context = context;
        }

        public bool EstaRelacionado(Estado estado)
        {
            return false;
        }

        public bool Existe(Estado estado)
        {
            try
            {
                if (estado.EstadoId == 0)
                {
                    return context.Estados.Any(e => e.Descripcion == estado.Descripcion);
                }

                return context.Estados.Any(e => e.Descripcion == estado.Descripcion
                                                   && e.EstadoId!= estado.EstadoId);
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
                return context.Estados.SingleOrDefault(e => e.EstadoId == id);
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
                return context.Estados.AsNoTracking().ToList();
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
                if (estado.EstadoId == 0)
                {
                    context.Estados.Add(estado);
                }
                else
                {
                    var estadoInDb = context.Estados
                        .SingleOrDefault(e => e.EstadoId == estado.EstadoId);
                    estadoInDb.EstadoId = estado.EstadoId;
                    estadoInDb.Descripcion = estado.Descripcion;
                    context.Entry(estadoInDb).State = EntityState.Modified;
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
