using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// -------------
using System.IO;

namespace PROG_REL8_EJ3_Vera_G
{
	internal class Program
	{
		private static void Main(string[] args)
		{
			if (args.Length != 3)
			{
				Console.Clear();
				Console.WriteLine("=====================================================");
				Console.WriteLine("  ERROR: EL NUMERO DE ARGUMENTOS DEBE SER IGUAL A 3.");
				Console.WriteLine("=====================================================");
				Console.ReadLine();
				return;
			}

			string rutaO = args[0];
			string rutaD = args[1];
			string caracter = args[2];
			string contenido = "";
			char tmp;

			StreamReader sr = new StreamReader(rutaO);

			do
			{
				tmp = (char)sr.Read();
				if (tmp != char.Parse(caracter))
					contenido += tmp;
			} while (!sr.EndOfStream || tmp != char.Parse(caracter));

			if (contenido == string.Empty)
			{
				Console.WriteLine("========================================================================================");
				Console.WriteLine(" El fichero está vacío.");
				Console.WriteLine("========================================================================================");
				Console.ReadLine();
				sr.Dispose();
				return;
			}

			StreamWriter sw = new StreamWriter(rutaD);

			if (!File.Exists(rutaD))
				File.Create(rutaD);

			sw.Write(contenido);
			sr.Dispose();
			sw.Dispose();
			Console.WriteLine("========================================================================================");
			Console.WriteLine(" Contenido copiado exitosamente a la ruta \"{0}\"", rutaD);
			Console.WriteLine("========================================================================================");

			Console.ReadLine();
		}
	}
}