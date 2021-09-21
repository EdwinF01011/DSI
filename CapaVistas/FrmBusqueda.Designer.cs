
namespace DSI.CapaVistas
{
    partial class FrmBusqueda
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblNombreUsuario = new System.Windows.Forms.Label();
            this.pnlMenu = new System.Windows.Forms.Panel();
            this.btnSalirProveedor = new System.Windows.Forms.Button();
            this.btnConfigurar = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnCrearProveedor = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblcategoria = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.teléfono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.correo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.etc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.Menu = new System.Windows.Forms.TextBox();
            this.txtCorreoMenu = new System.Windows.Forms.TextBox();
            this.txtRsocialMenu = new System.Windows.Forms.TextBox();
            this.txtSectorMenu = new System.Windows.Forms.TextBox();
            this.cboxPaisMenu = new System.Windows.Forms.ComboBox();
            this.cboxCiudadMenu = new System.Windows.Forms.ComboBox();
            this.txtTelMenu = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.pnlMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(253)))), ((int)(((byte)(220)))));
            this.panel1.Controls.Add(this.lblNombreUsuario);
            this.panel1.Location = new System.Drawing.Point(3, 2);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(250, 91);
            this.panel1.TabIndex = 13;
            // 
            // lblNombreUsuario
            // 
            this.lblNombreUsuario.AutoSize = true;
            this.lblNombreUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreUsuario.Location = new System.Drawing.Point(45, 26);
            this.lblNombreUsuario.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNombreUsuario.Name = "lblNombreUsuario";
            this.lblNombreUsuario.Size = new System.Drawing.Size(137, 33);
            this.lblNombreUsuario.TabIndex = 0;
            this.lblNombreUsuario.Text = "Nombre*";
            this.lblNombreUsuario.Click += new System.EventHandler(this.lblNombreUsuario_Click);
            // 
            // pnlMenu
            // 
            this.pnlMenu.BackColor = System.Drawing.Color.SteelBlue;
            this.pnlMenu.Controls.Add(this.btnSalirProveedor);
            this.pnlMenu.Controls.Add(this.btnConfigurar);
            this.pnlMenu.Controls.Add(this.label4);
            this.pnlMenu.Controls.Add(this.label3);
            this.pnlMenu.Controls.Add(this.btnCrearProveedor);
            this.pnlMenu.Controls.Add(this.label2);
            this.pnlMenu.Controls.Add(this.btnActualizar);
            this.pnlMenu.Location = new System.Drawing.Point(3, 94);
            this.pnlMenu.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pnlMenu.Name = "pnlMenu";
            this.pnlMenu.Size = new System.Drawing.Size(237, 755);
            this.pnlMenu.TabIndex = 12;
            // 
            // btnSalirProveedor
            // 
            this.btnSalirProveedor.FlatAppearance.BorderSize = 0;
            this.btnSalirProveedor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalirProveedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalirProveedor.ForeColor = System.Drawing.Color.White;
            this.btnSalirProveedor.Location = new System.Drawing.Point(15, 455);
            this.btnSalirProveedor.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSalirProveedor.Name = "btnSalirProveedor";
            this.btnSalirProveedor.Size = new System.Drawing.Size(192, 72);
            this.btnSalirProveedor.TabIndex = 14;
            this.btnSalirProveedor.Text = "Salir";
            this.btnSalirProveedor.UseVisualStyleBackColor = true;
            // 
            // btnConfigurar
            // 
            this.btnConfigurar.FlatAppearance.BorderSize = 0;
            this.btnConfigurar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfigurar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfigurar.ForeColor = System.Drawing.Color.White;
            this.btnConfigurar.Location = new System.Drawing.Point(16, 72);
            this.btnConfigurar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnConfigurar.Name = "btnConfigurar";
            this.btnConfigurar.Size = new System.Drawing.Size(192, 69);
            this.btnConfigurar.TabIndex = 1;
            this.btnConfigurar.Text = "Configurar";
            this.btnConfigurar.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(12, 695);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(137, 20);
            this.label4.TabIndex = 9;
            this.label4.Text = "E ingenierías SAS";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(12, 675);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "Suministros";
            // 
            // btnCrearProveedor
            // 
            this.btnCrearProveedor.FlatAppearance.BorderSize = 0;
            this.btnCrearProveedor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCrearProveedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCrearProveedor.ForeColor = System.Drawing.Color.White;
            this.btnCrearProveedor.Location = new System.Drawing.Point(4, 195);
            this.btnCrearProveedor.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCrearProveedor.Name = "btnCrearProveedor";
            this.btnCrearProveedor.Size = new System.Drawing.Size(218, 72);
            this.btnCrearProveedor.TabIndex = 2;
            this.btnCrearProveedor.Text = "Crear Proveedor";
            this.btnCrearProveedor.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(12, 655);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "Diseños ";
            // 
            // btnActualizar
            // 
            this.btnActualizar.FlatAppearance.BorderSize = 0;
            this.btnActualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnActualizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActualizar.ForeColor = System.Drawing.Color.White;
            this.btnActualizar.Location = new System.Drawing.Point(38, 320);
            this.btnActualizar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(147, 71);
            this.btnActualizar.TabIndex = 3;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = true;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(850, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 82);
            this.label1.TabIndex = 14;
            this.label1.Text = "DSI";
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(243)))), ((int)(((byte)(138)))));
            this.panel2.ForeColor = System.Drawing.Color.Transparent;
            this.panel2.Location = new System.Drawing.Point(991, 9);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(10, 85);
            this.panel2.TabIndex = 15;
            // 
            // lblcategoria
            // 
            this.lblcategoria.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblcategoria.AutoSize = true;
            this.lblcategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcategoria.Location = new System.Drawing.Point(1003, 38);
            this.lblcategoria.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblcategoria.Name = "lblcategoria";
            this.lblcategoria.Size = new System.Drawing.Size(203, 33);
            this.lblcategoria.TabIndex = 16;
            this.lblcategoria.Text = "Proveedores*";
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nombre,
            this.teléfono,
            this.correo,
            this.etc});
            this.dataGridView1.Location = new System.Drawing.Point(271, 289);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(936, 524);
            this.dataGridView1.TabIndex = 17;
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Column1";
            this.Nombre.MinimumWidth = 8;
            this.Nombre.Name = "Nombre";
            this.Nombre.Width = 150;
            // 
            // teléfono
            // 
            this.teléfono.HeaderText = "Column1";
            this.teléfono.MinimumWidth = 8;
            this.teléfono.Name = "teléfono";
            this.teléfono.Width = 150;
            // 
            // correo
            // 
            this.correo.HeaderText = "Column1";
            this.correo.MinimumWidth = 8;
            this.correo.Name = "correo";
            this.correo.Width = 150;
            // 
            // etc
            // 
            this.etc.HeaderText = "Column1";
            this.etc.MinimumWidth = 8;
            this.etc.Name = "etc";
            this.etc.Width = 150;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(267, 112);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(101, 29);
            this.label5.TabIndex = 18;
            this.label5.Text = "Nombre";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(513, 112);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(187, 29);
            this.label6.TabIndex = 19;
            this.label6.Text = "Sector/Actividad";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(513, 201);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(88, 29);
            this.label7.TabIndex = 21;
            this.label7.Text = "Correo";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(267, 201);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(154, 29);
            this.label8.TabIndex = 20;
            this.label8.Text = "Razón Social";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(756, 201);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(90, 29);
            this.label9.TabIndex = 23;
            this.label9.Text = "Ciudad";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(756, 112);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(60, 29);
            this.label10.TabIndex = 22;
            this.label10.Text = "País";
            // 
            // Menu
            // 
            this.Menu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Menu.Location = new System.Drawing.Point(271, 142);
            this.Menu.Name = "Menu";
            this.Menu.Size = new System.Drawing.Size(192, 35);
            this.Menu.TabIndex = 24;
            // 
            // txtCorreoMenu
            // 
            this.txtCorreoMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCorreoMenu.Location = new System.Drawing.Point(518, 233);
            this.txtCorreoMenu.Name = "txtCorreoMenu";
            this.txtCorreoMenu.Size = new System.Drawing.Size(192, 35);
            this.txtCorreoMenu.TabIndex = 25;
            // 
            // txtRsocialMenu
            // 
            this.txtRsocialMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRsocialMenu.Location = new System.Drawing.Point(271, 233);
            this.txtRsocialMenu.Name = "txtRsocialMenu";
            this.txtRsocialMenu.Size = new System.Drawing.Size(192, 35);
            this.txtRsocialMenu.TabIndex = 27;
            // 
            // txtSectorMenu
            // 
            this.txtSectorMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSectorMenu.Location = new System.Drawing.Point(518, 144);
            this.txtSectorMenu.Name = "txtSectorMenu";
            this.txtSectorMenu.Size = new System.Drawing.Size(192, 35);
            this.txtSectorMenu.TabIndex = 26;
            // 
            // cboxPaisMenu
            // 
            this.cboxPaisMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboxPaisMenu.FormattingEnabled = true;
            this.cboxPaisMenu.Location = new System.Drawing.Point(761, 145);
            this.cboxPaisMenu.Name = "cboxPaisMenu";
            this.cboxPaisMenu.Size = new System.Drawing.Size(166, 37);
            this.cboxPaisMenu.TabIndex = 28;
            // 
            // cboxCiudadMenu
            // 
            this.cboxCiudadMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboxCiudadMenu.FormattingEnabled = true;
            this.cboxCiudadMenu.Location = new System.Drawing.Point(761, 233);
            this.cboxCiudadMenu.Name = "cboxCiudadMenu";
            this.cboxCiudadMenu.Size = new System.Drawing.Size(166, 37);
            this.cboxCiudadMenu.TabIndex = 29;
            // 
            // txtTelMenu
            // 
            this.txtTelMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTelMenu.Location = new System.Drawing.Point(994, 195);
            this.txtTelMenu.Name = "txtTelMenu";
            this.txtTelMenu.Size = new System.Drawing.Size(192, 35);
            this.txtTelMenu.TabIndex = 31;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(994, 163);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(110, 29);
            this.label12.TabIndex = 32;
            this.label12.Text = "Teléfono";
            // 
            // FrmBusqueda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1219, 825);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.txtTelMenu);
            this.Controls.Add(this.cboxCiudadMenu);
            this.Controls.Add(this.cboxPaisMenu);
            this.Controls.Add(this.txtRsocialMenu);
            this.Controls.Add(this.txtSectorMenu);
            this.Controls.Add(this.txtCorreoMenu);
            this.Controls.Add(this.Menu);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.lblcategoria);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnlMenu);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FrmBusqueda";
            this.Text = "FrmBusquedaProvedor";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pnlMenu.ResumeLayout(false);
            this.pnlMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblNombreUsuario;
        private System.Windows.Forms.Panel pnlMenu;
        private System.Windows.Forms.Button btnConfigurar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnCrearProveedor;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Button btnSalirProveedor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblcategoria;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn teléfono;
        private System.Windows.Forms.DataGridViewTextBoxColumn correo;
        private System.Windows.Forms.DataGridViewTextBoxColumn etc;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox Menu;
        private System.Windows.Forms.TextBox txtCorreoMenu;
        private System.Windows.Forms.TextBox txtRsocialMenu;
        private System.Windows.Forms.TextBox txtSectorMenu;
        private System.Windows.Forms.ComboBox cboxPaisMenu;
        private System.Windows.Forms.ComboBox cboxCiudadMenu;
        private System.Windows.Forms.TextBox txtTelMenu;
        private System.Windows.Forms.Label label12;
    }
}