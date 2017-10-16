using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace accesoconfecha
{
    public partial class Form1 : Form
    {
        private string pass;
        public Form1()
        {
            InitializeComponent();
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
       
               
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DateTime hoy = DateTime.Now;
            {
                fecha.Text = hoy.ToString("dd/MM/yy");
                hora.Text = hoy.ToString("hh:mm:ss:tt");
            }
            string usuario;
            string pass;
            
            usuario = nombre.Text;
            pass = password.Text;
            
            while (usuario == null|| pass == null)
            {
                MessageBox.Show("Ingrese datos validos ");
            }
                persona NuevaPersona = new persona(); // inicializamos un objeto en la clase persona
                NuevaPersona.nombre = nombre.Text;// almacenamos la caja de texto en la propiedad nombre de la clase persona en la invocacion NuevaPersona
                NuevaPersona.fecha = fecha.Text;// almacenamos la caja de texto en la propiedad paterno de la clase persona en la invocacion NuevaPersona
                NuevaPersona.hora = hora.Text;// almacenamos la caja de texto en la propiedad materno de la clase persona en la invocacion NuevaPersona
                try//manejador de excepciones
                {
                    string datos = metodo_persona.ObtenerFicha(NuevaPersona); //invocamos nuestro metodo ObtenerFicha de obtener fichas (enviamos parametro de objeto NuevaPersona)
                    MessageBox.Show(datos);//Mostramos la ficha
                }
                catch
                {
                    MessageBox.Show("Error al ejecutar"); //enviamos el error de ejecucion como mensaje
                }
            
            nombre.Text = null;
            fecha.Text = null;
            hora.Text = null;
            password.Text = null;
        }
    }
}
