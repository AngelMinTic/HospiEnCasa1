using System;
using System.Collections.Generic;
using System.Linq;
using HospiEnCasa.App.Dominio;

namespace HospiEnCasa.App.Persistencia.AppRepositorios
{
    public class RepositorioPaciente : IRepositorioPaciente
    {
        private readonly AppContext _appContext; //Recomendable por seguridad

        public RepositorioPaciente(AppContext appContext)
        {
            _appContext = appContext; //Necesitamos definir un contexto
        }

        public IEnumerable<Paciente> GetAllPacientes()
        {
            return _appContext.Pacientes; //Pacientes es en plural puesto que es el nombre de la tabla asignado en el AppContext.cs
        }

        public IEnumerable<Paciente> GetPacientesPorFiltro(string filtro)
        {
            var pacientes = GetAllPacientes(); // Obtiene todos los pacientes 
            if (pacientes != null) //Si se tienen pacientes 
            {
                if (!String.IsNullOrEmpty(filtro)) // Si el filtro tiene algun valor 
                {
                    pacientes = pacientes.Where(p => p.Apellidos.Contains(filtro));
                    /// < summary> 
                    /// Filtra los mensajes que contienen el filtro 
                    /// </ summary> 
                }
            }
            return pacientes;
        }

         public Paciente AddPaciente(Paciente paciente)
        {
            var pacienteAdicionado = _appContext.Pacientes.Add(paciente);
            _appContext.SaveChanges(); //Se deben guardar los cambios
            return pacienteAdicionado.Entity;
        }

        public Paciente UpdatePaciente(Paciente paciente)
        {
            var pacienteEncontrado = _appContext.Pacientes.FirstOrDefault(p => p.Id == paciente.Id);
            //No se busca el idPaciente, se busca el paciente.Id puesto que se le pasa un objeto
            if (pacienteEncontrado != null)
            {
                pacienteEncontrado.Nombre = paciente.Nombre;
                pacienteEncontrado.Apellidos = paciente.Apellidos;
                pacienteEncontrado.NumeroTelefono = paciente.NumeroTelefono;
                pacienteEncontrado.Direccion = paciente.Direccion;
                pacienteEncontrado.Ciudad = paciente.Ciudad;
                pacienteEncontrado.FechaNacimiento = paciente.FechaNacimiento;
                pacienteEncontrado.Latitud = paciente.Latitud;
                pacienteEncontrado.Longitud = paciente.Longitud;
                pacienteEncontrado.Familiar = paciente.Familiar;
                pacienteEncontrado.Enfermera = paciente.Enfermera;
                pacienteEncontrado.Medico = paciente.Medico;
                pacienteEncontrado.Historia = paciente.Historia;
                _appContext.SaveChanges();

            }
            return pacienteEncontrado;

        }

        public void DeletePaciente(int idPaciente)
        {
            var pacienteEncontrado = _appContext.Pacientes.FirstOrDefault(p => p.Id == idPaciente);//p es el primero que encuentra. Recorre todos los elementos de la tabla
            if (pacienteEncontrado == null)
                return;
            _appContext.Pacientes.Remove(pacienteEncontrado);
            _appContext.SaveChanges();//Se deben guardar los cambios            
        }

        public Paciente GetPaciente(int idPaciente)
        {
            return _appContext.Pacientes.FirstOrDefault(p => p.Id == idPaciente);//retorna lo que encuentra
        }

        public Medico AsignarMedico(int idPaciente, int idMedico)
        {
            var pacienteEncontrado = _appContext.Pacientes.FirstOrDefault(p => p.Id == idPaciente);
            if (pacienteEncontrado != null)
            {
                var medicoEncontrado = _appContext.Medicos.FirstOrDefault(m => m.Id == idMedico);
                if (medicoEncontrado != null)
                {
                    pacienteEncontrado.Medico = medicoEncontrado;
                    _appContext.SaveChanges();
                }
                return medicoEncontrado;
            }
            return null;
        }

        public Enfermera AsignarEnfermera(int idPaciente, int idEnfermera)
        {
            var pacienteEncontrado = _appContext.Pacientes.FirstOrDefault(p => p.Id == idPaciente);
            if (pacienteEncontrado != null)
            {
                var enfermeraEncontrada = _appContext.Enfermeras.FirstOrDefault(e => e.Id == idEnfermera);
                if (enfermeraEncontrada != null)
                {
                    pacienteEncontrado.Enfermera = enfermeraEncontrada;
                    _appContext.SaveChanges();
                }
                return enfermeraEncontrada;
            }
            return null;
        }

        public FamiliarDesignado AsignarFamiliar(int idPaciente, int idFamiliar)
        {
            var pacienteEncontrado = _appContext.Pacientes.FirstOrDefault(p => p.Id == idPaciente);
            if (pacienteEncontrado != null)
            {
                var familiarEncontrado = _appContext.Familiares.FirstOrDefault(f => f.Id == idFamiliar);
                if (familiarEncontrado != null)
                {
                    pacienteEncontrado.Familiar = familiarEncontrado;
                    _appContext.SaveChanges();
                }
                return familiarEncontrado;
            }
            return null;
        }

        public IEnumerable<Paciente> GetPacientesMasculinos()
        {

            return _appContext.Pacientes.Where(p => p.Genero == Genero.Masculino).ToList();

        }

        public IEnumerable<Paciente> GetPacientesCorazon()
        {

            return _appContext.Pacientes
                .Where(p => p.SignosVitales.Any(s => TipoSigno.FrecuenciaCardiaca == s.Signo && s.Valor >= 90))
                .ToList();
        }

        public IEnumerable<Paciente> GetPacientesFiebre()
        {
                return _appContext.Pacientes
                .Where(p => p.SignosVitales.Any(s => (TipoSigno.TemperaturaCorporal == s.Signo && s.Valor >= 38) && (TipoSigno.FrecuenciaCardiaca == s.Signo && s.Valor < 60 )))
                .ToList();
        }
        public IEnumerable<Paciente> GetPacientesIgualApellido()
        {
                return _appContext.Pacientes
                //.Where(p => p.Apellidos.Any(p => Paciente.Apellidos == p.Apellidos))
                .ToList();
        }
    }
}