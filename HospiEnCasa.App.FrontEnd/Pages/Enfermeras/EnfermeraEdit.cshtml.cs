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
    public class EnfermeraEditModel : PageModel
    {
       private readonly IRepositorioEnfermera repositorioEnfermera;
        [BindProperty]
        public Enfermera Enfermera { get; set; }

        public EnfermeraEditModel(IRepositorioEnfermera repositorioEnfermera)
        {
            this.repositorioEnfermera = repositorioEnfermera;
        }
        public IActionResult OnGet(int? enfermeraId)
        {
            if (enfermeraId.HasValue)
            {
                Enfermera = repositorioEnfermera.GetEnfermera(enfermeraId.Value);
            }
            else
            {
                Enfermera = new Enfermera();
            }
            
            if (Enfermera == null)
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
            if(Enfermera.Id>0)
            {
            Enfermera = repositorioEnfermera.UpdateEnfermera(Enfermera);
            }
            else
            {
             repositorioEnfermera.AddEnfermera(Enfermera);
            }
            return RedirectToPage("./EnfermerasList");
        }
    }
}
