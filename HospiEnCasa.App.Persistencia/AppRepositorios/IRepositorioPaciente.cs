//using System;
using System.Collections.Generic;
using HospiEnCasa.App.Dominio;

namespace HospiEnCasa.App.Persistencia.AppRepositorios
{

    public interface IRepositorioPaciente
    {
        IEnumerable<Paciente> GetAllPacientes(); //método que me retorna todos los pacientes

        IEnumerable<Paciente> GetPacientesPorFiltro(string filtro);
        Paciente AddPaciente(Paciente paciente);
        Paciente UpdatePaciente(Paciente paciente);
        void DeletePaciente(int idPaciente);
        Paciente GetPaciente(int idPaciente);
        Medico AsignarMedico(int idPaciente, int idMedico);
        Enfermera AsignarEnfermera(int idPaciente, int idEnfermera);
        FamiliarDesignado AsignarFamiliar(int idPaciente, int idFamiliar);
        IEnumerable<Paciente> GetPacientesMasculinos();

        IEnumerable<Paciente> GetPacientesCorazon();
        IEnumerable<Paciente> GetPacientesFiebre();
    }

}

