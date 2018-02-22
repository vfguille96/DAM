using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace App_CambiarFechaCreacion_Modificacion
{
	class Program
	{
		static void Main(string[] args)
		{
			DateTime fechaNueva = DateTime.Parse("30-01-1996");
			DateTime fechaModificacion = DateTime.Parse("30-01-2019");

			string ruta = @"D:\alumno1718\Escritorio\pruebaCopia\vacia\archivo_del_futuro.txt";
			File.SetCreationTimeUtc(ruta, fechaNueva);
			File.SetLastWriteTimeUtc(ruta, fechaModificacion);
		}
	}
}
