using System;
using System.ComponentModel.DataAnnotations;

namespace HospiEnCasa.App.Dominio
{
     public class Persona
     {
         public int Id {get; set;}
         [Required(ErrorMessage = "El nombre el requerido"), StringLength(50)]
         public string Nombre {get; set;}
         [Required, StringLength(50)]
         public string Apellidos {get; set;}
         
         [Required, RegularExpression("^[0-9]+$", ErrorMessage = "Ingresar un número entero válido"), MinLength(6, ErrorMessage = "Mínimo 6 números"), DataType(DataType.PhoneNumber)]
         public string NumeroTelefono {get; set;}
         [Required]
         public Genero Genero {get; set;}
     }
}