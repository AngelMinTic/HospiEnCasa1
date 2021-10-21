using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using HospiEnCasa.App.Dominio;
using HospiEnCasa.App.Persistencia.AppRepositorios;
using Microsoft.AspNetCore.Authorization;

namespace HospiEnCasa.App.FrontEnd.Pages
{
    [Authorize]
    public class FamiliaresDesignadosListModel : PageModel
    {
        [BindProperty(SupportsGet = true)]
        public string FiltroBusqueda { get; set; }
        private readonly IRepositorioFamiliarDesignado repositorioFamiliarDesignado;
        public IEnumerable<FamiliarDesignado> Familiares { get; set; }

        public FamiliaresDesignadosListModel(IRepositorioFamiliarDesignado repositorioFamiliarDesignado)
        {
            this.repositorioFamiliarDesignado = repositorioFamiliarDesignado;
        }
        public void OnGet(string filtroBusqueda)
        {
            //ListaFamiliares = new List<string>();
            //ListaFamiliares.AddRange(familiarDesignados);
            FiltroBusqueda = filtroBusqueda;
            Familiares = repositorioFamiliarDesignado.GetFamiliaresPorFiltro(filtroBusqueda);
            //Familiares =  repositorioFamiliarDesignado.GetAllFamiliares();
        }
    }
}
