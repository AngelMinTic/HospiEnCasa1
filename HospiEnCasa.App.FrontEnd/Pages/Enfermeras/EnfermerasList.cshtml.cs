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
    public class EnfermerasListModel : PageModel
    {
       [BindProperty(SupportsGet = true)]
        public string FiltroBusqueda { get; set; }
        private readonly IRepositorioEnfermera repositorioEnfermera;
        public IEnumerable<Enfermera> Enfermeras { get; set; }

        public EnfermerasListModel(IRepositorioEnfermera repositorioEnfermera)
        {
            this.repositorioEnfermera = repositorioEnfermera;
        }
        public void OnGet(string filtroBusqueda)
        {
            //ListaEnfermeras = new List<string>();
            //ListaEnfermeras.AddRange(enfermeras);
            FiltroBusqueda = filtroBusqueda;
            Enfermeras = repositorioEnfermera.GetEnfermerasPorFiltro(filtroBusqueda);
            //Enfermeras =  repositorioEnfermera.GetAllEnfermeras();
        }
    }
}
