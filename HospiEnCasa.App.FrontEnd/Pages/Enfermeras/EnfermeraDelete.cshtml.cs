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
    public class EnfermeraDeleteModel : PageModel
    {
     private readonly IRepositorioEnfermera repositorioEnfermera;

        [BindProperty]
        public Enfermera Enfermera{get;set;}

        public EnfermeraDeleteModel(IRepositorioEnfermera repositorioEnfermera)
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

        public IActionResult OnPost()
        {
            if(Enfermera.Id>0)
            {
            repositorioEnfermera.DeleteEnfermera(Enfermera.Id);
            }
            return Page();
        }
    }
}
