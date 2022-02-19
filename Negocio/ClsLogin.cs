using DSI.Datos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;// import
using System.Net.Mail;//    import
using System.Net.Security;
using System.Net.Configuration;
using System.Security.Cryptography.X509Certificates;

namespace DSI.Negocio
{
    public class ClsLogin
    {
        ClsUsuario _usuario = new ClsUsuario();
        public bool BuscarUsuario(string usuario, string pass)
        {
            // 8C6976E5B5410415BDE908BD4DEE15DFB167A9C873FC4BB8A81F6F2AB448A918
            string passE = ClsEncrytp.GetSHA256(pass);
            using (DSIEntities1 BD = new DSIEntities1())
            {
                //VALIDA LAS CREDENCIALES
                var busqueda = (from l in BD.Usuarios
                                where l.CC == usuario && l.pass == passE
                                select l).FirstOrDefault();
                if (busqueda != null)
                {
                    //PARA OBTENER EL NOMBRE DEL USUARIO y ROL
                    ClsUsuario.nameUsuario = busqueda.Nombre;
                    ClsUsuario.idUsuario = busqueda.id;
                    ClsUsuario.estado = bool.Parse(busqueda.id_Estado.ToString());
                    bool x = busqueda.id_Rol;
                    if (x == false)
                    {
                        ClsUsuario.rolUsuario = 0;
                    }
                    else
                        ClsUsuario.rolUsuario = 1;

                    return true;
                }
                else
                    return false;
            }
        }

        public string recoverPassword(string userRequesting)
        {

            using (DSIEntities1 BD = new DSIEntities1())
            {
                var requestUser = (from l in BD.Usuarios
                                   where l.CC == userRequesting || l.Email == userRequesting
                                   select l).FirstOrDefault();
                if (requestUser != null)
                {
                    MessageBox.Show("no es nulo");
                    string userName = requestUser.Nombre;
                    string userCC = requestUser.CC;
                    //string userMail = requestUser.Email;  //                     usar este <<<
                    string userMail = "efortega62@misena.edu.co";

                    string newPass = ClsEncrytp.randomGenerator();

                    var mailService = new MailServices.SystemSupportMail();
                    mailService.sendMail(
                        subject: "Solicitud de recuperación de contraseña",
                        body: "Hola! " + userName + " \n su solicitud de recuperación de contraseña ha sido todo un éxito! (ﾉ◕ヮ◕)ﾉ*:･ﾟ " + "\n" +
                        "Usuario " + userCC + ", Una vez inicie sesión, por favor modifique esta contraseña: " + newPass,
                        recipientMail: userMail);
                    return "Solicitud de recuperación de contraseña procesado" +
                        "Hola! " + userName + " \n su solicitud de recuperación de contraseña ha sido todo un éxito! (ﾉ◕ヮ◕)ﾉ*:･ﾟ " + "\n" +
                        "Usuario " + userCC + ", inicie sesión en su correo " + userMail + " y por favor cambie la contraseña";
                }
                else
                {
                    MessageBox.Show("es nulo");

                    return "algo salió mal con el proceso de recuperación de contraseña, por favor rectifique su Usuaio ó Correo Electrónico \n " +
                        "Gracias.";
                }
            }


            //link continuar... -https://www.youtube.com/watch?v=ER3BD8pG-3k 

        }

        public void emailEnvia(string name,string user, string mail, string pass,string rol)
        {
            //crear mensaje  email
            MailMessage correo = new MailMessage();//"carobles24@misena.edu.co"
            correo.From = new MailAddress("SoporteDirectorioEmpresarial@gmail.com", "DIRECTORIO XD", System.Text.Encoding.UTF8);//Correo de salida
            correo.To.Add(mail); //Correo destino?/*efortega62@misena.edu.co*/
            correo.Subject = "Creación de usuario"; //Asunto
            correo.Body = "Saludos " + name + ", ha sido creado su usario ("+user+"), rol ("+rol+").\n  contraseña es: " + pass; //Mensaje del correo
            correo.IsBodyHtml = true;
            correo.Priority = MailPriority.Normal;
            SmtpClient smtp = new SmtpClient();
            smtp.UseDefaultCredentials = false;
            smtp.Host = "smtp.gmail.com"; //Host del servidor de correo
            smtp.Port = 587; //Puerto de salida
            smtp.Credentials = new System.Net.NetworkCredential("SoporteDirectorioEmpresarial@gmail.com", "SoporteDirectorio");//Cuenta de correo
            ServicePointManager.ServerCertificateValidationCallback = delegate (object s, X509Certificate certificate, X509Chain chain, SslPolicyErrors sslPolicyErrors) { return true; };
            smtp.EnableSsl = true;//True si el servidor de correo permite ssl
            try
            {
                smtp.Send(correo);
            }
            catch (Exception ex)
            {
                MessageBox.Show("error en catch del método enviarCorreo2() " + ex.ToString());
                //throw;
            }
        }

        public bool recoverPassword2(string userRequesting)
        {

            using (DSIEntities1 BD = new DSIEntities1())
            {
                var requestUser = (from l in BD.Usuarios
                                   where l.CC == userRequesting || l.Email == userRequesting
                                   select l).FirstOrDefault();
                if (requestUser != null)
                {
                    //generar contraseña
                    string randomContraseña=ClsEncrytp.randomGenerator();
                    //encriptar
                    string contraseña = ClsEncrytp.GetSHA256(randomContraseña);


                    //crear mensaje  email
                    MailMessage correo = new MailMessage();//"carobles24@misena.edu.co"
                    correo.From = new MailAddress("SoporteDirectorioEmpresarial@gmail.com", "DIRECTORIO XD", System.Text.Encoding.UTF8);//Correo de salida
                    correo.To.Add(requestUser.Email); //Correo destino?/*efortega62@misena.edu.co*/
                    correo.Subject = "Recuperación de CONTRASEÑA!!!!"; //Asunto
                    correo.Body = "Saludos"+ requestUser.Nombre.ToString()+ ", usted solicitó la recuperación de contraseña \n su nueva contraseña es: "+randomContraseña ; //Mensaje del correo
                    correo.IsBodyHtml = true;
                    correo.Priority = MailPriority.Normal;
                    SmtpClient smtp = new SmtpClient();
                    smtp.UseDefaultCredentials = false;
                    smtp.Host = "smtp.gmail.com"; //Host del servidor de correo
                    smtp.Port = 587; //Puerto de salida
                    smtp.Credentials = new System.Net.NetworkCredential("SoporteDirectorioEmpresarial@gmail.com", "SoporteDirectorio");//Cuenta de correo
                    ServicePointManager.ServerCertificateValidationCallback = delegate (object s, X509Certificate certificate, X509Chain chain, SslPolicyErrors sslPolicyErrors) { return true; };
                    smtp.EnableSsl = true;//True si el servidor de correo permite ssl
                    try
                    {
                        _usuario.updateUsuarioIIIContra(requestUser.id, contraseña);
                        smtp.Send(correo);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("error en catch del método enviarCorreo2() " + ex.ToString());
                        //throw;
                    }
                    return true;
                    
                }
                else
                {
                    return false;

                    //MessageBox.Show("es nulo");

                    //return "algo salió mal con el proceso de recuperación de contraseña, por favor rectifique su Usuaio ó Correo Electrónico \n " +
                        //"Gracias.";
                }
            }
            //<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<

            string texto = "Lorem ipsum dolor sit amet. Non omnis repellat harum similique et reiciendis vero sed asperiores obcaecati sit provident adipisci. ";

            //private SmtpClient smtpClient;

            //public void enviarCorreo()
            //{
            //    var mmsg = new MailMessage();
            //    mmsg.To.Add("efortega62@misena.edu.co");
            //    mmsg.Subject = "Envío del Email desde Visual Studio";
            //    mmsg.SubjectEncoding = System.Text.Encoding.UTF8;
            //    //mmsg.Bcc.Add("otroCorreo@gmail.com");
            //    mmsg.Body = texto;

            //    mmsg.BodyEncoding = System.Text.Encoding.UTF8;

            //    mmsg.IsBodyHtml = true;
            //    mmsg.From = new MailAddress("SoporteDirectorioEmpresarial@gmail.com");

            //    SmtpClient smtpClient = new SmtpClient();

            //    smtpClient.Credentials = new NetworkCredential("SoporteDirectorioEmpresarial@gmail.com", "SoporteDirectorio");
            //    //smtpClient.Credentials = new ("SoporteDirectorioEmpresarial@gmail.com", "SoporteDirectorio");

            //    smtpClient.Port = 465;// 587 25 465
            //    smtpClient.EnableSsl = true;//
            //    smtpClient.Host = "smtp.gmail.com";

            //    try
            //    {
            //        //smtpClient.Send(mmsg);
            //        smtpClient.Send(mmsg);
            //    }
            //    catch (Exception ex)
            //    {
            //        MessageBox.Show("error en catch del método enviarCorreo() " + ex.ToString());
            //        //throw;
            //    }
            //}

            //public void enviarCorreo2()// ref:hhttps://www.kyocode.com/2019/08/como-enviar-correo-con-c/#:~:text=La%20forma%20de%20como%20enviar,ser%20utilizado%20por%20otras%20aplicaciones.
            //{
            //    MailMessage correo = new MailMessage();
            //    correo.From = new MailAddress("SoporteDirectorioEmpresarial@gmail.com", "DIRECTORIO XD", System.Text.Encoding.UTF8);//Correo de salida
            //    correo.To.Add("efortega62@misena.edu.co"); //Correo destino?
            //    correo.Subject = "Correo de prueba"; //Asunto
            //    correo.Body = "Este es un correo de prueba desde c#"; //Mensaje del correo
            //    correo.IsBodyHtml = true;
            //    correo.Priority = MailPriority.Normal;
            //    SmtpClient smtp = new SmtpClient();
            //    smtp.UseDefaultCredentials = false;
            //    smtp.Host = "smtp.gmail.com"; //Host del servidor de correo
            //    smtp.Port = 587; //Puerto de salida
            //    smtp.Credentials = new System.Net.NetworkCredential("SoporteDirectorioEmpresarial@gmail.com", "SoporteDirectorio");//Cuenta de correo
            //    ServicePointManager.ServerCertificateValidationCallback = delegate (object s, X509Certificate certificate, X509Chain chain, SslPolicyErrors sslPolicyErrors) { return true; };
            //    smtp.EnableSsl = true;//True si el servidor de correo permite ssl
            //    try
            //    {
            //        smtp.Send(correo);
            //    }
            //    catch (Exception ex)
            //    {
            //        MessageBox.Show("error en catch del método enviarCorreo2() " + ex.ToString());
            //        //throw;
            //    }
            //}




        }

    }

}
