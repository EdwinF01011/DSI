using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DSI.CapaVistas
{
    public partial class FrmRegistro : Form
    {
        public FrmRegistro()
        {
            InitializeComponent();
        }

        private void btnDocR_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmDocumentos frmDoc = new FrmDocumentos();
            frmDoc.Show();
        }

        private void btnPlusSector_Click(object sender, EventArgs e)
        {
            FrmSector frmStor = new FrmSector();
            frmStor.Show();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmBusqueda frmBusq = new FrmBusqueda();
            frmBusq.Show();
        }
    }
}
