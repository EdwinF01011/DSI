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
    public partial class FrmRegistro : Form
    {
        ClsBusqueda ObjBu = new ClsBusqueda();
        bool bandera = false;
        bool bandera2 = false;



        Byte itemPais;
        Byte itemSector;
        Byte itemCity;

        public FrmRegistro()
        {
            InitializeComponent();
        }

        FrmDocumentos frmDoc = new FrmDocumentos();
        private void btnDocR_Click(object sender, EventArgs e)
        {
            //this.Hide();
            //FrmDocumentos frmDoc = new FrmDocumentos();
            //frmDoc.Show();
            llamarFrmDocumentos();
        }

        private void llamarFrmDocumentos()
        {
            frmDoc = new FrmDocumentos();
            frmDoc.TopLevel = false;
            panelRegistro.Controls.Add(frmDoc);
            frmDoc.Show();
        }

        private void btnPlusSector_Click(object sender, EventArgs e)
        {
            FrmSector frmStor = new FrmSector();
            frmStor.Show();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            //esta acción no será tan util, mantener así

            //this.Hide();
            //FrmBusqueda frmBusq = new FrmBusqueda();
            //frmBusq.Show();

        }

        private void FrmRegistro_Load(object sender, EventArgs e)
        {
            LlenarCboxs();// 

            //AsignarValues();

            /// pruebas 
            /// 
            if (bandera == true)
            {
               // LlenarCboxCity(3);


            }

            cboxCiudadRegistro.Enabled = false;

        }

        private void LlenarCboxs()//Byte idSector,Byte idPais , Byte idCity
        {
            //  SECTOR
            cboxSectorR.DataSource = ObjBu.BuscarSector();
            cboxSectorR.DisplayMember = "nombre_sector";
            cboxSectorR.ValueMember = "id";
            //cboxSectorR.SelectedIndex = idSector;//  ubica el índice de la lista del cbox

            //cboxSectorR.SelectedValue = "Comercio";
            
            //  PAÍS
            cboxPaisRegistro.DataSource = ObjBu.BuscarPais();
            cboxPaisRegistro.DisplayMember = "Npais";
            cboxPaisRegistro.ValueMember = "id";
            //cboxPaisRegistro.SelectedIndex = idPais;//  ubica el índice de la lista del cbox


            //  # pendiente esto 
            bandera = true;
            
            LlenarCboxCity(itemPais);// idCity

        }

        private void cboxPaisRegistro_SelectedValueChanged(object sender, EventArgs e)
        {

            if (bandera == true)
            {
                itemPais = Byte.Parse(cboxPaisRegistro.SelectedValue.ToString());
                LlenarCboxCity(itemPais);
                lblPais.Text = cboxPaisRegistro.Text;
                cboxCiudadRegistro.Enabled = true;
            }

            

        }

        private void LlenarCboxCity(Byte x)
        {
            if (bandera == true)
            {
                cboxCiudadRegistro.DataSource = ObjBu.BuscarCiudad(x);//BuscarCiudad(3)
                cboxCiudadRegistro.DisplayMember = "NCiudad";
                cboxCiudadRegistro.ValueMember = "id";
                //cboxCiudadRegistro.SelectedIndex = x;
                bandera2 = true;

            }

        }

        public void AsignarValues(// agrega los valores de FrmBusqueda de dgv
            Byte id,
            string name,
            string NIT,
            string Rsocial,
            string Tel,
            string correo,
            string Direccion,
            string Sector,
            string Pais,
            string City,
            string descripcion
            //Byte idPais
            )
        {
            lblKey.Text = id.ToString();
            txtNombreR.Text = name;
            txtNIT.Text = NIT;
            txtRsocialR.Text = Rsocial;
            txtTelefonoR.Text = Tel;
            txtCorreoR.Text = correo;
            txtDireccionR.Text = Direccion;
            txtDescripcionR.Text = descripcion;
            lblSector.Text = Sector;
            lblPais.Text = Pais;
            lblCity.Text = City;
            //itemPais = idPais;


            //LlenarCboxs(idSector, idPais ,idCity);

        }

        private void cboxSectorR_SelectedValueChanged(object sender, EventArgs e)
        {
            if (bandera == true)
            {
                itemSector = Byte.Parse(cboxSectorR.SelectedValue.ToString());
                lblSector.Text= cboxSectorR.Text;
            }
        }

        private void cboxCiudadRegistro_SelectedValueChanged(object sender, EventArgs e)
        {
            if (bandera2 == true)
            {
                itemCity = Byte.Parse(cboxCiudadRegistro.SelectedValue.ToString());
                lblCity.Text = cboxCiudadRegistro.Text;
            }
        }
    }
}
