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

        private void FrmLogin_Load(object sender, EventArgs e)
        {
            //this.Size = Screen.PrimaryScreen.WorkingArea.Size;
            //this.Location = Screen.PrimaryScreen.WorkingArea.Location;

            //juagr con la propiedad anchor
        }

        private void btnValidar_Click(object sender, EventArgs e)
        {
            CapturarDatos();
        }

        private void CapturarDatos()
        {
            // Método para validar y dar acceso al usuario
            string usuario = txtUsuario.Text;
            string contraseña = txtContraseña.Text;
            bool busqueda= ObjL.BuscarUsuario(usuario,contraseña);
            if (busqueda == true)
            {
                this.Hide();
                FrmMenu frmM = new FrmMenu();
                frmM.Show();
            }
            else
                lblinfo.Text = "*Credenciales incorrectas*";
        }
    }
}
