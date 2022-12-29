using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VideoClub.Entidades.Entidades;

namespace VideoClub.Servicios.Servicios.Facades
{
    public interface IServicioPeliculas
    {
        List<Pelicula> GetLista();
        void Guardar(Pelicula pelicula);
        bool Existe(Pelicula pelicula);
        void Borrar(int peliculaId);
        //bool EstaRelacionado(Pelicula pelicula);
    }
}
