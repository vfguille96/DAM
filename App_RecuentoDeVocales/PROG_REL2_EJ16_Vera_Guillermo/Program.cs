using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROG_REL2_EJ16_Vera_Guillermo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Cáculo del volumen y área lateral de un cilindro recto";

            // Declaramos
            double radio = 0;
            double altura = 0;
            double volumen = 0;
            double areaLateral = 0;

            try
            {
                Console.WriteLine(" Pidiendo el radio y altura, calcularé el área lateral \n y el volumen de un cilindro.");
                Console.WriteLine();
                Console.Write(" Introduce el radio: ");
                radio = double.Parse(Console.ReadLine());
                Console.Write(" Introduce la altura: ");
                altura = double.Parse(Console.ReadLine());
                Console.WriteLine();

                // Cálculos
                volumen = Math.PI * Math.Pow(radio, 2) * altura;
                areaLateral = 2 * Math.PI * radio * altura;

                Console.WriteLine(" El área lateral del cilindro es: {0:N}", areaLateral);
                Console.WriteLine(" El volumen del cicindro es: {0:N}", volumen);
            }
            catch (Exception)
            {
                Console.WriteLine();
                Console.WriteLine("\t==========================");
                Console.WriteLine("\tERROR: FORMATO INCORRECTO.");
                Console.WriteLine("\t==========================");
            }


            Console.ReadLine();

        }
    }
}
