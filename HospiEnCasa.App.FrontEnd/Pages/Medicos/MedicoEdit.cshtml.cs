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
    public class MedicoEditModel : PageModel
    {
        private readonly IRepositorioMedico repositorioMedico;
        [BindProperty]
        public Medico Medico { get; set; }

        public MedicoEditModel(IRepositorioMedico repositorioMedico)
        {
            this.repositorioMedico = repositorioMedico;
        }
        public IActionResult OnGet(int? medicoId)
        {
            if (medicoId.HasValue)
            {
                Medico = repositorioMedico.GetMedico(medicoId.Value);
            }
            else
            {
                Medico = new Medico();
            }
            
            if (Medico == null)
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
            if(Medico.Id>0)
            {
            Medico = repositorioMedico.UpdateMedico(Medico);
            }
            else
            {
             repositorioMedico.AddMedico(Medico);
            }
            return RedirectToPage("./MedicosList");
        }
    }
}
