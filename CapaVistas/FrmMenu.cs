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

        private void pnlMenu_Paint(object sender, PaintEventArgs e)
        {

        }

        private void FrmMenu_Load(object sender, EventArgs e)
        {
            Nombre_Usuario();
        }

        private void Nombre_Usuario()
        {
            lblUsuarioname.Text = ClsUsuario.nameUsuario;
        }

        private void btnClientesGo_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmBusqueda fmB = new FrmBusqueda();
            fmB.Show();
            fmB.Busqueda_tipo_label("Clientes");
        }

        private void btnProveedorsGo_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmBusqueda fmB = new FrmBusqueda();
            fmB.Show();
            fmB.Busqueda_tipo_label("Proveedores");
        }
    }
}
