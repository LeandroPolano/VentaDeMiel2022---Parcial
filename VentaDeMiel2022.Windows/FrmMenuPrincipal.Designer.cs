
namespace VentaDeMiel2022.Windows
{
    partial class FrmMenuPrincipal
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.label1 = new System.Windows.Forms.Label();
            this.CerrarButton = new System.Windows.Forms.Button();
            this.LocalidadButton = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.ProvinciaButton = new System.Windows.Forms.Button();
            this.TipoEnvaseButton = new System.Windows.Forms.Button();
            this.PaisButton = new System.Windows.Forms.Button();
            this.ClientesButton = new System.Windows.Forms.Button();
            this.VendedorButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
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
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.VendedorButton);
            this.splitContainer1.Panel2.Controls.Add(this.CerrarButton);
            this.splitContainer1.Panel2.Controls.Add(this.LocalidadButton);
            this.splitContainer1.Panel2.Controls.Add(this.button6);
            this.splitContainer1.Panel2.Controls.Add(this.ProvinciaButton);
            this.splitContainer1.Panel2.Controls.Add(this.TipoEnvaseButton);
            this.splitContainer1.Panel2.Controls.Add(this.PaisButton);
            this.splitContainer1.Panel2.Controls.Add(this.ClientesButton);
            this.splitContainer1.Panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer1_Panel2_Paint);
            this.splitContainer1.Size = new System.Drawing.Size(516, 536);
            this.splitContainer1.SplitterDistance = 69;
            this.splitContainer1.SplitterWidth = 5;
            this.splitContainer1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.CadetBlue;
            this.label1.Font = new System.Drawing.Font("HP Simplified", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(-8, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(524, 68);
            this.label1.TabIndex = 0;
            this.label1.Text = "Venta De Miel";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CerrarButton
            // 
            this.CerrarButton.BackColor = System.Drawing.Color.Maroon;
            this.CerrarButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.CerrarButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.CerrarButton.Font = new System.Drawing.Font("Open Sans", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CerrarButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.CerrarButton.Location = new System.Drawing.Point(333, 374);
            this.CerrarButton.Name = "CerrarButton";
            this.CerrarButton.Size = new System.Drawing.Size(161, 68);
            this.CerrarButton.TabIndex = 7;
            this.CerrarButton.Text = "Cerrar";
            this.CerrarButton.UseVisualStyleBackColor = false;
            this.CerrarButton.Click += new System.EventHandler(this.CerrarButton_Click);
            // 
            // LocalidadButton
            // 
            this.LocalidadButton.BackColor = System.Drawing.Color.RoyalBlue;
            this.LocalidadButton.Font = new System.Drawing.Font("HP Simplified", 10.8F);
            this.LocalidadButton.ForeColor = System.Drawing.SystemColors.Control;
            this.LocalidadButton.Location = new System.Drawing.Point(12, 4);
            this.LocalidadButton.Name = "LocalidadButton";
            this.LocalidadButton.Size = new System.Drawing.Size(161, 68);
            this.LocalidadButton.TabIndex = 5;
            this.LocalidadButton.Text = "Localidades";
            this.LocalidadButton.UseVisualStyleBackColor = false;
            this.LocalidadButton.Click += new System.EventHandler(this.LocalidadButton_Click);
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.RoyalBlue;
            this.button6.Font = new System.Drawing.Font("HP Simplified", 10.8F);
            this.button6.ForeColor = System.Drawing.SystemColors.Control;
            this.button6.Location = new System.Drawing.Point(12, 374);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(161, 68);
            this.button6.TabIndex = 4;
            this.button6.Text = "Tipo De Documento";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // ProvinciaButton
            // 
            this.ProvinciaButton.BackColor = System.Drawing.Color.RoyalBlue;
            this.ProvinciaButton.Font = new System.Drawing.Font("HP Simplified", 10.8F);
            this.ProvinciaButton.ForeColor = System.Drawing.SystemColors.Control;
            this.ProvinciaButton.Location = new System.Drawing.Point(12, 300);
            this.ProvinciaButton.Name = "ProvinciaButton";
            this.ProvinciaButton.Size = new System.Drawing.Size(161, 68);
            this.ProvinciaButton.TabIndex = 3;
            this.ProvinciaButton.Text = "Provincia";
            this.ProvinciaButton.UseVisualStyleBackColor = false;
            this.ProvinciaButton.Click += new System.EventHandler(this.ProvinciaButton_Click);
            // 
            // TipoEnvaseButton
            // 
            this.TipoEnvaseButton.BackColor = System.Drawing.Color.RoyalBlue;
            this.TipoEnvaseButton.Font = new System.Drawing.Font("HP Simplified", 10.8F);
            this.TipoEnvaseButton.ForeColor = System.Drawing.SystemColors.Control;
            this.TipoEnvaseButton.Location = new System.Drawing.Point(12, 78);
            this.TipoEnvaseButton.Name = "TipoEnvaseButton";
            this.TipoEnvaseButton.Size = new System.Drawing.Size(161, 68);
            this.TipoEnvaseButton.TabIndex = 2;
            this.TipoEnvaseButton.Text = "Tipo De Envase";
            this.TipoEnvaseButton.UseVisualStyleBackColor = false;
            this.TipoEnvaseButton.Click += new System.EventHandler(this.TipoEnvaseButton_Click);
            // 
            // PaisButton
            // 
            this.PaisButton.BackColor = System.Drawing.Color.RoyalBlue;
            this.PaisButton.Font = new System.Drawing.Font("HP Simplified", 10.8F);
            this.PaisButton.ForeColor = System.Drawing.SystemColors.Control;
            this.PaisButton.Location = new System.Drawing.Point(12, 152);
            this.PaisButton.Name = "PaisButton";
            this.PaisButton.Size = new System.Drawing.Size(161, 68);
            this.PaisButton.TabIndex = 1;
            this.PaisButton.Text = "Pais";
            this.PaisButton.UseVisualStyleBackColor = false;
            this.PaisButton.Click += new System.EventHandler(this.PaisButton_Click);
            // 
            // ClientesButton
            // 
            this.ClientesButton.BackColor = System.Drawing.Color.RoyalBlue;
            this.ClientesButton.Font = new System.Drawing.Font("HP Simplified", 10.8F);
            this.ClientesButton.ForeColor = System.Drawing.SystemColors.Control;
            this.ClientesButton.Location = new System.Drawing.Point(12, 226);
            this.ClientesButton.Name = "ClientesButton";
            this.ClientesButton.Size = new System.Drawing.Size(161, 68);
            this.ClientesButton.TabIndex = 0;
            this.ClientesButton.Text = "Clientes";
            this.ClientesButton.UseVisualStyleBackColor = false;
            this.ClientesButton.Click += new System.EventHandler(this.ClientesButton_Click);
            // 
            // VendedorButton
            // 
            this.VendedorButton.BackColor = System.Drawing.Color.RoyalBlue;
            this.VendedorButton.Font = new System.Drawing.Font("HP Simplified", 10.8F);
            this.VendedorButton.ForeColor = System.Drawing.SystemColors.Control;
            this.VendedorButton.Location = new System.Drawing.Point(333, 4);
            this.VendedorButton.Name = "VendedorButton";
            this.VendedorButton.Size = new System.Drawing.Size(161, 68);
            this.VendedorButton.TabIndex = 8;
            this.VendedorButton.Text = "Vendedor";
            this.VendedorButton.UseVisualStyleBackColor = false;
            this.VendedorButton.Click += new System.EventHandler(this.VendedorButton_Click);
            // 
            // FrmMenuPrincipal
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSize = true;
            this.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            this.ClientSize = new System.Drawing.Size(516, 536);
            this.ControlBox = false;
            this.Controls.Add(this.splitContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximumSize = new System.Drawing.Size(522, 542);
            this.MinimumSize = new System.Drawing.Size(522, 542);
            this.Name = "FrmMenuPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.FrmMenuPrincipal_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button LocalidadButton;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button ProvinciaButton;
        private System.Windows.Forms.Button TipoEnvaseButton;
        private System.Windows.Forms.Button PaisButton;
        private System.Windows.Forms.Button ClientesButton;
        private System.Windows.Forms.Button CerrarButton;
        private System.Windows.Forms.Button VendedorButton;
    }
}

