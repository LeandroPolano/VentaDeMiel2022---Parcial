namespace VentaDeMiel2022.Windows
{
    partial class frmVentasAE
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
            this.label2 = new System.Windows.Forms.Label();
            this.CancelarIconButton = new FontAwesome.Sharp.IconButton();
            this.CantidadLabel = new System.Windows.Forms.Label();
            this.OKIconButton = new FontAwesome.Sharp.IconButton();
            this.TotalLabel = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.TotalPanel = new System.Windows.Forms.Panel();
            this.CarritoPanel = new System.Windows.Forms.Panel();
            this.CarritoDataGridView = new System.Windows.Forms.DataGridView();
            this.TipoEnvasesComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.EnvaseFlowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.TipoProductosPanel = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.VendedoresComboBox = new System.Windows.Forms.ComboBox();
            this.ClientesComboBox = new System.Windows.Forms.ComboBox();
            this.colEnvase = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPrecio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSubTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAgregar = new System.Windows.Forms.DataGridViewImageColumn();
            this.colQuitar = new System.Windows.Forms.DataGridViewImageColumn();
            this.TotalPanel.SuspendLayout();
            this.CarritoPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CarritoDataGridView)).BeginInit();
            this.TipoProductosPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(535, 91);
            this.label2.TabIndex = 1;
            this.label2.Text = "Carrito Detalle";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CancelarIconButton
            // 
            this.CancelarIconButton.BackColor = System.Drawing.Color.Red;
            this.CancelarIconButton.ForeColor = System.Drawing.Color.White;
            this.CancelarIconButton.IconChar = FontAwesome.Sharp.IconChar.Ban;
            this.CancelarIconButton.IconColor = System.Drawing.Color.White;
            this.CancelarIconButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.CancelarIconButton.IconSize = 32;
            this.CancelarIconButton.Location = new System.Drawing.Point(357, 46);
            this.CancelarIconButton.Margin = new System.Windows.Forms.Padding(4);
            this.CancelarIconButton.Name = "CancelarIconButton";
            this.CancelarIconButton.Size = new System.Drawing.Size(161, 50);
            this.CancelarIconButton.TabIndex = 9;
            this.CancelarIconButton.Text = "Cancelar";
            this.CancelarIconButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.CancelarIconButton.UseVisualStyleBackColor = false;
            // 
            // CantidadLabel
            // 
            this.CantidadLabel.AutoSize = true;
            this.CantidadLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CantidadLabel.ForeColor = System.Drawing.Color.White;
            this.CantidadLabel.Location = new System.Drawing.Point(309, 14);
            this.CantidadLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.CantidadLabel.Name = "CantidadLabel";
            this.CantidadLabel.Size = new System.Drawing.Size(17, 18);
            this.CantidadLabel.TabIndex = 0;
            this.CantidadLabel.Text = "0";
            // 
            // OKIconButton
            // 
            this.OKIconButton.BackColor = System.Drawing.Color.RoyalBlue;
            this.OKIconButton.ForeColor = System.Drawing.Color.White;
            this.OKIconButton.IconChar = FontAwesome.Sharp.IconChar.FloppyDisk;
            this.OKIconButton.IconColor = System.Drawing.Color.White;
            this.OKIconButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.OKIconButton.IconSize = 32;
            this.OKIconButton.Location = new System.Drawing.Point(188, 47);
            this.OKIconButton.Margin = new System.Windows.Forms.Padding(4);
            this.OKIconButton.Name = "OKIconButton";
            this.OKIconButton.Size = new System.Drawing.Size(161, 50);
            this.OKIconButton.TabIndex = 10;
            this.OKIconButton.Text = "OK";
            this.OKIconButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.OKIconButton.UseVisualStyleBackColor = false;
            this.OKIconButton.Click += new System.EventHandler(this.OKIconButton_Click);
            // 
            // TotalLabel
            // 
            this.TotalLabel.AutoSize = true;
            this.TotalLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalLabel.ForeColor = System.Drawing.Color.White;
            this.TotalLabel.Location = new System.Drawing.Point(420, 14);
            this.TotalLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.TotalLabel.Name = "TotalLabel";
            this.TotalLabel.Size = new System.Drawing.Size(17, 18);
            this.TotalLabel.TabIndex = 0;
            this.TotalLabel.Text = "$";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(223, 12);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 18);
            this.label4.TabIndex = 0;
            this.label4.Text = "Cantidad:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(355, 12);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 18);
            this.label3.TabIndex = 0;
            this.label3.Text = "Total:";
            // 
            // TotalPanel
            // 
            this.TotalPanel.BackColor = System.Drawing.Color.ForestGreen;
            this.TotalPanel.Controls.Add(this.CancelarIconButton);
            this.TotalPanel.Controls.Add(this.CantidadLabel);
            this.TotalPanel.Controls.Add(this.OKIconButton);
            this.TotalPanel.Controls.Add(this.TotalLabel);
            this.TotalPanel.Controls.Add(this.label4);
            this.TotalPanel.Controls.Add(this.label3);
            this.TotalPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.TotalPanel.Location = new System.Drawing.Point(0, 350);
            this.TotalPanel.Margin = new System.Windows.Forms.Padding(4);
            this.TotalPanel.Name = "TotalPanel";
            this.TotalPanel.Size = new System.Drawing.Size(602, 100);
            this.TotalPanel.TabIndex = 1;
            // 
            // CarritoPanel
            // 
            this.CarritoPanel.BackColor = System.Drawing.Color.ForestGreen;
            this.CarritoPanel.Controls.Add(this.label2);
            this.CarritoPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.CarritoPanel.Location = new System.Drawing.Point(0, 0);
            this.CarritoPanel.Margin = new System.Windows.Forms.Padding(4);
            this.CarritoPanel.Name = "CarritoPanel";
            this.CarritoPanel.Size = new System.Drawing.Size(602, 91);
            this.CarritoPanel.TabIndex = 0;
            // 
            // CarritoDataGridView
            // 
            this.CarritoDataGridView.AllowUserToAddRows = false;
            this.CarritoDataGridView.AllowUserToDeleteRows = false;
            this.CarritoDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CarritoDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colEnvase,
            this.colPrecio,
            this.colCantidad,
            this.colSubTotal,
            this.colAgregar,
            this.colQuitar});
            this.CarritoDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CarritoDataGridView.Location = new System.Drawing.Point(0, 91);
            this.CarritoDataGridView.Margin = new System.Windows.Forms.Padding(4);
            this.CarritoDataGridView.MultiSelect = false;
            this.CarritoDataGridView.Name = "CarritoDataGridView";
            this.CarritoDataGridView.ReadOnly = true;
            this.CarritoDataGridView.RowHeadersWidth = 51;
            this.CarritoDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.CarritoDataGridView.Size = new System.Drawing.Size(602, 259);
            this.CarritoDataGridView.TabIndex = 2;
            this.CarritoDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.CarritoDataGridView_CellContentClick);
            // 
            // TipoEnvasesComboBox
            // 
            this.TipoEnvasesComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.TipoEnvasesComboBox.FormattingEnabled = true;
            this.TipoEnvasesComboBox.Location = new System.Drawing.Point(141, 8);
            this.TipoEnvasesComboBox.Margin = new System.Windows.Forms.Padding(4);
            this.TipoEnvasesComboBox.Name = "TipoEnvasesComboBox";
            this.TipoEnvasesComboBox.Size = new System.Drawing.Size(273, 24);
            this.TipoEnvasesComboBox.TabIndex = 1;
            this.TipoEnvasesComboBox.SelectedIndexChanged += new System.EventHandler(this.TipoEnvasesComboBox_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(13, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tipo de Envase:";
            // 
            // EnvaseFlowLayoutPanel
            // 
            this.EnvaseFlowLayoutPanel.AutoScroll = true;
            this.EnvaseFlowLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.EnvaseFlowLayoutPanel.Location = new System.Drawing.Point(0, 91);
            this.EnvaseFlowLayoutPanel.Margin = new System.Windows.Forms.Padding(4);
            this.EnvaseFlowLayoutPanel.Name = "EnvaseFlowLayoutPanel";
            this.EnvaseFlowLayoutPanel.Size = new System.Drawing.Size(837, 359);
            this.EnvaseFlowLayoutPanel.TabIndex = 1;
            // 
            // TipoProductosPanel
            // 
            this.TipoProductosPanel.BackColor = System.Drawing.Color.RoyalBlue;
            this.TipoProductosPanel.Controls.Add(this.label6);
            this.TipoProductosPanel.Controls.Add(this.ClientesComboBox);
            this.TipoProductosPanel.Controls.Add(this.VendedoresComboBox);
            this.TipoProductosPanel.Controls.Add(this.label5);
            this.TipoProductosPanel.Controls.Add(this.TipoEnvasesComboBox);
            this.TipoProductosPanel.Controls.Add(this.label1);
            this.TipoProductosPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.TipoProductosPanel.Location = new System.Drawing.Point(0, 0);
            this.TipoProductosPanel.Margin = new System.Windows.Forms.Padding(4);
            this.TipoProductosPanel.Name = "TipoProductosPanel";
            this.TipoProductosPanel.Size = new System.Drawing.Size(837, 91);
            this.TipoProductosPanel.TabIndex = 0;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(68, 41);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 18);
            this.label6.TabIndex = 4;
            this.label6.Text = "Cliente:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(457, 9);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 18);
            this.label5.TabIndex = 2;
            this.label5.Text = "Vendedor:";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(4);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.EnvaseFlowLayoutPanel);
            this.splitContainer1.Panel1.Controls.Add(this.TipoProductosPanel);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.CarritoDataGridView);
            this.splitContainer1.Panel2.Controls.Add(this.TotalPanel);
            this.splitContainer1.Panel2.Controls.Add(this.CarritoPanel);
            this.splitContainer1.Size = new System.Drawing.Size(1444, 450);
            this.splitContainer1.SplitterDistance = 837;
            this.splitContainer1.SplitterWidth = 5;
            this.splitContainer1.TabIndex = 1;
            // 
            // VendedoresComboBox
            // 
            this.VendedoresComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.VendedoresComboBox.FormattingEnabled = true;
            this.VendedoresComboBox.Location = new System.Drawing.Point(549, 8);
            this.VendedoresComboBox.Margin = new System.Windows.Forms.Padding(4);
            this.VendedoresComboBox.Name = "VendedoresComboBox";
            this.VendedoresComboBox.Size = new System.Drawing.Size(273, 24);
            this.VendedoresComboBox.TabIndex = 3;
            this.VendedoresComboBox.SelectedIndexChanged += new System.EventHandler(this.VendedoresComboBox_SelectedIndexChanged);
            // 
            // ClientesComboBox
            // 
            this.ClientesComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ClientesComboBox.FormattingEnabled = true;
            this.ClientesComboBox.Location = new System.Drawing.Point(141, 40);
            this.ClientesComboBox.Margin = new System.Windows.Forms.Padding(4);
            this.ClientesComboBox.Name = "ClientesComboBox";
            this.ClientesComboBox.Size = new System.Drawing.Size(273, 24);
            this.ClientesComboBox.TabIndex = 5;
            this.ClientesComboBox.SelectedIndexChanged += new System.EventHandler(this.ClientesComboBox_SelectedIndexChanged);
            // 
            // colEnvase
            // 
            this.colEnvase.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colEnvase.HeaderText = "Envase";
            this.colEnvase.MinimumWidth = 6;
            this.colEnvase.Name = "colEnvase";
            this.colEnvase.ReadOnly = true;
            // 
            // colPrecio
            // 
            this.colPrecio.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.colPrecio.HeaderText = "Precio";
            this.colPrecio.MinimumWidth = 6;
            this.colPrecio.Name = "colPrecio";
            this.colPrecio.ReadOnly = true;
            this.colPrecio.Width = 75;
            // 
            // colCantidad
            // 
            this.colCantidad.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.colCantidad.HeaderText = "Cant.";
            this.colCantidad.MinimumWidth = 6;
            this.colCantidad.Name = "colCantidad";
            this.colCantidad.ReadOnly = true;
            this.colCantidad.Width = 66;
            // 
            // colSubTotal
            // 
            this.colSubTotal.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.colSubTotal.HeaderText = "SubTot.";
            this.colSubTotal.MinimumWidth = 6;
            this.colSubTotal.Name = "colSubTotal";
            this.colSubTotal.ReadOnly = true;
            this.colSubTotal.Width = 83;
            // 
            // colAgregar
            // 
            this.colAgregar.HeaderText = "";
            this.colAgregar.MinimumWidth = 6;
            this.colAgregar.Name = "colAgregar";
            this.colAgregar.ReadOnly = true;
            this.colAgregar.Width = 20;
            // 
            // colQuitar
            // 
            this.colQuitar.HeaderText = "";
            this.colQuitar.MinimumWidth = 6;
            this.colQuitar.Name = "colQuitar";
            this.colQuitar.ReadOnly = true;
            this.colQuitar.Width = 20;
            // 
            // frmVentasAE
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1444, 450);
            this.Controls.Add(this.splitContainer1);
            this.Name = "frmVentasAE";
            this.Text = "FrmVentasAE";
            this.Load += new System.EventHandler(this.frmVentasAE_Load);
            this.TotalPanel.ResumeLayout(false);
            this.TotalPanel.PerformLayout();
            this.CarritoPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.CarritoDataGridView)).EndInit();
            this.TipoProductosPanel.ResumeLayout(false);
            this.TipoProductosPanel.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private FontAwesome.Sharp.IconButton CancelarIconButton;
        private System.Windows.Forms.Label CantidadLabel;
        private FontAwesome.Sharp.IconButton OKIconButton;
        private System.Windows.Forms.Label TotalLabel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel TotalPanel;
        private System.Windows.Forms.Panel CarritoPanel;
        private System.Windows.Forms.DataGridView CarritoDataGridView;
        private System.Windows.Forms.ComboBox TipoEnvasesComboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FlowLayoutPanel EnvaseFlowLayoutPanel;
        private System.Windows.Forms.Panel TipoProductosPanel;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEnvase;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPrecio;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSubTotal;
        private System.Windows.Forms.DataGridViewImageColumn colAgregar;
        private System.Windows.Forms.DataGridViewImageColumn colQuitar;
        private System.Windows.Forms.ComboBox ClientesComboBox;
        private System.Windows.Forms.ComboBox VendedoresComboBox;
    }
}