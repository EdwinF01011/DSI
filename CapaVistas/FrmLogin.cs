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
                lblinfo.Text = "*Credenciales incorrectas*";
        }

        private void btnValidar_Click_1(object sender, EventArgs e)
        {
            CapturarDatos();
        }



        private void txtContraseña_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar==13)// si es == al Enter: --> 
            {
                CapturarDatos();
            }
        }
    }
}
