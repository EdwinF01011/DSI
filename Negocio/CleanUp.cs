using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace DSI.Negocio
{
    static class CleanUp
    {
        public static void limpiarCajas(Control control, GroupBox Gb)//  limpia el contenido de un textBox & reubicar el ComboBox
        {
            foreach (var txt in control.Controls)
            {
                if (txt is TextBox)
                {
                    ((TextBox)txt).Clear();
                }
                else if (txt is ComboBox)
                {
                    ((ComboBox)txt).SelectedIndex = 0;
                }
            }

            foreach (var gb in Gb.Controls)
            {
                if(gb is TextBox)
                {
                    ((TextBox)gb).Clear();
                }
                else if (gb is ComboBox)
                {
                    ((ComboBox)gb).SelectedIndex = 0;
                }
            }


        }

    }
}
