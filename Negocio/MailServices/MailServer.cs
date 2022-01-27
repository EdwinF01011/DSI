using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Mail;//  import
using System.Net;// import
using System.Windows.Forms;

namespace DSI.Negocio.MailServices
{
    public abstract class MailServer
    {
        private SmtpClient smtpClient;
        protected string senderMail { get; set; }// emisor
        protected string password { get; set; }
        protected string host { get; set; }
        protected int port { get; set; }
        protected bool ssl { get; set; }

        protected void initializeSmtpClient()
        {
            smtpClient = new SmtpClient();
            smtpClient.Credentials = new NetworkCredential(senderMail,password);
            smtpClient.Host = host;
            smtpClient.Port = port;
            smtpClient.EnableSsl = ssl;
        }

        public void sendMail(string subject, string body, string recipientMail)
        {
            var mailMessage = new MailMessage();
            try
            {// se indica el mensaje
                mailMessage.From = new MailAddress(senderMail);
                mailMessage.To.Add(recipientMail);// para quién va el correo
                mailMessage.Subject = subject;//    asunto del correo
                mailMessage.Body = body;// el cuerpo
                mailMessage.Priority = MailPriority.Normal;// prioridad del mail

                smtpClient.Send(mailMessage);

            }
            catch (Exception ex)
            {
                //throw;
                MessageBox.Show("MailServer catch " + ex.ToString());
            }
            finally
            {// liberar recursos
                mailMessage.Dispose();
                smtpClient.Dispose();
            }
        }





    }
}
