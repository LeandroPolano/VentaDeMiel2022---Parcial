
namespace VentaDeMiel2022.Windows
{
    partial class FrmEnvases
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.PrecioDescIconButton = new FontAwesome.Sharp.IconButton();
            this.OrdenarPrecioAsciIconButton = new FontAwesome.Sharp.IconButton();
            this.OrdenarZAPorEnvaseiconButton = new FontAwesome.Sharp.IconButton();
            this.OredenarAZPorEnvaseiconButton = new FontAwesome.Sharp.IconButton();
            this.CerrarIconButton = new FontAwesome.Sharp.IconButton();
            this.FiltrariconButton = new FontAwesome.Sharp.IconButton();
            this.EditarIconButton = new FontAwesome.Sharp.IconButton();
            this.BorrarIconButton = new FontAwesome.Sharp.IconButton();
            this.NuevoIconButton = new FontAwesome.Sharp.IconButton();
            this.DatosDataGridView = new System.Windows.Forms.DataGridView();
            this.colEnvase = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPrecio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colStock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DatosDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.PrecioDescIconButton);
            this.splitContainer1.Panel1.Controls.Add(this.OrdenarPrecioAsciIconButton);
            this.splitContainer1.Panel1.Controls.Add(this.OrdenarZAPorEnvaseiconButton);
            this.splitContainer1.Panel1.Controls.Add(this.OredenarAZPorEnvaseiconButton);
            this.splitContainer1.Panel1.Controls.Add(this.CerrarIconButton);
            this.splitContainer1.Panel1.Controls.Add(this.FiltrariconButton);
            this.splitContainer1.Panel1.Controls.Add(this.EditarIconButton);
            this.splitContainer1.Panel1.Controls.Add(this.BorrarIconButton);
            this.splitContainer1.Panel1.Controls.Add(this.NuevoIconButton);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.DatosDataGridView);
            this.splitContainer1.Size = new System.Drawing.Size(1067, 554);
            this.splitContainer1.SplitterDistance = 98;
            this.splitContainer1.SplitterWidth = 5;
            this.splitContainer1.TabIndex = 2;
            // 
            // PrecioDescIconButton
            // 
            this.PrecioDescIconButton.BackColor = System.Drawing.Color.Transparent;
            this.PrecioDescIconButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PrecioDescIconButton.IconChar = FontAwesome.Sharp.IconChar.SortNumericDesc;
            this.PrecioDescIconButton.IconColor = System.Drawing.Color.DodgerBlue;
            this.PrecioDescIconButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.PrecioDescIconButton.Location = new System.Drawing.Point(731, 15);
            this.PrecioDescIconButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.PrecioDescIconButton.Name = "PrecioDescIconButton";
            this.PrecioDescIconButton.Size = new System.Drawing.Size(76, 78);
            this.PrecioDescIconButton.TabIndex = 1;
            this.PrecioDescIconButton.Text = " Asc";
            this.PrecioDescIconButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.PrecioDescIconButton.UseVisualStyleBackColor = false;
            this.PrecioDescIconButton.Click += new System.EventHandler(this.PrecioDescIconButton_Click);
            // 
            // OrdenarPrecioAsciIconButton
            // 
            this.OrdenarPrecioAsciIconButton.BackColor = System.Drawing.Color.Transparent;
            this.OrdenarPrecioAsciIconButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.OrdenarPrecioAsciIconButton.IconChar = FontAwesome.Sharp.IconChar.ArrowDown19;
            this.OrdenarPrecioAsciIconButton.IconColor = System.Drawing.Color.DodgerBlue;
            this.OrdenarPrecioAsciIconButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.OrdenarPrecioAsciIconButton.Location = new System.Drawing.Point(647, 15);
            this.OrdenarPrecioAsciIconButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.OrdenarPrecioAsciIconButton.Name = "OrdenarPrecioAsciIconButton";
            this.OrdenarPrecioAsciIconButton.Size = new System.Drawing.Size(76, 78);
            this.OrdenarPrecioAsciIconButton.TabIndex = 2;
            this.OrdenarPrecioAsciIconButton.Text = " Asc";
            this.OrdenarPrecioAsciIconButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.OrdenarPrecioAsciIconButton.UseVisualStyleBackColor = false;
            this.OrdenarPrecioAsciIconButton.Click += new System.EventHandler(this.OrdenarPrecioAsciIconButton_Click);
            // 
            // OrdenarZAPorEnvaseiconButton
            // 
            this.OrdenarZAPorEnvaseiconButton.BackColor = System.Drawing.Color.Transparent;
            this.OrdenarZAPorEnvaseiconButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.OrdenarZAPorEnvaseiconButton.IconChar = FontAwesome.Sharp.IconChar.SortAlphaDesc;
            this.OrdenarZAPorEnvaseiconButton.IconColor = System.Drawing.Color.DodgerBlue;
            this.OrdenarZAPorEnvaseiconButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.OrdenarZAPorEnvaseiconButton.Location = new System.Drawing.Point(561, 15);
            this.OrdenarZAPorEnvaseiconButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.OrdenarZAPorEnvaseiconButton.Name = "OrdenarZAPorEnvaseiconButton";
            this.OrdenarZAPorEnvaseiconButton.Size = new System.Drawing.Size(77, 78);
            this.OrdenarZAPorEnvaseiconButton.TabIndex = 3;
            this.OrdenarZAPorEnvaseiconButton.Text = "Alfa Z-A";
            this.OrdenarZAPorEnvaseiconButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.OrdenarZAPorEnvaseiconButton.UseVisualStyleBackColor = false;
            this.OrdenarZAPorEnvaseiconButton.Click += new System.EventHandler(this.OrdenarZAPorEnvaseiconButton_Click);
            // 
            // OredenarAZPorEnvaseiconButton
            // 
            this.OredenarAZPorEnvaseiconButton.BackColor = System.Drawing.Color.Transparent;
            this.OredenarAZPorEnvaseiconButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.OredenarAZPorEnvaseiconButton.IconChar = FontAwesome.Sharp.IconChar.SortAlphaDown;
            this.OredenarAZPorEnvaseiconButton.IconColor = System.Drawing.Color.DodgerBlue;
            this.OredenarAZPorEnvaseiconButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.OredenarAZPorEnvaseiconButton.Location = new System.Drawing.Point(476, 15);
            this.OredenarAZPorEnvaseiconButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.OredenarAZPorEnvaseiconButton.Name = "OredenarAZPorEnvaseiconButton";
            this.OredenarAZPorEnvaseiconButton.Size = new System.Drawing.Size(77, 78);
            this.OredenarAZPorEnvaseiconButton.TabIndex = 4;
            this.OredenarAZPorEnvaseiconButton.Text = "Alfa A-Z";
            this.OredenarAZPorEnvaseiconButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.OredenarAZPorEnvaseiconButton.UseVisualStyleBackColor = false;
            this.OredenarAZPorEnvaseiconButton.Click += new System.EventHandler(this.OredenarAZPorEnvaseiconButton_Click);
            // 
            // CerrarIconButton
            // 
            this.CerrarIconButton.BackColor = System.Drawing.Color.Transparent;
            this.CerrarIconButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CerrarIconButton.IconChar = FontAwesome.Sharp.IconChar.Ban;
            this.CerrarIconButton.IconColor = System.Drawing.Color.Red;
            this.CerrarIconButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.CerrarIconButton.Location = new System.Drawing.Point(968, 15);
            this.CerrarIconButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.CerrarIconButton.Name = "CerrarIconButton";
            this.CerrarIconButton.Size = new System.Drawing.Size(83, 78);
            this.CerrarIconButton.TabIndex = 0;
            this.CerrarIconButton.Text = "Cerrar";
            this.CerrarIconButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.CerrarIconButton.UseVisualStyleBackColor = false;
            this.CerrarIconButton.Click += new System.EventHandler(this.CerrarIconButton_Click);
            // 
            // FiltrariconButton
            // 
            this.FiltrariconButton.BackColor = System.Drawing.Color.Transparent;
            this.FiltrariconButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.FiltrariconButton.IconChar = FontAwesome.Sharp.IconChar.Filter;
            this.FiltrariconButton.IconColor = System.Drawing.Color.Blue;
            this.FiltrariconButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.FiltrariconButton.Location = new System.Drawing.Point(333, 15);
            this.FiltrariconButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.FiltrariconButton.Name = "FiltrariconButton";
            this.FiltrariconButton.Size = new System.Drawing.Size(83, 78);
            this.FiltrariconButton.TabIndex = 0;
            this.FiltrariconButton.Text = "Filtrar";
            this.FiltrariconButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.FiltrariconButton.UseVisualStyleBackColor = false;
            this.FiltrariconButton.Click += new System.EventHandler(this.FiltrariconButton_Click);
            // 
            // EditarIconButton
            // 
            this.EditarIconButton.BackColor = System.Drawing.Color.Transparent;
            this.EditarIconButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EditarIconButton.IconChar = FontAwesome.Sharp.IconChar.Pen;
            this.EditarIconButton.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.EditarIconButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.EditarIconButton.Location = new System.Drawing.Point(204, 15);
            this.EditarIconButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.EditarIconButton.Name = "EditarIconButton";
            this.EditarIconButton.Size = new System.Drawing.Size(83, 78);
            this.EditarIconButton.TabIndex = 0;
            this.EditarIconButton.Text = "Editar";
            this.EditarIconButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.EditarIconButton.UseVisualStyleBackColor = false;
            this.EditarIconButton.Click += new System.EventHandler(this.EditarIconButton_Click);
            // 
            // BorrarIconButton
            // 
            this.BorrarIconButton.BackColor = System.Drawing.Color.Transparent;
            this.BorrarIconButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BorrarIconButton.IconChar = FontAwesome.Sharp.IconChar.TrashAlt;
            this.BorrarIconButton.IconColor = System.Drawing.Color.Red;
            this.BorrarIconButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BorrarIconButton.Location = new System.Drawing.Point(113, 15);
            this.BorrarIconButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BorrarIconButton.Name = "BorrarIconButton";
            this.BorrarIconButton.Size = new System.Drawing.Size(83, 78);
            this.BorrarIconButton.TabIndex = 0;
            this.BorrarIconButton.Text = "Borrar";
            this.BorrarIconButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.BorrarIconButton.UseVisualStyleBackColor = false;
            this.BorrarIconButton.Click += new System.EventHandler(this.BorrarIconButton_Click);
            // 
            // NuevoIconButton
            // 
            this.NuevoIconButton.BackColor = System.Drawing.Color.Transparent;
            this.NuevoIconButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.NuevoIconButton.IconChar = FontAwesome.Sharp.IconChar.File;
            this.NuevoIconButton.IconColor = System.Drawing.Color.LimeGreen;
            this.NuevoIconButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.NuevoIconButton.Location = new System.Drawing.Point(23, 15);
            this.NuevoIconButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.NuevoIconButton.Name = "NuevoIconButton";
            this.NuevoIconButton.Size = new System.Drawing.Size(83, 78);
            this.NuevoIconButton.TabIndex = 0;
            this.NuevoIconButton.Text = "Nuevo";
            this.NuevoIconButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.NuevoIconButton.UseVisualStyleBackColor = false;
            this.NuevoIconButton.Click += new System.EventHandler(this.NuevoIconButton_Click);
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
            this.colEnvase,
            this.colTipo,
            this.colPrecio,
            this.colStock});
            this.DatosDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DatosDataGridView.Location = new System.Drawing.Point(0, 0);
            this.DatosDataGridView.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.DatosDataGridView.MultiSelect = false;
            this.DatosDataGridView.Name = "DatosDataGridView";
            this.DatosDataGridView.ReadOnly = true;
            this.DatosDataGridView.RowHeadersWidth = 51;
            this.DatosDataGridView.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DatosDataGridView.RowTemplate.Height = 28;
            this.DatosDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DatosDataGridView.Size = new System.Drawing.Size(1067, 451);
            this.DatosDataGridView.TabIndex = 0;
            // 
            // colEnvase
            // 
            this.colEnvase.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colEnvase.HeaderText = "Envase";
            this.colEnvase.MinimumWidth = 6;
            this.colEnvase.Name = "colEnvase";
            this.colEnvase.ReadOnly = true;
            // 
            // colTipo
            // 
            this.colTipo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colTipo.HeaderText = "Tipo de Envase";
            this.colTipo.MinimumWidth = 6;
            this.colTipo.Name = "colTipo";
            this.colTipo.ReadOnly = true;
            this.colTipo.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // colPrecio
            // 
            this.colPrecio.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.colPrecio.DefaultCellStyle = dataGridViewCellStyle3;
            this.colPrecio.HeaderText = "Precio";
            this.colPrecio.MinimumWidth = 6;
            this.colPrecio.Name = "colPrecio";
            this.colPrecio.ReadOnly = true;
            this.colPrecio.Width = 90;
            // 
            // colStock
            // 
            this.colStock.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.colStock.DefaultCellStyle = dataGridViewCellStyle4;
            this.colStock.HeaderText = "Stock";
            this.colStock.MinimumWidth = 6;
            this.colStock.Name = "colStock";
            this.colStock.ReadOnly = true;
            this.colStock.Width = 85;
            // 
            // FrmEnvases
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.splitContainer1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FrmEnvases";
            this.Text = "frmEnvases";
            this.Load += new System.EventHandler(this.frmEnvases_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DatosDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private FontAwesome.Sharp.IconButton CerrarIconButton;
        private FontAwesome.Sharp.IconButton EditarIconButton;
        private FontAwesome.Sharp.IconButton BorrarIconButton;
        private FontAwesome.Sharp.IconButton NuevoIconButton;
        private System.Windows.Forms.DataGridView DatosDataGridView;
        private FontAwesome.Sharp.IconButton FiltrariconButton;
        private FontAwesome.Sharp.IconButton PrecioDescIconButton;
        private FontAwesome.Sharp.IconButton OrdenarPrecioAsciIconButton;
        private FontAwesome.Sharp.IconButton OrdenarZAPorEnvaseiconButton;
        private FontAwesome.Sharp.IconButton OredenarAZPorEnvaseiconButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEnvase;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTipo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPrecio;
        private System.Windows.Forms.DataGridViewTextBoxColumn colStock;
    }
}