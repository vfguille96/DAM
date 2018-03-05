using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// -------------
using System.IO;

namespace PROG_REL8_EJ3_Vera_G
{
	class Program
	{
		static void Main(string[] args)
		{
			string rutaO = args[0];
			string rutaD = args[1];
			string contenido = "";

			StreamReader sr = new StreamReader(rutaO);
			contenido = sr.ReadToEnd();
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
			{
				File.Create(rutaD);
			}
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
