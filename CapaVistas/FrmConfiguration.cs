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
using System.Data.SqlClient;
using System.IO;
using System.Configuration;// jpara acceder al  App.config

namespace DSI.CapaVistas
{
    public partial class FrmConfiguration : Form
    {
        ClsLogin _login = new ClsLogin();

        FrmLogin _frmLo = new FrmLogin();
        ClsUsuario _ClsUsu = new ClsUsuario();
        ClsValidacionCajas validate = new ClsValidacionCajas();

        bool Rol, bandera=false,bandera1=false, bandera2 = false;
        private string rolname;
        string contraseñaGenerada, postRuta;
        Byte conteo=0;
        
        //  2 modos para la conexión a la Base de Datos
        //1  no tan segura"
        SqlConnection conex = new SqlConnection("SERVER=ELLIOT\\SQLEXPRESS;DATABASE=DSI;Integrated Security=true");//    Uid=admin;pwd=1234; si no se hace por autentificación de windows
        //2   dicen que es seguro
        private SqlConnection conx = new SqlConnection(ConfigurationManager.ConnectionStrings["conexionBackup"].ConnectionString);

        //NOTA IMPORTANTE
        //para usar la cadena de conexión de App.config, debemos modificar la que vayamos a utilizar. video explicativo
        // video-https://www.youtube.com/watch?v=IukThCJajEA
        //resultado del video:
        //<add name="conexionBackup" connectionString="data source=ELLIOT\SQLEXPRESS;initial catalog=DSI;integrated security=True;" providerName="System.Data.EntityClient" />



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
            txtEmailP.Visible = false;
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


            //FormCollection frms = Application.OpenForms;
            //foreach (Form f in frms)
            //{
            //    if (f.Name != "FrmLogin")
            //    {
            //        f.Close();
            //    }
            //}

            //foreach (Form frm in Application.OpenForms)
            //{
            //    if (frm != this)
            //    {
            //        frm.Close();
            //    }
            //}

            


            //  pruebas
            //tabControl1.TabPages.Remove(tabPage2);
        }

        private bool accesosRol()//  bloque accesos según el rol
        {
            if (ClsUsuario.rolUsuario == 1)
            {
                tabControl1.TabPages.Remove(tabPage2);
                tabControl1.TabPages.Remove(lblAlert);
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
            //clear();
        }

        private void selectionRol()
        {
            if (rbtnAdmin.Checked)
            {
                Rol = false;
                rolname="Administrador";
            }
            else if (rbtnAuxiliar.Checked)
            {
                Rol = true;
                rolname = "Auxiliar";
            }
            //MessageBox.Show(Rol.ToString());
        }

        private void insertUsuario()
        {
            bool x = validationInfo();
            if (x == true && bandera1== true && bandera2 == true)
            {
                string prePass = ClsEncrytp.randomGenerator();
                lblAviso.Text = "USUARIO CREADO,  una vez inglese al sistema,\n modifique esta misma contraseña: "+prePass;
                lblPassword.Text = prePass;
                string pass = ClsEncrytp.GetSHA256(prePass);
                _ClsUsu.insertUsuario(txtNameUsuarioU.Text.Trim(), txtUsuarioU.Text.Trim(), pass, Rol, false, txtCorreo.Text.Trim());// estado:false default
                _login.emailEnvia(txtNameUsuarioU.Text, txtUsuarioU.Text, txtCorreo.Text, prePass,rolname);
                clear();
            }
            else
            {
                lblAviso.Text= "◱  No pudo crear un nuevo usuario.  ◱";
            }
        }

        private void updateUsuario()
        {
            if (conteo == 1)
            {
                _ClsUsu.updateUsuario(txtNameUsuarioP.Text);
                MessageBox.Show("Esta pestaña se cerrará, vuelva a iniciar sesión");
                _frmLo.Show();
            }
            else if (conteo==2)
            {
                _ClsUsu.updateUsuarioII(txtUsuarioP.Text);
                MessageBox.Show("Esta pestaña se cerrará, vuelva a iniciar sesión");
                _frmLo.Show();
            }
            else if (conteo ==3)
            {
                bool x = compareTxt();
                if (x==true)
                {
                    string pass = ClsEncrytp.GetSHA256(contraseñaGenerada);
                    _ClsUsu.updateUsuarioIII(pass);
                    MessageBox.Show("Esta pestaña se cerrará, vuelva a iniciar sesión");
                    _frmLo.Show();
                }
            }
            else if (conteo == 4 && txtEmailP.Text!=string.Empty && bandera2==true)
            {
                _ClsUsu.updateUsuarioIV(txtEmailP.Text.Trim());
                MessageBox.Show("Esta pestaña se cerrará, vuelva a iniciar sesión y revise su correo");
                _frmLo.Show();
            }
            else if (conteo==5)
            {
                bool x = compareTxt();
                bool y = validationInfo2();
                if (x == true && y == true)
                {
                    string pass = ClsEncrytp.GetSHA256(contraseñaGenerada);
                    _ClsUsu.updateUsuarioV(txtNameUsuarioP.Text, txtUsuarioP.Text, pass,txtEmailP.Text);
                    //MessageBox.Show("Actualizado");
                    lblAlerta.Text="Actualizado";
                    MessageBox.Show("Esta pestaña se cerrará, vuelva a iniciar sesión");
                    _frmLo.Show();
                    }
                else
                {
                    lblAlerta.Visible = true;
                }
                    //MessageBox.Show("No se pudo concretar la acción");
            }
            clear(); 

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
            if (txtNameUsuarioU.Text == String.Empty || txtUsuarioU.Text == String.Empty || Rol.ToString() == String.Empty || txtCorreo.Text==String.Empty)
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
            lblAlerta.Visible = false;

            //lblAlertPerfil.Text = "";// no

            //-----
            txtNameUsuarioU.Text = "";
            txtUsuarioU.Text = "";
            rbtnAdmin.Checked = false;
            rbtnAuxiliar.Checked = false;
            txtCorreo.Text = "";
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

        private void txtEmailP_KeyUp(object sender, KeyEventArgs e)
        {
            btnUpdate.Enabled = true;
            lblMail.Text = "";
            //valideMail();
            txtEmailP.ForeColor = Color.Black;

            bool y = email_validation.isvalideEmail(txtEmailP.Text.Trim());
            if (y == true)
            {
                bool x = _ClsUsu.verifyMail(txtEmailP.Text.Trim());
                if (x == true)// si ya existe
                {
                    bandera2 = false;
                    txtEmailP.ForeColor = Color.Red;
                    lblMail.Text = "⨉";
                    //MessageBox.Show("X");
                }
                else
                {
                    bandera2 = true;
                    txtEmailP.ForeColor = Color.Black;
                    lblMail.Text = "ↆ";
                    //MessageBox.Show("down");
                }
            }
            else
            {
                bandera2 = false;
                //MessageBox.Show("non");
                lblMail.Text = "⨯";
            }
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
            {//
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

        private void rbtnEmail_CheckedChanged(object sender, EventArgs e)
        {
            colorBack();
            rbtnEmail.ForeColor = Color.Red;
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
            rbtnEmail.ForeColor = Color.Cyan;
            rbtnContraseña.ForeColor = Color.Cyan;
            rbtnTodo.ForeColor = Color.Cyan;
        }

        //private void btnCrear_Click(object sender, EventArgs e)
        //{
        //    // sin uso, mantener por si las moscas
        //    bool x= AjustarRuta();
        //    //  ejemplos
        //    //string comando_consulta = "BACKUP DATABASE [DSI] TO  DISK = N'C:\\Users\\loros\\Downloads\\copiasSegurity\\"+fecha_copia + "' WITH NOFORMAT, NOINIT,  NAME = N'DSI-Full Database Backup', SKIP, NOREWIND, NOUNLOAD,  STATS = 10";
        //    //string comando_consulta3 = "BACKUP DATABASE [DSI] TO  DISK = N'C:\\Program Files\\Microsoft SQL Server\\MSSQL15.SQLEXPRESS\\MSSQL\\Backup\\DSI.bak' WITH NOFORMAT, NOINIT,  NAME = N'DSI-Full Database Backup', SKIP, NOREWIND, NOUNLOAD,  STATS = 10";
        //    try
        //    {
        //        if (x==true)
        //        {
        //            //  ontiene fecha y hora del sistema
        //            string fecha_copia = "Fecha_" + System.DateTime.Now.ToString("dd_MM_yyyy") + "_hora_"
        //                + System.DateTime.Now.ToString("hhh_mm_ss") + ".bak";
        //            string comando_consulta2 = "BACKUP DATABASE [DSI] TO  DISK = N'" + postRuta + "\\" + fecha_copia + "' WITH NOFORMAT, NOINIT,  NAME = N'DSI-Full Database Backup', SKIP, NOREWIND, NOUNLOAD,  STATS = 10";
        //            SqlCommand cmd = new SqlCommand(comando_consulta2, conex);
        //            conex.Open();
        //            cmd.ExecuteNonQuery();
        //            MessageBox.Show("creado correctamente BACKUP ");
        //        }
        //        else
        //            MessageBox.Show("No se pudo completar el backup");
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show("nada mi  prro "+ ex.ToString());
        //    }
        //    finally
        //    {
        //        conex.Close();
        //        conex.Dispose();
        //    }
        //    //MessageBox.Show(fecha_copia);
        //}

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
            else if (rbtnEmail.Checked==true)
            {
                txtEmailP.Visible = true;
                conteo = 4;
            }
            else if (rbtnTodo.Checked == true)
            {
                txtNameUsuarioP.Visible = true;
                txtUsuarioP.Visible = true;
                txtEmailP.Visible = true;
                txtPass1.Visible = true;
                txtPass2.Visible = true;
                conteo = 5;
            }
        }

        private void txtNameUsuarioP_KeyPress(object sender, KeyPressEventArgs e)
        {
            validate.SoloLetras(e);
        }

        private void txtNameUsuarioU_KeyPress(object sender, KeyPressEventArgs e)
        {
            validate.SoloLetras(e);
        }

        private void btnRuta_Click(object sender, EventArgs e)
        {
            Backup();
            string txt = "click para crear backup de la base de datos,\n" +
            "sugerible en una carpeta cerca de la unidad C.";
            //lblCreado.Visible = false;
        }

        private void lblAlert_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("click");
            lblCreado.Visible = false;
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void Backup()
        {
            //  ontiene fecha y hora del sistema
            string fecha_copia = "Fecha_" + System.DateTime.Now.ToString("dd_MM_yyyy") + "_hora_"
                + System.DateTime.Now.ToString("hhh_mm_ss") + ".bak";
            try
            {
                saveFileDialog1.Title = "SELECCIONE LA RUTA";
                saveFileDialog1.FileName = "Backup";
                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    string ruta = Path.GetDirectoryName(saveFileDialog1.FileName);
                    string nameFile = Path.GetFileName(saveFileDialog1.FileName);
                    string comando_consulta = "BACKUP DATABASE [DSI] TO  DISK = N'" + ruta + "\\" + nameFile + "_" + fecha_copia + "' WITH NOFORMAT, NOINIT,  NAME = N'DSI-Full Database Backup', SKIP, NOREWIND, NOUNLOAD,  STATS = 10";
                    SqlCommand cmd = new SqlCommand(comando_consulta, conx);
                    conx.Open();
                    cmd.ExecuteNonQuery();
                    lblCreado.Visible = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                conx.Close();
            }
        }

        //<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<

        private void txtCorreo_KeyUp(object sender, KeyEventArgs e)
        {// verificar si existe
            lblPassword.Text = "-";
            bool y = email_validation.isvalideEmail(txtCorreo.Text.Trim());
            if (y == true /*&& Dot =='.'*/)
            {
                bool x = _ClsUsu.verifyMail(txtCorreo.Text.Trim());
                if (x == true)// si ya existe
                {
                    bandera2 = false;
                    txtCorreo.ForeColor = Color.Red;
                    lblPassword.Text = "Este correo, yá se encuentra en uso.     ಠ_ಠ";
                }
                else
                {
                    bandera2 = true;
                    txtCorreo.ForeColor = Color.Black;
                    lblPassword.Text = "Perfect.     （￣︶￣）↗　";
                }
            }
            else
            {
                lblPassword.Text = "El formato  de correo no existe.     X﹏X";
            }         
        }

        private void btnCargarBak_Click(object sender, EventArgs e)
        {
            requestRuta();
        }

        private void btnRestaurar_Click(object sender, EventArgs e)
        {
            RestaurarBD();
        }

        //private void valideMail()
        //{// verificar si existe
        // //lblMail.Text = "";//⇅
        //    txtEmailP.ForeColor = Color.Black;

        //    bool y = email_validation.isvalideEmail(txtEmailP.Text.Trim());
        //    if (y == true)
        //    {
        //        bool x = _ClsUsu.verifyMail(txtCorreo.Text.Trim());
        //        if (x == true)// si ya existe
        //        {
        //            bandera2 = false;
        //            txtEmailP.ForeColor = Color.Red;
        //            lblMail.Text = "⨉";
        //            //MessageBox.Show("X");
        //        }
        //        else
        //        {
        //            bandera2 = true;
        //            txtEmailP.ForeColor = Color.Black;
        //            lblMail.Text = "ↆ";
        //            //MessageBox.Show("down");
        //        }
        //    }
        //    else
        //    {
        //        bandera2 = false;
        //        //MessageBox.Show("non");
        //        //lblMail.Text = "⨯";
        //    }
        //}

        private void txtUsuarioU_KeyUp(object sender, KeyEventArgs e)
        {// verificar si existe
            bool x = _ClsUsu.verifyUser(txtUsuarioU.Text);
            if (x == true)
            {
                bandera1 = false;
                txtUsuarioU.ForeColor = Color.Red;
            }
            else
            {
                bandera1 = true;
                txtUsuarioU.ForeColor = Color.Black;
            }   
        }

        private void txtNameUsuarioU_KeyUp(object sender, KeyEventArgs e)
        {
            
        }

        private void requestRuta()//  -https://www.youtube.com/watch?v=wbVb6tH_BDc
        {
            //openFileDialog1.InitialDirectory = "c:\\";
            openFileDialog1.InitialDirectory = @"c:\";  // evita errores por diagonales inversas @.

            openFileDialog1.Filter = "Archivos .bak (*.bak*)|*.bak*";//"Todos los archivos (*.*)|*."
            openFileDialog1.Title = "Selecccionar respaldo";
            openFileDialog1.FilterIndex = 1;
            openFileDialog1.RestoreDirectory = true;
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string ruta= openFileDialog1.FileName;
                //AjustarRuta(ruta);
                txtRutaRestoreBackup.Text = ruta;
                //MessageBox.Show(ruta);
            }

            /*  para hacer la restauración
             *  
             *  -https://elblogdelbeto.com/codigo-en-c-para-crear-un-respaldo-de-una-base-de-datos-en-sql-server-y-restaurarla/
             *  -https://cpiprodesign.blogspot.com/2018/06/backup-y-restore-database-sql-server.html
             *  
             *  
             *  USE [master]
                RESTORE DATABASE [DSI] FROM  DISK = N'C:\z\ultima_Fecha_14_02_2022_hora_09_36_14.bak' WITH  FILE = 1,  NOUNLOAD,  STATS = 5
                GO
             */
        }

        private void RestaurarBD()
        {
            string ruta = txtRutaRestoreBackup.Text.Trim();
            string bd = conx.Database.ToString();
            try
            {
                if (conx.State != ConnectionState.Open)
                {
                    conx.Open();
                }
                //hacer single user y rollback
                string sqlT1 = String.Format("ALTER DATABASE [" + bd + "] SET SINGLE_USER WITH ROLLBACK IMMEDIATE");
                SqlCommand cmd1 = new SqlCommand(sqlT1, conx);
                cmd1.ExecuteNonQuery();
                string comandoConsulta = "USE [master] RESTORE DATABASE[DSI] FROM DISK = N'"+ruta+"' WITH FILE = 1, NOUNLOAD, STATS = 5  GO";
                //  ALTER TABLE
                string sqlT2 = @"USE [master] RESTORE DATABASE[DSI] FROM DISK = N'C:\z\ultima_Fecha_14_02_2022_hora_09_36_14.bak' WITH FILE = 1, NOUNLOAD, STATS = 5 ";
                SqlCommand cmd2 = new SqlCommand(sqlT2, conx);
                cmd2.ExecuteNonQuery();
                //hacer multi user
                string sqlT3 = String.Format("ALTER DATABASE [" + bd + "] SET MULTI_USER");
                SqlCommand cmd3 = new SqlCommand(sqlT3, conx);
                cmd3.ExecuteNonQuery();
                //Bibliografía
                //-https://www.sqlshack.com/alter-database-set-single_user-statement-in-sql-server/
                //-https://cpiprodesign.blogspot.com/2018/06/backup-y-restore-database-sql-server.html
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                conx.Close();
            }
        }


        //private void AjustarRuta(string ruta)// sin uso, sirve
        //{
        //    //    if (txtRutaRestoreBackup.Text != String.Empty)
        //    //    {
        //    //string preRuta = ruta;
        //        foreach (var item in ruta)
        //        {
        //            postRuta += item.ToString();
        //            if (item.ToString().Contains("\\"))
        //            {
        //                postRuta += "\\";
        //            }
        //        }
        //        txtRutaRestoreBackup.Text = postRuta;
        //        //return true;

        //    //}
        //    //else
        //    //{
        //    //    MessageBox.Show("agregue una ruta");
        //    //    //return false;
        //    //}
        //}


    }
}
