using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using HospiEnCasa.App.Dominio;
using HospiEnCasa.App.Persistencia.AppRepositorios;

namespace HospiEnCasa.App.FrontEnd.Pages
{
    public class EnfermeraDetailsModel : PageModel
    {
        private readonly IRepositorioEnfermera repositorioEnfermera;
        public Enfermera Enfermera{get;set;}

        public EnfermeraDetailsModel(IRepositorioEnfermera repositorioEnfermera)
        {
            this.repositorioEnfermera = repositorioEnfermera;
        }

        public IActionResult OnGet(int enfermeraId)
        {
            Enfermera = repositorioEnfermera.GetEnfermera(enfermeraId);
            if(Enfermera==null)
            {
                return RedirectToPage("./NotFound");
            }
            else 
            return Page();
        }
    }
}
