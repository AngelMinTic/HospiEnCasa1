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
    public class FamiliarDesignadoDeleteModel : PageModel
    {
     private readonly IRepositorioFamiliarDesignado repositorioFamiliarDesignado;

        [BindProperty]
        public FamiliarDesignado FamiliarDesignado{get;set;}

        public FamiliarDesignadoDeleteModel(IRepositorioFamiliarDesignado repositorioFamiliarDesignado)
        {
            this.repositorioFamiliarDesignado = repositorioFamiliarDesignado;
        }

        public IActionResult OnGet(int familiarDesignadoId)
        {
            FamiliarDesignado = repositorioFamiliarDesignado.GetFamiliarDesignado(familiarDesignadoId);
            if(FamiliarDesignado==null)
            {
                return RedirectToPage("./NotFound");
            }
            else 
            return Page();
        }

        public IActionResult OnPost()
        {
            if(FamiliarDesignado.Id>0)
            {
            repositorioFamiliarDesignado.DeleteFamiliarDesignado(FamiliarDesignado.Id);
            }
            return Page();
        }
    }
}
