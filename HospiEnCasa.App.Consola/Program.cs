using System;
using System.Collections.Generic;
using HospiEnCasa.App.Dominio;
using HospiEnCasa.App.Persistencia.AppRepositorios;

namespace HospiEnCasa.App.Consola
{
    class Program
    {
        private static IRepositorioPaciente _repoPaciente = new RepositorioPaciente(new Persistencia.AppContext());
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World EF!");
            ListarPacientesFiebre();
            //AddSugerenciaPaciente(1);
            //AddHistoriaPaciente(3);
            //AddPacienteConHistoria();
            //ListarPacientesCorazon();
            //ListarPacientesMasculinos();
            //AddSignosPaciente(2);
            //AddPacienteConSignos();             
            //AddPaciente();
            //AddPaciente2();
            //BuscarPaciente(2);

            //AsignarMedico();

        }
        private static void AddPaciente()
        {
            var paciente = new Paciente
            {
                Nombre = "Angel",
                Apellidos = "Aguirre",
                NumeroTelefono = "3005464535",
                Genero = Genero.Masculino,
                Direccion = "Cl 45 no. 28 -74",
                Ciudad = "Bogotá",
                Longitud = 5.07062F,
                Latitud = -75.52290F,
                FechaNacimiento = new DateTime(1986, 02, 20)
            };
            _repoPaciente.AddPaciente(paciente);
        }

        private static void AddPacienteConHistoria()
        {
            var paciente = new Paciente
            {
                Nombre = "Ricardo",
                Apellidos = "Meneses",
                NumeroTelefono = "3029966374",
                Genero = Genero.Masculino,
                Direccion = "Calle 45 No 76 - 28",
                Longitud = 5.07062F,
                Latitud = -75.52290F,
                Ciudad = "Bogota",
                FechaNacimiento = new DateTime(1991, 03, 12),
                Historia = new Historia
                {
                    Diagnostico = "Diabetes",
                    Entorno = "La casa se encuentra en buen estado y organizada.",
                    Sugerencias = new List<SugerenciaCuidado>
                    {
                        new SugerenciaCuidado{ FechaHora= new DateTime(2021,10,15,18,50,0), Descripcion = "Paciente debe guardar reposo"},
                        new SugerenciaCuidado{FechaHora= new DateTime(2021,10,15,19,50,0), Descripcion = "Paciente ha de girarse cada 30 minutos"},
                        new SugerenciaCuidado{FechaHora= new DateTime(2021,10,15,19,50,0), Descripcion = "Paciente ha de cuidarse de una lesion distal (pie)"}
                    }
                }
            };
            _repoPaciente.AddPaciente(paciente);
        }


        private static void AddHistoriaPaciente(int idPaciente)
        {
            var paciente = _repoPaciente.GetPaciente(idPaciente);
            if (paciente != null)
            {
                if (paciente.Historia != null)
                {
                    paciente.Historia = new Historia
                    {

                        Diagnostico = "ACV",
                        Entorno = "La casa se encuentra en mal estado y sucia.",
                        Sugerencias = new List<SugerenciaCuidado>
                        {
                            new SugerenciaCuidado{FechaHora= new DateTime(2021,10,14,18,50,0), Descripcion = "Paciente debe seguir terapia"},
                            new SugerenciaCuidado{FechaHora= new DateTime(2021,10,14,19,50,0), Descripcion = "Paciente requiere de apoyo moral"}
                        }
                    };

                }
                else
                {
                    paciente.Historia = new Historia
                    {

                        Diagnostico = "ACV",
                        Entorno = "La casa se encuentra en mal estado y sucia.",
                        Sugerencias = new List<SugerenciaCuidado>
                        {
                            new SugerenciaCuidado{FechaHora= new DateTime(2021,10,14,18,50,0), Descripcion = "Paciente debe seguir terapia"},
                            new SugerenciaCuidado{FechaHora= new DateTime(2021,10,14,19,50,0), Descripcion = "Paciente requiere de apoyo moral"}
                        }
                    };
                }
                _repoPaciente.UpdatePaciente(paciente);
            }
        }
/*
        private static void AddSugerenciaPaciente(int idPaciente)
        {
            var paciente = _repoPaciente.GetPaciente(idPaciente);
            if (paciente != null)
            {   
                var historia = new Historia();
                if (paciente.Historia != null)
                
                {
                    historia = paciente.Historia;
                    if (historia.Sugerencias != null)   /// Pero estamos identificando el paciente???
                    {
                        historia.Sugerencias = new List<SugerenciaCuidado>
                        {
                            new SugerenciaCuidado{FechaHora= new DateTime(2021,10,16,18,50,0), Descripcion = "Paciente ha de seguir en silla de ruedas"}
                        };
                    }
                    else
                    {
                        historia.Sugerencias = new List<SugerenciaCuidado>
                        historia.Sugerencias.add(new SugerenciaCuidado { FechaHora = new DateTime(2021, 10, 16, 18, 50, 0), Descripcion = "Paciente ha de seguir en silla de ruedas" });
                    }

                }
                else
                {
                    paciente.Historia = new Historia
                    {

                        Diagnostico = "Fractura de Cadera",
                        Entorno = "La casa es amplia, aunque no tiene ascensor, cuenta con apoyo familiar.",
                        Sugerencias = new List<SugerenciaCuidado>
                        {
                            new SugerenciaCuidado{FechaHora= new DateTime(2021,10,16,18,50,0), Descripcion = "Paciente ha de seguir en silla de ruedas"}
                        }
                    };
                };
                _repoPaciente.UpdatePaciente(paciente);
            }
        }
    
*/
        private static void BuscarPaciente(int idPaciente)
        {
            var paciente = _repoPaciente.GetPaciente(idPaciente);
            Console.WriteLine("Nombre: " + paciente.Nombre + " " + paciente.Apellidos + " Genero: " + paciente.Genero);
        }

        private static void AsignarMedico()
        {
            var medico = _repoPaciente.AsignarMedico(1, 2);
            Console.WriteLine(medico.Nombre + " " + medico.Apellidos);
        }

        private static void AddPacienteConSignos()
        {
            var paciente = new Paciente
            {
                Nombre = "Carmenza",
                Apellidos = "Zuluaga",
                NumeroTelefono = "5001646",
                Genero = Genero.Femenino,
                Direccion = "Calle 908 No Xy-40",
                Longitud = 5.07062F,
                Latitud = -75.52290F,
                Ciudad = "Pereira",
                FechaNacimiento = new DateTime(1984, 04, 12),
                SignosVitales = new List<SignoVital> {
                        new SignoVital{FechaHora= new DateTime(2021,09,12,18,50,0),Valor=36,Signo=TipoSigno.TemperaturaCorporal},
                        new SignoVital{FechaHora= new DateTime(2021,09,12,18,50,0),Valor=95,Signo=TipoSigno.SaturacionOxigeno},
                        new SignoVital{FechaHora= new DateTime(2021,09,12,18,50,0),Valor=90,Signo=TipoSigno.FrecuenciaCardiaca}

                    }
            };
            _repoPaciente.AddPaciente(paciente);

        }

        private static void AddSignosPaciente(int idPaciente)
        {
            var paciente = _repoPaciente.GetPaciente(idPaciente);
            if (paciente != null)
            {
                if (paciente.SignosVitales != null)
                {
                    paciente.SignosVitales.Add(new SignoVital
                    {
                        FechaHora = new DateTime(2021, 07, 10, 10, 50, 0),
                        Valor = 86,
                        Signo = TipoSigno.FrecuenciaCardiaca
                    });
                }
                else
                {
                    paciente.SignosVitales = new List<SignoVital> {
                            new SignoVital{FechaHora= new DateTime(2021,07,10,10,50,0),Valor=86,Signo=TipoSigno.FrecuenciaCardiaca}
                        };
                }
                _repoPaciente.UpdatePaciente(paciente);
            }
        }

        private static void ListarPacientesMasculinos()
        {
            var pacientesM = _repoPaciente.GetPacientesMasculinos();
            foreach (Paciente p in pacientesM)
            {
                Console.WriteLine(p.Nombre + " " + p.Apellidos);
            }

        }
        private static void ListarPacientesCorazon()
        {
            var pacientesH = _repoPaciente.GetPacientesCorazon();
            foreach (Paciente p in pacientesH)
            {
                Console.WriteLine(p.Nombre + " " + p.Apellidos);
            }

        }

        private static void ListarPacientesFiebre()
        {
            var pacientesH = _repoPaciente.GetPacientesFiebre();
            foreach (Paciente p in pacientesH)
            {
                Console.WriteLine(p.Nombre + " " + p.Apellidos);
            }

        }

    }
}
