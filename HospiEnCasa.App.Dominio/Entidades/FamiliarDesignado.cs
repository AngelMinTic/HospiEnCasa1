using System.ComponentModel.DataAnnotations;

namespace HospiEnCasa.App.Dominio
{
    public class FamiliarDesignado:Persona
    {
      public string Parentesco{get;set;}
      [EmailAddress(ErrorMessage = "Correo invalido")]
      public string Correo{get;set;}
    }
}