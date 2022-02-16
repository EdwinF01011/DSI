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
                x.Handled = true;// evita la escritura
                //return;
            }
            return x;
        }
        public KeyPressEventArgs SoloNumeroConsignos(KeyPressEventArgs x)
        {
            if (x.KeyChar >= 33 && x.KeyChar <= 42 // desde el 32 se anula el espaciado
                || x.KeyChar == 47
                || x.KeyChar >= 58 && x.KeyChar <= 255)
            {
                MessageBox.Show("Solo número", "Alerta", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                x.Handled = true;
                //return;
            }
            return x;
        }

        public KeyPressEventArgs SoloLetras(KeyPressEventArgs x)//KeyPressEventArgs
        {
            //segín código Ascii. que permita usar tildes

            //MessageBox.Show(x.KeyChar.ToString());
            //MessageBox.Show(x.KeyValue.ToString());



            if (x.KeyChar >= 33 && x.KeyChar <= 64
                || x.KeyChar >= 91 && x.KeyChar <= 96 ||
                x.KeyChar >= 123 && x.KeyChar <= 129
                || x.KeyChar >= 131
                && x.KeyChar <= 143
                || x.KeyChar >= 145
                && x.KeyChar <= 159
                || x.KeyChar >= 166
                && x.KeyChar <= 180
                || x.KeyChar >= 182
                && x.KeyChar <= 213
                || x.KeyChar >= 215
                && x.KeyChar <= 223//   si se desbloquea el resto: la (Ñ y vocales con acento agudo se bloquearán áéíóú)
                //|| x.KeyChar >= 225
                //&& x.KeyChar <= 238
                //|| x.KeyChar >= 241
                //&& x.KeyChar <= 254
                )
            {
                MessageBox.Show("Solo letras", "Alerta", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                x.Handled = true;
                //return;
            }
            return x;
        }

        public KeyEventArgs SoloLetras2(KeyEventArgs x)//KeyPressEventArgs
        {
            //segín código Ascii. que permita usar tildes

            //MessageBox.Show(x.KeyChar.ToString());
            MessageBox.Show(x.SuppressKeyPress.ToString());


            if (x.KeyValue >= 33 && x.KeyValue <= 64
                || x.KeyValue >= 91 && x.KeyValue <= 96 ||
                x.KeyValue >= 123 && x.KeyValue <= 129
                //|| x.KeyValue >= 131
                //&& x.KeyValue <= 143
                //|| x.KeyValue >= 145
                //&& x.KeyValue <= 159
                //|| x.KeyValue >= 166
                //&& x.KeyValue <= 180
                //|| x.KeyValue >= 182
                //&& x.KeyValue <= 213
                //|| x.KeyValue >= 215
                //&& x.KeyValue <= 223
                //|| x.KeyValue >= 225
                //&& x.KeyValue <= 238
                //|| x.KeyValue >= 240
                //&& x.KeyValue <= 255
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
