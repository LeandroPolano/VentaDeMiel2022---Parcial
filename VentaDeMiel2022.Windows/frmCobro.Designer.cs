namespace VentaDeMiel2022.Windows
{
    partial class frmCobro
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.VisaButton = new System.Windows.Forms.Button();
            this.EfectivoButton = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.VueltoLabel = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.ImporteRecibidoLabel = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ImporteLabel = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.VisaButton);
            this.groupBox2.Controls.Add(this.EfectivoButton);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(17, 229);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(1025, 226);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Medios de Pago";
            // 
            // VisaButton
            // 
            this.VisaButton.Image = global::VentaDeMiel2022.Windows.Properties.Resources.visa_50px;
            this.VisaButton.Location = new System.Drawing.Point(163, 68);
            this.VisaButton.Margin = new System.Windows.Forms.Padding(4);
            this.VisaButton.Name = "VisaButton";
            this.VisaButton.Size = new System.Drawing.Size(111, 110);
            this.VisaButton.TabIndex = 0;
            this.VisaButton.Text = "Visa";
            this.VisaButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.VisaButton.UseVisualStyleBackColor = true;
            this.VisaButton.Click += new System.EventHandler(this.VisaButton_Click);
            // 
            // EfectivoButton
            // 
            this.EfectivoButton.Image = global::VentaDeMiel2022.Windows.Properties.Resources.money_50px;
            this.EfectivoButton.Location = new System.Drawing.Point(32, 68);
            this.EfectivoButton.Margin = new System.Windows.Forms.Padding(4);
            this.EfectivoButton.Name = "EfectivoButton";
            this.EfectivoButton.Size = new System.Drawing.Size(111, 110);
            this.EfectivoButton.TabIndex = 0;
            this.EfectivoButton.Text = "Efectivo";
            this.EfectivoButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.EfectivoButton.UseVisualStyleBackColor = true;
            this.EfectivoButton.Click += new System.EventHandler(this.EfectivoButton_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.VueltoLabel);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(17, 632);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox4.Size = new System.Drawing.Size(1033, 123);
            this.groupBox4.TabIndex = 6;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Vuelto";
            // 
            // VueltoLabel
            // 
            this.VueltoLabel.BackColor = System.Drawing.Color.White;
            this.VueltoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VueltoLabel.Location = new System.Drawing.Point(8, 25);
            this.VueltoLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.VueltoLabel.Name = "VueltoLabel";
            this.VueltoLabel.Size = new System.Drawing.Size(1017, 73);
            this.VueltoLabel.TabIndex = 0;
            this.VueltoLabel.Text = "0.00";
            this.VueltoLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.ImporteRecibidoLabel);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(17, 485);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox3.Size = new System.Drawing.Size(1033, 123);
            this.groupBox3.TabIndex = 7;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Importe a Recibido";
            // 
            // ImporteRecibidoLabel
            // 
            this.ImporteRecibidoLabel.BackColor = System.Drawing.Color.White;
            this.ImporteRecibidoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ImporteRecibidoLabel.Location = new System.Drawing.Point(8, 25);
            this.ImporteRecibidoLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ImporteRecibidoLabel.Name = "ImporteRecibidoLabel";
            this.ImporteRecibidoLabel.Size = new System.Drawing.Size(1017, 73);
            this.ImporteRecibidoLabel.TabIndex = 0;
            this.ImporteRecibidoLabel.Text = "0.00";
            this.ImporteRecibidoLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ImporteLabel);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(17, 84);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(1033, 123);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Importe a Cobrar";
            // 
            // ImporteLabel
            // 
            this.ImporteLabel.BackColor = System.Drawing.Color.White;
            this.ImporteLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ImporteLabel.Location = new System.Drawing.Point(8, 25);
            this.ImporteLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ImporteLabel.Name = "ImporteLabel";
            this.ImporteLabel.Size = new System.Drawing.Size(1017, 73);
            this.ImporteLabel.TabIndex = 0;
            this.ImporteLabel.Text = "0.00";
            this.ImporteLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // frmCobro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 839);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.MaximumSize = new System.Drawing.Size(1085, 886);
            this.MinimumSize = new System.Drawing.Size(1085, 886);
            this.Name = "frmCobro";
            this.Load += new System.EventHandler(this.frmCobro_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button VisaButton;
        private System.Windows.Forms.Button EfectivoButton;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label VueltoLabel;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label ImporteRecibidoLabel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label ImporteLabel;
    }
}