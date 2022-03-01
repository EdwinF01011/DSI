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
        FrmConfiguration _confi = new FrmConfiguration();
        FrmBusqueda _busqueda = new FrmBusqueda();

        public FrmMenu()
        {
            InitializeComponent();
        }

        private void accesosRol()//  bloque accesos según el rol
        {
            //lblPrueba.Text = ClsUsuario.rolUsuario.ToString();
            if (ClsUsuario.rolUsuario == 1)
            {
                //btnBackup.Visible = false; borrar
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
            //panelBusqueda.Visible = false;
            // para suspender uso de  botones
            ClsUsuario.number_categoria = true;
            changeContac();
        }

        private void Nombre_Usuario()
        {
            lblUsuarioname.Text = ClsUsuario.nameUsuario;
        }

        private void changeContac()
        {
            _busqueda = new FrmBusqueda();
            ClsUsuario.categoria_busqueda = "Proveedores";
            _busqueda.Busqueda_tipo_label("Proveedores");
            traerFormBusqueda(_busqueda);
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
            panelBusqueda.Visible = false;
            btnClosed.Visible = true;
            traerFrmConfi();
        }

        private void traerFrmConfi()
        {
            panelMenu.Visible = true;
            _confi = new FrmConfiguration();
            _confi.TopLevel = false;
            panelMenu.Controls.Add(_confi);
            _confi.Show();
        }

        private void traerFormBusqueda(Form frmbusqueda)
        {
            frmbusqueda.TopLevel = false;
            panelBusqueda.Visible = true;
            panelBusqueda.Controls.Add(frmbusqueda);
            frmbusqueda.Show();
        }

        private void btnClosed_Click(object sender, EventArgs e)
        {
            panelMenu.Visible = false;
            panelBusqueda.Enabled = true;
            changeContac();
            btnClosed.Visible = false;
        }


    }
}
