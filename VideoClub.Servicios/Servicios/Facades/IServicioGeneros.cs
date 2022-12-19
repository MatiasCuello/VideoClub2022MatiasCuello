using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VideoClub.Entidades.Entidades;

namespace VideoClub.Servicios.Servicios.Facades
{
    public interface IServicioGeneros
    {
        List<Genero> GetLista();
        Genero GetGeneroPorId(int id);
        void Guardar(Genero genero);
        bool Existe(Genero genero);
        bool EstaRelacionado(Genero genero);
    }
}
