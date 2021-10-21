using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HospiEnCasa.App.Dominio;
using HospiEnCasa.App.Persistencia.AppRepositorios;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace HospiEnCasa.App.FrontEnd.Pages
{
    [Authorize]
    public class MedicosListModel : PageModel
    {       
        
        [BindProperty(SupportsGet = true)]
        public string FiltroBusqueda { get; set; }
        private readonly IRepositorioMedico repositorioMedico;
        public IEnumerable<Medico> Medicos { get; set; }

        public MedicosListModel(IRepositorioMedico repositorioMedico)
        {
            this.repositorioMedico = repositorioMedico;
        }
        public void OnGet(string filtroBusqueda)
        {
            //ListaMedicos = new List<string>();
            //ListaMedicos.AddRange(medicos);
            FiltroBusqueda = filtroBusqueda;
            Medicos = repositorioMedico.GetMedicosPorFiltro(filtroBusqueda);
            //Medicos =  repositorioMedico.GetAllMedicos();
        }
    }
}
