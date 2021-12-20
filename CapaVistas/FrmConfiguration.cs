﻿using System;
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
    public partial class FrmConfiguration : Form
    {
        ClsUsuario _ClsUsu = new ClsUsuario();
        bool Rol, bandera=false;
        string contraseñaGenerada;
        Byte conteo=0;



        public FrmConfiguration()
        {
            InitializeComponent();
        }

        private void FrmConfiguration_Load(object sender, EventArgs e)
        {
            bool z=accesosRol();
            if (z==false)
            {
                //  nada
            }
            else
            {
                btnUpdate.Enabled = false;
                selectUsuarios();
            }
            disableTxt();

        }

        private void enmascarar()
        {
            if (chkContraseña.Checked == true)
            {
                if (txtPass1.PasswordChar=='*' && txtPass2.PasswordChar == '*')
                {
                    txtPass1.PasswordChar = '\0';
                    txtPass2.PasswordChar = '\0';

                }
            }
            else
            {
                txtPass1.PasswordChar = '*';
                txtPass2.PasswordChar = '*';

            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            enmascarar();
        }

    private void disableTxt()//     iniciar con las cajas de texto inactivas
        {
            txtNameUsuarioP.Visible = false;
            txtUsuarioP.Visible = false;
            txtPass1.Visible = false;
            txtPass2.Visible = false;
        }

        private void clearTxt()//     iniciar con las cajas de texto inactivas
        {
            txtNameUsuarioP.Text = "";
            txtUsuarioP.Text = "";
            txtPass1.Text = "";
            txtPass2.Text = "";
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {
            //tabPage2.remov
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            
            
            updateUsuario();

            


            //  pruebas
            //tabControl1.TabPages.Remove(tabPage2);
        }

        private bool accesosRol()//  bloque accesos según el rol
        {
            if (ClsUsuario.rolUsuario == 1)
            {
                tabControl1.TabPages.Remove(tabPage2);
                tabControl1.TabPages.Remove(tabPage3);
                return false;
            }
            else
            {
                return true;
            }

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            selectionRol();
            insertUsuario();

            clear();
        }

        private void selectionRol()
        {
            if (rbtnAdmin.Checked)
            {
                Rol = false;
            }
            else if (rbtnAuxiliar.Checked)
            {
                Rol = true;
            }
            //MessageBox.Show(Rol.ToString());
        }

        private void insertUsuario()
        {
            bool x = validationInfo();

            if (x == true)
            {
                string prePass = ClsEncrytp.randomGenerator();
                lblAviso.Text = "USUARIO CREADO,  una vez inglese al sistema,\n modifique esta misma contraseña: "+prePass;
                lblPassword.Text = prePass;


                string pass = ClsEncrytp.GetSHA256(prePass);


                _ClsUsu.insertUsuario(txtNameUsuarioU.Text, txtUsuarioU.Text, pass, Rol, false);// estado:false default

            }
            else
                MessageBox.Show("No pudo registrarlo");

        }

        private void updateUsuario()
        {

            if (conteo == 1)
            {
                _ClsUsu.updateUsuario(txtNameUsuarioP.Text);
            }
            else if (conteo==2)
            {
                _ClsUsu.updateUsuarioII(txtUsuarioP.Text);
            }
            else if (conteo ==3)
            {
                bool x = compareTxt();
                if (x==true)
                {
                    string pass = ClsEncrytp.GetSHA256(contraseñaGenerada);
                    _ClsUsu.updateUsuarioIII(pass);
                }
            }
            else if (conteo==4)
            {
                bool x = compareTxt();
                bool y = validationInfo2();
                if (x == true && y == true)
                {
                    string pass = ClsEncrytp.GetSHA256(contraseñaGenerada);
                    _ClsUsu.updateUsuarioIV(txtNameUsuarioP.Text, txtUsuarioP.Text, pass);
                    MessageBox.Show("Actualizado");
                    
                }
                else
                    MessageBox.Show("No se pudo concretar la acción");
            }
            clear(); ;

            //bool x = compareTxt();
            //bool y = validationInfo2();
            //if (x == true && y==true)
            //{
            //    string pass = ClsEncrytp.GetSHA256(contraseñaGenerada);
            //    _ClsUsu.updateUsuarioIV(txtNameUsuarioP.Text, txtUsuarioP.Text, pass);
            //    MessageBox.Show("Actualizado");
            //    clear();
            //}
            //else
            //    MessageBox.Show("No se pudo concretar la acción");
        }

        private void disableUsuario()
        {
            try
            {
                
                if (true)
                {
                    foreach (var item in lista)
                    {
                        _ClsUsu.disableUsuario(item.idUsuario, item.estado);
                        //MessageBox.Show(item.idUsuario.ToString() + " id");
                        //MessageBox.Show(item.estado.ToString()+" estado");


                    }
                    MessageBox.Show("guardado con éxito");
                }
                else
                {
                    MessageBox.Show("pailas mi Rey");

                }
            }
            catch (Exception ex)
            {

                    MessageBox.Show("pailas mi Rey  CATCH"+ ex.ToString());

            }

        }

        private void selectUsuarios()
        {
            dgvUsuarios.DataSource = _ClsUsu.selectUsuario();
            DataGridViewCheckBoxColumn dgvChek = new DataGridViewCheckBoxColumn();
            DataGridViewTextBoxColumn dgvRol = new DataGridViewTextBoxColumn();

            dgvChek.Name = "Deshabilitado";
            dgvRol.Name = "Rol";

            //dgvChek.HeaderText = "hola";

            dgvUsuarios.Columns[3].Visible = false;
            dgvUsuarios.Columns[4].Visible = false;

            dgvUsuarios.Columns.Add(dgvRol);
            dgvUsuarios.Columns.Add(dgvChek);

            bandera = true;





            //dgvUsuarios.CurrentRow.Cells[4].Style = dgvChek.DefaultCellStyle;


        }

        private bool compareTxt()
        {
            if (txtPass1.Text == txtPass2.Text)
            {
                contraseñaGenerada = txtPass1.Text;
                return true;
            }
            else
            {
                lblAlertPerfil.Text = "¡Contraseñas Incorrectas!";
                //MessageBox.Show("Contraseñas incorrectas");
                return false;
            }
        }

        private bool validationInfo()
        {
            if (txtNameUsuarioU.Text == String.Empty || txtUsuarioU.Text == String.Empty || Rol.ToString() == String.Empty)
            {
                return false;
            }
            else
                return true;
        }

        private bool validationInfo2()
        {
            if (txtNameUsuarioP.Text == String.Empty || txtUsuarioP.Text == String.Empty || txtPass1.Text == String.Empty || txtPass2.Text == String.Empty)
            {
                return false;
            }
            else
                return true;
        }

        private void clear()
        {
            txtNameUsuarioP.Text = "";
            txtUsuarioP.Text = "";
            txtPass1.Text = "";
            txtPass2.Text = "";
            //lblAlertPerfil.Text = "";// no

            //-----
            txtNameUsuarioU.Text = "";
            txtUsuarioU.Text = "";
            rbtnAdmin.Checked = false;
            rbtnAuxiliar.Checked = false;

        }

        private void txtPass1_KeyUp(object sender, KeyEventArgs e)
        {
            lblAlertPerfil.Text = "";
            lblConfirmPass.Text = "Confirme su contraseña";
        }

        private void txtPass2_KeyUp(object sender, KeyEventArgs e)
        {
            lblAlertPerfil.Text = "";
            btnUpdate.Enabled = true;
        }

        private void txtNameUsuarioP_KeyUp(object sender, KeyEventArgs e)
        {
            btnUpdate.Enabled = true;
        }

        private void txtUsuarioP_KeyUp(object sender, KeyEventArgs e)
        {
            btnUpdate.Enabled = true;

        }

        private void btnGuardarU_Click(object sender, EventArgs e)
        {
            //dgvUsuarios.CurrentRow.Cells[0].Value = true;



            //dgvUsuarios.Columns


            //foreach (DataGridViewCell item in dgvUsuarios.CurrentRow.Cells)
            //{
            //    dgvUsuarios.CurrentRow.Cells[0].Value = item;
            //}

            //string a=dgvUsuarios.CurrentRow.Cells[5].Value.ToString();
            //MessageBox.Show(a+"  celda");


            //listar();
            listar();
            disableUsuario();

        }

        private void columnasedit()
        {

            bool valueEstado, valueRol;
            if (bandera==true)
            {
                for (int i = 0; i < dgvUsuarios.RowCount; i++)//    obtnemos el valor de la celda, para darselo a otra.
                {
                    valueRol = bool.Parse(dgvUsuarios.Rows[i].Cells[5].Value.ToString());
                    if (valueRol == false)
                    {
                        dgvUsuarios.Rows[i].Cells[0].Value = "Administrador";
                    }
                    else
                    {
                        dgvUsuarios.Rows[i].Cells[0].Value = "Auxiliar";

                    }

                    valueEstado = bool.Parse(dgvUsuarios.Rows[i].Cells[6].Value.ToString());
                    dgvUsuarios.Rows[i].Cells[1].Value = valueEstado;
                }
            }

        }

        IList<Usuario2> lista = new List<Usuario2>();

        private void tabControl1_Click(object sender, EventArgs e)
        {
            //  se necesita que el dgv cargue y termine el Load para ejecutar this.
            columnasedit();

        }
        

    private void listar()
        {
            for (int i = 0; i < dgvUsuarios.RowCount; i++)
            {
                lista.Add(new Usuario2
                {
                    idUsuario = dgvUsuarios.Rows[i].Cells[2].Value.ToString(),
                    estado = dgvUsuarios.Rows[i].Cells[1].Value.ToString()
                });
            }

            //string a = dgvUsuarios.Rows[4].Cells[2].Value.ToString();
            //string b =dgvUsuarios.Rows[4].Cells[1].Value.ToString();

            //Byte f = Byte.Parse(a);



            //MessageBox.Show("f: " + f.ToString() + " B: " + b.ToString());

            //lista.Add(new Usuario2
            //{
            //    idUsuario = 3,
            //    estado = 0
            //}) ;
        }

        private void rbtnNombre_CheckedChanged(object sender, EventArgs e)
        {
            colorBack();
            rbtnNombre.ForeColor = Color.Red;
            disableTxt();

            opcionesBusqueda();

        }

        private void rbtnUsuario_CheckedChanged(object sender, EventArgs e)
        {
            colorBack();

            rbtnUsuario.ForeColor = Color.Red;

            disableTxt();

            opcionesBusqueda();
        }

        private void rbtnContraseña_CheckedChanged(object sender, EventArgs e)
        {
            colorBack();

            rbtnContraseña.ForeColor = Color.Red;

            disableTxt();

            opcionesBusqueda();
        }

        private void rbtnTodo_CheckedChanged(object sender, EventArgs e)
        {
            colorBack();

            rbtnTodo.ForeColor = Color.Red;

            disableTxt();

            opcionesBusqueda();
        }

        private void colorBack()
        {
            rbtnNombre.ForeColor = Color.Cyan;
            rbtnUsuario.ForeColor = Color.Cyan;
            rbtnContraseña.ForeColor = Color.Cyan;
            rbtnTodo.ForeColor = Color.Cyan;

        }

        

        private void opcionesBusqueda()
        {
            btnUpdate.Enabled = false;
            clearTxt();
            if (rbtnNombre.Checked==true)
            {
                txtNameUsuarioP.Visible = true;
                conteo = 1;
            }
            else if(rbtnUsuario.Checked==true)
            {
                txtUsuarioP.Visible = true;
                conteo = 2;

            }
            else if (rbtnContraseña.Checked == true)
            {
                txtPass1.Visible = true;
                txtPass2.Visible = true;
                conteo = 3;

            }
            else if (rbtnTodo.Checked == true)
            {
                txtNameUsuarioP.Visible = true;
                txtUsuarioP.Visible = true;
                txtPass1.Visible = true;
                txtPass2.Visible = true;
                conteo = 4;

            }


        }




    }
}