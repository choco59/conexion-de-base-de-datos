using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace conexion_de_base_de_datos
{
    public partial class Form1 : Form
    {
        MySqlConnection conexion = new MySqlConnection();
        String variableconexion;
        public Form1()
        {
            InitializeComponent();
            iniciarconexion();
        }
        private void iniciarconexion(){
           try {
               variableconexion = ("server= 127.0.0.1; database=prueba; user=root;pwd=;");
               conexion.ConnectionString = variableconexion;
               conexion.Open();
               MessageBox.Show("la conexion se ha realizado con exito");
           }catch (MySqlException ex){
           MessageBox.Show ("la conexion ha fallado, el error es " + ex);
           }

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
