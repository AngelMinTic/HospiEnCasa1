using System.Collections.Generic;
using HospiEnCasa.App.Dominio;

namespace HospiEnCasa.App.Persistencia.AppRepositorios
{
    public interface IRepositorioFamiliarDesignado
    {
        IEnumerable<FamiliarDesignado> GetAllFamiliares(); //método que me retorna todos los pacientes

        IEnumerable<FamiliarDesignado> GetFamiliaresPorFiltro(string filtro);
        FamiliarDesignado AddFamiliarDesignado(FamiliarDesignado paciente);
        FamiliarDesignado UpdateFamiliarDesignado(FamiliarDesignado paciente);
        void DeleteFamiliarDesignado(int idFamiliarDesignado);
        FamiliarDesignado GetFamiliarDesignado(int idFamiliarDesignado);
    }
}