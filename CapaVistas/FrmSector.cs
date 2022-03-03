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
    public partial class FrmSector : Form
    {
        ClsSector objsec = new ClsSector();
        bool bandera;// para update sector

        public FrmSector()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            //this.Close();
            btnActualizar.Visible = false;
            btnAgregarSector.Enabled = false;
            llenarDGV();
            bandera = false;
            txtSector.Text = "";
        }

        private void FrmSector_Load(object sender, EventArgs e)
        {
            llenarDGV();
            //updateSector2();
        }

        private void llenarDGV()
        {
            try
            {
                dgvSector.DataSource = objsec.TraerSectores();

            }
            catch
            {

            }
        }

        private void insertarSector()
        {
            if (txtSector.Text != String.Empty)
            {
                objsec.InsertSector(txtSector.Text.Trim());
            }
            else
                btnAgregarSector.Enabled = false;
        }

        private void updateSector()
        {
            objsec.UpdateSector(valueID, txtSector.Text.Trim());
        }

        private void updateSector2()
        {
            Properties.Settings.Default.SuperGlobal = "hola global";
            Properties.Settings.Default.Save();
            Properties.Settings.Default.Reload();
            MessageBox.Show(Properties.Settings.Default.SuperGlobal);
        }

        private void tomarIdexSector()
        {

        }

        private void btnAgregarSector_Click(object sender, EventArgs e)
        {
            insertarSector();
            llenarDGV();
            txtSector.Text = "";
        }

        int valueID;
        string valueNsector;// no se usa, eliminarlo
        private void dgvSector_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            valueID = int.Parse(dgvSector.CurrentRow.Cells[0].Value.ToString());
            txtSector.Text = dgvSector.CurrentRow.Cells[1].Value.ToString();


            //valueNsector = dgvSector.CurrentRow.Cells[1].Value.ToString();//  no se usa, eliminarlo
            btnActualizar.Visible = true;
            btnActualizar.Enabled = false;
            btnAgregarSector.Enabled = false;
            bandera = true;
            //btnActualizar.Focus(true) = Focus().

        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            updateSector();
            llenarDGV();
            txtSector.Text = "";
            btnAgregarSector.Enabled = true;
            btnActualizar.Enabled = false;

        }

        private void FrmSector_Click(object sender, EventArgs e)
        {
            btnActualizar.Enabled = false;
            txtSector.Text = "";
            btnAgregarSector.Enabled = false;
            bandera = false;
            btnActualizar.Visible = false;
        }

        private void txtSector_TextChanged(object sender, EventArgs e)
        {
            bool y = objsec.verifySector(txtSector.Text);

            if (bandera == true)// no permite agregar
            {
                btnAgregarSector.Enabled = false;
                if (y == true)
                {
                    btnActualizar.Enabled = false;
                }
                else
                {
                    btnActualizar.Enabled = true;
                }
            }
            else
            {
                btnActualizar.Enabled = false;
                if (y == true)
                {
                    btnAgregarSector.Enabled = false;
                }
                else
                {
                    btnAgregarSector.Enabled = true;
                }
            }
        }
    }
}
