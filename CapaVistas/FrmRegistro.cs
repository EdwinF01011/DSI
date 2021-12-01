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
        Clscontacto ObjCont = new Clscontacto();
        ClsBusqueda ObjBu = new ClsBusqueda();
        bool bandera = false;
        bool bandera2 = false;
        Byte itemPaisR;
        Byte itemSectorR;
        Byte itemCityR;

        public FrmRegistro()
        {
            InitializeComponent();
        }

        FrmDocumentos frmDoc = new FrmDocumentos();
        private void btnDocR_Click(object sender, EventArgs e)
        {
            llamarFrmDocumentos();
        }

        private void llamarFrmDocumentos()
        {
            frmDoc = new FrmDocumentos();
            frmDoc.TopLevel = false;
            panelRegistro.Controls.Add(frmDoc);
            frmDoc.Show();
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

            //if (lblKey.Text == "#0*")    // ajustar esto
            //{
            //    btnDocR.Enabled = false;
            //}


            /// pruebas 
            /// 


            cboxCiudadRegistro.Enabled = false;

        }

        private void LlenarCboxs()//Byte idSector,Byte idPais , Byte idCity
        {
            //  SECTOR
            cboxSectorR.DataSource = ObjBu.BuscarSector();
            cboxSectorR.DisplayMember = "nombre_sector";
            cboxSectorR.ValueMember = "id";
            //cboxSectorR.SelectedIndex = idSector;//  ubica el índice de la lista del cbox
            
            //  PAÍS
            cboxPaisRegistro.DataSource = ObjBu.BuscarPais();
            cboxPaisRegistro.DisplayMember = "Npais";
            cboxPaisRegistro.ValueMember = "id";
            //cboxPaisRegistro.SelectedIndex = idPais;//  ubica el índice de la lista del cbox

            bandera = true;
            LlenarCboxCity(itemPaisR);// idCity

        }

        private void cboxPaisRegistro_SelectedValueChanged(object sender, EventArgs e)
        {
            if (bandera == true)
            {
                itemPaisR = Byte.Parse(cboxPaisRegistro.SelectedValue.ToString());
                LlenarCboxCity(itemPaisR);
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
            string descripcion,
            Byte itemCity,
            //Byte itemPais, en duda
            Byte itemSector

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
            itemSectorR = itemSector;
            itemCityR = itemCity;
            Clscontacto.idContanto = id;// para usarlo en FrmDocumentos, referenciar el documento.

        }

        private void cboxSectorR_SelectedValueChanged(object sender, EventArgs e)
        {
            if (bandera == true)
            {
                itemSectorR = Byte.Parse(cboxSectorR.SelectedValue.ToString());
                lblSector.Text= cboxSectorR.Text;
            }
        }

        private void cboxCiudadRegistro_SelectedValueChanged(object sender, EventArgs e)
        {
            if (bandera2 == true)
            {
                itemCityR = Byte.Parse(cboxCiudadRegistro.SelectedValue.ToString());
                lblCity.Text = cboxCiudadRegistro.Text;
            }
        }

        private void InsertContacto()
        {
            ObjCont.InsertContacto(
                txtNombreR.Text,
                txtNIT.Text,
                txtRsocialR.Text,
                txtTelefonoR.Text,
                txtCorreoR.Text,
                txtDireccionR.Text,
                txtDescripcionR.Text,
                itemSectorR,
                itemCityR,
                true
                );
            MessageBox.Show("Contacto Creado");
        }

        private void UpdateContacto()
        {
            // necesito obtener el id del sector y la ciudad


            ObjCont.UpdateContacto(
                Byte.Parse(lblKey.Text),
                txtNombreR.Text,
                txtNIT.Text,
                txtRsocialR.Text,
                txtTelefonoR.Text,
                txtCorreoR.Text,
                txtDireccionR.Text,
                txtDescripcionR.Text,
                itemSectorR,
                itemCityR,
                true
                );
            MessageBox.Show("Contacto Actualizado");

        }

        public void Proces(Byte x)
        {
            if (x == 1)
            {
                btnGuardarR.Enabled = false;

            }
            else
            {
                btnActualizar.Enabled = false;
                btnDocR.Enabled = false;

            }

        }

        private void btnGuardarR_Click(object sender, EventArgs e)
        {
            InsertContacto();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            UpdateContacto();
        }
    }
}
