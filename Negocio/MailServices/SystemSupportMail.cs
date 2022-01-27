using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSI.Negocio.MailServices
{
    class SystemSupportMail: MailServer     //  herencia
    {
        public SystemSupportMail()
        {
            senderMail = "SoporteDirectorioEmpresarial@gmail.com";
            password = "SoporteDirectorio";
            host = "smtp.gmail.com";// name server  smtp.gmail.com
            port = 465;
            ssl = true;
            initializeSmtpClient();

        }
    }
}
