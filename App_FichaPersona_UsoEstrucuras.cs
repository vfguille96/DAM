using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App_FichaPersona_Estructura
{
    internal class Program
    {
        // Contiene los datos de una persona.
        public struct FichaPersona
        {
            private string Privado; // Para demostrar que no salen los miembros de la estructura.
            public string Nombre;
            public float Altura;
            public DateTime FechaNacimiento;
            public string Dni;
            public int Edad;
        };

        private static void Main(string[] args)
        {
            FichaPersona aux1;
            aux1 = LeeDatos();
            VerDatos(aux1);

            Console.ReadLine();
        }

        #region Métodos propios

        public static void VerDatos(FichaPersona p)
        {
            Console.WriteLine("\n\n   Datos de una Persona");
            Console.WriteLine(" ---------------------------\n");
            Console.WriteLine("   Nombre: {0}\n", p.Nombre);
            p.Edad = CalcularEdad(p.FechaNacimiento);
            Console.WriteLine("     Edad: {0}\n", p.Edad);
            Console.WriteLine(" Estatura: {0}\n", p.Altura);
            Console.WriteLine("      DNI: {0}\n", p.Dni);
        }

        public static FichaPersona LeeDatos()
        {
            FichaPersona p = new FichaPersona();
            bool correcto = false;

            do
            {
                try
                {
                    Console.Clear();
                    Console.WriteLine("              Datos de una Persona");
                    Console.WriteLine(" -----------------------------------------------\n");
                    Console.Write("                           Nombre: ");
                    p.Nombre = Console.ReadLine();
                    Console.Write("\n Fecha de nacimiento (dd/mm/aaaa): ");
                    p.FechaNacimiento = DateTime.Parse(Console.ReadLine());
                    Console.Write("\n                         Estatura: ");
                    p.Altura = float.Parse(Console.ReadLine());
                    Console.Write("\n                              DNI: ");
                    p.Dni = Console.ReadLine();

                    correcto = true;
                }
                catch (Exception)
                {
                    Console.WriteLine("\n\n ERROR: FORMATO DE ENTRADA INVALIDO.");
                    Console.ReadLine();
                }
            } while (!correcto);

            return p;
        }

        public static int CalcularEdad(DateTime FechaNacimiento)
        {
            DateTime fechaHoy = DateTime.Today;
            int edad = fechaHoy.Year - FechaNacimiento.Year;

            if (FechaNacimiento > fechaHoy.AddYears(-edad))
                edad--;

            return edad;
        }

        #endregion Métodos propios
    }
}