
namespace DSI.CapaVistas
{
    partial class FrmConfiguration
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmConfiguration));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbtnEmail = new System.Windows.Forms.RadioButton();
            this.rbtnContraseña = new System.Windows.Forms.RadioButton();
            this.rbtnNombre = new System.Windows.Forms.RadioButton();
            this.rbtnTodo = new System.Windows.Forms.RadioButton();
            this.rbtnUsuario = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblMail = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lblAlertPerfil = new System.Windows.Forms.Label();
            this.txtEmailP = new System.Windows.Forms.TextBox();
            this.chkContraseña = new System.Windows.Forms.CheckBox();
            this.txtNameUsuarioP = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtUsuarioP = new System.Windows.Forms.TextBox();
            this.lblConfirmPass = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPass1 = new System.Windows.Forms.TextBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.txtPass2 = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblAlerta = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnGuardarU = new System.Windows.Forms.Button();
            this.dgvUsuarios = new System.Windows.Forms.DataGridView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.txtCorreo = new System.Windows.Forms.TextBox();
            this.lblAviso = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.rbtnAuxiliar = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.rbtnAdmin = new System.Windows.Forms.RadioButton();
            this.label7 = new System.Windows.Forms.Label();
            this.txtNameUsuarioU = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtUsuarioU = new System.Windows.Forms.TextBox();
            this.lblAlert = new System.Windows.Forms.TabPage();
            this.lblCreado = new System.Windows.Forms.Label();
            this.btnRuta = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.lblA = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuarios)).BeginInit();
            this.panel3.SuspendLayout();
            this.lblAlert.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.lblAlert);
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(30, 33);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1469, 885);
            this.tabControl1.TabIndex = 0;
            this.tabControl1.Click += new System.EventHandler(this.tabControl1_Click);
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.White;
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.panel1);
            this.tabPage1.Controls.Add(this.panel2);
            this.tabPage1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage1.Location = new System.Drawing.Point(4, 34);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1461, 847);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Perfil";
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.groupBox1.Controls.Add(this.rbtnEmail);
            this.groupBox1.Controls.Add(this.rbtnContraseña);
            this.groupBox1.Controls.Add(this.rbtnNombre);
            this.groupBox1.Controls.Add(this.rbtnTodo);
            this.groupBox1.Controls.Add(this.rbtnUsuario);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.Cyan;
            this.groupBox1.Location = new System.Drawing.Point(198, 161);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(256, 312);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "¿Qué desea actualizar?";
            // 
            // rbtnEmail
            // 
            this.rbtnEmail.AutoSize = true;
            this.rbtnEmail.Cursor = System.Windows.Forms.Cursors.Default;
            this.rbtnEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnEmail.Location = new System.Drawing.Point(17, 160);
            this.rbtnEmail.Name = "rbtnEmail";
            this.rbtnEmail.Size = new System.Drawing.Size(112, 36);
            this.rbtnEmail.TabIndex = 19;
            this.rbtnEmail.TabStop = true;
            this.rbtnEmail.Text = "Email";
            this.rbtnEmail.UseVisualStyleBackColor = true;
            this.rbtnEmail.CheckedChanged += new System.EventHandler(this.rbtnEmail_CheckedChanged);
            // 
            // rbtnContraseña
            // 
            this.rbtnContraseña.AutoSize = true;
            this.rbtnContraseña.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnContraseña.Location = new System.Drawing.Point(17, 200);
            this.rbtnContraseña.Name = "rbtnContraseña";
            this.rbtnContraseña.Size = new System.Drawing.Size(187, 36);
            this.rbtnContraseña.TabIndex = 19;
            this.rbtnContraseña.TabStop = true;
            this.rbtnContraseña.Text = "Contraseña";
            this.rbtnContraseña.UseVisualStyleBackColor = true;
            this.rbtnContraseña.CheckedChanged += new System.EventHandler(this.rbtnContraseña_CheckedChanged);
            // 
            // rbtnNombre
            // 
            this.rbtnNombre.AutoSize = true;
            this.rbtnNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnNombre.ForeColor = System.Drawing.Color.Cyan;
            this.rbtnNombre.Location = new System.Drawing.Point(17, 85);
            this.rbtnNombre.Name = "rbtnNombre";
            this.rbtnNombre.Size = new System.Drawing.Size(140, 36);
            this.rbtnNombre.TabIndex = 16;
            this.rbtnNombre.TabStop = true;
            this.rbtnNombre.Text = "Nombre";
            this.rbtnNombre.UseVisualStyleBackColor = true;
            this.rbtnNombre.CheckedChanged += new System.EventHandler(this.rbtnNombre_CheckedChanged);
            // 
            // rbtnTodo
            // 
            this.rbtnTodo.AutoSize = true;
            this.rbtnTodo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnTodo.Location = new System.Drawing.Point(17, 239);
            this.rbtnTodo.Name = "rbtnTodo";
            this.rbtnTodo.Size = new System.Drawing.Size(105, 36);
            this.rbtnTodo.TabIndex = 18;
            this.rbtnTodo.TabStop = true;
            this.rbtnTodo.Text = "Todo";
            this.rbtnTodo.UseVisualStyleBackColor = true;
            this.rbtnTodo.CheckedChanged += new System.EventHandler(this.rbtnTodo_CheckedChanged);
            // 
            // rbtnUsuario
            // 
            this.rbtnUsuario.AutoSize = true;
            this.rbtnUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnUsuario.Location = new System.Drawing.Point(17, 120);
            this.rbtnUsuario.Name = "rbtnUsuario";
            this.rbtnUsuario.Size = new System.Drawing.Size(138, 36);
            this.rbtnUsuario.TabIndex = 17;
            this.rbtnUsuario.TabStop = true;
            this.rbtnUsuario.Text = "Usuario";
            this.rbtnUsuario.UseVisualStyleBackColor = true;
            this.rbtnUsuario.CheckedChanged += new System.EventHandler(this.rbtnUsuario_CheckedChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(652, 32);
            this.label4.TabIndex = 9;
            this.label4.Text = "Aquí tendrá el poder de modificar sus credenciales";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.panel1.Controls.Add(this.lblMail);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.lblAlertPerfil);
            this.panel1.Controls.Add(this.txtEmailP);
            this.panel1.Controls.Add(this.chkContraseña);
            this.panel1.Controls.Add(this.txtNameUsuarioP);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtUsuarioP);
            this.panel1.Controls.Add(this.lblConfirmPass);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txtPass1);
            this.panel1.Controls.Add(this.btnUpdate);
            this.panel1.Controls.Add(this.txtPass2);
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(546, 119);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(415, 656);
            this.panel1.TabIndex = 13;
            // 
            // lblMail
            // 
            this.lblMail.AutoSize = true;
            this.lblMail.BackColor = System.Drawing.Color.Black;
            this.lblMail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMail.ForeColor = System.Drawing.SystemColors.Window;
            this.lblMail.Location = new System.Drawing.Point(269, 207);
            this.lblMail.Name = "lblMail";
            this.lblMail.Size = new System.Drawing.Size(21, 29);
            this.lblMail.TabIndex = 18;
            this.lblMail.Text = "-";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Black;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.Window;
            this.label10.Location = new System.Drawing.Point(56, 207);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(74, 29);
            this.label10.TabIndex = 17;
            this.label10.Text = "Email";
            // 
            // lblAlertPerfil
            // 
            this.lblAlertPerfil.AutoSize = true;
            this.lblAlertPerfil.BackColor = System.Drawing.Color.Black;
            this.lblAlertPerfil.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAlertPerfil.ForeColor = System.Drawing.SystemColors.Window;
            this.lblAlertPerfil.Location = new System.Drawing.Point(78, 522);
            this.lblAlertPerfil.Name = "lblAlertPerfil";
            this.lblAlertPerfil.Size = new System.Drawing.Size(19, 26);
            this.lblAlertPerfil.TabIndex = 16;
            this.lblAlertPerfil.Text = "-";
            // 
            // txtEmailP
            // 
            this.txtEmailP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmailP.Location = new System.Drawing.Point(60, 239);
            this.txtEmailP.MaxLength = 30;
            this.txtEmailP.Name = "txtEmailP";
            this.txtEmailP.Size = new System.Drawing.Size(283, 35);
            this.txtEmailP.TabIndex = 2;
            this.txtEmailP.Visible = false;
            this.txtEmailP.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtEmailP_KeyUp);
            // 
            // chkContraseña
            // 
            this.chkContraseña.AutoSize = true;
            this.chkContraseña.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.chkContraseña.ForeColor = System.Drawing.Color.Cyan;
            this.chkContraseña.Location = new System.Drawing.Point(61, 451);
            this.chkContraseña.Name = "chkContraseña";
            this.chkContraseña.Size = new System.Drawing.Size(249, 33);
            this.chkContraseña.TabIndex = 5;
            this.chkContraseña.Text = "Mostrar Contraseña";
            this.chkContraseña.UseVisualStyleBackColor = false;
            this.chkContraseña.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // txtNameUsuarioP
            // 
            this.txtNameUsuarioP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNameUsuarioP.Location = new System.Drawing.Point(62, 64);
            this.txtNameUsuarioP.MaxLength = 30;
            this.txtNameUsuarioP.Name = "txtNameUsuarioP";
            this.txtNameUsuarioP.Size = new System.Drawing.Size(283, 35);
            this.txtNameUsuarioP.TabIndex = 0;
            this.txtNameUsuarioP.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNameUsuarioP_KeyPress);
            this.txtNameUsuarioP.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtNameUsuarioP_KeyUp);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Black;
            this.label1.ForeColor = System.Drawing.SystemColors.Window;
            this.label1.Location = new System.Drawing.Point(62, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(220, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre de usuario";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Black;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Window;
            this.label2.Location = new System.Drawing.Point(57, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 29);
            this.label2.TabIndex = 3;
            this.label2.Text = "Usuario";
            // 
            // txtUsuarioP
            // 
            this.txtUsuarioP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsuarioP.Location = new System.Drawing.Point(61, 149);
            this.txtUsuarioP.MaxLength = 10;
            this.txtUsuarioP.Name = "txtUsuarioP";
            this.txtUsuarioP.Size = new System.Drawing.Size(283, 35);
            this.txtUsuarioP.TabIndex = 1;
            this.txtUsuarioP.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtUsuarioP_KeyUp);
            // 
            // lblConfirmPass
            // 
            this.lblConfirmPass.AutoSize = true;
            this.lblConfirmPass.BackColor = System.Drawing.Color.Black;
            this.lblConfirmPass.ForeColor = System.Drawing.SystemColors.Window;
            this.lblConfirmPass.Location = new System.Drawing.Point(59, 363);
            this.lblConfirmPass.Name = "lblConfirmPass";
            this.lblConfirmPass.Size = new System.Drawing.Size(21, 29);
            this.lblConfirmPass.TabIndex = 12;
            this.lblConfirmPass.Text = "-";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Black;
            this.label3.ForeColor = System.Drawing.SystemColors.Window;
            this.label3.Location = new System.Drawing.Point(56, 287);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(206, 29);
            this.label3.TabIndex = 5;
            this.label3.Text = "Contraseña nueva";
            // 
            // txtPass1
            // 
            this.txtPass1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPass1.Location = new System.Drawing.Point(60, 319);
            this.txtPass1.MaxLength = 15;
            this.txtPass1.Name = "txtPass1";
            this.txtPass1.PasswordChar = '*';
            this.txtPass1.Size = new System.Drawing.Size(284, 35);
            this.txtPass1.TabIndex = 3;
            this.txtPass1.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtPass1_KeyUp);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.Black;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.ForeColor = System.Drawing.SystemColors.Window;
            this.btnUpdate.Location = new System.Drawing.Point(61, 576);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(283, 45);
            this.btnUpdate.TabIndex = 6;
            this.btnUpdate.Text = "Actualizar";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // txtPass2
            // 
            this.txtPass2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPass2.Location = new System.Drawing.Point(60, 395);
            this.txtPass2.MaxLength = 15;
            this.txtPass2.Name = "txtPass2";
            this.txtPass2.PasswordChar = '*';
            this.txtPass2.Size = new System.Drawing.Size(284, 35);
            this.txtPass2.TabIndex = 4;
            this.txtPass2.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtPass2_KeyUp);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.MidnightBlue;
            this.panel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel2.BackgroundImage")));
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel2.Controls.Add(this.lblAlerta);
            this.panel2.Location = new System.Drawing.Point(512, 84);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(481, 722);
            this.panel2.TabIndex = 14;
            // 
            // lblAlerta
            // 
            this.lblAlerta.AutoSize = true;
            this.lblAlerta.BackColor = System.Drawing.Color.Black;
            this.lblAlerta.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAlerta.ForeColor = System.Drawing.SystemColors.Window;
            this.lblAlerta.Location = new System.Drawing.Point(74, 682);
            this.lblAlerta.Name = "lblAlerta";
            this.lblAlerta.Size = new System.Drawing.Size(317, 26);
            this.lblAlerta.TabIndex = 17;
            this.lblAlerta.Text = "No se pudo concretar la acción.";
            this.lblAlerta.Visible = false;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btnGuardarU);
            this.tabPage2.Controls.Add(this.dgvUsuarios);
            this.tabPage2.Controls.Add(this.panel3);
            this.tabPage2.ForeColor = System.Drawing.SystemColors.WindowText;
            this.tabPage2.Location = new System.Drawing.Point(4, 34);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1461, 847);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Usuarios";
            this.tabPage2.UseVisualStyleBackColor = true;
            this.tabPage2.Click += new System.EventHandler(this.tabPage2_Click);
            // 
            // btnGuardarU
            // 
            this.btnGuardarU.Location = new System.Drawing.Point(1219, 743);
            this.btnGuardarU.Name = "btnGuardarU";
            this.btnGuardarU.Size = new System.Drawing.Size(149, 38);
            this.btnGuardarU.TabIndex = 21;
            this.btnGuardarU.Text = "Guardar";
            this.btnGuardarU.UseVisualStyleBackColor = true;
            this.btnGuardarU.Click += new System.EventHandler(this.btnGuardarU_Click);
            // 
            // dgvUsuarios
            // 
            this.dgvUsuarios.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvUsuarios.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvUsuarios.BackgroundColor = System.Drawing.Color.White;
            this.dgvUsuarios.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvUsuarios.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvUsuarios.ColumnHeadersHeight = 34;
            this.dgvUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvUsuarios.EnableHeadersVisualStyles = false;
            this.dgvUsuarios.GridColor = System.Drawing.SystemColors.Highlight;
            this.dgvUsuarios.Location = new System.Drawing.Point(83, 494);
            this.dgvUsuarios.Name = "dgvUsuarios";
            this.dgvUsuarios.RowHeadersVisible = false;
            this.dgvUsuarios.RowHeadersWidth = 62;
            this.dgvUsuarios.RowTemplate.Height = 28;
            this.dgvUsuarios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvUsuarios.Size = new System.Drawing.Size(1285, 243);
            this.dgvUsuarios.TabIndex = 17;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.panel3.Controls.Add(this.label8);
            this.panel3.Controls.Add(this.txtCorreo);
            this.panel3.Controls.Add(this.lblAviso);
            this.panel3.Controls.Add(this.lblPassword);
            this.panel3.Controls.Add(this.btnGuardar);
            this.panel3.Controls.Add(this.rbtnAuxiliar);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.rbtnAdmin);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.txtNameUsuarioU);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.txtUsuarioU);
            this.panel3.Location = new System.Drawing.Point(83, 31);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1285, 416);
            this.panel3.TabIndex = 24;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label8.Location = new System.Drawing.Point(56, 203);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(92, 30);
            this.label8.TabIndex = 24;
            this.label8.Text = "Correo";
            // 
            // txtCorreo
            // 
            this.txtCorreo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCorreo.Location = new System.Drawing.Point(61, 236);
            this.txtCorreo.MaxLength = 30;
            this.txtCorreo.Name = "txtCorreo";
            this.txtCorreo.Size = new System.Drawing.Size(386, 35);
            this.txtCorreo.TabIndex = 2;
            this.txtCorreo.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtCorreo_KeyUp);
            // 
            // lblAviso
            // 
            this.lblAviso.AutoSize = true;
            this.lblAviso.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAviso.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblAviso.Location = new System.Drawing.Point(517, 80);
            this.lblAviso.Name = "lblAviso";
            this.lblAviso.Size = new System.Drawing.Size(24, 26);
            this.lblAviso.TabIndex = 22;
            this.lblAviso.Text = "#";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassword.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblPassword.Location = new System.Drawing.Point(477, 241);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(39, 26);
            this.lblPassword.TabIndex = 23;
            this.lblPassword.Text = "P#";
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(1136, 359);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(132, 41);
            this.btnGuardar.TabIndex = 5;
            this.btnGuardar.Text = "Crear";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // rbtnAuxiliar
            // 
            this.rbtnAuxiliar.AutoSize = true;
            this.rbtnAuxiliar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.rbtnAuxiliar.Location = new System.Drawing.Point(61, 371);
            this.rbtnAuxiliar.Name = "rbtnAuxiliar";
            this.rbtnAuxiliar.Size = new System.Drawing.Size(101, 29);
            this.rbtnAuxiliar.TabIndex = 4;
            this.rbtnAuxiliar.TabStop = true;
            this.rbtnAuxiliar.Text = "Auxiliar";
            this.rbtnAuxiliar.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(56, 294);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 30);
            this.label5.TabIndex = 20;
            this.label5.Text = "Rol";
            // 
            // rbtnAdmin
            // 
            this.rbtnAdmin.AutoSize = true;
            this.rbtnAdmin.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.rbtnAdmin.Location = new System.Drawing.Point(61, 336);
            this.rbtnAdmin.Name = "rbtnAdmin";
            this.rbtnAdmin.Size = new System.Drawing.Size(142, 29);
            this.rbtnAdmin.TabIndex = 3;
            this.rbtnAdmin.TabStop = true;
            this.rbtnAdmin.Text = "Admistrador";
            this.rbtnAdmin.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label7.Location = new System.Drawing.Point(56, 26);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(231, 30);
            this.label7.TabIndex = 9;
            this.label7.Text = "Nombre de usuario";
            // 
            // txtNameUsuarioU
            // 
            this.txtNameUsuarioU.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNameUsuarioU.Location = new System.Drawing.Point(61, 59);
            this.txtNameUsuarioU.MaxLength = 30;
            this.txtNameUsuarioU.Name = "txtNameUsuarioU";
            this.txtNameUsuarioU.Size = new System.Drawing.Size(198, 35);
            this.txtNameUsuarioU.TabIndex = 0;
            this.txtNameUsuarioU.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNameUsuarioU_KeyPress);
            this.txtNameUsuarioU.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtNameUsuarioU_KeyUp);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.Location = new System.Drawing.Point(56, 115);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(102, 30);
            this.label6.TabIndex = 12;
            this.label6.Text = "Usuario";
            // 
            // txtUsuarioU
            // 
            this.txtUsuarioU.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsuarioU.Location = new System.Drawing.Point(61, 148);
            this.txtUsuarioU.MaxLength = 10;
            this.txtUsuarioU.Name = "txtUsuarioU";
            this.txtUsuarioU.Size = new System.Drawing.Size(198, 35);
            this.txtUsuarioU.TabIndex = 1;
            this.txtUsuarioU.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtUsuarioU_KeyUp);
            // 
            // lblAlert
            // 
            this.lblAlert.Controls.Add(this.lblCreado);
            this.lblAlert.Controls.Add(this.btnRuta);
            this.lblAlert.Controls.Add(this.label9);
            this.lblAlert.Controls.Add(this.lblA);
            this.lblAlert.Location = new System.Drawing.Point(4, 34);
            this.lblAlert.Name = "lblAlert";
            this.lblAlert.Padding = new System.Windows.Forms.Padding(3);
            this.lblAlert.Size = new System.Drawing.Size(1461, 847);
            this.lblAlert.TabIndex = 2;
            this.lblAlert.Text = "Backup";
            this.lblAlert.UseVisualStyleBackColor = true;
            this.lblAlert.Click += new System.EventHandler(this.lblAlert_Click);
            // 
            // lblCreado
            // 
            this.lblCreado.AutoSize = true;
            this.lblCreado.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lblCreado.Location = new System.Drawing.Point(820, 388);
            this.lblCreado.Name = "lblCreado";
            this.lblCreado.Size = new System.Drawing.Size(165, 25);
            this.lblCreado.TabIndex = 28;
            this.lblCreado.Text = "Creado con éxito.";
            this.lblCreado.Visible = false;
            // 
            // btnRuta
            // 
            this.btnRuta.Location = new System.Drawing.Point(714, 381);
            this.btnRuta.Name = "btnRuta";
            this.btnRuta.Size = new System.Drawing.Size(91, 38);
            this.btnRuta.TabIndex = 27;
            this.btnRuta.Text = "...";
            this.btnRuta.UseVisualStyleBackColor = true;
            this.btnRuta.Click += new System.EventHandler(this.btnRuta_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(303, 304);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(913, 25);
            this.label9.TabIndex = 26;
            this.label9.Text = "Click para abrir el explorador de archivos y seleccionar la ubicación para el bac" +
    "kup. La extensión es .bak\r\n";
            // 
            // lblA
            // 
            this.lblA.AutoSize = true;
            this.lblA.Location = new System.Drawing.Point(552, 446);
            this.lblA.Name = "lblA";
            this.lblA.Size = new System.Drawing.Size(415, 50);
            this.lblA.TabIndex = 23;
            this.lblA.Text = "click para crear backup de la base de datos,\r\nsugerible en una carpeta cerca de l" +
    "a unidad C.";
            this.lblA.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // FrmConfiguration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(1530, 948);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmConfiguration";
            this.Text = "FrmConfiguration";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmConfiguration_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuarios)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.lblAlert.ResumeLayout(false);
            this.lblAlert.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox txtPass2;
        private System.Windows.Forms.TextBox txtPass1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtUsuarioP;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.TextBox txtNameUsuarioP;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RadioButton rbtnAuxiliar;
        private System.Windows.Forms.RadioButton rbtnAdmin;
        private System.Windows.Forms.DataGridView dgvUsuarios;
        private System.Windows.Forms.TextBox txtUsuarioU;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.TextBox txtNameUsuarioU;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TabPage lblAlert;
        private System.Windows.Forms.Button btnGuardarU;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblAviso;
        private System.Windows.Forms.Label lblConfirmPass;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbtnContraseña;
        private System.Windows.Forms.RadioButton rbtnNombre;
        private System.Windows.Forms.RadioButton rbtnTodo;
        private System.Windows.Forms.RadioButton rbtnUsuario;
        private System.Windows.Forms.CheckBox chkContraseña;
        private System.Windows.Forms.Label lblAlertPerfil;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lblA;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnRuta;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Label lblCreado;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtCorreo;
        private System.Windows.Forms.RadioButton rbtnEmail;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtEmailP;
        private System.Windows.Forms.Label lblMail;
        private System.Windows.Forms.Label lblAlerta;
    }
}