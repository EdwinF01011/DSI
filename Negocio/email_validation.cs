using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSI.Negocio
{
    public class email_validation
    {
        public static bool isvalideEmail(string email)
        {
            char Dot = '#';
            try
            {
                string dot = email;
                var addr = new System.Net.Mail.MailAddress(email);
                for (int i = 0; i < dot.Length; i++)
                {
                    if (dot[i].ToString() == ".")
                    {
                        Dot = dot[i];
                    }
                }
                if (addr.Address == email && Dot == '.')
                {
                    return addr.Address == email;
                }
                else
                    return false;
            }
            catch
            {
                return false;
            }

        }
    }
}
