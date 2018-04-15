using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace GestionEntradas
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu();
        }

        private static void Menu()
        {
            Console.Clear();
            Console.WriteLine("\n   GESTION ENTRADAS");
            Console.WriteLine("==========================");
            Console.WriteLine(" a) Mostrar el número de entradas libres y vendidas de cada tipo");
            Console.WriteLine(" b) Vender entrada");
            Console.WriteLine(" c) Mostrar la cantidad recaudada de cada tipo de entrada");
            Console.WriteLine(" d) Salir");
            Console.Write("\n -Seleccione una opción: ");
            ConsoleKeyInfo tecla;
            tecla = Console.ReadKey();

            switch (tecla.Key)
            {
                case ConsoleKey.A:
                    MostarNumeroEntradas();
                    break;
                case ConsoleKey.B:
                    VenderEntrada();
                    break;
                case ConsoleKey.C:
                    MostrarCantidadRecaudada();
                    break;
                case ConsoleKey.D:
                    Console.Clear();
                    Console.WriteLine(" Saliendo...");
                    Thread.Sleep(1000);
                    Environment.Exit(0);
                    break;
                default:
                    Menu();
                    break;
            }
        }

        private static void MostarNumeroEntradas()
        {
            Console.Clear();
            Console.WriteLine("\n  NUMERO DE ENTRADAS");
            Console.WriteLine("=======================");
            Console.WriteLine("\n-ENTRADAS DISPONIBLES:");
            Console.WriteLine("\n\t -Popular: {0}", Entradas.popular.nPlazas - Entradas.popular.vendidas);
            Console.WriteLine("\t -General: {0}", Entradas.general.nPlazas - Entradas.general.vendidas);
            Console.WriteLine("\t     -VIP: {0}", Entradas.VIP.nPlazas - Entradas.VIP.vendidas);

            Console.WriteLine("\n\n-ENTRADAS VENDIDAS:");
            Console.WriteLine("\n\t -Popular: {0}", Entradas.popular.vendidas);
            Console.WriteLine("\t -General: {0}", Entradas.general.vendidas);
            Console.WriteLine("\t     -VIP: {0}", Entradas.VIP.vendidas);

            Console.WriteLine("\n\n Pulse ENTER para volver al Menú Principal.");
            Console.ReadLine();
            Menu();
        }

        private static void VenderEntrada()
        {
            Console.Clear();
            Console.WriteLine("\n  VENDER ENTRADA");
            Console.WriteLine("=======================");
            Console.Write(" -Indica el tipo de entrada ( a) Popular, b) General, c) VIP ): ");
            ConsoleKeyInfo tecla2;
            tecla2 = Console.ReadKey();
            switch (tecla2.Key)
            {
                case ConsoleKey.A:
                    VenderEntradaPopular();
                    break;
                case ConsoleKey.B:
                    VenderEntradaGeneral();
                    break;
                case ConsoleKey.C:
                    VenderEntradaVIP();
                    break;
                default:
                    VenderEntrada();
                    break;
            }
        }

        private static void VenderEntradaPopular()
        {
            string confirmar = "y";
            string entradaTeclado = "";
            uint nEntradas = 0;

            Console.Clear();
            Console.WriteLine("\n  VENDER ENTRADA POPULAR");
            Console.WriteLine("==============================");
            Console.WriteLine(" Entradas disponibles: {0}", Entradas.popular.nPlazas - Entradas.popular.vendidas);
            Console.Write(" Número de entradas ({0} euros ud.): ", Entradas.popular.precio);
            try
            {
                nEntradas = uint.Parse(Console.ReadLine());
                if (nEntradas <= (Entradas.popular.nPlazas - Entradas.popular.vendidas) && nEntradas > 0)
                {
                    Console.WriteLine("Total pedido: {0} euros", nEntradas * Entradas.popular.precio);

                    Console.WriteLine("¿Desea confirmar la compra? (y/n)");
                    entradaTeclado = Console.ReadLine();
                    if (entradaTeclado.ToLower() == confirmar)
                    {
                        Entradas.popular.vendidas += nEntradas;
                        Entradas.popular.recaudado = nEntradas * Entradas.popular.precio;
                        Console.WriteLine("\n\n SE HA PROCESADO EL PEDIDO CON EXITO.");
                        Console.WriteLine("\n Pulse ENTER para volver al Menú Principal.");
                        Console.ReadLine();
                        Menu();
                    }
                    else
                    {
                        Console.WriteLine("\n\nNO SE HA PROCESADO EL PEDIDO.");
                        Console.WriteLine("\n Pulse ENTER para volver al Menú Principal.");
                        Console.ReadLine();
                        Menu();
                    }
                }
                else
                {
                    if (Entradas.popular.nPlazas == Entradas.popular.vendidas)
                    {
                        Console.WriteLine("\n\nNO SE HA PROCESADO EL PEDIDO. NO QUEDAN ENTRADAS DISPONIBLES.");
                        Console.WriteLine("\n Pulse ENTER para volver al Menú Principal.");
                        Console.ReadLine();
                        Menu();
                    }
                    Console.WriteLine("\n\n ERROR: EL NUMERO DE ENTRADAS SOLICITADAS ES MAYOR A LAS DISPONIBLES.");
                    Console.WriteLine("\n Pulse ENTER para volver a intentarlo.");
                    Console.ReadLine();
                    VenderEntradaPopular();
                }
            }
            catch (Exception)
            {
                Console.WriteLine("\n\n ERROR: EL NUMERO DE ENTRADAS SOLICITADAS ES INCORRECTO.");
                Console.WriteLine("\n Pulse ENTER para volver a intentarlo.");
                Console.ReadLine();
                VenderEntradaPopular();
            }
        }

        private static void VenderEntradaGeneral()
        {
            string confirmar = "y";
            string entradaTeclado = "";
            uint nEntradas = 0;

            Console.Clear();
            Console.WriteLine("\n  VENDER ENTRADA GENERAL");
            Console.WriteLine("==============================");
            Console.WriteLine(" Entradas disponibles: {0}", Entradas.general.nPlazas - Entradas.general.vendidas);
            Console.Write(" Número de entradas ({0} euros ud.): ", Entradas.general.precio);

            try
            {
                nEntradas = uint.Parse(Console.ReadLine());
                if (nEntradas <= (Entradas.general.nPlazas - Entradas.general.vendidas) && nEntradas > 0)
                {
                    Console.WriteLine("Total pedido: {0} euros", nEntradas * Entradas.general.precio);

                    Console.WriteLine("¿Desea confirmar la compra? (y/n)");
                    entradaTeclado = Console.ReadLine();
                    if (entradaTeclado.ToLower() == confirmar)
                    {
                        Entradas.general.vendidas += nEntradas;
                        Entradas.general.recaudado = nEntradas * Entradas.general.precio;
                        Console.WriteLine("\n\n SE HA PROCESADO EL PEDIDO CON EXITO.");
                        Console.WriteLine("\n Pulse ENTER para volver al Menú Principal.");
                        Console.ReadLine();
                        Menu();
                    }
                    else
                    {
                        Console.WriteLine("\n\nNO SE HA PROCESADO EL PEDIDO.");
                        Console.WriteLine("\n Pulse ENTER para volver al Menú Principal.");
                        Console.ReadLine();
                        Menu();
                    }
                }
                else
                {
                    if (Entradas.general.nPlazas == Entradas.general.vendidas)
                    {
                        Console.WriteLine("\n\nNO SE HA PROCESADO EL PEDIDO. NO QUEDAN ENTRADAS DISPONIBLES.");
                        Console.WriteLine("\n Pulse ENTER para volver al Menú Principal.");
                        Console.ReadLine();
                        Menu();
                    }

                    Console.WriteLine("\n\n ERROR: EL NUMERO DE ENTRADAS SOLICITADAS ES MAYOR A LAS DISPONIBLES.");
                    Console.WriteLine("\n Pulse ENTER para volver a intentarlo.");
                    Console.ReadLine();
                    VenderEntradaGeneral();
                }
            }
            catch (Exception)
            {
                Console.WriteLine("\n\n ERROR: EL NUMERO DE ENTRADAS SOLICITADAS ES INCORRECTO.");
                Console.WriteLine("\n Pulse ENTER para volver a intentarlo.");
                Console.ReadLine();
                VenderEntradaGeneral();
            }
        }

        private static void VenderEntradaVIP()
        {
            string confirmar = "y";
            string entradaTeclado = "";
            uint nEntradas = 0;

            Console.Clear();
            Console.WriteLine("\n  VENDER ENTRADA VIP");
            Console.WriteLine("==============================");
            Console.WriteLine(" Entradas disponibles: {0}", Entradas.VIP.nPlazas - Entradas.VIP.vendidas);
            Console.Write(" Número de entradas ({0} euros ud.): ", Entradas.VIP.precio);

            try
            {
                nEntradas = uint.Parse(Console.ReadLine());
                if (nEntradas <= (Entradas.VIP.nPlazas - Entradas.VIP.vendidas) && nEntradas > 0)
                {
                    Console.WriteLine("Total pedido: {0} euros", nEntradas * Entradas.VIP.precio);

                    Console.WriteLine("¿Desea confirmar la compra? (y/n)");
                    entradaTeclado = Console.ReadLine();
                    if (entradaTeclado.ToLower() == confirmar)
                    {
                        Entradas.VIP.vendidas += nEntradas;
                        Entradas.VIP.recaudado = nEntradas * Entradas.VIP.precio;
                        Console.WriteLine("\n\n SE HA PROCESADO EL PEDIDO CON EXITO.");
                        Console.WriteLine("\n Pulse ENTER para volver al Menú Principal.");
                        Console.ReadLine();
                        Menu();
                    }
                    else
                    {
                        Console.WriteLine("\n\nNO SE HA PROCESADO EL PEDIDO.");
                        Console.WriteLine("\n Pulse ENTER para volver al Menú Principal.");
                        Console.ReadLine();
                        Menu();
                    }
                }
                else
                {
                    if (Entradas.VIP.nPlazas == Entradas.VIP.vendidas)
                    {
                        Console.WriteLine("\n\nNO SE HA PROCESADO EL PEDIDO. NO QUEDAN ENTRADAS DISPONIBLES.");
                        Console.WriteLine("\n Pulse ENTER para volver al Menú Principal.");
                        Console.ReadLine();
                        Menu();
                    }

                    Console.WriteLine("\n\n ERROR: EL NUMERO DE ENTRADAS SOLICITADAS ES MAYOR A LAS DISPONIBLES.");
                    Console.WriteLine("\n Pulse ENTER para volver a intentarlo.");
                    Console.ReadLine();
                    VenderEntradaVIP();
                }
            }
            catch (Exception)
            {
                Console.WriteLine("\n\n ERROR: EL NUMERO DE ENTRADAS SOLICITADAS ES INCORRECTO.");
                Console.WriteLine("\n Pulse ENTER para volver a intentarlo.");
                Console.ReadLine();
                VenderEntradaVIP();
            }
        }

        private static void MostrarCantidadRecaudada()
        {
            Console.Clear();
            Console.WriteLine("\n  CANTIDAD RECAUDADA");
            Console.WriteLine("==============================");
            Console.WriteLine("\n -Total recaudado entradas Popular: {0}", Entradas.popular.recaudado);
            Console.WriteLine(" -Total recaudado entradas General: {0}", Entradas.general.recaudado);
            Console.WriteLine(" -Total recaudado entradas VIP: {0}", Entradas.VIP.recaudado);

            Console.WriteLine("\n\n Pulse ENTER para volver al Menú Principal.");
            Console.ReadLine();
            Menu();
        }
    }

    public class Entradas
    {
        public struct popular
        {
            public static string nombre = "popular";
            public static uint nPlazas = 20;
            public static uint precio = 5;
            public static uint vendidas = 0;
            public static uint recaudado = 0;
        }

        public struct general
        {
            public static string nombre = "general";
            public static uint nPlazas = 10;
            public static uint precio = 10;
            public static uint vendidas = 0;
            public static uint recaudado = 0;
        }

        public struct VIP
        {
            public static string nombre = "VIP";
            public static uint nPlazas = 5;
            public static uint precio = 20;
            public static uint vendidas = 0;
            public static uint recaudado = 0;
        }
    }
}
