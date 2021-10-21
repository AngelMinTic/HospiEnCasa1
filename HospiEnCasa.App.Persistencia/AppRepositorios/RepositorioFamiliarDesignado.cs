using System;
using System.Collections.Generic;
using System.Linq;
using HospiEnCasa.App.Dominio;

namespace HospiEnCasa.App.Persistencia.AppRepositorios
{
    public class RepositorioFamiliarDesignado : IRepositorioFamiliarDesignado
    {
         private readonly AppContext _appContext; //Recomendable por seguridad

        public RepositorioFamiliarDesignado(AppContext appContext)
        {
            _appContext = appContext; //Necesitamos definir un contexto
        }

        public IEnumerable<FamiliarDesignado> GetAllFamiliares()
        {
            return _appContext.Familiares; //FamiliaresDesignados es en plural puesto que es el nombre de la tabla asignado en el AppContext.cs
        }

        public IEnumerable<FamiliarDesignado> GetFamiliaresPorFiltro(string filtro)
        {
            var familiaresDesignados = GetAllFamiliares(); // Obtiene todos los familiaresDesignados 
            if (familiaresDesignados != null) //Si se tienen familiaresDesignados 
            {
                if (!String.IsNullOrEmpty(filtro)) // Si el filtro tiene algun valor 
                {
                    familiaresDesignados = familiaresDesignados.Where(p => p.Apellidos.Contains(filtro));
                    /// < summary> 
                    /// Filtra los mensajes que contienen el filtro 
                    /// </ summary> 
                }
            }
            return familiaresDesignados;
        }

         public FamiliarDesignado AddFamiliarDesignado(FamiliarDesignado familiarDesignado)
        {
            var familiarDesignadoAdicionado = _appContext.Familiares.Add(familiarDesignado);
            _appContext.SaveChanges(); //Se deben guardar los cambios
            return familiarDesignadoAdicionado.Entity;
        }

        public FamiliarDesignado UpdateFamiliarDesignado(FamiliarDesignado familiarDesignado)
        {
            var familiarDesignadoEncontrado = _appContext.Familiares.FirstOrDefault(p => p.Id == familiarDesignado.Id);
            //No se busca el idFamiliarDesignado, se busca el familiarDesignado.Id puesto que se le pasa un objeto
            if (familiarDesignadoEncontrado != null)
            {

                familiarDesignadoEncontrado.Nombre = familiarDesignado.Nombre;
                familiarDesignadoEncontrado.Apellidos = familiarDesignado.Apellidos;
                familiarDesignadoEncontrado.NumeroTelefono = familiarDesignado.NumeroTelefono;
                familiarDesignadoEncontrado.Parentesco = familiarDesignado.Parentesco;
                familiarDesignadoEncontrado.Correo = familiarDesignado.Correo;
                familiarDesignadoEncontrado.Genero = familiarDesignado.Genero;

                _appContext.SaveChanges();

            }
            return familiarDesignadoEncontrado;

        }

        public void DeleteFamiliarDesignado(int idFamiliarDesignado)
        {
            var familiarDesignadoEncontrado = _appContext.Familiares.FirstOrDefault(p => p.Id == idFamiliarDesignado);//p es el primero que encuentra. Recorre todos los elementos de la tabla
            if (familiarDesignadoEncontrado == null)
                return;
            _appContext.Familiares.Remove(familiarDesignadoEncontrado);
            _appContext.SaveChanges();//Se deben guardar los cambios            
        }

        public FamiliarDesignado GetFamiliarDesignado(int idFamiliarDesignado)
        {
            return _appContext.Familiares.FirstOrDefault(p => p.Id == idFamiliarDesignado);//retorna lo que encuentra
        }

    }
}