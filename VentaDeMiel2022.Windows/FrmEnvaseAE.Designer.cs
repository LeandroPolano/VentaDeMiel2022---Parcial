namespace VentaDeMiel2022.Windows
{
    partial class FrmEnvaseAE
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
            this.components = new System.ComponentModel.Container();
            this.CancelarIconButton = new FontAwesome.Sharp.IconButton();
            this.OKIconButton = new FontAwesome.Sharp.IconButton();
            this.EnvaseTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.PrecioVtaTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TipoEnvasesComboBox = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.StockNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.ImagenPictureBox = new System.Windows.Forms.PictureBox();
            this.BuscarIconButton = new FontAwesome.Sharp.IconButton();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.StockNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImagenPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // CancelarIconButton
            // 
            this.CancelarIconButton.BackColor = System.Drawing.Color.Red;
            this.CancelarIconButton.ForeColor = System.Drawing.Color.White;
            this.CancelarIconButton.IconChar = FontAwesome.Sharp.IconChar.Ban;
            this.CancelarIconButton.IconColor = System.Drawing.Color.White;
            this.CancelarIconButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.CancelarIconButton.Location = new System.Drawing.Point(413, 261);
            this.CancelarIconButton.Margin = new System.Windows.Forms.Padding(4);
            this.CancelarIconButton.Name = "CancelarIconButton";
            this.CancelarIconButton.Size = new System.Drawing.Size(161, 73);
            this.CancelarIconButton.TabIndex = 7;
            this.CancelarIconButton.Text = "Cancelar";
            this.CancelarIconButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.CancelarIconButton.UseVisualStyleBackColor = false;
            this.CancelarIconButton.Click += new System.EventHandler(this.CancelarIconButton_Click);
            // 
            // OKIconButton
            // 
            this.OKIconButton.BackColor = System.Drawing.Color.RoyalBlue;
            this.OKIconButton.ForeColor = System.Drawing.Color.White;
            this.OKIconButton.IconChar = FontAwesome.Sharp.IconChar.FloppyDisk;
            this.OKIconButton.IconColor = System.Drawing.Color.White;
            this.OKIconButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.OKIconButton.Location = new System.Drawing.Point(83, 261);
            this.OKIconButton.Margin = new System.Windows.Forms.Padding(4);
            this.OKIconButton.Name = "OKIconButton";
            this.OKIconButton.Size = new System.Drawing.Size(161, 73);
            this.OKIconButton.TabIndex = 8;
            this.OKIconButton.Text = "Guardar";
            this.OKIconButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.OKIconButton.UseVisualStyleBackColor = false;
            this.OKIconButton.Click += new System.EventHandler(this.OKIconButton_Click);
            // 
            // EnvaseTextBox
            // 
            this.EnvaseTextBox.Location = new System.Drawing.Point(224, 48);
            this.EnvaseTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.EnvaseTextBox.MaxLength = 200;
            this.EnvaseTextBox.Name = "EnvaseTextBox";
            this.EnvaseTextBox.Size = new System.Drawing.Size(349, 22);
            this.EnvaseTextBox.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(79, 52);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 16);
            this.label1.TabIndex = 10;
            this.label1.Text = "Envase:";
            // 
            // PrecioVtaTextBox
            // 
            this.PrecioVtaTextBox.Location = new System.Drawing.Point(224, 137);
            this.PrecioVtaTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.PrecioVtaTextBox.MaxLength = 200;
            this.PrecioVtaTextBox.Name = "PrecioVtaTextBox";
            this.PrecioVtaTextBox.Size = new System.Drawing.Size(349, 22);
            this.PrecioVtaTextBox.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(79, 97);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 16);
            this.label2.TabIndex = 10;
            this.label2.Text = "Tipo de Envase:";
            // 
            // TipoEnvasesComboBox
            // 
            this.TipoEnvasesComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.TipoEnvasesComboBox.FormattingEnabled = true;
            this.TipoEnvasesComboBox.Location = new System.Drawing.Point(224, 94);
            this.TipoEnvasesComboBox.Margin = new System.Windows.Forms.Padding(4);
            this.TipoEnvasesComboBox.Name = "TipoEnvasesComboBox";
            this.TipoEnvasesComboBox.Size = new System.Drawing.Size(349, 24);
            this.TipoEnvasesComboBox.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(83, 144);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 16);
            this.label3.TabIndex = 12;
            this.label3.Text = "Precio Vta:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(83, 187);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 16);
            this.label4.TabIndex = 12;
            this.label4.Text = "Stock:";
            // 
            // StockNumericUpDown
            // 
            this.StockNumericUpDown.Location = new System.Drawing.Point(224, 187);
            this.StockNumericUpDown.Margin = new System.Windows.Forms.Padding(4);
            this.StockNumericUpDown.Maximum = new decimal(new int[] {
            150,
            0,
            0,
            0});
            this.StockNumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.StockNumericUpDown.Name = "StockNumericUpDown";
            this.StockNumericUpDown.Size = new System.Drawing.Size(160, 22);
            this.StockNumericUpDown.TabIndex = 13;
            this.StockNumericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // ImagenPictureBox
            // 
            this.ImagenPictureBox.Location = new System.Drawing.Point(673, 48);
            this.ImagenPictureBox.Margin = new System.Windows.Forms.Padding(4);
            this.ImagenPictureBox.Name = "ImagenPictureBox";
            this.ImagenPictureBox.Size = new System.Drawing.Size(141, 112);
            this.ImagenPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ImagenPictureBox.TabIndex = 14;
            this.ImagenPictureBox.TabStop = false;
            // 
            // BuscarIconButton
            // 
            this.BuscarIconButton.BackColor = System.Drawing.Color.ForestGreen;
            this.BuscarIconButton.ForeColor = System.Drawing.Color.White;
            this.BuscarIconButton.IconChar = FontAwesome.Sharp.IconChar.Search;
            this.BuscarIconButton.IconColor = System.Drawing.Color.White;
            this.BuscarIconButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BuscarIconButton.IconSize = 32;
            this.BuscarIconButton.Location = new System.Drawing.Point(653, 167);
            this.BuscarIconButton.Margin = new System.Windows.Forms.Padding(4);
            this.BuscarIconButton.Name = "BuscarIconButton";
            this.BuscarIconButton.Size = new System.Drawing.Size(179, 44);
            this.BuscarIconButton.TabIndex = 7;
            this.BuscarIconButton.Text = "Buscar";
            this.BuscarIconButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BuscarIconButton.UseVisualStyleBackColor = false;
            this.BuscarIconButton.Click += new System.EventHandler(this.BuscarIconButton_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // FrmEnvaseAE
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(849, 356);
            this.ControlBox = false;
            this.Controls.Add(this.ImagenPictureBox);
            this.Controls.Add(this.StockNumericUpDown);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TipoEnvasesComboBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PrecioVtaTextBox);
            this.Controls.Add(this.EnvaseTextBox);
            this.Controls.Add(this.BuscarIconButton);
            this.Controls.Add(this.CancelarIconButton);
            this.Controls.Add(this.OKIconButton);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximumSize = new System.Drawing.Size(867, 403);
            this.MinimumSize = new System.Drawing.Size(867, 403);
            this.Name = "FrmEnvaseAE";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmEnvaseAE";
            ((System.ComponentModel.ISupportInitialize)(this.StockNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImagenPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private FontAwesome.Sharp.IconButton CancelarIconButton;
        private FontAwesome.Sharp.IconButton OKIconButton;
        private System.Windows.Forms.TextBox EnvaseTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox PrecioVtaTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox TipoEnvasesComboBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown StockNumericUpDown;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.PictureBox ImagenPictureBox;
        private FontAwesome.Sharp.IconButton BuscarIconButton;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}
