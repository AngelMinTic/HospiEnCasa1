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
    public class FamiliarDesignadoEditModel : PageModel
    {

        private readonly IRepositorioFamiliarDesignado repositorioFamiliarDesignado;
        [BindProperty]
        public FamiliarDesignado FamiliarDesignado { get; set; }

        public FamiliarDesignadoEditModel(IRepositorioFamiliarDesignado repositorioFamiliarDesignado)
        {
            this.repositorioFamiliarDesignado = repositorioFamiliarDesignado;
        }
        public IActionResult OnGet(int? familiarDesignadoId)
        {
            if (familiarDesignadoId.HasValue)
            {
                FamiliarDesignado = repositorioFamiliarDesignado.GetFamiliarDesignado(familiarDesignadoId.Value);
            }
            else
            {
                FamiliarDesignado = new FamiliarDesignado();
            }
            
            if (FamiliarDesignado == null)
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
            if(FamiliarDesignado.Id>0)
            {
            FamiliarDesignado = repositorioFamiliarDesignado.UpdateFamiliarDesignado(FamiliarDesignado);
            }
            else
            {
             repositorioFamiliarDesignado.AddFamiliarDesignado(FamiliarDesignado);
            }
            return RedirectToPage("./FamiliaresDesignadosList");
        }
    }
}
