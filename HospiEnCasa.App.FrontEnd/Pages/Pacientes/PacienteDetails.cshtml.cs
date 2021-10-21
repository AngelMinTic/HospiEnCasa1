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
    public class PacienteDetailsModel : PageModel
    {
        private readonly IRepositorioPaciente repositorioPaciente;
        public Paciente Paciente{get;set;}

        public PacienteDetailsModel(IRepositorioPaciente repositorioPaciente)
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
    }
}
