using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
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
                goEmail();
            }
            else
            {
                CapturarDatos();
            }
        }



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
            //lblTitle.Location = new Point(186, 28);



        }
    }
}
