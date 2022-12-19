using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VideoClub.Entidades.Entidades;

namespace VideoClub.Servicios.Servicios.Facades
{
    public interface IServicioEstados
    {
        List<Estado> GetLista();
        Estado GetEstadoPorId(int id);
        void Guardar(Estado estado);
        bool Existe(Estado estado);
        bool EstaRelacionado(Estado estado);
    }
}
