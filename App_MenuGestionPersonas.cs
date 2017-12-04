using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace PROG_REL5_EJ9_Vera_G
{
    internal class Program
    {
        public static int nPersonas = 0;
        private const int NMAXPERS = 10;
        public static int posicionArray = 0;
        public static ConsoleKeyInfo tecla;
        public static FichaPersona[] arrayPersonas = new FichaPersona[NMAXPERS];

        public struct FichaPersona
        {
            public uint codigo;
            public string apellidos;
            public string nombre;
            public int edad;
            public int sueldo;
            public DateTime fechaContrato;
        }

        private static void Main(string[] args)
        {
            Menu();
            Console.ReadLine();
        }

        private static void Menu()
        {
            Console.Title = "Menú Gestión Personas\t Fichas: " + nPersonas.ToString() + "/" + NMAXPERS.ToString();
            Console.WriteLine("\n  =============================");
            Console.WriteLine("    MENU GESTION DE PERSONAS");
            Console.WriteLine("  =============================\n");
            Console.WriteLine("     1- Añadir.");
            Console.WriteLine("     2- Buscar.");
            Console.WriteLine("     3- Editar.");
            Console.WriteLine("     4- Listar.");
            Console.WriteLine("\n     0- Salir.");
            Console.Write("\n\n  -Elige una opción: ");
            tecla = Console.ReadKey();

            switch (tecla.KeyChar)
            {
                case '1':
                    if (nPersonas < NMAXPERS)
                    {
                        if (!AddPersona(arrayPersonas, CrearFichaPersona()))
                            ErrorAnadirDatos();
                        else
                            nPersonas++;
                        PieOpciones();
                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine("\n\n *********************************************************");
                        Console.WriteLine("   ERROR: SE HA ALCANZADO EL NUMERO MAXIMO DE PERSONAS.");
                        Console.WriteLine(" *********************************************************");
                        PieOpciones();
                    }
                    break;

                case '2':
                    uint codigo = 0;
                    Console.Clear();
                    Console.WriteLine("\n =======================");
                    Console.WriteLine("     2- Buscar.");
                    Console.WriteLine(" =======================\n");
                    Console.Write(" -Código: ");
                    try
                    {
                        codigo = uint.Parse(Console.ReadLine());
                        BuscarPersona(codigo, arrayPersonas);
                    }
                    catch (Exception)
                    {
                        Console.Clear();
                        Console.WriteLine("\n\n *************************************************************");
                        Console.WriteLine("   ERROR: SE HA INTRODUCIDO UN FORMATO DE CODIGO INCORRECTO.");
                        Console.WriteLine(" *************************************************************");
                        PieOpciones();
                    }

                    PieOpciones();
                    break;

                case '3':
                    Console.Clear();
                    Console.WriteLine("\n =======================");
                    Console.WriteLine("     3- Editar.");
                    Console.WriteLine(" =======================\n");
                    VerDatosEditar(arrayPersonas);
                    PieOpciones();
                    break;

                case '4':
                    Console.Clear();
                    Console.WriteLine("\n =======================");
                    Console.WriteLine("     4- Listar.");
                    Console.WriteLine(" =======================\n");
                    Listar(arrayPersonas);
                    PieOpciones();
                    break;

                case '0':
                    SalirApp();
                    break;

                default:
                    Console.Clear();
                    Menu();
                    break;
            }
        }

        private static void PieOpciones()
        {
            Console.WriteLine("\n\n Presiona la tecla ESC para regresar al Menú Principal.\n\n Pulsa SUPR para salir de la App.");
            tecla = Console.ReadKey();
            if (tecla.Key == ConsoleKey.Escape)
            {
                Console.Clear();
                Menu();
            }
            if (tecla.Key == ConsoleKey.Delete)
                SalirApp();
        }

        private static void SalirApp()
        {
            Console.Clear();
            Console.WriteLine("\n =======================");
            Console.WriteLine("     0- Salir...");
            Console.WriteLine(" =======================\n");
            Console.WriteLine("\n\n -Espere 1 segundo...");
            Thread.Sleep(1000);
            Environment.Exit(0);
        }

        public static FichaPersona CrearFichaPersona()
        {
            FichaPersona p1 = new FichaPersona();
            Console.Clear();
            Console.WriteLine("\n =======================");
            Console.WriteLine("     1- Añadir.");
            Console.WriteLine(" =======================\n");
            Console.Write("\t -Codigo: ");
            try
            {
                p1.codigo = uint.Parse(Console.ReadLine());
                if (!BuscarPersona(p1.codigo, arrayPersonas, 1))
                {
                    Console.Clear();
                    Console.WriteLine("\n\n ************************************************************");
                    Console.WriteLine("   ERROR: SE HA ENCONTRADO UNA PERSONA CON EL MISMO CODIGO.");
                    Console.WriteLine(" ************************************************************");
                    PieOpciones();
                }
                Console.Write("\n\t -Apellidos: ");
                p1.apellidos = Console.ReadLine();
                Console.Write("\n\t -Nombre: ");
                p1.nombre = Console.ReadLine();
                Console.Write("\n\t -Edad: ");
                p1.edad = int.Parse(Console.ReadLine());
                Console.Write("\n\t -Sueldo: ");
                p1.sueldo = int.Parse(Console.ReadLine());
                Console.Write("\n\t -Fecha de contrato: ");
                p1.fechaContrato = DateTime.Parse(Console.ReadLine());

                return p1;
            }
            catch (Exception)
            {
                ErrorAnadirDatos();
            }

            return p1;
        }

        private static bool AddPersona(FichaPersona[] vector, FichaPersona p1)
        {
            if (posicionArray >= vector.Length)
                return false;
            vector[posicionArray++] = p1;
            return true;
        }

        private static void BuscarPersona(uint codigo, FichaPersona[] arrayPersonas)
        {
            for (int i = 0; i < posicionArray; i++)
            {
                if (arrayPersonas[i].codigo == codigo)
                    VerDatosEditar(arrayPersonas, i);
            }
        }

        private static bool BuscarPersona(uint codigo, FichaPersona[] arrayPersonas, byte x)
        {
            bool personaEncontrada = true;
            for (int i = 0; i < posicionArray; i++)
            {
                if (arrayPersonas[i].codigo == codigo)
                    personaEncontrada = false;
            }

            if (!personaEncontrada)
                return personaEncontrada;
            else
                return true;
        }

        public static void VerDatosEditar(FichaPersona[] arrayPersonas, int numero)
        {
            for (int i = numero; i < posicionArray; i++)
            {
                Console.WriteLine("\n\n   Datos de una Persona");
                Console.WriteLine(" ---------------------------\n");
                Console.WriteLine("     Codigo: {0}\n", arrayPersonas[i].codigo);
                Console.WriteLine("     Nombre: {0}\n", arrayPersonas[i].nombre);
                Console.WriteLine("  Apellidos: {0}\n", arrayPersonas[i].apellidos);
                Console.WriteLine("       Edad: {0}\n", arrayPersonas[i].edad);
                Console.WriteLine("     Sueldo: {0}\n", arrayPersonas[i].sueldo);
                Console.WriteLine("F. Contrato: {0}\n", arrayPersonas[i].fechaContrato.ToShortDateString());
            }
        }

        public static void VerDatosEditar(FichaPersona[] arrayPersonas)
        {
            for (int i = 0; i < posicionArray; i++)
            {
                Console.WriteLine("\n\n   Datos de una Persona");
                Console.WriteLine(" ---------------------------\n");
                Console.WriteLine("     Codigo: {0}\n", arrayPersonas[i].codigo);
                Console.WriteLine("     Nombre: {0}\n", arrayPersonas[i].nombre);
                Console.WriteLine("  Apellidos: {0}\n", arrayPersonas[i].apellidos);
                Console.WriteLine("       Edad: {0}\n", arrayPersonas[i].edad);
                Console.WriteLine("     Sueldo: {0}\n", arrayPersonas[i].sueldo);
                Console.WriteLine("F. Contrato: {0}\n", arrayPersonas[i].fechaContrato.ToShortDateString());
            }
        }

        private static void Listar(FichaPersona[] a)
        {
            if (posicionArray == 0)
                Console.Write("\n La lista de Perosnas está vacía.");
            else
            {
                Console.SetWindowSize(120, 34);
                Console.WriteLine("\n Codigo\t Nombre\t\t\tApellidos\t\t Edad\t Sueldo\t Fecha Contrato");
                Console.WriteLine(" --------------------------------------------------------------------------------------------");
                for (int i = 0; i < posicionArray; i++)
                    Console.WriteLine(" {0,3}\t {1}\t\t{2}\t\t {3}\t {4}\t {5}", ((a[i].codigo).ToString()).PadRight(3, ' '), ((a[i].nombre).ToString()).PadRight(12, ' '), ((a[i].apellidos).ToString()).PadRight(12, ' '), ((a[i].edad).ToString()).PadRight(2, ' '), ((a[i].sueldo).ToString()).PadRight(5, ' '), a[i].fechaContrato.ToShortDateString());

                Console.WriteLine("\n\n Fin del listado...");
            }
        }

        private static void ErrorAnadirDatos()
        {
            Console.Clear();
            Console.WriteLine("\n\n ERROR: NO SE HAN AÑADIDO LOS DATOS.\n\nVolver al Menú Principal en 3 segundos...");
            Thread.Sleep(3000);
            Menu();
        }
    }
}
