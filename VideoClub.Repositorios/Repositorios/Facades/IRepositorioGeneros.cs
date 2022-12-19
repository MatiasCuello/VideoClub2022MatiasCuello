using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VideoClub.Entidades.Entidades;

namespace VideoClub.Repositorios.Repositorios.Facades
{
    public interface IRepositorioGeneros
    {
        List<Genero> GetLista();
        Genero GetGeneroPorId(int id);
        void Guardar(Genero genero);
        bool Existe(Genero genero);
        bool EstaRelacionado(Genero genero);
        void Borrar(Genero genero);
    }
}
