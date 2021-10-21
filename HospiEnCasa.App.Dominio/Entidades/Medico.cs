using System.ComponentModel.DataAnnotations;

namespace HospiEnCasa.App.Dominio
{
    public class Medico:Persona
    {
      [Required, StringLength(50)]
      public string Especialidad{get;set;}
      public string Codigo{get;set;}
      [Required, StringLength(50)]
      public string RegistroRethus{get;set;}
    }
}