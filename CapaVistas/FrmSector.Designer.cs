
namespace DSI.CapaVistas
{
    partial class FrmSector
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
            this.txtSector = new System.Windows.Forms.TextBox();
            this.btnAgregarSector = new System.Windows.Forms.Button();
            this.dgvSector = new System.Windows.Forms.DataGridView();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnActualizar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSector)).BeginInit();
            this.SuspendLayout();
            // 
            // txtSector
            // 
            this.txtSector.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSector.Location = new System.Drawing.Point(21, 29);
            this.txtSector.MaxLength = 20;
            this.txtSector.Name = "txtSector";
            this.txtSector.Size = new System.Drawing.Size(291, 35);
            this.txtSector.TabIndex = 26;
            this.txtSector.TextChanged += new System.EventHandler(this.txtSector_TextChanged);
            // 
            // btnAgregarSector
            // 
            this.btnAgregarSector.Enabled = false;
            this.btnAgregarSector.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarSector.Location = new System.Drawing.Point(318, 26);
            this.btnAgregarSector.Name = "btnAgregarSector";
            this.btnAgregarSector.Size = new System.Drawing.Size(134, 40);
            this.btnAgregarSector.TabIndex = 27;
            this.btnAgregarSector.Text = "Agregar";
            this.btnAgregarSector.UseVisualStyleBackColor = true;
            this.btnAgregarSector.Click += new System.EventHandler(this.btnAgregarSector_Click);
            // 
            // dgvSector
            // 
            this.dgvSector.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSector.Location = new System.Drawing.Point(21, 84);
            this.dgvSector.Name = "dgvSector";
            this.dgvSector.ReadOnly = true;
            this.dgvSector.RowHeadersWidth = 62;
            this.dgvSector.RowTemplate.Height = 28;
            this.dgvSector.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSector.Size = new System.Drawing.Size(431, 173);
            this.dgvSector.TabIndex = 28;
            this.dgvSector.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSector_CellDoubleClick);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Location = new System.Drawing.Point(318, 263);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(134, 40);
            this.btnCancelar.TabIndex = 29;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnActualizar
            // 
            this.btnActualizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActualizar.Location = new System.Drawing.Point(21, 263);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(134, 40);
            this.btnActualizar.TabIndex = 30;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = true;
            this.btnActualizar.Visible = false;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // FrmSector
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(477, 314);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.dgvSector);
            this.Controls.Add(this.btnAgregarSector);
            this.Controls.Add(this.txtSector);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FrmSector";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sector";
            this.Load += new System.EventHandler(this.FrmSector_Load);
            this.Click += new System.EventHandler(this.FrmSector_Click);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSector)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtSector;
        private System.Windows.Forms.Button btnAgregarSector;
        private System.Windows.Forms.DataGridView dgvSector;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnActualizar;
    }
}