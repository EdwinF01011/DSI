
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmBusqueda));
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblcategoria = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtNombreMenu = new System.Windows.Forms.TextBox();
            this.txtRsocialMenu = new System.Windows.Forms.TextBox();
            this.cboxPaisMenu = new System.Windows.Forms.ComboBox();
            this.cboxCiudadMenu = new System.Windows.Forms.ComboBox();
            this.btnCrearProveedor = new System.Windows.Forms.Button();
            this.btnbuscar = new System.Windows.Forms.Button();
            this.cboxSectorMenu = new System.Windows.Forms.ComboBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.btnCambio = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.plRazon = new System.Windows.Forms.Panel();
            this.plName = new System.Windows.Forms.Panel();
            this.plSector = new System.Windows.Forms.Panel();
            this.plPais = new System.Windows.Forms.Panel();
            this.plCity = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(243)))), ((int)(((byte)(138)))));
            this.panel2.ForeColor = System.Drawing.Color.Transparent;
            this.panel2.Location = new System.Drawing.Point(69, 21);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(10, 33);
            this.panel2.TabIndex = 15;
            // 
            // lblcategoria
            // 
            this.lblcategoria.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblcategoria.AutoSize = true;
            this.lblcategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcategoria.Location = new System.Drawing.Point(87, 21);
            this.lblcategoria.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblcategoria.Name = "lblcategoria";
            this.lblcategoria.Size = new System.Drawing.Size(78, 33);
            this.lblcategoria.TabIndex = 16;
            this.lblcategoria.Text = "nnn*";
            this.lblcategoria.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.SpringGreen;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.SpringGreen;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeight = 34;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.LightCyan;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.GridColor = System.Drawing.Color.Blue;
            this.dataGridView1.Location = new System.Drawing.Point(1, 243);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft YaHei", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Violet;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1547, 777);
            this.dataGridView1.TabIndex = 17;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 152);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(101, 29);
            this.label5.TabIndex = 18;
            this.label5.Text = "Nombre";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(724, 152);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 29);
            this.label6.TabIndex = 19;
            this.label6.Text = "Sector";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(371, 152);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(154, 29);
            this.label8.TabIndex = 20;
            this.label8.Text = "Razón Social";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(1219, 154);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(90, 29);
            this.label9.TabIndex = 23;
            this.label9.Text = "Ciudad";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(965, 149);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(60, 29);
            this.label10.TabIndex = 22;
            this.label10.Text = "País";
            // 
            // txtNombreMenu
            // 
            this.txtNombreMenu.BackColor = System.Drawing.SystemColors.MenuBar;
            this.txtNombreMenu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNombreMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombreMenu.Location = new System.Drawing.Point(16, 182);
            this.txtNombreMenu.MaxLength = 35;
            this.txtNombreMenu.Name = "txtNombreMenu";
            this.txtNombreMenu.Size = new System.Drawing.Size(314, 35);
            this.txtNombreMenu.TabIndex = 1;
            this.txtNombreMenu.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNombreMenu_KeyPress);
            this.txtNombreMenu.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtNombreMenu_KeyUp);
            // 
            // txtRsocialMenu
            // 
            this.txtRsocialMenu.BackColor = System.Drawing.SystemColors.MenuBar;
            this.txtRsocialMenu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtRsocialMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRsocialMenu.Location = new System.Drawing.Point(375, 182);
            this.txtRsocialMenu.MaxLength = 20;
            this.txtRsocialMenu.Name = "txtRsocialMenu";
            this.txtRsocialMenu.Size = new System.Drawing.Size(314, 35);
            this.txtRsocialMenu.TabIndex = 2;
            this.txtRsocialMenu.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtRsocialMenu_KeyPress);
            this.txtRsocialMenu.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtRsocialMenu_KeyUp);
            // 
            // cboxPaisMenu
            // 
            this.cboxPaisMenu.BackColor = System.Drawing.Color.White;
            this.cboxPaisMenu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboxPaisMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboxPaisMenu.FormattingEnabled = true;
            this.cboxPaisMenu.Location = new System.Drawing.Point(969, 181);
            this.cboxPaisMenu.Name = "cboxPaisMenu";
            this.cboxPaisMenu.Size = new System.Drawing.Size(211, 37);
            this.cboxPaisMenu.TabIndex = 4;
            this.cboxPaisMenu.SelectedValueChanged += new System.EventHandler(this.cboxPaisMenu_SelectedValueChanged);
            this.cboxPaisMenu.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cboxPaisMenu_KeyPress);
            // 
            // cboxCiudadMenu
            // 
            this.cboxCiudadMenu.BackColor = System.Drawing.Color.White;
            this.cboxCiudadMenu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboxCiudadMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboxCiudadMenu.FormattingEnabled = true;
            this.cboxCiudadMenu.Location = new System.Drawing.Point(1223, 181);
            this.cboxCiudadMenu.Name = "cboxCiudadMenu";
            this.cboxCiudadMenu.Size = new System.Drawing.Size(211, 37);
            this.cboxCiudadMenu.TabIndex = 5;
            this.cboxCiudadMenu.SelectedIndexChanged += new System.EventHandler(this.cboxCiudadMenu_SelectedIndexChanged);
            this.cboxCiudadMenu.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cboxCiudadMenu_KeyPress);
            // 
            // btnCrearProveedor
            // 
            this.btnCrearProveedor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCrearProveedor.BackColor = System.Drawing.Color.White;
            this.btnCrearProveedor.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCrearProveedor.BackgroundImage")));
            this.btnCrearProveedor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnCrearProveedor.FlatAppearance.BorderSize = 0;
            this.btnCrearProveedor.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnCrearProveedor.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnCrearProveedor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCrearProveedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCrearProveedor.ForeColor = System.Drawing.Color.Coral;
            this.btnCrearProveedor.Location = new System.Drawing.Point(1486, 25);
            this.btnCrearProveedor.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCrearProveedor.Name = "btnCrearProveedor";
            this.btnCrearProveedor.Size = new System.Drawing.Size(53, 48);
            this.btnCrearProveedor.TabIndex = 2;
            this.btnCrearProveedor.UseVisualStyleBackColor = false;
            this.btnCrearProveedor.Click += new System.EventHandler(this.btnCrearProveedor_Click);
            // 
            // btnbuscar
            // 
            this.btnbuscar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnbuscar.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnbuscar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnbuscar.BackgroundImage")));
            this.btnbuscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnbuscar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnbuscar.FlatAppearance.BorderSize = 0;
            this.btnbuscar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.btnbuscar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnbuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnbuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnbuscar.Location = new System.Drawing.Point(1481, 94);
            this.btnbuscar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnbuscar.Name = "btnbuscar";
            this.btnbuscar.Size = new System.Drawing.Size(63, 52);
            this.btnbuscar.TabIndex = 0;
            this.btnbuscar.UseVisualStyleBackColor = false;
            this.btnbuscar.Click += new System.EventHandler(this.btnbuscar_Click);
            // 
            // cboxSectorMenu
            // 
            this.cboxSectorMenu.BackColor = System.Drawing.Color.White;
            this.cboxSectorMenu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboxSectorMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboxSectorMenu.FormattingEnabled = true;
            this.cboxSectorMenu.Location = new System.Drawing.Point(724, 181);
            this.cboxSectorMenu.Name = "cboxSectorMenu";
            this.cboxSectorMenu.Size = new System.Drawing.Size(191, 37);
            this.cboxSectorMenu.TabIndex = 3;
            this.cboxSectorMenu.SelectedValueChanged += new System.EventHandler(this.cboxSectorMenu_SelectedValueChanged);
            this.cboxSectorMenu.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cboxSectorMenu_KeyPress);
            // 
            // btnClear
            // 
            this.btnClear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClear.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnClear.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnClear.BackgroundImage")));
            this.btnClear.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnClear.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnClear.FlatAppearance.BorderSize = 0;
            this.btnClear.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnClear.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(1490, 166);
            this.btnClear.Margin = new System.Windows.Forms.Padding(0);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(45, 58);
            this.btnClear.TabIndex = 6;
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 190);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 29);
            this.label1.TabIndex = 44;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel1.Location = new System.Drawing.Point(17, 232);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1512, 5);
            this.panel1.TabIndex = 45;
            // 
            // panelMenu
            // 
            this.panelMenu.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.panelMenu.Location = new System.Drawing.Point(1, 243);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(1547, 777);
            this.panelMenu.TabIndex = 43;
            // 
            // btnCambio
            // 
            this.btnCambio.BackColor = System.Drawing.Color.White;
            this.btnCambio.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCambio.BackgroundImage")));
            this.btnCambio.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnCambio.FlatAppearance.BorderSize = 0;
            this.btnCambio.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnCambio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCambio.Location = new System.Drawing.Point(1, 12);
            this.btnCambio.Name = "btnCambio";
            this.btnCambio.Size = new System.Drawing.Size(61, 50);
            this.btnCambio.TabIndex = 46;
            this.btnCambio.UseVisualStyleBackColor = false;
            this.btnCambio.Click += new System.EventHandler(this.btnCambio_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Transparent;
            this.panel3.Location = new System.Drawing.Point(1, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(318, 81);
            this.panel3.TabIndex = 47;
            this.panel3.Click += new System.EventHandler(this.panel3_Click);
            // 
            // plRazon
            // 
            this.plRazon.BackColor = System.Drawing.Color.Lime;
            this.plRazon.Location = new System.Drawing.Point(375, 219);
            this.plRazon.Name = "plRazon";
            this.plRazon.Size = new System.Drawing.Size(314, 5);
            this.plRazon.TabIndex = 48;
            this.plRazon.Visible = false;
            // 
            // plName
            // 
            this.plName.BackColor = System.Drawing.Color.Lime;
            this.plName.Location = new System.Drawing.Point(16, 219);
            this.plName.Name = "plName";
            this.plName.Size = new System.Drawing.Size(314, 5);
            this.plName.TabIndex = 49;
            this.plName.Visible = false;
            // 
            // plSector
            // 
            this.plSector.BackColor = System.Drawing.Color.Lime;
            this.plSector.Location = new System.Drawing.Point(724, 219);
            this.plSector.Name = "plSector";
            this.plSector.Size = new System.Drawing.Size(191, 5);
            this.plSector.TabIndex = 50;
            this.plSector.Visible = false;
            // 
            // plPais
            // 
            this.plPais.BackColor = System.Drawing.Color.Lime;
            this.plPais.Location = new System.Drawing.Point(969, 219);
            this.plPais.Name = "plPais";
            this.plPais.Size = new System.Drawing.Size(211, 5);
            this.plPais.TabIndex = 51;
            this.plPais.Visible = false;
            // 
            // plCity
            // 
            this.plCity.BackColor = System.Drawing.Color.Lime;
            this.plCity.Location = new System.Drawing.Point(1223, 219);
            this.plCity.Name = "plCity";
            this.plCity.Size = new System.Drawing.Size(211, 5);
            this.plCity.TabIndex = 52;
            this.plCity.Visible = false;
            // 
            // FrmBusqueda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1552, 1025);
            this.Controls.Add(this.plCity);
            this.Controls.Add(this.plPais);
            this.Controls.Add(this.plSector);
            this.Controls.Add(this.plName);
            this.Controls.Add(this.plRazon);
            this.Controls.Add(this.btnCambio);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnCrearProveedor);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.cboxSectorMenu);
            this.Controls.Add(this.btnbuscar);
            this.Controls.Add(this.cboxCiudadMenu);
            this.Controls.Add(this.cboxPaisMenu);
            this.Controls.Add(this.txtRsocialMenu);
            this.Controls.Add(this.txtNombreMenu);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblcategoria);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panelMenu);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FrmBusqueda";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmBusquedaProvedor";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmBusqueda_Load);
            this.Click += new System.EventHandler(this.FrmBusqueda_Click);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblcategoria;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtNombreMenu;
        private System.Windows.Forms.TextBox txtRsocialMenu;
        private System.Windows.Forms.ComboBox cboxPaisMenu;
        private System.Windows.Forms.ComboBox cboxCiudadMenu;
        private System.Windows.Forms.Button btnCrearProveedor;
        private System.Windows.Forms.Button btnbuscar;
        private System.Windows.Forms.ComboBox cboxSectorMenu;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Button btnCambio;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel plRazon;
        private System.Windows.Forms.Panel plName;
        private System.Windows.Forms.Panel plSector;
        private System.Windows.Forms.Panel plPais;
        private System.Windows.Forms.Panel plCity;
    }
}