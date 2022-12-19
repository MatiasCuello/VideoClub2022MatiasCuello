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
    public class RepositorioGeneros : IRepositorioGeneros
    {
        private readonly VideoClubDbContext context;

        public RepositorioGeneros()
        {
            context = new VideoClubDbContext();
        }

        public bool EstaRelacionado(Genero genero)
        {
            return false;
        }

        public bool Existe(Genero genero)
        {
            try
            {
                if (genero.GeneroId == 0)
                {
                    return context.Generos.Any(g => g.Descripcion == genero.Descripcion);
                }

                return context.Generos.Any(g => g.Descripcion == genero.Descripcion
                                                   && g.GeneroId != genero.GeneroId);
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
                return context.Generos.SingleOrDefault(g => g.GeneroId == id);
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
                return context.Generos.AsNoTracking().ToList();
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
                if (genero.GeneroId == 0)
                {
                    context.Generos.Add(genero);
                }
                else
                {
                    context.Entry(genero).State = EntityState.Modified;
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
