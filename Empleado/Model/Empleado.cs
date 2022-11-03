using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaEmpleado.Model
{

    public class Empleado
    {
        public Empleado() { }
        public Empleado(int id, string nombre, string apellido)
        {
            Id = id;
            Nombre = nombre;
            Apellido = apellido;
        }

        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        private static int Comision=111;

        public static int comision
        {
            get { return Comision; }
            set { Comision= value; }
        }

    }
}