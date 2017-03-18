using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace PROG_REL8_EJ15_Vera_Guillermo
{
    class Program
    {
        static void Main(string[] args)
        {
        }

        static void Menu()
        {
            Console.WriteLine(" =================================== ");
            Console.WriteLine("     M E N U  P R I N C I P A L");
            Console.WriteLine(" =================================== ");
            Console.WriteLine();
            Console.WriteLine("\n 1. Alta de artículos.");
            Console.WriteLine("\n 2. Baja de artículos.");
            Console.WriteLine("\n 3. Consultar un artículo.");
            Console.WriteLine("\n 4. Modificar un artículo.");
            Console.WriteLine("\n 5. Listar artículos ordenados por código.");
            Console.WriteLine("\n 6. Listar artículos ordenados por nombre.");
            Console.WriteLine("\n 7. Imprimir.");
            Console.WriteLine("\n 8. Generar documento HTML.");
            Console.WriteLine("\n 9. Crear fichero.");
            Console.WriteLine();
            Console.WriteLine("\n\t 0. Salir del programa.");

            switch (Console.Read())
            {
                case '1':
                    Console.WriteLine(" ========================= ");
                    Console.WriteLine("   1. Alta de artículos.");
                    Console.WriteLine(" ========================= ");
                    break;
                case '2':
                    Console.WriteLine(" ========================= ");
                    Console.WriteLine("   2. Baja de artículos.");
                    Console.WriteLine(" ========================= ");
                    break;
                case '3':
                    Console.WriteLine(" ============================= ");
                    Console.WriteLine("   3. Consultar un artículo.");
                    Console.WriteLine(" ============================= ");
                    break;
                case '4':
                    Console.WriteLine(" ============================= ");
                    Console.WriteLine("   4. Modificar un artículo.");
                    Console.WriteLine(" ============================= ");
                    break;
                case '5':
                    Console.WriteLine(" ============================================= ");
                    Console.WriteLine("   5. Listar artículos ordenados por código.");
                    Console.WriteLine(" ============================================= ");
                    break;
                case '6':
                    Console.WriteLine(" ============================================= ");
                    Console.WriteLine("   5. Listar artículos ordenados por código.");
                    Console.WriteLine(" ============================================= ");
                    break;
                case '7':
                    Console.WriteLine("1. Alta de artículos.");
                    break;
                case '8':
                    Console.WriteLine("1. Alta de artículos.");
                    break;
                case '9':
                    Console.WriteLine("1. Alta de artículos.");
                    break;
                case '0':
                    Console.WriteLine("1. Alta de artículos.");
                    break;

            }
        }
    }
}
