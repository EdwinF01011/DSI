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
        ClsValidacionCajas validate = new ClsValidacionCajas();
        bool bandera = false;
        bool bandera2 = false, bandera3 = false;
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

            accesosRol();

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
            if (cboxSectorR.Items.Count > 1)
            {
                cboxSectorR.SelectedIndex = -1;
            }


            //cboxSectorR.SelectedIndex = idSector;//  ubica el índice de la lista del cbox

            //  PAÍS
            cboxPaisRegistro.DataSource = ObjBu.BuscarPais();
            cboxPaisRegistro.DisplayMember = "Npais";
            cboxPaisRegistro.ValueMember = "id";
            //cboxPaisRegistro.SelectedIndex = idPais;//  ubica el índice de la lista del cbox
            if (cboxPaisRegistro.Items.Count > 1)
            {
                cboxPaisRegistro.SelectedIndex = -1;
            }
            bandera = true;
            LlenarCboxCity(itemPaisR);// idCity
        }

        private void cboxPaisRegistro_SelectedValueChanged(object sender, EventArgs e)
        {
            if (bandera == true)
            {
                itemPaisR = Byte.Parse(cboxPaisRegistro.SelectedValue.ToString());
                LlenarCboxCity(itemPaisR);
                //lblPais.Text = cboxPaisRegistro.Text;
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
                if (cboxCiudadRegistro.Items.Count >= 1)// se aconseja >= y no >, para cuando haya un solo valor
                {
                    cboxCiudadRegistro.SelectedIndex = -1;
                }
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
            Byte itemPais, //en duda
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
            //lblSector.Text = Sector;// no existen
            //lblPais.Text = Pais;
            //lblCity.Text = City;
            itemSectorR = itemSector;
            itemCityR = itemCity;
            Clscontacto.idContanto = id;// para usarlo en FrmDocumentos, referenciar el documento.
            //  permite que los comboBox se posesionen en el valor predefinido
            cboxPaisRegistro.SelectedValue = itemPais;
            cboxCiudadRegistro.SelectedValue = itemCity;
            cboxSectorR.SelectedValue = itemSector;
        }

        private void cboxSectorR_SelectedValueChanged(object sender, EventArgs e)
        {
            if (bandera == true)
            {
                itemSectorR = Byte.Parse(cboxSectorR.SelectedValue.ToString());
                //lblSector.Text= cboxSectorR.Text;// no existe
            }
        }

        private void cboxCiudadRegistro_SelectedValueChanged(object sender, EventArgs e)
        {
            //if (bandera2 == true && cboxCiudadRegistro.SelectedValue != null && cboxCiudadRegistro.SelectedIndex != -1)
            //{
            //    itemCityR = Byte.Parse(cboxCiudadRegistro.SelectedValue.ToString());
            //    lblCity.Text = cboxCiudadRegistro.Text;
            //}
        }

        private void cboxCiudadRegistro_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(bandera2 == true && cboxCiudadRegistro.SelectedValue != null && cboxCiudadRegistro.SelectedIndex != -1)
            {
                itemCityR = Byte.Parse(cboxCiudadRegistro.SelectedValue.ToString());

                //lblCity.Text =cboxCiudadRegistro.SelectedValue.ToString();

                ////lblCity

                //lblCity.Text = cboxCiudadRegistro.Text;
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
                btnGuardarR.Visible = false;
            }
            else
            {
                btnActualizar.Visible = false;
                btnDocR.Visible = false;
                //btnGuardarR.Enabled = false;

            }
        }

        private void btnGuardarR_Click(object sender, EventArgs e)
        {
            bool x = noEmpty();
            if (x == false)
            {
                lblKey.Text = "  Complete los campos   ←_← ";
                //lblKey.ForeColor=
            }
            else { InsertContacto(); CleanUp.limpiarCajas(this, groupBox1);  /*MessageBox.Show("cleanUp");*/ }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            UpdateContacto();
        }

        private void accesosRol()//  bloque accesos según el rol
        {
            if (ClsUsuario.rolUsuario == 1)
            {
                btnActualizar.Visible = false;
            }
        }

        private bool noEmpty()
        {
            if (txtNombreR.Text == String.Empty ||
                txtNIT.Text == String.Empty ||
                txtRsocialR.Text == String.Empty ||
                txtTelefonoR.Text == "" ||
                txtCorreoR.Text == "" ||
                txtDireccionR.Text == "" ||
                itemSectorR <= 0 ||
                itemPaisR <= 0 ||
                itemCityR <= 0 ||
                bandera3 ==false
                )
            {
                return false;
            }
            else
                return true;
        }

        private void txtNombreR_KeyPress(object sender, KeyPressEventArgs e)
        {
            validate.SoloLetras(e);
        }

        private void txtNIT_KeyPress(object sender, KeyPressEventArgs e)
        {
            txtNIT.ForeColor = Color.Black;

            validate.SoloNumero(e);
            //bool verifynit =ObjCont.verifyNit(txtNIT.Text);
            //if (verifynit ==true)
            //{
            //    MessageBox.Show("Este nit ya existe");
            //}
        }

        private void txtRsocialR_KeyPress(object sender, KeyPressEventArgs e)
        {
            validate.SoloLetras(e);
        }

        private void txtTelefonoR_KeyPress(object sender, KeyPressEventArgs e)
        {
            validate.SoloNumeroConsignos(e);
        }

        private void txtNIT_KeyUp(object sender, KeyEventArgs e)
        {
            bool verifynit = ObjCont.verifyNit(txtNIT.Text);
            if (verifynit == true)
            {
                txtNIT.ForeColor = Color.Red;
                MessageBox.Show("Este nit ya existe");
            }
        }

        private void txtCorreoR_KeyUp(object sender, KeyEventArgs e)
        {
            char Dot = '#';
            lblCorreoAlert.Text = "-";
            bool y = email_validation.isvalideEmail(txtCorreoR.Text.Trim());
            string dot = txtCorreoR.Text.Trim();
            for (int i = 0; i < dot.Length; i++)
            {
                if (dot[i].ToString() == ".")
                {
                    Dot = dot[i];
                }
            }
            if (y == true && Dot == '.')
            {
                bandera3 = true;
                lblCorreoAlert.Text = "↴";
            }
            else
            {
                lblCorreoAlert.Text = "↺";
            }
        }
    }
}
