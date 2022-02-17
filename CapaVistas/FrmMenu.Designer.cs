
namespace DSI.CapaVistas
{
    partial class FrmMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMenu));
            this.lblNombreUsuario = new System.Windows.Forms.Label();
            this.btnConfigurar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.lblDirectorioEmpresarial = new System.Windows.Forms.Label();
            this.pnlMenu = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnSectores = new System.Windows.Forms.Button();
            this.btnUbicaciones = new System.Windows.Forms.Button();
            this.lblUsuarioname = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.btnClosed = new System.Windows.Forms.Button();
            this.panelBusqueda = new System.Windows.Forms.Panel();
            this.pnlMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNombreUsuario
            // 
            this.lblNombreUsuario.AutoSize = true;
            this.lblNombreUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreUsuario.ForeColor = System.Drawing.Color.White;
            this.lblNombreUsuario.Location = new System.Drawing.Point(448, -208);
            this.lblNombreUsuario.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNombreUsuario.Name = "lblNombreUsuario";
            this.lblNombreUsuario.Size = new System.Drawing.Size(137, 33);
            this.lblNombreUsuario.TabIndex = 0;
            this.lblNombreUsuario.Text = "Nombre*";
            // 
            // btnConfigurar
            // 
            this.btnConfigurar.FlatAppearance.BorderSize = 0;
            this.btnConfigurar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.btnConfigurar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Indigo;
            this.btnConfigurar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfigurar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfigurar.ForeColor = System.Drawing.Color.White;
            this.btnConfigurar.Location = new System.Drawing.Point(99, 186);
            this.btnConfigurar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnConfigurar.Name = "btnConfigurar";
            this.btnConfigurar.Size = new System.Drawing.Size(192, 69);
            this.btnConfigurar.TabIndex = 1;
            this.btnConfigurar.Text = "Configurar";
            this.btnConfigurar.UseVisualStyleBackColor = true;
            this.btnConfigurar.Click += new System.EventHandler(this.btnConfigurar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.FlatAppearance.BorderSize = 0;
            this.btnSalir.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.btnSalir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Indigo;
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.ForeColor = System.Drawing.Color.White;
            this.btnSalir.Location = new System.Drawing.Point(99, 600);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(192, 69);
            this.btnSalir.TabIndex = 3;
            this.btnSalir.Text = "Cerrar Sesión";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // lblDirectorioEmpresarial
            // 
            this.lblDirectorioEmpresarial.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDirectorioEmpresarial.AutoSize = true;
            this.lblDirectorioEmpresarial.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDirectorioEmpresarial.Location = new System.Drawing.Point(45, 12);
            this.lblDirectorioEmpresarial.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDirectorioEmpresarial.Name = "lblDirectorioEmpresarial";
            this.lblDirectorioEmpresarial.Size = new System.Drawing.Size(276, 29);
            this.lblDirectorioEmpresarial.TabIndex = 4;
            this.lblDirectorioEmpresarial.Text = "Directorio Empresarial";
            // 
            // pnlMenu
            // 
            this.pnlMenu.BackColor = System.Drawing.Color.Transparent;
            this.pnlMenu.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlMenu.BackgroundImage")));
            this.pnlMenu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlMenu.Controls.Add(this.pictureBox1);
            this.pnlMenu.Controls.Add(this.btnSectores);
            this.pnlMenu.Controls.Add(this.btnUbicaciones);
            this.pnlMenu.Controls.Add(this.lblUsuarioname);
            this.pnlMenu.Controls.Add(this.lblNombreUsuario);
            this.pnlMenu.Controls.Add(this.btnConfigurar);
            this.pnlMenu.Controls.Add(this.panel2);
            this.pnlMenu.Controls.Add(this.lblDirectorioEmpresarial);
            this.pnlMenu.Controls.Add(this.btnSalir);
            this.pnlMenu.Location = new System.Drawing.Point(-20, -3);
            this.pnlMenu.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pnlMenu.Name = "pnlMenu";
            this.pnlMenu.Size = new System.Drawing.Size(342, 1028);
            this.pnlMenu.TabIndex = 10;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(32, 70);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(56, 56);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // btnSectores
            // 
            this.btnSectores.FlatAppearance.BorderSize = 0;
            this.btnSectores.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.btnSectores.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Indigo;
            this.btnSectores.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSectores.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSectores.ForeColor = System.Drawing.Color.White;
            this.btnSectores.Location = new System.Drawing.Point(99, 465);
            this.btnSectores.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSectores.Name = "btnSectores";
            this.btnSectores.Size = new System.Drawing.Size(192, 72);
            this.btnSectores.TabIndex = 13;
            this.btnSectores.Text = "Sectores";
            this.btnSectores.UseVisualStyleBackColor = true;
            this.btnSectores.Click += new System.EventHandler(this.btnSectores_Click);
            // 
            // btnUbicaciones
            // 
            this.btnUbicaciones.FlatAppearance.BorderSize = 0;
            this.btnUbicaciones.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.btnUbicaciones.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Indigo;
            this.btnUbicaciones.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUbicaciones.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUbicaciones.ForeColor = System.Drawing.Color.White;
            this.btnUbicaciones.Location = new System.Drawing.Point(99, 320);
            this.btnUbicaciones.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnUbicaciones.Name = "btnUbicaciones";
            this.btnUbicaciones.Size = new System.Drawing.Size(192, 72);
            this.btnUbicaciones.TabIndex = 13;
            this.btnUbicaciones.Text = "Ubicaciones";
            this.btnUbicaciones.UseVisualStyleBackColor = true;
            this.btnUbicaciones.Click += new System.EventHandler(this.btnUbicaciones_Click);
            // 
            // lblUsuarioname
            // 
            this.lblUsuarioname.AutoSize = true;
            this.lblUsuarioname.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuarioname.Location = new System.Drawing.Point(95, 82);
            this.lblUsuarioname.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUsuarioname.Name = "lblUsuarioname";
            this.lblUsuarioname.Size = new System.Drawing.Size(137, 33);
            this.lblUsuarioname.TabIndex = 13;
            this.lblUsuarioname.Text = "Nombre*";
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.panel2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel2.Location = new System.Drawing.Point(33, 46);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(297, 9);
            this.panel2.TabIndex = 12;
            // 
            // panelMenu
            // 
            this.panelMenu.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelMenu.BackColor = System.Drawing.Color.DarkRed;
            this.panelMenu.Location = new System.Drawing.Point(357, 77);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(1529, 948);
            this.panelMenu.TabIndex = 15;
            // 
            // btnClosed
            // 
            this.btnClosed.BackColor = System.Drawing.Color.Transparent;
            this.btnClosed.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnClosed.BackgroundImage")));
            this.btnClosed.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnClosed.FlatAppearance.BorderSize = 0;
            this.btnClosed.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnClosed.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnClosed.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClosed.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClosed.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnClosed.Location = new System.Drawing.Point(329, 29);
            this.btnClosed.Name = "btnClosed";
            this.btnClosed.Size = new System.Drawing.Size(109, 42);
            this.btnClosed.TabIndex = 16;
            this.btnClosed.UseVisualStyleBackColor = false;
            this.btnClosed.Click += new System.EventHandler(this.btnClosed_Click);
            // 
            // panelBusqueda
            // 
            this.panelBusqueda.BackColor = System.Drawing.Color.Crimson;
            this.panelBusqueda.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panelBusqueda.Location = new System.Drawing.Point(346, 0);
            this.panelBusqueda.Name = "panelBusqueda";
            this.panelBusqueda.Size = new System.Drawing.Size(1552, 1025);
            this.panelBusqueda.TabIndex = 17;
            // 
            // FrmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(1898, 1024);
            this.Controls.Add(this.panelBusqueda);
            this.Controls.Add(this.panelMenu);
            this.Controls.Add(this.btnClosed);
            this.Controls.Add(this.pnlMenu);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FrmMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmMenu";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmMenu_Load);
            this.pnlMenu.ResumeLayout(false);
            this.pnlMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblNombreUsuario;
        private System.Windows.Forms.Button btnConfigurar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Label lblDirectorioEmpresarial;
        private System.Windows.Forms.Panel pnlMenu;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblUsuarioname;
        private System.Windows.Forms.Button btnSectores;
        private System.Windows.Forms.Button btnUbicaciones;
        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Button btnClosed;
        private System.Windows.Forms.Panel panelBusqueda;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}