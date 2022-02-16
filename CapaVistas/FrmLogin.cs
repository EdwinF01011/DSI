using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Net.Security;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DSI.Negocio;

namespace DSI.CapaVistas
{
    public partial class FrmLogin : Form
    {
        ClsLogin ObjL = new ClsLogin();
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void bunifuCustomLabel1_Click(object sender, EventArgs e)
        {

        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {
            linkLabel1.Enabled = false;
            btnVolver.Visible = false;
            foreach (Form frm in Application.OpenForms)//   itera los forms abiertos y los esconde
            {
                if (frm != this)
                {
                    frm.Hide();//    no se pudo usar el Close o Dispose ()
                }
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }


        private void CapturarDatos()
        {
            // Método para validar y dar acceso al usuario
            string usuario = txtUsuario.Text.Trim();
            string contraseña = txtContraseña.Text.Trim();
            bool busqueda= ObjL.BuscarUsuario(usuario,contraseña);
            if (busqueda == true)
            {
                if (ClsUsuario.estado == false)
                {
                    this.Hide();
                    FrmMenu frmM = new FrmMenu();
                    frmM.Show();
                }
                else
                {
                    MessageBox.Show("No tiene acceso al programa");
                }
            }
            else
            {
                linkLabel1.Enabled = true;
                lblinfo.Text = "*Credenciales incorrectas*";
            }
        }

        private void btnValidar_Click_1(object sender, EventArgs e)
        {
            if (btnValidar.Text == "Enviar")
            {
                //ObjL.enviarCorreo2();
                //goEmail();
                ObjL.recoverPassword2(txtUsuario.Text);
            }
            else
            {
                CapturarDatos();
            }
        }

        public void enviarCorreo2()// ref:hhttps://www.kyocode.com/2019/08/como-enviar-correo-con-c/#:~:text=La%20forma%20de%20como%20enviar,ser%20utilizado%20por%20otras%20aplicaciones.
        {
            MailMessage correo = new MailMessage();
            correo.From = new MailAddress("SoporteDirectorioEmpresarial@gmail.com", "DIRECTORIO XD", System.Text.Encoding.UTF8);//Correo de salida
            correo.To.Add("carobles24@misena.edu.co"); //Correo destino?/*efortega62@misena.edu.co*/
            correo.Subject = "Correo de prueba"; //Asunto
            correo.Body = "Este es un correo de prueba desde c# Camilo Robles"; //Mensaje del correo
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

        //public void enviarCorreo2()// ref:hhttps://www.kyocode.com/2019/08/como-enviar-correo-con-c/#:~:text=La%20forma%20de%20como%20enviar,ser%20utilizado%20por%20otras%20aplicaciones.
        //{
        //    MailMessage correo = new MailMessage();
        //    correo.From = new MailAddress("SoporteDirectorioEmpresarial@gmail.com", "DIRECTORIO XD", System.Text.Encoding.UTF8);//Correo de salida
        //    correo.To.Add("carobles24@misena.edu.co"); //Correo destino?/*efortega62@misena.edu.co*/
        //    correo.Subject = "Correo de prueba"; //Asunto
        //    correo.Body = "Este es un correo de prueba desde c# Camilo Robles"; //Mensaje del correo
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

        private void txtContraseña_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar==13)// si es == al Enter: --> 
            {
                CapturarDatos();
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            lblTitle.Location = new Point(74, 15);
            lblContraseña.Visible = false;
            txtContraseña.Visible = false;
            lblTitle.Text = "Recuperación";
            lblUser.Text = "Digite su Usuario ó Correo eléctrónico";
            btnValidar.Text = "Enviar";
            btnVolver.Visible = true;
            linkLabel1.Visible = false;
        }

        private void goEmail()
        {
            ObjL.recoverPassword(txtUsuario.Text);
        }

        private void panel3_Click(object sender, EventArgs e)
        {
            lblinfo.Text = "-";
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            btnVolver.Visible = false;
            linkLabel1.Visible = true;
            lblTitle.Text = "Ingresar";
            lblContraseña.Visible = true;
            txtContraseña.Visible = true;
            lblUser.Text = "Usuario";
            btnValidar.Text = "Validar";
            txtUsuario.Text = "";
            txtContraseña.Text = "";
            //lblTitle.Location = new Point(186, 28);



        }
    }
}
