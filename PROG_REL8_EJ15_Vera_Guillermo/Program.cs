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

            // Iniciamos el menú.
            Menu();
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
            Console.WriteLine();
            Console.WriteLine();
            Console.Write("\t -Seleccione una opción: ");

            switch (Console.Read())
            {
                case '1':
                    Console.WriteLine();
                    Console.WriteLine(" ========================= ");
                    Console.WriteLine("   1. Alta de artículos.");
                    Console.WriteLine(" ========================= ");
                    Console.WriteLine();
                    AltaArticulos();
                    Console.ReadLine();
                    break;
                case '2':
                    Console.WriteLine();
                    Console.WriteLine(" ========================= ");
                    Console.WriteLine("   2. Baja de artículos.");
                    Console.WriteLine(" ========================= ");
                    Console.WriteLine();
                    break;
                case '3':
                    Console.WriteLine();
                    Console.WriteLine(" ============================= ");
                    Console.WriteLine("   3. Consultar un artículo.");
                    Console.WriteLine(" ============================= ");
                    Console.WriteLine();
                    break;
                case '4':
                    Console.WriteLine();
                    Console.WriteLine(" ============================= ");
                    Console.WriteLine("   4. Modificar un artículo.");
                    Console.WriteLine(" ============================= ");
                    Console.WriteLine();
                    break;
                case '5':
                    Console.WriteLine();
                    Console.WriteLine(" ============================================= ");
                    Console.WriteLine("   5. Listar artículos ordenados por código.");
                    Console.WriteLine(" ============================================= ");
                    Console.WriteLine();
                    break;
                case '6':
                    Console.WriteLine();
                    Console.WriteLine(" ============================================= ");
                    Console.WriteLine("   6. Listar artículos ordenados por nombre.");
                    Console.WriteLine(" ============================================= ");
                    Console.WriteLine();
                    break;
                case '7':
                    Console.WriteLine();
                    Console.WriteLine(" ================ ");
                    Console.WriteLine("   7. Imprimir.");
                    Console.WriteLine(" ================ ");
                    Console.WriteLine();
                    break;
                case '8':
                    Console.WriteLine();
                    Console.WriteLine(" ============================== ");
                    Console.WriteLine("   8. Generar documento HTML.");
                    Console.WriteLine(" ============================== ");
                    Console.WriteLine();
                    break;
                case '9':
                    Console.WriteLine();
                    Console.WriteLine(" ===================== ");
                    Console.WriteLine("   9. Crear fichero.");
                    Console.WriteLine(" ===================== ");
                    Console.WriteLine();
                    break;
                case '0':
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine(" ========================= ");
                    Console.WriteLine("   0. Salir del programa.");
                    Console.WriteLine(" ========================= ");
                    Environment.Exit(0);
                    break;

            }
        }

        static void AltaArticulos()
        {
            // Declaramos la ruta del fichero donde se guardan los artículos.
            // Luego puede ser copiado al contenido de un fichero creado con la opción "9. Crear fichero".
            string rutaAltaArticulos = Path.GetFullPath(@"AltaArticulos.txt");
            
            // Boolean todo ok
            bool ok = true;

            // Inicializamos el flujo.
            StreamWriter flujoAltaArticulos = new StreamWriter(rutaAltaArticulos, ok);

            // Declaramos.
            int? cod_art = 000; // Entero, con posibilidad de null. Código de artículo.
            string cod_artToString = ""; // String conversión de int.
            string nombre_art = ""; // Nombre artículo.
            float? precio = 0.00F; // Flotante, Precio artículo.
            string precioToString = ""; // String de conversión de float.
            float? pvp = 0.00F; // Flotante, PVP.
            string pvpToString = ""; // String de conversión de float.
            int existencias = 0; // Entero de existencias.
            string existenciasToString = ""; // String conversión de int.
            string comentario = "";




            // Inicio del Método en consola.
            Console.WriteLine(" Introduzca códigos de artículos.\n Si el valor introducido es '0', saldrá al menú.");
            Console.WriteLine();
            Console.ReadLine();
            try
            {
                do // Escribe el contenido en el fichero siempre que el código no sea null.
                {
                    Console.WriteLine(" ================================================================== ");
                    Console.WriteLine(" ================================================================== ");
                    Console.WriteLine();
                    Console.WriteLine();
                    // Escribimos los cod_art.
                    Console.Write("\n\t cod_art: ");
                    cod_art = int.Parse(Console.ReadLine()); // Conversión para detectar int null.

                    if (cod_art == 0)
                    {
                        throw new FormatException();
                    }

                    // Convertimos el número a string para escribirlo junto al nombre.
                    cod_artToString = cod_art.ToString();
                    
                    // Escribimos los nombre_art.
                    Console.Write("\n\t nombre_art: ");
                    nombre_art = Console.ReadLine();

                    if (nombre_art == string.Empty)
                    {
                        throw new FormatException();
                    }

                    // Escribimos el precio.
                    Console.Write("\n\t precio: ");
                    precio = float.Parse(Console.ReadLine());

                    if (precio == 0)
                    {
                        throw new FormatException();
                    }

                    // Convertimos el número a string para escribirlo junto al nombre.
                    precioToString = precio.ToString();

                    // Escribimos el PVP.
                    Console.Write("\n\t pvp: ");
                    pvp = float.Parse(Console.ReadLine());

                    if (pvp == 0)
                    {
                        throw new FormatException();
                    }

                    // Convertimos el número a string para escribirlo junto al nombre.
                    pvpToString = pvp.ToString();

                    // Escribimos las existencias.
                    Console.Write("\n\t existencias: ");
                    existencias = int.Parse(Console.ReadLine());

                    // Convertimos el número a string para escribirlo junto al nombre.
                    existenciasToString = existencias.ToString();

                    // Comentario
                    Console.Write("\n\t comentario: ");
                    comentario = Console.ReadLine();

                    Console.WriteLine();
                    Console.WriteLine();

                    // Escribimos la información anterior en el menú                   
                    flujoAltaArticulos.Write(cod_artToString + " " + nombre_art + " " + precioToString + " " + existenciasToString + " " + comentario);
                    flujoAltaArticulos.Close();

                } while (cod_art != 0 && nombre_art != string.Empty && precio != 0 && pvp != 0);

                Menu();

            }
            catch (Exception)
            {
                AltaArticulosException();
            }
        }

        public static void AltaArticulosException()
        {
            // Limpia el caché de la consola.
            Console.Clear();

            // Devuelve por consola el siguiente mensaje.
            Console.WriteLine("=========================================");
            Console.WriteLine(" ERROR: FORMATO INTRODUCIDO INCORRECTO.");
            Console.WriteLine("=========================================");
            Console.WriteLine();
            Console.WriteLine(" -El formato debe respetar 3 dígitos.");
            Console.WriteLine(" -El nombre no puede estar vacío.");
            Console.WriteLine(" -El precio del artículo no puede estar vacío o ser nulo.");
        }
    }
}
