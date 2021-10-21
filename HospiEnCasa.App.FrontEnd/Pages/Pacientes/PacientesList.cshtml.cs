using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using HospiEnCasa.App.Dominio;
using HospiEnCasa.App.Persistencia.AppRepositorios;
using Microsoft.AspNetCore.Authorization;

namespace HospiEnCasa.App.FrontEnd.Pages
{
    [Authorize]
    public class PacientesListModel : PageModel
    {
       [BindProperty(SupportsGet = true)]
        public string FiltroBusqueda { get; set; }
        private readonly IRepositorioPaciente repositorioPaciente;
        public IEnumerable<Paciente> Pacientes { get; set; }

        public PacientesListModel(IRepositorioPaciente repositorioPaciente)
        {
            this.repositorioPaciente = repositorioPaciente;
        }
        public void OnGet(string filtroBusqueda)
        {
            //ListaPacientes = new List<string>();
            //ListaPacientes.AddRange(pacientes);
            FiltroBusqueda = filtroBusqueda;
            Pacientes = repositorioPaciente.GetPacientesPorFiltro(filtroBusqueda);
            //Pacientes =  repositorioPaciente.GetAllPacientes();
        }
    }
}