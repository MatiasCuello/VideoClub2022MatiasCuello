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
    public class RepositorioSoportes : IRepositorioSoportes
    {
        private readonly VideoClubDbContext context;

        public RepositorioSoportes()
        {
            context = new VideoClubDbContext();
        }

        public bool EstaRelacionado(Soporte soporte)
        {
            return false;
        }

        public bool Existe(Soporte soporte)
        {
            try
            {
                if (soporte.SoporteId == 0)
                {
                    return context.Soportes.Any(s => s.Descripcion == soporte.Descripcion);
                }

                return context.Soportes.Any(s => s.Descripcion == soporte.Descripcion
                                                   && s.SoporteId != soporte.SoporteId);
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
                return context.Soportes.SingleOrDefault(s => s.SoporteId == id);
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
                return context.Soportes.AsNoTracking().ToList();
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
                if (soporte.SoporteId == 0)
                {
                    context.Soportes.Add(soporte);
                }
                else
                {
                    context.Entry(soporte).State = EntityState.Modified;
                }

                context.SaveChanges();
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
    }
}
