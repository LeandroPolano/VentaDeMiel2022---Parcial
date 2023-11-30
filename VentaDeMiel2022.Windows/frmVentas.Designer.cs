
namespace VentaDeMiel2022.Windows
{
    partial class frmVentas
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
            this.DatosDataGridView = new System.Windows.Forms.DataGridView();
            this.colVenta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colImporte = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEstado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.CobrarIconButton = new FontAwesome.Sharp.IconButton();
            this.DetalleIconButton = new FontAwesome.Sharp.IconButton();
            this.CerrarIconButton = new FontAwesome.Sharp.IconButton();
            this.AnularIconButton = new FontAwesome.Sharp.IconButton();
            this.NuevoIconButton = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)(this.DatosDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // DatosDataGridView
            // 
            this.DatosDataGridView.AllowUserToAddRows = false;
            this.DatosDataGridView.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.DatosDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(2);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DatosDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.DatosDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DatosDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colVenta,
            this.colFecha,
            this.colImporte,
            this.colEstado});
            this.DatosDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DatosDataGridView.Location = new System.Drawing.Point(0, 0);
            this.DatosDataGridView.Margin = new System.Windows.Forms.Padding(4);
            this.DatosDataGridView.MultiSelect = false;
            this.DatosDataGridView.Name = "DatosDataGridView";
            this.DatosDataGridView.ReadOnly = true;
            this.DatosDataGridView.RowHeadersWidth = 51;
            this.DatosDataGridView.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DatosDataGridView.RowTemplate.Height = 28;
            this.DatosDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DatosDataGridView.Size = new System.Drawing.Size(1556, 633);
            this.DatosDataGridView.TabIndex = 0;
            // 
            // colVenta
            // 
            this.colVenta.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.colVenta.HeaderText = "Venta Nro.";
            this.colVenta.MinimumWidth = 6;
            this.colVenta.Name = "colVenta";
            this.colVenta.ReadOnly = true;
            this.colVenta.Width = 121;
            // 
            // colFecha
            // 
            this.colFecha.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colFecha.HeaderText = "Fecha";
            this.colFecha.MinimumWidth = 6;
            this.colFecha.Name = "colFecha";
            this.colFecha.ReadOnly = true;
            // 
            // colImporte
            // 
            this.colImporte.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colImporte.HeaderText = "Importe";
            this.colImporte.MinimumWidth = 6;
            this.colImporte.Name = "colImporte";
            this.colImporte.ReadOnly = true;
            // 
            // colEstado
            // 
            this.colEstado.HeaderText = "Estado";
            this.colEstado.MinimumWidth = 6;
            this.colEstado.Name = "colEstado";
            this.colEstado.ReadOnly = true;
            this.colEstado.Width = 125;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(4);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.CobrarIconButton);
            this.splitContainer1.Panel1.Controls.Add(this.DetalleIconButton);
            this.splitContainer1.Panel1.Controls.Add(this.CerrarIconButton);
            this.splitContainer1.Panel1.Controls.Add(this.AnularIconButton);
            this.splitContainer1.Panel1.Controls.Add(this.NuevoIconButton);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.DatosDataGridView);
            this.splitContainer1.Size = new System.Drawing.Size(1556, 740);
            this.splitContainer1.SplitterDistance = 102;
            this.splitContainer1.SplitterWidth = 5;
            this.splitContainer1.TabIndex = 4;
            // 
            // CobrarIconButton
            // 
            this.CobrarIconButton.BackColor = System.Drawing.Color.Transparent;
            this.CobrarIconButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CobrarIconButton.IconChar = FontAwesome.Sharp.IconChar.DollarSign;
            this.CobrarIconButton.IconColor = System.Drawing.Color.DarkGoldenrod;
            this.CobrarIconButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.CobrarIconButton.Location = new System.Drawing.Point(315, 15);
            this.CobrarIconButton.Margin = new System.Windows.Forms.Padding(4);
            this.CobrarIconButton.Name = "CobrarIconButton";
            this.CobrarIconButton.Size = new System.Drawing.Size(83, 78);
            this.CobrarIconButton.TabIndex = 5;
            this.CobrarIconButton.Text = "Cobrar";
            this.CobrarIconButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.CobrarIconButton.UseVisualStyleBackColor = false;
            this.CobrarIconButton.Click += new System.EventHandler(this.CobrarIconButton_Click);
            // 
            // DetalleIconButton
            // 
            this.DetalleIconButton.BackColor = System.Drawing.Color.Transparent;
            this.DetalleIconButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DetalleIconButton.IconChar = FontAwesome.Sharp.IconChar.Info;
            this.DetalleIconButton.IconColor = System.Drawing.Color.Green;
            this.DetalleIconButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.DetalleIconButton.Location = new System.Drawing.Point(425, 15);
            this.DetalleIconButton.Margin = new System.Windows.Forms.Padding(4);
            this.DetalleIconButton.Name = "DetalleIconButton";
            this.DetalleIconButton.Size = new System.Drawing.Size(83, 78);
            this.DetalleIconButton.TabIndex = 6;
            this.DetalleIconButton.Text = "Detalle";
            this.DetalleIconButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.DetalleIconButton.UseVisualStyleBackColor = false;
            this.DetalleIconButton.Click += new System.EventHandler(this.DetalleIconButton_Click);
            // 
            // CerrarIconButton
            // 
            this.CerrarIconButton.BackColor = System.Drawing.Color.Transparent;
            this.CerrarIconButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CerrarIconButton.IconChar = FontAwesome.Sharp.IconChar.Ban;
            this.CerrarIconButton.IconColor = System.Drawing.Color.Red;
            this.CerrarIconButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.CerrarIconButton.Location = new System.Drawing.Point(1441, 15);
            this.CerrarIconButton.Margin = new System.Windows.Forms.Padding(4);
            this.CerrarIconButton.Name = "CerrarIconButton";
            this.CerrarIconButton.Size = new System.Drawing.Size(83, 78);
            this.CerrarIconButton.TabIndex = 0;
            this.CerrarIconButton.Text = "Cerrar";
            this.CerrarIconButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.CerrarIconButton.UseVisualStyleBackColor = false;
            this.CerrarIconButton.Click += new System.EventHandler(this.CerrarIconButton_Click);
            // 
            // AnularIconButton
            // 
            this.AnularIconButton.BackColor = System.Drawing.Color.Transparent;
            this.AnularIconButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AnularIconButton.IconChar = FontAwesome.Sharp.IconChar.TrashAlt;
            this.AnularIconButton.IconColor = System.Drawing.Color.Red;
            this.AnularIconButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.AnularIconButton.Location = new System.Drawing.Point(113, 15);
            this.AnularIconButton.Margin = new System.Windows.Forms.Padding(4);
            this.AnularIconButton.Name = "AnularIconButton";
            this.AnularIconButton.Size = new System.Drawing.Size(83, 78);
            this.AnularIconButton.TabIndex = 0;
            this.AnularIconButton.Text = "Anular";
            this.AnularIconButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.AnularIconButton.UseVisualStyleBackColor = false;
            this.AnularIconButton.Click += new System.EventHandler(this.AnularIconButton_Click);
            // 
            // NuevoIconButton
            // 
            this.NuevoIconButton.BackColor = System.Drawing.Color.Transparent;
            this.NuevoIconButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.NuevoIconButton.IconChar = FontAwesome.Sharp.IconChar.File;
            this.NuevoIconButton.IconColor = System.Drawing.Color.LimeGreen;
            this.NuevoIconButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.NuevoIconButton.Location = new System.Drawing.Point(23, 15);
            this.NuevoIconButton.Margin = new System.Windows.Forms.Padding(4);
            this.NuevoIconButton.Name = "NuevoIconButton";
            this.NuevoIconButton.Size = new System.Drawing.Size(83, 78);
            this.NuevoIconButton.TabIndex = 0;
            this.NuevoIconButton.Text = "Nuevo";
            this.NuevoIconButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.NuevoIconButton.UseVisualStyleBackColor = false;
            this.NuevoIconButton.Click += new System.EventHandler(this.NuevoIconButton_Click);
            // 
            // frmVentas
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1556, 740);
            this.Controls.Add(this.splitContainer1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmVentas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmVentas";
            this.Load += new System.EventHandler(this.frmVentas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DatosDataGridView)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private FontAwesome.Sharp.IconButton NuevoIconButton;
        private System.Windows.Forms.DataGridView DatosDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn colVenta;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn colImporte;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEstado;
        private FontAwesome.Sharp.IconButton DetalleIconButton;
        private FontAwesome.Sharp.IconButton AnularIconButton;
        private FontAwesome.Sharp.IconButton CobrarIconButton;
        private FontAwesome.Sharp.IconButton CerrarIconButton;
        private System.Windows.Forms.SplitContainer splitContainer1;
    }
}