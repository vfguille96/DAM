using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROG_REL4_EJ8_Vera_Guillermo
{
    class Program
    {
        static void Main(string[] args)
        {
            // Declaramos una variable como tipo byte.
            byte caracter = 0;
            
            // Declaramos una estructura que descibe la recla presionada en la consola.
            ConsoleKeyInfo tecla;

            // Inicializamos un blucle infinito para que pida constantemente una tecla y devuelva esa tecla en mayúsculas.
            while (true)    
            { 
                Console.Write("\n Escribe un caracter y lo paso a mayúsculas: ");

                // Indicamos que la tecla presionada en la consola sea de la estructura.
                tecla = Console.ReadKey();

                // Introducimos en la variable el valor ASCII de la tecla presionada.
                caracter = (byte)tecla.KeyChar;

                // Si la tecla presionada no está entre los valores de las letras minúsculas y mayúsculas de la tabla ASCII, indicamos que el caracter introducido es inválido.
                if (caracter < (byte)65 || caracter > (byte)122)
                {
                    Console.Clear();    // Limpiamos la consola.
                    Console.WriteLine("\n ERROR: CARACTER INVALIDO.\n");
                }

                // Si está dentro de los valores, la convertimos a mayúsculas.
                if (caracter >= (byte)65 && caracter <= (byte)122)
                {
                    Console.Clear();
                    Console.WriteLine("\n\n **********************************************");
                    // Escribimos el caracter introducido y llamamos a la función que convierte a mayúsculas como parámetro el caracter que hemos leído de la consola. Dicha función devuelve el caracter en mayúsculas.
                    Console.WriteLine("\n     El caracter \"{0}\" en mayúsculas es : \"{1}\"\n", (char)caracter, ConvertirCaracterAMayusculas(caracter));
                    Console.WriteLine(" **********************************************\n\n");
                }
            }
        }

        /// <summary>
        /// Función que convierte el valor ASCII de un caracter a mayúsculas.
        /// </summary>
        /// <param name="x"></param>
        /// <returns>Devuelve un caracter en mayúsculas.</returns>
        static char ConvertirCaracterAMayusculas(byte x)
        {
            // Evaluamos si el valor pertenece al rango de las mayúsculas. Si es así, devolvemos el caracter.
            if (x >= (byte)65 && x <= (byte)90)           
                return (char)x;

            // Si no, le restamos la diferencia de los caracteres minúsculas a las mayúsculas y lo convertimos a caracter. Lo devolvemos.
            return (char)(x - (byte)32);
        }
    }
}
