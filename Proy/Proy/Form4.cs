using Proy.usuario;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proy
{
    public partial class Form4 : Form
    {
       
        public Form4()
        {
            InitializeComponent();
            
            
            

           
                    
            
        }

        private void button3_Click(object sender, EventArgs e)
        {

            Form3 form_busqueda = new Form3();
            form_busqueda.Show();
            this.Close();
            
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            /*
            comboBox1.DataSource = Usuario_insertar_SQL.ObtenerPrivilegio();
            comboBox1.DisplayMember = "des_privilegio";
            comboBox1.ValueMember = "id_privilegio";
             * */
        }

        
    }
}
