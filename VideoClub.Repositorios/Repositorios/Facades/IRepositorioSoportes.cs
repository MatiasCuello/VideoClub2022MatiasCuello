using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VideoClub.Entidades.Entidades;

namespace VideoClub.Repositorios.Repositorios.Facades
{
    public interface IRepositorioSoportes
    {
        List<Soporte> GetLista();
        Soporte GetSoportePorId(int id);
        void Guardar(Soporte soporte);
        bool Existe(Soporte soporte);
        bool EstaRelacionado(Soporte soporte);
        void Borrar(Soporte soporte);
    }
}
