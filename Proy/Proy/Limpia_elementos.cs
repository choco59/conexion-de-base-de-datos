using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proy
{
    public class Limpia_elementos
    {
       
        public void BorrarCamposA(Control control)
        {
            foreach (var form in control.Controls)
            {
                if (form is TextBox)
                {
                    ((TextBox)form).Clear();
                }
                else if (form is ComboBox)
                {
                    ((ComboBox)form).SelectedIndex = 0;
                }
            }
        }

        public void BorrarCamposB(GroupBox groupbox)
        {
            foreach (var group in groupbox.Controls)
            {
                if (group is TextBox)
                {
                    ((TextBox)group).Clear();
                }
                else if (group is ComboBox)
                {
                    ((ComboBox)group).SelectedIndex = 0;
                }
            }
        }
        
        public void BorrarCamposC(Control control, GroupBox gb)
        { 
            foreach(var form in control.Controls){
                if (form is TextBox) {
                    ((TextBox)form).Clear();
                }else if(form is ComboBox){
                    ((ComboBox)form).SelectedIndex = 0;
                }
            }
            foreach (var group in gb.Controls)
            {
                if (group is TextBox)
                {
                    ((TextBox)group).Clear();
                }
                else if (group is ComboBox)
                {
                    ((ComboBox)group).SelectedIndex = 0;
                }
            }
           
        }
       

       
    }
}
