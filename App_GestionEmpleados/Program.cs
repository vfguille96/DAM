using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// --------------------------
using Guille.PROG_REL7_EJ5_Vera_G;
using System.Collections;
using System.Threading;
using System.Globalization;

namespace Guille.PROG_REL7_EJ5_Vera_G
{
	class Program
	{

		static void Main(string[] args)
		{
			Menu();

			Console.ReadLine();
		}

		private static void Menu()
		{
			ConsoleKeyInfo tecla;

			Console.Clear();
			Console.WriteLine("\n    GESTION DE EMPLEADOS     {0}/{1}", Empleado.nEmpleados, Empleado.NMAX_EMPLEADOS);
			Console.WriteLine("========================================");
			Console.WriteLine("\t 1- Añadir");
			Console.WriteLine("\t 2- Buscar");
			Console.WriteLine("\t 3- Ver");
			Console.WriteLine("\t 4- Listar");
			Console.WriteLine("\t 5- Borrar");
			Console.WriteLine("\n\t 0- Salir");
			Console.Write("\n\t -Elige una opción: ");
			tecla = Console.ReadKey();
			switch (tecla.KeyChar)
			{
				case '1':
					Console.Clear();
					Console.WriteLine("           AÑADIR");
					Console.WriteLine("=============================");
					if (!Empleado.AnadirEmpleado(UnoAnadir()))
						ErrorParametros();
					Menu();
					break;
				case '2':
					Console.Clear();
					Console.WriteLine("           BUSCAR");
					Console.WriteLine("=============================");
					Console.Write(" -Introduce el código de la persona: ");
					try
					{
						uint codigo = uint.Parse(Console.ReadLine());
						if (BuscarEmpleado(codigo) == 0)
						{
							Console.Clear();
							Console.WriteLine("\n NO SE HA ENCONTRADO A LA PERSONA.");
							Console.ReadLine();
							Menu();
						}
						if (BuscarEmpleado(codigo) == 1)
							VerEmpleado(BuscarEmpleado(codigo) - 1); // Ver persona de este int devuelto.
						if (BuscarEmpleado(codigo) > 1)
						{
							VerEmpleado(BuscarEmpleado(codigo));
						}
					}
					catch (Exception)
					{
						ErrorParametros();
					}
					Console.ReadLine();
					Menu();
					break;
				case '3':
					Console.Clear();
					Console.WriteLine("             VER");
					Console.WriteLine("=============================");
					VerEmpleado();
					Console.ReadLine();
					Menu();
					break;
				case '4':
					Console.Clear();
					Console.WriteLine("           LISTAR");
					Console.WriteLine("=============================");
					Listar(Empleado.arrayEmpleados);
					Console.ReadLine();
					Menu();
					break;
				case '5':
					Console.Clear();
					Console.WriteLine("           BORRAR");
					Console.WriteLine("=============================");
					Console.Write(" -Introduce el código de la persona a borrar: ");
					try
					{
						uint codigoBorrar = uint.Parse(Console.ReadLine());
						BorrarEmpleado(codigoBorrar);
					}
					catch (Exception)
					{

						ErrorParametros();
					}
					Console.ReadLine();
					Menu();
					break;
				case '0':
					Console.Clear();
					Console.Write(" Saliendo");
					Thread.Sleep(300);
					Console.Write(".");
					Thread.Sleep(200);
					Console.Write(".");
					Thread.Sleep(200);
					Console.Write(".");
					Environment.Exit(0);
					break;
				default:
					Menu();
					break;
			}
		}
		private static Empleado UnoAnadir()
		{
			uint preCodigo = 0;
			Empleado e1 = new Empleado();

			try
			{
				Console.Write("              -Código: ");
				preCodigo = uint.Parse(Console.ReadLine());
				if (Empleado.ComprobarCodigo(preCodigo) || preCodigo == 0)
					ErrorParametros(preCodigo);
				e1.Codigo = preCodigo;
				Console.Write("              -Nombre: ");
				e1.Nombre = Console.ReadLine();
				Console.Write("           -Apellidos: ");
				e1.Apellidos = Console.ReadLine();
				Console.Write(" -Fecha de Nacimiento: ");
				e1.FechaNacimiento = DateTime.Parse(Console.ReadLine());
				Console.Write("              -Sueldo: ");
				e1.Sueldo = uint.Parse(Console.ReadLine());
			}
			catch (Exception)
			{
				ErrorParametros();
			}

			return e1;
		}

		private static int BuscarEmpleado(uint codigo)
		{
			for (int i = 0; i < Empleado.nEmpleados; i++)
			{
				if (codigo == Empleado.arrayEmpleados[i].Codigo)
				{
					if (i == 0)
						return (i + 1);
					else
						return i;
				}
			}
			return 0;
		}

		private static void VerEmpleado(int posicion)
		{
			Console.Write("\n              -Código: " + Empleado.arrayEmpleados[posicion].Codigo.ToString());
			Console.Write("\n              -Nombre: " + Empleado.arrayEmpleados[posicion].Nombre);
			Console.Write("\n           -Apellidos: " + Empleado.arrayEmpleados[posicion].Apellidos);
			Console.Write("\n -Fecha de Nacimiento: " + Empleado.arrayEmpleados[posicion].FechaNacimiento.ToShortDateString());
			Console.Write("\n              -Sueldo: {0:C}", Empleado.arrayEmpleados[posicion].Sueldo);
		}

		private static void VerEmpleado()
		{
			if (Empleado.nEmpleados != 0)
			{
				for (int posicion = 0; posicion < Empleado.nEmpleados; posicion++)
				{
					Console.WriteLine("\n========================================================");
					Console.WriteLine("          PERSONA Nº {0}", posicion + 1);
					Console.WriteLine("========================================================");
					Console.WriteLine("              -Código: " + Empleado.arrayEmpleados[posicion].Codigo.ToString());
					Console.WriteLine("              -Nombre: " + Empleado.arrayEmpleados[posicion].Nombre);
					Console.WriteLine("           -Apellidos: " + Empleado.arrayEmpleados[posicion].Apellidos);
					Console.WriteLine(" -Fecha de Nacimiento: " + Empleado.arrayEmpleados[posicion].FechaNacimiento.ToShortDateString());
					Console.WriteLine("              -Sueldo: {0:C}", Empleado.arrayEmpleados[posicion].Sueldo);
					Console.WriteLine("========================================================");
				}

				Console.WriteLine("\n\n FIN DEL LISTADO.");
			}
			else
			{
				Console.WriteLine("\n\n No hay empleados guardados.");
			}
		}

		private static void BorrarEmpleado(uint codigo)
		{
			int codPersonaABorrar = -1;
			int indiceCopia = 0;
			Empleado[] arrayEmpleadosCopia = new Empleado[Empleado.nEmpleados];

			for (int i = 0; i < Empleado.nEmpleados; i++)
			{
				if (codigo == Empleado.arrayEmpleados[i].Codigo)

					codPersonaABorrar = i;
			}

			if (codPersonaABorrar == -1)
			{
				Console.WriteLine("\n\n NO SE HA ENCONTRADO UNA PERSONA A BORRAR.");
			}
			else
			{
				for (int i = 0; i < Empleado.nEmpleados; i++)
				{
					if (i == codPersonaABorrar)
						i++;
					else
						arrayEmpleadosCopia[indiceCopia++] = Empleado.arrayEmpleados[i];
				}

				for (int i = 0; i < indiceCopia; i++)
				{
					Empleado.arrayEmpleados[i] = arrayEmpleadosCopia[i];
				}
				Empleado.nEmpleados = indiceCopia;
				Console.WriteLine("\n Se ha borrado la persona: {0}", codigo);
			}
		}

		private static void Listar(Empleado[] a)
		{
			if (Empleado.nEmpleados == 0)
				Console.Write("\n La lista de Perosnas está vacía.");
			else
			{
				Console.SetWindowSize(120, 34);
				Console.WriteLine("\n Codigo\t Nombre\t\t\tApellidos\t\t  Sueldo\t Fecha Nacimiento");
				Console.WriteLine(" --------------------------------------------------------------------------------------------");
				for (int i = 0; i < Empleado.nEmpleados; i++)
					Console.WriteLine(" {0,3}\t {1}\t\t{2}\t\t  {3:C}\t\t {4}", ((a[i].Codigo).ToString()).PadRight(3, ' '), ((a[i].Nombre).ToString()).PadRight(12, ' '), ((a[i].Apellidos).ToString()).PadRight(12, ' '), ((a[i].Sueldo).ToString()).PadRight(5, ' '), a[i].FechaNacimiento.ToShortDateString());

				Console.WriteLine("\n\n Fin del listado...");
			}
		}

		private static void ErrorParametros()
		{
			Console.Clear();
			Console.WriteLine("\n ERROR: PARAMETROS INCORRECTOS");
			Console.ReadLine();
			Menu();
		}

		private static void ErrorParametros(uint preCodigo)
		{
			Console.Clear();
			Console.WriteLine("\n ERROR: PARAMETROS INCORRECTOS.\n\n EL CODIGO DEBE SER MAYOR QUE 0.");
			Console.ReadLine();
			Menu();
		}
	}
}
