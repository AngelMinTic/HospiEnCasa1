using System;
using System.Collections.Generic;
using System.Linq;
using HospiEnCasa.App.Dominio;

namespace HospiEnCasa.App.Persistencia.AppRepositorios
{
    public class RepositorioMedico : IRepositorioMedico
    {
        private readonly AppContext _appContext; //Recomendable por seguridad

        public RepositorioMedico(AppContext appContext)
        {
            _appContext = appContext; //Necesitamos definir un contexto
        }

        public IEnumerable<Medico> GetAllMedicos()
        {
            return _appContext.Medicos; //Medicos es en plural puesto que es el nombre de la tabla asignado en el AppContext.cs
        }

        public IEnumerable<Medico> GetMedicosPorFiltro(string filtro)
        {
            var medicos = GetAllMedicos(); // Obtiene todos los medicos 
            if (medicos != null) //Si se tienen medicos 
            {
                if (!String.IsNullOrEmpty(filtro)) // Si el filtro tiene algun valor 
                {
                    medicos = medicos.Where(p => p.Apellidos.Contains(filtro));

                }
            }
            return medicos;
        }

         public Medico AddMedico(Medico medico)
        {
            var medicoAdicionado = _appContext.Medicos.Add(medico);
            _appContext.SaveChanges(); //Se deben guardar los cambios
            return medicoAdicionado.Entity;
        }

        public Medico UpdateMedico(Medico medico)
        {
            var medicoEncontrado = _appContext.Medicos.FirstOrDefault(p => p.Id == medico.Id);
            //No se busca el idMedico, se busca el medico.Id puesto que se le pasa un objeto
            if (medicoEncontrado != null)
            {

                medicoEncontrado.Nombre = medico.Nombre;
                medicoEncontrado.Apellidos = medico.Apellidos;
                medicoEncontrado.NumeroTelefono = medico.NumeroTelefono;
                medicoEncontrado.Genero = medico.Genero;
                medicoEncontrado.Especialidad = medico.Especialidad;
                medicoEncontrado.Codigo = medico.Codigo;
                medicoEncontrado.RegistroRethus = medico.RegistroRethus;

                _appContext.SaveChanges();

            }
            return medicoEncontrado;

        }

        public void DeleteMedico(int idMedico)
        {
            var medicoEncontrado = _appContext.Medicos.FirstOrDefault(p => p.Id == idMedico);//p es el primero que encuentra. Recorre todos los elementos de la tabla
            if (medicoEncontrado == null)
                return;
            _appContext.Medicos.Remove(medicoEncontrado);
            _appContext.SaveChanges();//Se deben guardar los cambios            
        }

        public Medico GetMedico(int idMedico)
        {
            return _appContext.Medicos.FirstOrDefault(p => p.Id == idMedico);//retorna lo que encuentra
        }

    }
}