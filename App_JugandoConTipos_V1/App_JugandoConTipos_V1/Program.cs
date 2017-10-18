using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App_JugandoConTipos_V1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Declaramos
            byte b1;

            Console.Clear();
            Console.WriteLine();
            Console.WriteLine(" El tipo int es un \"{0}\"", typeof(int));
            Console.WriteLine(" El tipo float es un \"{0}\"", typeof(float));
            Console.WriteLine(" El tipo byte es un \"{0}\"", typeof(byte));
            Console.WriteLine(" \n-------------------------------------------------------\n");
            Console.WriteLine(" El tipo {0} ocupa {1} bytes en memoria.", "int", sizeof(int));
            Console.WriteLine(" El tipo {0} ocupa {1} bytes en memoria.", "float", sizeof(float));
            Console.WriteLine(" El tipo {0} ocupa {1} bytes en memoria.", "byte", sizeof(byte));
            Console.WriteLine(" El tipo {0} ocupa {1} bytes en memoria.", "double", sizeof(double));
            Console.WriteLine(" \n-------------------------------------------------------\n");
            Console.WriteLine(" Los límites del tipo \"{0}\" son \"{1}\" y \"{2}\"", "int", int.MinValue, int.MaxValue);
            Console.WriteLine(" Los límites del tipo \"{0}\" son \"{1}\" y \"{2}\"", "double", double.MinValue, double.MaxValue);
            Console.WriteLine(" Los límites del tipo \"{0}\" son \"{1}\" y \"{2}\"", "sbyte", sbyte.MinValue, sbyte.MaxValue);
            Console.WriteLine(" \n-------------------------------------------------------\n");
            // Desbordamientos
            b1 = 254;
            Console.WriteLine(" El valor de {0} --> {1}", "b1", b1);
            // No se usa!!!  b1 = b1 + 1;
            b1++; // 255
            //checked      Salta excepción. Con unchecked (igual que no ponerlo) no saltaría la excepción.
            {
                Console.WriteLine(" El valor de {0} --> {1}", "b1", b1);
                b1++; // 256 -- El valor se vuelve a 0 porque el unchecked está activo. Vuelve al primer dígito.
                Console.WriteLine(" El valor de {0} --> {1}", "b1", b1);
            }

            // Ejemplo de casting
            int i1 = 65;
            char letra = 'X';
            letra = (char)int.Parse("65");  // Convertimos el string "65" en entero y luego le hacemos el casting a un char.
            Console.WriteLine(" \n-------------------------------------------------------\n");
            Console.WriteLine(" El ASCII de {0} es {1}", letra, i1);
            Console.WriteLine(" El ASCII de {0} es {1}", letra, (int)i1);
            Console.WriteLine(" El ASCII de {0} es {1}", (char)i1, i1);


            Console.ReadLine();
        }
    }
}
