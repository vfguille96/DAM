using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROG_REL3_EJ16_Vera_Guillermo
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            // Declaramos los contadores de cada vocal.
            int contadorA = 0;
            int contadorE = 0;
            int contadorI = 0;
            int contadorO = 0;
            int contadorU = 0;

            // Declaramos el caracter de escape.
            char asterisco = '*';

            // Declaramos una variable de entrada por taclado.
            char entradaTeclado = ' ';

            Console.WriteLine(" Contabilizador de vocales");
            Console.WriteLine(" --------------------------");
            Console.WriteLine();
            Console.WriteLine(" Contabiliza el número de vocales hasta introducir un '*'.");
            Console.WriteLine();
            Console.Write(" Introduce una vocal: ");
            entradaTeclado = (char)Console.Read();

            do
            {
                switch (entradaTeclado)
                {
                    case 'a':
                        contadorA++;
                        break;

                    case 'e':
                        contadorE++;
                        break;

                    case 'i':
                        contadorI++;
                        break;

                    case 'o':
                        contadorO++;
                        break;

                    case 'u':
                        contadorU++;
                        break;

                    case 'A':
                        contadorA++;
                        break;

                    case 'E':
                        contadorE++;
                        break;

                    case 'I':
                        contadorI++;
                        break;

                    case 'O':
                        contadorO++;
                        break;

                    case 'U':
                        contadorU++;
                        break;
                }
                               
                Console.ReadLine();
                Console.Write(" Introduce una vocal: ");
                entradaTeclado = (char)Console.Read();
            } while (entradaTeclado != asterisco);

            // Llama al método para el recuento de vocales.
            EscribirNumeroCaracteres(contadorA, contadorE, contadorI, contadorO, contadorU);
            Console.ReadLine();
        }

        /// <summary>
        /// Método que escribe el número de vocales.
        /// </summary>
        /// <param name="contadorA"></param>
        /// <param name="contadorE"></param>
        /// <param name="contadorI"></param>
        /// <param name="contadorO"></param>
        /// <param name="contadorU"></param>
        private static void EscribirNumeroCaracteres(int contadorA, int contadorE, int contadorI, int contadorO, int contadorU)
        {
            Console.Clear();
            Console.WriteLine();
            Console.WriteLine("      VOCAL | NUMERO DE VOCALES");
            Console.WriteLine("    -----------------------------");
            Console.WriteLine("\tA ---> {0}", contadorA);
            Console.WriteLine("\tE ---> {0}", contadorE);
            Console.WriteLine("\tI ---> {0}", contadorI);
            Console.WriteLine("\tO ---> {0}", contadorO);
            Console.WriteLine("\tU ---> {0}", contadorU);

            Console.ReadLine();
        }
    }
}
