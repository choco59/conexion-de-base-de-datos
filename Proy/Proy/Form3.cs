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
    public partial class Form3 : Form
    {
        
        public Form3()
        {
            InitializeComponent();
            
        }

        
        private void Form3_Load(object sender, EventArgs e)
        {
            data_mostrar_usuario.DataSource = Usuario_insertar_SQL.MostrarUsuario();
            data_mostrar_usuario.Columns["id_privilegio"].Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            try
            {

                
                data_mostrar_usuario.DataSource = Usuario_insertar_SQL.BuscarUsuario((Convert.ToInt32(txb_idusuario.Text)), txb_usuario.Text);
                data_mostrar_usuario.Columns["id_privilegio"].Visible = false;
                
            }
            catch {
                MessageBox.Show("Revise los parametros de busqueda, no existe el registro especificado");
            }
      

        
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Limpia_elementos limpieza = new Limpia_elementos();
            limpieza.BorrarCamposB(groupBox1);
            data_mostrar_usuario.DataSource = Usuario_insertar_SQL.MostrarUsuario();
            data_mostrar_usuario.Columns["id_privilegio"].Visible = false;
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if(data_mostrar_usuario.SelectedRows.Count == 1){
                int id = Convert.ToInt32(data_mostrar_usuario.CurrentRow.Cells["id_usuario"].Value);
                Form4 form_edt = new Form4();
                data_mostrar_usuario.DataSource = Usuario_insertar_SQL.ObtenerUsuario(id);
                form_edt.txtuser.Text = Convert.ToString(data_mostrar_usuario.CurrentRow.Cells["usuario"].Value);
                form_edt.txtfecha.Text = Convert.ToString(data_mostrar_usuario.CurrentRow.Cells["fecha_creacion"].Value);
                form_edt.txtpri.Text = Convert.ToString(data_mostrar_usuario.CurrentRow.Cells["des_privilegio"].Value);
                form_edt.comboBox1.DisplayMember = Convert.ToString(data_mostrar_usuario.CurrentRow.Cells["des_privilegio"].Value);
                form_edt.comboBox1.ValueMember = Convert.ToString(data_mostrar_usuario.CurrentRow.Cells["id_privilegio"].Value);
                form_edt.Show();
                this.Close();
            }else{
                MessageBox.Show("Debe seleccionar una fila");
            }
        }

        private void data_mostrar_usuario_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
       
       
    }
}
