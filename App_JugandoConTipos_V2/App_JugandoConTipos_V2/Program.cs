using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App_JugandoConTipos_V2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Declaramos variables.
            char c1 = (char)65; // Casting al 65 para convertirlo en caracter.
            int i1 = 0;
            byte b1 = (byte)'A';    // Casting al caracter 'A' para convertirlo a byte.
            short s1 = 5;   // 0000 0000 0000 0101 en binario. 0005 en hexadecimal.
            short s2 = 10;  // 0000 0000 0000 1010 en binario. 000A en hexadecimal.
            string ss1 = "Hola";
            string ss2 = "Hola";
            int[] a1 = { 1, 2, 3 }; // Array que contiene los números "1, 2, 3" en la variable a1.
            int[] a2 = { 1, 2, 3 };
            string cadena = " ===> ";
            float f1 = 3.141592F;   // Si se pone un número real, es doble. Si le digo al SO que sea flotante, hay que colocarle una F detrás.

            Console.WriteLine(" El número s1 vale en decimal {0} y en hexadecimal {0:X4}", s1);
            Console.WriteLine(" El número s1 vale en decimal {0} y en hexadecimal {0:X4}", s2);
            Console.WriteLine();    // Salto de línea.
            Console.WriteLine(" Escribe el complemento A1 de {0} es {1}", s2, ~s2);
            Console.WriteLine(" Escribe el complemento A1 de {0:X8} es {1:X8} --> {2:X8}", s2, ~s2, ~~2);   // Sería 1111 1111 1111 0101 (FFFF FFFF FFFF 5). --> 0000002
            Console.WriteLine();
            Console.WriteLine(" Es ss1 == ss2, {0}", ss1 == ss2);   // Porque está sobrecargado el operador. Pero es por referencia.
            Console.WriteLine(" Es a1 == a2, {0}", a1 == a2 ? "Verdad" : "Falso");  // Operador ternario condicional.
            Console.WriteLine();
            Console.WriteLine(" {0} es {1}", true, true);   // Introduce el valor booleano true en sus posiciones.
            Console.WriteLine(" {0} es {1}", true, !true);  // Introduce el valor booleano correspondiente con la posición, pero a la posición {1} se le da la vuelta.
            Console.WriteLine(" {0} es {1}", true, !!true);  // Introduce el valor booleano correspondiente con la posición, pero a la posición {1} se le da la vuelta dos veces.
            Console.WriteLine(" {0} es {1}", b1 > s1, !!true);    // Devuelve el valor booleano de la operación de la posición {0} y luego una doble negación de una afirmación verdadera.

            cadena += " Hola caracola\n" + ", " + " Un día vi una vaca...";
            Console.WriteLine(cadena);

            Console.ReadLine();
        }
    }
}
