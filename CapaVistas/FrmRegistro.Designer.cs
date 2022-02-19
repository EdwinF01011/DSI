
namespace DSI.CapaVistas
{
    partial class FrmRegistro
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtNIT = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblKey = new System.Windows.Forms.Label();
            this.cboxSectorR = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.txtDireccionR = new System.Windows.Forms.TextBox();
            this.cboxCiudadRegistro = new System.Windows.Forms.ComboBox();
            this.txtRsocialR = new System.Windows.Forms.TextBox();
            this.txtDescripcionR = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtNombreR = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.cboxPaisRegistro = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtTelefonoR = new System.Windows.Forms.TextBox();
            this.txtCorreoR = new System.Windows.Forms.TextBox();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.btnGuardarR = new System.Windows.Forms.Button();
            this.btnDocR = new System.Windows.Forms.Button();
            this.panelRegistro = new System.Windows.Forms.Panel();
            this.lblCorreoAlert = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(243)))), ((int)(((byte)(138)))));
            this.panel2.ForeColor = System.Drawing.Color.Transparent;
            this.panel2.Location = new System.Drawing.Point(625, 12);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(10, 85);
            this.panel2.TabIndex = 18;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.Menu;
            this.groupBox1.Controls.Add(this.lblCorreoAlert);
            this.groupBox1.Controls.Add(this.txtNIT);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.lblKey);
            this.groupBox1.Controls.Add(this.cboxSectorR);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.txtDireccionR);
            this.groupBox1.Controls.Add(this.cboxCiudadRegistro);
            this.groupBox1.Controls.Add(this.txtRsocialR);
            this.groupBox1.Controls.Add(this.txtDescripcionR);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.txtNombreR);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.cboxPaisRegistro);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.txtTelefonoR);
            this.groupBox1.Controls.Add(this.txtCorreoR);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(606, 700);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Registro";
            // 
            // txtNIT
            // 
            this.txtNIT.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNIT.Location = new System.Drawing.Point(126, 187);
            this.txtNIT.MaxLength = 11;
            this.txtNIT.Name = "txtNIT";
            this.txtNIT.Size = new System.Drawing.Size(395, 35);
            this.txtNIT.TabIndex = 3;
            this.txtNIT.Tag = "";
            this.txtNIT.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNIT_KeyPress);
            this.txtNIT.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtNIT_KeyUp);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(61, 141);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 29);
            this.label1.TabIndex = 40;
            this.label1.Text = "Razón Social:";
            // 
            // lblKey
            // 
            this.lblKey.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblKey.AutoSize = true;
            this.lblKey.BackColor = System.Drawing.SystemColors.Menu;
            this.lblKey.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKey.ForeColor = System.Drawing.Color.DarkBlue;
            this.lblKey.Location = new System.Drawing.Point(129, 2);
            this.lblKey.Name = "lblKey";
            this.lblKey.Size = new System.Drawing.Size(20, 26);
            this.lblKey.TabIndex = 22;
            this.lblKey.Text = "-";
            // 
            // cboxSectorR
            // 
            this.cboxSectorR.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboxSectorR.FormattingEnabled = true;
            this.cboxSectorR.Location = new System.Drawing.Point(188, 396);
            this.cboxSectorR.Name = "cboxSectorR";
            this.cboxSectorR.Size = new System.Drawing.Size(261, 37);
            this.cboxSectorR.TabIndex = 6;
            this.cboxSectorR.Tag = "";
            this.cboxSectorR.SelectedValueChanged += new System.EventHandler(this.cboxSectorR_SelectedValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(61, 190);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 29);
            this.label4.TabIndex = 25;
            this.label4.Text = "NIT:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(61, 341);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(121, 29);
            this.label13.TabIndex = 29;
            this.label13.Text = "Dirección:";
            // 
            // txtDireccionR
            // 
            this.txtDireccionR.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDireccionR.Location = new System.Drawing.Point(188, 338);
            this.txtDireccionR.MaxLength = 50;
            this.txtDireccionR.Name = "txtDireccionR";
            this.txtDireccionR.Size = new System.Drawing.Size(333, 35);
            this.txtDireccionR.TabIndex = 5;
            this.txtDireccionR.Tag = "";
            // 
            // cboxCiudadRegistro
            // 
            this.cboxCiudadRegistro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboxCiudadRegistro.FormattingEnabled = true;
            this.cboxCiudadRegistro.Location = new System.Drawing.Point(188, 505);
            this.cboxCiudadRegistro.Name = "cboxCiudadRegistro";
            this.cboxCiudadRegistro.Size = new System.Drawing.Size(261, 37);
            this.cboxCiudadRegistro.TabIndex = 8;
            this.cboxCiudadRegistro.SelectedIndexChanged += new System.EventHandler(this.cboxCiudadRegistro_SelectedIndexChanged);
            this.cboxCiudadRegistro.SelectedValueChanged += new System.EventHandler(this.cboxCiudadRegistro_SelectedValueChanged);
            // 
            // txtRsocialR
            // 
            this.txtRsocialR.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRsocialR.Location = new System.Drawing.Point(227, 138);
            this.txtRsocialR.MaxLength = 20;
            this.txtRsocialR.Name = "txtRsocialR";
            this.txtRsocialR.Size = new System.Drawing.Size(294, 35);
            this.txtRsocialR.TabIndex = 1;
            this.txtRsocialR.Tag = "";
            this.txtRsocialR.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtRsocialR_KeyPress);
            // 
            // txtDescripcionR
            // 
            this.txtDescripcionR.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescripcionR.Location = new System.Drawing.Point(24, 559);
            this.txtDescripcionR.MaxLength = 100;
            this.txtDescripcionR.Multiline = true;
            this.txtDescripcionR.Name = "txtDescripcionR";
            this.txtDescripcionR.Size = new System.Drawing.Size(566, 123);
            this.txtDescripcionR.TabIndex = 9;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(486, 534);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(104, 22);
            this.label8.TabIndex = 31;
            this.label8.Text = "Descripción";
            // 
            // txtNombreR
            // 
            this.txtNombreR.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombreR.Location = new System.Drawing.Point(61, 89);
            this.txtNombreR.MaxLength = 35;
            this.txtNombreR.Name = "txtNombreR";
            this.txtNombreR.Size = new System.Drawing.Size(460, 35);
            this.txtNombreR.TabIndex = 0;
            this.txtNombreR.Tag = "";
            this.txtNombreR.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNombreR_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(61, 239);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(116, 29);
            this.label6.TabIndex = 27;
            this.label6.Text = "Teléfono:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(93, 400);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(89, 29);
            this.label11.TabIndex = 37;
            this.label11.Text = "Sector:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(86, 509);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(96, 29);
            this.label9.TabIndex = 34;
            this.label9.Text = "Ciudad:";
            // 
            // cboxPaisRegistro
            // 
            this.cboxPaisRegistro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboxPaisRegistro.FormattingEnabled = true;
            this.cboxPaisRegistro.Location = new System.Drawing.Point(188, 450);
            this.cboxPaisRegistro.Name = "cboxPaisRegistro";
            this.cboxPaisRegistro.Size = new System.Drawing.Size(261, 37);
            this.cboxPaisRegistro.TabIndex = 7;
            this.cboxPaisRegistro.SelectedValueChanged += new System.EventHandler(this.cboxPaisRegistro_SelectedValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(61, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(243, 29);
            this.label3.TabIndex = 6;
            this.label3.Text = "Representante Legal:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(61, 290);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(94, 29);
            this.label7.TabIndex = 29;
            this.label7.Text = "Correo:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(116, 454);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(66, 29);
            this.label10.TabIndex = 33;
            this.label10.Text = "País:";
            // 
            // txtTelefonoR
            // 
            this.txtTelefonoR.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTelefonoR.Location = new System.Drawing.Point(181, 236);
            this.txtTelefonoR.MaxLength = 30;
            this.txtTelefonoR.Name = "txtTelefonoR";
            this.txtTelefonoR.Size = new System.Drawing.Size(340, 35);
            this.txtTelefonoR.TabIndex = 3;
            this.txtTelefonoR.Tag = "";
            this.txtTelefonoR.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTelefonoR_KeyPress);
            // 
            // txtCorreoR
            // 
            this.txtCorreoR.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCorreoR.Location = new System.Drawing.Point(161, 287);
            this.txtCorreoR.MaxLength = 50;
            this.txtCorreoR.Name = "txtCorreoR";
            this.txtCorreoR.Size = new System.Drawing.Size(360, 35);
            this.txtCorreoR.TabIndex = 4;
            this.txtCorreoR.Tag = "";
            this.txtCorreoR.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtCorreoR_KeyUp);
            // 
            // btnActualizar
            // 
            this.btnActualizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActualizar.Location = new System.Drawing.Point(255, 718);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(164, 40);
            this.btnActualizar.TabIndex = 11;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = true;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // btnGuardarR
            // 
            this.btnGuardarR.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardarR.Location = new System.Drawing.Point(12, 718);
            this.btnGuardarR.Name = "btnGuardarR";
            this.btnGuardarR.Size = new System.Drawing.Size(164, 40);
            this.btnGuardarR.TabIndex = 10;
            this.btnGuardarR.Text = "Guardar";
            this.btnGuardarR.UseVisualStyleBackColor = true;
            this.btnGuardarR.Click += new System.EventHandler(this.btnGuardarR_Click);
            // 
            // btnDocR
            // 
            this.btnDocR.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDocR.Location = new System.Drawing.Point(438, 718);
            this.btnDocR.Name = "btnDocR";
            this.btnDocR.Size = new System.Drawing.Size(164, 40);
            this.btnDocR.TabIndex = 12;
            this.btnDocR.Text = "Documentos";
            this.btnDocR.UseVisualStyleBackColor = true;
            this.btnDocR.Click += new System.EventHandler(this.btnDocR_Click);
            // 
            // panelRegistro
            // 
            this.panelRegistro.Location = new System.Drawing.Point(642, 14);
            this.panelRegistro.Name = "panelRegistro";
            this.panelRegistro.Size = new System.Drawing.Size(889, 698);
            this.panelRegistro.TabIndex = 27;
            // 
            // lblCorreoAlert
            // 
            this.lblCorreoAlert.AutoSize = true;
            this.lblCorreoAlert.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCorreoAlert.Location = new System.Drawing.Point(527, 287);
            this.lblCorreoAlert.Name = "lblCorreoAlert";
            this.lblCorreoAlert.Size = new System.Drawing.Size(28, 37);
            this.lblCorreoAlert.TabIndex = 41;
            this.lblCorreoAlert.Text = "-";
            // 
            // FrmRegistro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1547, 777);
            this.Controls.Add(this.panelRegistro);
            this.Controls.Add(this.btnDocR);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.btnGuardarR);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmRegistro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Tag = "1";
            this.Text = "FrmRegistro";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmRegistro_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblKey;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNombreR;
        private System.Windows.Forms.TextBox txtRsocialR;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtTelefonoR;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtCorreoR;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtDescripcionR;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cboxCiudadRegistro;
        private System.Windows.Forms.ComboBox cboxPaisRegistro;
        private System.Windows.Forms.Button btnGuardarR;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtDireccionR;
        private System.Windows.Forms.ComboBox cboxSectorR;
        private System.Windows.Forms.Button btnDocR;
        private System.Windows.Forms.Panel panelRegistro;
        private System.Windows.Forms.TextBox txtNIT;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lblCorreoAlert;
    }
}