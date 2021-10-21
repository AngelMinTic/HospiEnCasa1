using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HospiEnCasa.App.Dominio;
using HospiEnCasa.App.Persistencia.AppRepositorios;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace HospiEnCasa.App.FrontEnd.Pages
{
    public class MedicoDeleteModel : PageModel
    {
     private readonly IRepositorioMedico repositorioMedico;

        [BindProperty]
        public Medico Medico{get;set;}

        public MedicoDeleteModel(IRepositorioMedico repositorioMedico)
        {
            this.repositorioMedico = repositorioMedico;
        }

        public IActionResult OnGet(int medicoId)
        {
            Medico = repositorioMedico.GetMedico(medicoId);
            if(Medico==null)
            {
                return RedirectToPage("./NotFound");
            }
            else 
            return Page();
        }

        public IActionResult OnPost()
        {
            if(Medico.Id>0)
            {
            repositorioMedico.DeleteMedico(Medico.Id);
            }
            return Page();
        }
    }
}
