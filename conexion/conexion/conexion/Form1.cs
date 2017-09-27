using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using conexion.mysql;

namespace conexion
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            conecting.obtenerconexion();
            MessageBox.Show("la conexion se realizo con exito");
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            alumno agregar = new alumno();
            agregar.nombre = txt1.Text;
            agregar.apellido = txt2.Text;
            agregar.matricula = txt3.Text;
            int retorno = funciones.agregar(agregar);
            if (retorno > 0)
            {
                MessageBox.Show("si se agrego");
            }
            else {
                MessageBox.Show("no se agrego");
            }
        }
    }
}
