using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guille.PROG_REL7_EJ5_Vera_G
{
    public class Empleado
    {
        private static bool primeraVez = true;
        public const int NMAX_EMPLEADOS = 100;
        public static int nEmpleados = 0;
        public static Empleado[] arrayEmpleados = new Empleado[NMAX_EMPLEADOS];
        private uint _codigo;
        private string _apellidos;
        private string _nombre;
        private DateTime _fechaNacimiento;
        private uint _sueldo;

        #region Propiedades
        public uint Codigo
        {

            get { return _codigo; }
            set
            {
                if (!ComprobarCodigo(value) && !primeraVez)
                    _codigo = value;
                if (primeraVez)
                {
                    _codigo = value;
                    primeraVez = false;
                }
            }
        }

        public static bool ComprobarCodigo(uint codigo)
        {
            bool encontrado = false;
            if (nEmpleados == 0)
            {
                return encontrado;
            }
            else
            {
                for (int i = 0; i < nEmpleados; i++)
                {
                    if (codigo == arrayEmpleados[i].Codigo)
                        encontrado = true;
                }
            }

            return encontrado;
        }

        public string Apellidos
        {
            get { return _apellidos; }
            set
            {
                if (_apellidos != value)
                    _apellidos = value;
            }
        }

        public string Nombre
        {
            get { return _nombre; }
            set
            {
                if (_nombre != value)
                    _nombre = value;
            }
        }

        public DateTime FechaNacimiento
        {
            get { return _fechaNacimiento; }
            set { _fechaNacimiento = value; }
        }

        public uint Sueldo
        {
            get { return _sueldo; }
            set
            {
                if (_sueldo != value && value > 0 && value < uint.MaxValue)
                    _sueldo = value;
                else
                    _sueldo = 0;
            }
        }
        #endregion

        public Empleado()
        {
            this._codigo = 0;
            this._apellidos = string.Empty;
            this._nombre = string.Empty;
            this._fechaNacimiento = DateTime.Now;
            this._sueldo = 0;
        }

        public Empleado(uint codigo, string apellidos, string nombre, DateTime fechaNacimiento, uint sueldo)
        {
            this._codigo = codigo;
            this._apellidos = apellidos;
            this._nombre = nombre;
            this._fechaNacimiento = fechaNacimiento;
            this._sueldo = sueldo;
        }



        public static bool AnadirEmpleado(Empleado empleado)
        {
            if (nEmpleados != NMAX_EMPLEADOS)
            {
                arrayEmpleados[nEmpleados++] = empleado;
                return true;
            }
            else
                return false;
        }
    }
}
