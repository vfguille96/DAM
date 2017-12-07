using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROG_REL5_EJ11_Vera_G
{
    class Program
    {
        #region Campos
        private static int totalTiradas = 0;
        private static int numSacado = 0;

        private static int vecesUno = 0;
        private static int vecesDos = 0;
        private static int vecesTres = 0;
        private static int vecesCuatro = 0;
        private static int vecesCinco = 0;
        private static int vecesSeis = 0;

        private static string resCalculado1 = "";
        private static string resCalculado2 = "";
        private static string resCalculado3 = "";
        private static string resCalculado4 = "";
        private static string resCalculado5 = "";
        private static string resCalculado6 = "";

        private static int porcentajeUno = 0;
        private static int porcentajeDos = 0;
        private static int porcentajeTres = 0;
        private static int porcentajeCuatro = 0;
        private static int porcentajeCinco = 0;
        private static int porcentajeSeis = 0;
        #endregion
        static void Main(string[] args)
        {
            byte[] dado = { 1, 2, 3, 4, 5, 6 };
            Random rnd = new Random();

            Console.Title = "Tirada de dados";
            Console.Write(" Introduce la cantidad de tiradas del dado: ");
            totalTiradas = int.Parse(Console.ReadLine());

            for (int i = 0; i < totalTiradas; i++)
            {
                numSacado = dado[rnd.Next(dado.Length)];
                ContarNumeros();
            }
            CalcularEstadisticas();

            Console.ReadLine();
        }

        private static void CalcularEstadisticas()
        {
            if (vecesUno != 0 && vecesUno != 1)
            {
                porcentajeUno = (vecesUno * 100) / totalTiradas;
                resCalculado1 = "\n 1 --> " + vecesUno + " veces" + " --> " + porcentajeUno + "%";
                Console.WriteLine(resCalculado1);

            }
            else if (vecesUno == 1)
            {
                porcentajeUno = (vecesUno * 100) / totalTiradas;
                resCalculado1 = "\n 1 --> " + vecesUno + " vez" + " --> " + porcentajeUno + "%";
                Console.WriteLine(resCalculado1);
            }
            else
            {
                resCalculado1 = "\n 1 --> " + vecesUno + " veces" + " --> " + porcentajeUno + "%";
                Console.WriteLine(resCalculado1);
            }

            //-----------------------------------

            if (vecesDos != 0 && vecesDos != 1)
            {
                porcentajeDos = (vecesDos * 100) / totalTiradas;
                resCalculado2 = " 2 --> " + vecesDos + " veces" + " --> " + porcentajeDos + "%";
                Console.WriteLine(resCalculado2);
            }
            else if (vecesDos == 1)
            {
                porcentajeDos = (vecesDos * 100) / totalTiradas;
                resCalculado2 = " 2 --> " + vecesDos + " vez" + " --> " + porcentajeDos + "%";
                Console.WriteLine(resCalculado2);
            }
            else
            {
                resCalculado2 = " 2 --> " + vecesDos + " veces" + " --> " + porcentajeDos + "%";
                Console.WriteLine(resCalculado2);
            }

            //-----------------------------------

            if (vecesTres != 0 && vecesTres != 1)
            {
                porcentajeTres = (vecesTres * 100) / totalTiradas;
                resCalculado3 = " 3 --> " + vecesTres + " veces" + " --> " + porcentajeTres + "%";
                Console.WriteLine(resCalculado3);
            }
            else if (vecesTres == 1)
            {
                porcentajeTres = (vecesTres * 100) / totalTiradas;
                resCalculado3 = " 3 --> " + vecesTres + " vez" + " --> " + porcentajeTres + "%";
                Console.WriteLine(resCalculado3);
            }
            else
            {
                resCalculado3 = " 3 --> " + vecesTres + " veces" + " --> " + porcentajeTres + "%";
                Console.WriteLine(resCalculado3);

            }

            //-----------------------------------

            if (vecesCuatro != 0 && vecesCuatro != 1)
            {
                porcentajeCuatro = (vecesCuatro * 100) / totalTiradas;
                resCalculado4 = " 4 --> " + vecesCuatro + " veces" + " --> " + porcentajeCuatro + "%";
                Console.WriteLine(resCalculado4);
            }
            else if (vecesCuatro == 1)
            {
                porcentajeCuatro = (vecesCuatro * 100) / totalTiradas;
                resCalculado4 = " 4 --> " + vecesCuatro + " vez" + " --> " + porcentajeCuatro + "%";
                Console.WriteLine(resCalculado4);
            }
            else
            {
                resCalculado4 = " 4 --> " + vecesCuatro + " veces" + " --> " + porcentajeCuatro + "%";
                Console.WriteLine(resCalculado4);
            }

            //-----------------------------------

            if (vecesCinco != 0 && vecesCinco != 1)
            {
                porcentajeCinco = (vecesCinco * 100) / totalTiradas;
                resCalculado5 = " 5 --> " + vecesCinco + " veces" + " --> " + porcentajeCinco + "%";
                Console.WriteLine(resCalculado5);
            }
            else if (vecesCinco == 1)
            {
                porcentajeCinco = (vecesCinco * 100) / totalTiradas;
                resCalculado5 = " 5 --> " + vecesCinco + " vez" + " --> " + porcentajeCinco + "%";
                Console.WriteLine(resCalculado5);
            }
            else
            {
                resCalculado5 = " 5 --> " + vecesCinco + " veces" + " --> " + porcentajeCinco + "%";
                Console.WriteLine(resCalculado5);
            }

            //-----------------------------------

            if (vecesSeis != 0 && vecesSeis != 1)
            {
                porcentajeSeis = (vecesSeis * 100) / totalTiradas;
                resCalculado6 = " 6 --> " + vecesSeis + " veces" + " --> " + porcentajeSeis + "%";
                Console.WriteLine(resCalculado6);
            }
            else if (vecesSeis == 1)
            {
                porcentajeSeis = (vecesSeis * 100) / totalTiradas;
                resCalculado6 = " 6 --> " + vecesSeis + " vez" + " --> " + porcentajeSeis + "%";
                Console.WriteLine(resCalculado6);
            }
            else
            {
                resCalculado6 = " 6 --> " + vecesSeis + " veces" + " --> " + porcentajeSeis + "%";
                Console.WriteLine(resCalculado6);
            }
        }

        private static void ContarNumeros()
        {
            if (numSacado == 1)
                vecesUno++;
            if (numSacado == 2)
                vecesDos++;
            if (numSacado == 3)
                vecesTres++;
            if (numSacado == 4)
                vecesCuatro++;
            if (numSacado == 5)
                vecesCinco++;
            if (numSacado == 6)
                vecesSeis++;
        }
    }
}
