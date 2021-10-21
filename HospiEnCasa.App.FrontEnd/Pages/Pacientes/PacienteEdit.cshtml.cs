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
    public class PacienteEditModel : PageModel
    {

        private readonly IRepositorioPaciente repositorioPaciente;
        [BindProperty]
        public Paciente Paciente { get; set; }

        public PacienteEditModel(IRepositorioPaciente repositorioPaciente)
        {
            this.repositorioPaciente = repositorioPaciente;
        }
        public IActionResult OnGet(int? pacienteId)
        {
            if (pacienteId.HasValue)
            {
                Paciente = repositorioPaciente.GetPaciente(pacienteId.Value);
            }
            else
            {
                Paciente = new Paciente();
            }
            
            if (Paciente == null)
            {
                return RedirectToPage("./NotFound");
            }
            else
                return Page();

        }

        public IActionResult OnPost()
        {
            if(!ModelState.IsValid)
            {
                return Page();
            }
            if(Paciente.Id>0)
            {
            Paciente = repositorioPaciente.UpdatePaciente(Paciente);
            }
            else
            {
             repositorioPaciente.AddPaciente(Paciente);
            }
            return RedirectToPage("./PacientesList");
        }
    }
}
