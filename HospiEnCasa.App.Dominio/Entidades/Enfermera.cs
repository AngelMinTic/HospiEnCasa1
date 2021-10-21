using System;
using System.ComponentModel.DataAnnotations;

namespace HospiEnCasa.App.Dominio
{
    public class Enfermera:Persona
    {
      [Required, StringLength(50)]
      public string TarjetaProfesional{get;set;}
      public int HorasLaborales{get;set;}
    } 
}