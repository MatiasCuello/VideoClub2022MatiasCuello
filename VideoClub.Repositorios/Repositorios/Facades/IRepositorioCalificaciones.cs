using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VideoClub.Entidades.Entidades;

namespace VideoClub.Repositorios.Repositorios.Facades
{
    public interface IRepositorioCalificaciones
    { 
        List<Calificacion> GetLista();
        Calificacion GetCalificacionPorId(int id);  
        void Guardar(Calificacion calificacion);
        bool Existe(Calificacion calificacion);
        bool EstaRelacionado(Calificacion calificacion);
        void Borrar(Calificacion calificacion);
    }
}
