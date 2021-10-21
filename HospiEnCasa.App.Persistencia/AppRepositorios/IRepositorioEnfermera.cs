using System.Collections.Generic;
using HospiEnCasa.App.Dominio;

namespace HospiEnCasa.App.Persistencia.AppRepositorios
{
    public interface IRepositorioEnfermera
    {
        IEnumerable<Enfermera> GetAllEnfermeras(); //método que me retorna todos los enfermeras
        IEnumerable<Enfermera> GetEnfermerasPorFiltro(string filtro);
        Enfermera AddEnfermera(Enfermera enfermera);
        Enfermera UpdateEnfermera(Enfermera enfermera);
        void DeleteEnfermera(int idEnfermera);
        Enfermera GetEnfermera(int idEnfermera);
    }
}