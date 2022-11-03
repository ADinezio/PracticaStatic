using LibreriaEmpleado.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsPracticaStatic
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnEmpleados_Click(object sender, EventArgs e)
        {
            
            Empleado empleado1 = new Empleado() { Nombre="Juan", Apellido="Pepe", Id=12};
            Empleado empleado2 = new Empleado() { Nombre = "Carlos", Apellido = "Quito", Id = 15 };
            MessageBox.Show($"Nombre : {empleado1.Nombre}\nApellido : {empleado1.Apellido}\nId : {empleado1.Id}\nComision : {Empleado.comision}");
            MessageBox.Show($"Nombre : {empleado2.Nombre}\nApellido : {empleado2.Apellido}\nId : {empleado2.Id}\nComision : {Empleado.comision}");

            Empleado.comision = 2223;

            Empleado empleado3 = new Empleado() { Nombre = "Agustin", Apellido = "Loto", Id = 33 };
            Empleado empleado4 = new Empleado() { Nombre = "Grillo", Apellido = "Pepe", Id = 20 };
            MessageBox.Show($"Nombre : {empleado3.Nombre}\nApellido : {empleado3.Apellido}\nId : {empleado3.Id}\nComision : {Empleado.comision}");
            MessageBox.Show($"Nombre : {empleado4.Nombre}\nApellido : {empleado4.Apellido}\nId : {empleado4.Id}\nComision : {Empleado.comision}");
        }
    }
}
