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
    public class PacienteDeleteModel : PageModel
    {
     private readonly IRepositorioPaciente repositorioPaciente;

        [BindProperty]
        public Paciente Paciente{get;set;}

        public PacienteDeleteModel(IRepositorioPaciente repositorioPaciente)
        {
            this.repositorioPaciente = repositorioPaciente;
        }

        public IActionResult OnGet(int pacienteId)
        {
            Paciente = repositorioPaciente.GetPaciente(pacienteId);
            if(Paciente==null)
            {
                return RedirectToPage("./NotFound");
            }
            else 
            return Page();
        }

        public IActionResult OnPost()
        {
            if(Paciente.Id>0)
            {
            repositorioPaciente.DeletePaciente(Paciente.Id);
            }
            return Page();
        }

    }
}
