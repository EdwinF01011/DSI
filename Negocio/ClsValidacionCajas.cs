using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;//   import

namespace DSI.Negocio
{
    public class ClsValidacionCajas
    {
        public KeyPressEventArgs SoloNumero(KeyPressEventArgs x)
        {
            if (x.KeyChar >= 32 && x.KeyChar <= 47
                ||
                x.KeyChar >= 58 && x.KeyChar <= 255)
            {
                MessageBox.Show("Solo número", "Alerta", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                x.Handled = true;
                //return;
            }
            return x;
        }
        public KeyPressEventArgs SoloNumeroConsignos(KeyPressEventArgs x)
        {
            if (x.KeyChar >= 32 && x.KeyChar <= 43 || x.KeyChar == 47
                || x.KeyChar == 45
                || x.KeyChar >= 58 && x.KeyChar <= 255)
            {
                MessageBox.Show("Solo número", "Alerta", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                x.Handled = true;
                //return;
            }
            return x;
        }

        public KeyPressEventArgs SoloLetras(KeyPressEventArgs x)
        {
            //segín código Ascii. que permita usar tildes 

            if (x.KeyChar >= 33 && x.KeyChar <= 64
                || x.KeyChar >= 91 && x.KeyChar <= 96 ||
                x.KeyChar >= 123 && x.KeyChar <= 129
                || x.KeyChar >= 131
                && x.KeyChar <= 143
                || x.KeyChar >= 145
                && x.KeyChar <= 159
                || x.KeyChar >= 164
                && x.KeyChar <= 180
                || x.KeyChar >= 182
                && x.KeyChar <= 213
                || x.KeyChar >= 215
                && x.KeyChar <= 223
                || x.KeyChar >= 225
                && x.KeyChar <= 238
                || x.KeyChar >= 240
                && x.KeyChar <= 255
                )
            {
                MessageBox.Show("Solo letras", "Alerta", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                x.Handled = true;
                //return;
            }
            return x;
        }
    }
}
