
namespace VentaDeMiel2022.Windows
{
    partial class FrmVendedoresAE
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
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.OKIconButton = new FontAwesome.Sharp.IconButton();
            this.TelefonoMovilTextBox = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.NombreTextBox = new System.Windows.Forms.TextBox();
            this.TelefonoFijoTextBox = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.DireccionTextBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.ApellidoTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.CorreoElectronicoTextBox = new System.Windows.Forms.TextBox();
            this.NroDocumentoTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.FechaDeNacimientoDateTimePicker = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // iconButton1
            // 
            this.iconButton1.BackColor = System.Drawing.Color.Red;
            this.iconButton1.Font = new System.Drawing.Font("Tahoma", 10.8F);
            this.iconButton1.ForeColor = System.Drawing.Color.White;
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.Ban;
            this.iconButton1.IconColor = System.Drawing.Color.White;
            this.iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton1.Location = new System.Drawing.Point(329, 399);
            this.iconButton1.Margin = new System.Windows.Forms.Padding(4);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Size = new System.Drawing.Size(210, 97);
            this.iconButton1.TabIndex = 12;
            this.iconButton1.Text = "Cancelar";
            this.iconButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButton1.UseVisualStyleBackColor = false;
            this.iconButton1.Click += new System.EventHandler(this.iconButton1_Click);
            // 
            // OKIconButton
            // 
            this.OKIconButton.BackColor = System.Drawing.Color.RoyalBlue;
            this.OKIconButton.Font = new System.Drawing.Font("Tahoma", 10.8F);
            this.OKIconButton.ForeColor = System.Drawing.Color.White;
            this.OKIconButton.IconChar = FontAwesome.Sharp.IconChar.FloppyDisk;
            this.OKIconButton.IconColor = System.Drawing.Color.White;
            this.OKIconButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.OKIconButton.Location = new System.Drawing.Point(329, 294);
            this.OKIconButton.Margin = new System.Windows.Forms.Padding(4);
            this.OKIconButton.Name = "OKIconButton";
            this.OKIconButton.Size = new System.Drawing.Size(210, 97);
            this.OKIconButton.TabIndex = 11;
            this.OKIconButton.Text = "OK";
            this.OKIconButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.OKIconButton.UseVisualStyleBackColor = false;
            this.OKIconButton.Click += new System.EventHandler(this.OKIconButton_Click);
            // 
            // TelefonoMovilTextBox
            // 
            this.TelefonoMovilTextBox.Font = new System.Drawing.Font("Tahoma", 10.8F);
            this.TelefonoMovilTextBox.Location = new System.Drawing.Point(24, 407);
            this.TelefonoMovilTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.TelefonoMovilTextBox.MaxLength = 120;
            this.TelefonoMovilTextBox.Name = "TelefonoMovilTextBox";
            this.TelefonoMovilTextBox.Size = new System.Drawing.Size(277, 29);
            this.TelefonoMovilTextBox.TabIndex = 7;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Tahoma", 10.8F);
            this.label11.Location = new System.Drawing.Point(20, 9);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(72, 22);
            this.label11.TabIndex = 68;
            this.label11.Text = "Nombre";
            // 
            // NombreTextBox
            // 
            this.NombreTextBox.Font = new System.Drawing.Font("Tahoma", 10.8F);
            this.NombreTextBox.Location = new System.Drawing.Point(24, 38);
            this.NombreTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.NombreTextBox.MaxLength = 120;
            this.NombreTextBox.Name = "NombreTextBox";
            this.NombreTextBox.Size = new System.Drawing.Size(277, 29);
            this.NombreTextBox.TabIndex = 0;
            // 
            // TelefonoFijoTextBox
            // 
            this.TelefonoFijoTextBox.Font = new System.Drawing.Font("Tahoma", 10.8F);
            this.TelefonoFijoTextBox.Location = new System.Drawing.Point(24, 347);
            this.TelefonoFijoTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.TelefonoFijoTextBox.MaxLength = 120;
            this.TelefonoFijoTextBox.Name = "TelefonoFijoTextBox";
            this.TelefonoFijoTextBox.Size = new System.Drawing.Size(277, 29);
            this.TelefonoFijoTextBox.TabIndex = 6;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Tahoma", 10.8F);
            this.label9.Location = new System.Drawing.Point(20, 139);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(175, 22);
            this.label9.TabIndex = 66;
            this.label9.Text = "Fecha De Nacimiento";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Tahoma", 10.8F);
            this.label10.Location = new System.Drawing.Point(20, 380);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(126, 22);
            this.label10.TabIndex = 67;
            this.label10.Text = "Telefono Movil";
            // 
            // DireccionTextBox
            // 
            this.DireccionTextBox.Font = new System.Drawing.Font("Tahoma", 10.8F);
            this.DireccionTextBox.Location = new System.Drawing.Point(24, 284);
            this.DireccionTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.DireccionTextBox.MaxLength = 120;
            this.DireccionTextBox.Name = "DireccionTextBox";
            this.DireccionTextBox.Size = new System.Drawing.Size(277, 29);
            this.DireccionTextBox.TabIndex = 5;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 10.8F);
            this.label7.Location = new System.Drawing.Point(20, 257);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(81, 22);
            this.label7.TabIndex = 64;
            this.label7.Text = "Direccion";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 10.8F);
            this.label5.Location = new System.Drawing.Point(20, 440);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(153, 22);
            this.label5.TabIndex = 62;
            this.label5.Text = "Correo Electronico";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 10.8F);
            this.label6.Location = new System.Drawing.Point(20, 320);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(113, 22);
            this.label6.TabIndex = 63;
            this.label6.Text = "Telefono Fijo";
            // 
            // ApellidoTextBox
            // 
            this.ApellidoTextBox.Font = new System.Drawing.Font("Tahoma", 10.8F);
            this.ApellidoTextBox.Location = new System.Drawing.Point(24, 98);
            this.ApellidoTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.ApellidoTextBox.MaxLength = 120;
            this.ApellidoTextBox.Name = "ApellidoTextBox";
            this.ApellidoTextBox.Size = new System.Drawing.Size(277, 29);
            this.ApellidoTextBox.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 10.8F);
            this.label3.Location = new System.Drawing.Point(20, 71);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 22);
            this.label3.TabIndex = 60;
            this.label3.Text = "Apellido";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // CorreoElectronicoTextBox
            // 
            this.CorreoElectronicoTextBox.Font = new System.Drawing.Font("Tahoma", 10.8F);
            this.CorreoElectronicoTextBox.Location = new System.Drawing.Point(24, 467);
            this.CorreoElectronicoTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.CorreoElectronicoTextBox.MaxLength = 120;
            this.CorreoElectronicoTextBox.Name = "CorreoElectronicoTextBox";
            this.CorreoElectronicoTextBox.Size = new System.Drawing.Size(277, 29);
            this.CorreoElectronicoTextBox.TabIndex = 8;
            // 
            // NroDocumentoTextBox
            // 
            this.NroDocumentoTextBox.Font = new System.Drawing.Font("Tahoma", 10.8F);
            this.NroDocumentoTextBox.Location = new System.Drawing.Point(24, 224);
            this.NroDocumentoTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.NroDocumentoTextBox.MaxLength = 120;
            this.NroDocumentoTextBox.Name = "NroDocumentoTextBox";
            this.NroDocumentoTextBox.Size = new System.Drawing.Size(277, 29);
            this.NroDocumentoTextBox.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 10.8F);
            this.label1.Location = new System.Drawing.Point(20, 197);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 22);
            this.label1.TabIndex = 58;
            this.label1.Text = "Nro Documento";
            // 
            // FechaDeNacimientoDateTimePicker
            // 
            this.FechaDeNacimientoDateTimePicker.Font = new System.Drawing.Font("Tahoma", 10.8F);
            this.FechaDeNacimientoDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.FechaDeNacimientoDateTimePicker.Location = new System.Drawing.Point(24, 165);
            this.FechaDeNacimientoDateTimePicker.Name = "FechaDeNacimientoDateTimePicker";
            this.FechaDeNacimientoDateTimePicker.Size = new System.Drawing.Size(277, 29);
            this.FechaDeNacimientoDateTimePicker.TabIndex = 3;
            // 
            // FrmVendedoresAE
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(552, 527);
            this.ControlBox = false;
            this.Controls.Add(this.FechaDeNacimientoDateTimePicker);
            this.Controls.Add(this.iconButton1);
            this.Controls.Add(this.OKIconButton);
            this.Controls.Add(this.TelefonoMovilTextBox);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.NombreTextBox);
            this.Controls.Add(this.TelefonoFijoTextBox);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.DireccionTextBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.ApellidoTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.CorreoElectronicoTextBox);
            this.Controls.Add(this.NroDocumentoTextBox);
            this.Controls.Add(this.label1);
            this.MaximumSize = new System.Drawing.Size(570, 545);
            this.MinimumSize = new System.Drawing.Size(570, 545);
            this.Name = "FrmVendedoresAE";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.FrmVendedoresAE_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private FontAwesome.Sharp.IconButton iconButton1;
        private FontAwesome.Sharp.IconButton OKIconButton;
        private System.Windows.Forms.TextBox TelefonoMovilTextBox;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox NombreTextBox;
        private System.Windows.Forms.TextBox TelefonoFijoTextBox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox DireccionTextBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox ApellidoTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.TextBox CorreoElectronicoTextBox;
        private System.Windows.Forms.TextBox NroDocumentoTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker FechaDeNacimientoDateTimePicker;
    }
}