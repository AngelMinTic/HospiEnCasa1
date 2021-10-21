using System;
using System.Collections.Generic;
using System.Linq;
using HospiEnCasa.App.Dominio;

namespace HospiEnCasa.App.Persistencia.AppRepositorios
{
    public class RepositorioEnfermera : IRepositorioEnfermera
    {
        private readonly AppContext _appContext; //Recomendable por seguridad

        public RepositorioEnfermera(AppContext appContext)
        {
            _appContext = appContext; //Necesitamos definir un contexto
        }

        public IEnumerable<Enfermera> GetAllEnfermeras()
        {
            return _appContext.Enfermeras; //Enfermeras es en plural puesto que es el nombre de la tabla asignado en el AppContext.cs
        }

        public IEnumerable<Enfermera> GetEnfermerasPorFiltro(string filtro)
        {
            var enfermeras = GetAllEnfermeras(); // Obtiene todos los enfermeras 
            if (enfermeras != null) //Si se tienen enfermeras 
            {
                if (!String.IsNullOrEmpty(filtro)) // Si el filtro tiene algun valor 
                {
                    enfermeras = enfermeras.Where(p => p.Apellidos.Contains(filtro));
                    /// < summary> 
                    /// Filtra los mensajes que contienen el filtro 
                    /// </ summary> 
                }
            }
            return enfermeras;
        }

         public Enfermera AddEnfermera(Enfermera enfermera)
        {
            var enfermeraAdicionado = _appContext.Enfermeras.Add(enfermera);
            _appContext.SaveChanges(); //Se deben guardar los cambios
            return enfermeraAdicionado.Entity;
        }

        public Enfermera UpdateEnfermera(Enfermera enfermera)
        {
            var enfermeraEncontrado = _appContext.Enfermeras.FirstOrDefault(p => p.Id == enfermera.Id);
            //No se busca el idEnfermera, se busca el enfermera.Id puesto que se le pasa un objeto
            if (enfermeraEncontrado != null)
            {

                enfermeraEncontrado.Nombre = enfermera.Nombre;
                enfermeraEncontrado.Apellidos = enfermera.Apellidos;
                enfermeraEncontrado.NumeroTelefono = enfermera.NumeroTelefono;
                enfermeraEncontrado.Genero = enfermera.Genero;
                enfermeraEncontrado.TarjetaProfesional = enfermera.TarjetaProfesional;
                enfermeraEncontrado.HorasLaborales = enfermera.HorasLaborales;

                _appContext.SaveChanges();

            }
            return enfermeraEncontrado;

        }

        public void DeleteEnfermera(int idEnfermera)
        {
            var enfermeraEncontrado = _appContext.Enfermeras.FirstOrDefault(p => p.Id == idEnfermera);//p es el primero que encuentra. Recorre todos los elementos de la tabla
            if (enfermeraEncontrado == null)
                return;
            _appContext.Enfermeras.Remove(enfermeraEncontrado);
            _appContext.SaveChanges();//Se deben guardar los cambios            
        }

        public Enfermera GetEnfermera(int idEnfermera)
        {
            return _appContext.Enfermeras.FirstOrDefault(p => p.Id == idEnfermera);//retorna lo que encuentra
        }
  
    }
}