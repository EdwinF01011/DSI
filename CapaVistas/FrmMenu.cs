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
    public partial class FrmMenu : Form
    {
        public FrmMenu()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void accesosRol()//  bloque accesos según el rol
        {
            lblPrueba.Text = ClsUsuario.rolUsuario.ToString();
            if (ClsUsuario.rolUsuario == 1)
            {
                btnBackup.Visible = false;
                btnUbicaciones.Visible = false;
                btnSectores.Visible = false;
            }
        }

        private void FrmMenu_Load(object sender, EventArgs e)
        {
            Nombre_Usuario();
            accesosRol();
            panelMenu.Visible = false;
            btnClosed.Visible = false;
        }

        private void Nombre_Usuario()
        {
            lblUsuarioname.Text = ClsUsuario.nameUsuario;
        }

        private void btnClientesGo_Click(object sender, EventArgs e)
        {
            ClsUsuario.number_categoria = false;
            this.Hide();
            FrmBusqueda fmB = new FrmBusqueda();
            fmB.Show();
            ClsUsuario.categoria_busqueda = "Clientes";
            fmB.Busqueda_tipo_label("Clientes");
        }

        private void btnProveedorsGo_Click(object sender, EventArgs e)
        {
            ClsUsuario.number_categoria = true;
            this.Hide();
            FrmBusqueda fmB = new FrmBusqueda();
            fmB.Show();
            ClsUsuario.categoria_busqueda = "Proveedores";
            fmB.Busqueda_tipo_label("Proveedores");
        }

        private void btnUbicaciones_Click(object sender, EventArgs e)
        {
            FrmUbicación frmU = new FrmUbicación();
            frmU.Show();
        }

        private void btnSectores_Click(object sender, EventArgs e)
        {
            FrmSector frmstr = new FrmSector();
            frmstr.Show();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
            FrmLogin frmLogin = new FrmLogin();
            frmLogin.Show();
        }

        private void btnConfigurar_Click(object sender, EventArgs e)
        {
            //this.Hide();
            //FrmConfiguration _Confi = new FrmConfiguration();
            //_Confi.Show();
            btnClosed.Visible = true;
            traerFrmConfi();
        }

        FrmConfiguration _confi = new FrmConfiguration();
        private void traerFrmConfi()
        {
            panelMenu.Visible = true;

            _confi = new FrmConfiguration();
            _confi.TopLevel = false;
            panelMenu.Controls.Add(_confi);
            _confi.Show();

        }

        public void ClosePanel()
        {
            if(panelMenu.Visible==true)
            {
                panelMenu.Visible = false;
            }
        }

        private void btnClosed_Click(object sender, EventArgs e)
        {
            ClosePanel();
            btnClosed.Visible = false;

        }
    }
}
