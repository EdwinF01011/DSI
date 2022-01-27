using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DSI.Negocio
{
    public  class ClsEncrytp
    {
        public static string GetSHA256(string str)
        {
            // se importó el siguiente código.
            /*ohttps://hdeleon.net/funcion-para-encriptar-en-sha256-en-c-net/ */
            SHA256 sha256 = SHA256Managed.Create();
            ASCIIEncoding encoding = new ASCIIEncoding();
            byte[] stream = null;
            StringBuilder sb = new StringBuilder();
            stream = sha256.ComputeHash(encoding.GetBytes(str));
            for (int i = 0; i < stream.Length; i++) sb.AppendFormat("{0:x2}", stream[i]);
            return sb.ToString();
        }

        public static string randomGenerator()
        {
            var characters = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
            var charsarr = new char[8];
            var randal = new Random();
            for(int i=0; i<charsarr.Length; i++)
            {
                charsarr[i] = characters[randal.Next(characters.Length)];
            }
            var resultString = new String(charsarr);
            //MessageBox.Show(resultString);
            return resultString;
        }
    }
}
