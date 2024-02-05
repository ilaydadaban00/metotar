namespace metot
{
    partial class Form1
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
            this.lblSayi1 = new System.Windows.Forms.Label();
            this.txtSayi1 = new System.Windows.Forms.TextBox();
            this.lblSonuc = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.txtSayi2 = new System.Windows.Forms.TextBox();
            this.lblSayi2 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.txtMesaj = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.colorDialog2 = new System.Windows.Forms.ColorDialog();
            this.btnRengisec = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblSayi1
            // 
            this.lblSayi1.AutoSize = true;
            this.lblSayi1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSayi1.Location = new System.Drawing.Point(39, 40);
            this.lblSayi1.Name = "lblSayi1";
            this.lblSayi1.Size = new System.Drawing.Size(63, 25);
            this.lblSayi1.TabIndex = 0;
            this.lblSayi1.Text = "sayı 1";
            // 
            // txtSayi1
            // 
            this.txtSayi1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtSayi1.Location = new System.Drawing.Point(112, 37);
            this.txtSayi1.Name = "txtSayi1";
            this.txtSayi1.Size = new System.Drawing.Size(173, 30);
            this.txtSayi1.TabIndex = 1;
            // 
            // lblSonuc
            // 
            this.lblSonuc.AutoSize = true;
            this.lblSonuc.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSonuc.Location = new System.Drawing.Point(27, 249);
            this.lblSonuc.Name = "lblSonuc";
            this.lblSonuc.Size = new System.Drawing.Size(65, 25);
            this.lblSonuc.TabIndex = 2;
            this.lblSonuc.Text = "sonuc";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.Location = new System.Drawing.Point(41, 184);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(244, 45);
            this.button1.TabIndex = 3;
            this.button1.Text = "hesapla";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtSayi2
            // 
            this.txtSayi2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtSayi2.Location = new System.Drawing.Point(112, 87);
            this.txtSayi2.Name = "txtSayi2";
            this.txtSayi2.Size = new System.Drawing.Size(177, 30);
            this.txtSayi2.TabIndex = 5;
            // 
            // lblSayi2
            // 
            this.lblSayi2.AutoSize = true;
            this.lblSayi2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSayi2.Location = new System.Drawing.Point(43, 90);
            this.lblSayi2.Name = "lblSayi2";
            this.lblSayi2.Size = new System.Drawing.Size(63, 25);
            this.lblSayi2.TabIndex = 4;
            this.lblSayi2.Text = "sayı 2";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(340, 53);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(149, 77);
            this.button2.TabIndex = 6;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // txtMesaj
            // 
            this.txtMesaj.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtMesaj.Location = new System.Drawing.Point(112, 134);
            this.txtMesaj.Name = "txtMesaj";
            this.txtMesaj.Size = new System.Drawing.Size(177, 30);
            this.txtMesaj.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(43, 137);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 25);
            this.label1.TabIndex = 7;
            this.label1.Text = "sayı 3";
            // 
            // btnRengisec
            // 
            this.btnRengisec.Location = new System.Drawing.Point(317, 193);
            this.btnRengisec.Name = "btnRengisec";
            this.btnRengisec.Size = new System.Drawing.Size(52, 36);
            this.btnRengisec.TabIndex = 9;
            this.btnRengisec.Text = "rengi seç";
            this.btnRengisec.UseVisualStyleBackColor = true;
            this.btnRengisec.Click += new System.EventHandler(this.btnRengisec_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(523, 292);
            this.Controls.Add(this.btnRengisec);
            this.Controls.Add(this.txtMesaj);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.txtSayi2);
            this.Controls.Add(this.lblSayi2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblSonuc);
            this.Controls.Add(this.txtSayi1);
            this.Controls.Add(this.lblSayi1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSayi1;
        private System.Windows.Forms.TextBox txtSayi1;
        private System.Windows.Forms.Label lblSonuc;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtSayi2;
        private System.Windows.Forms.Label lblSayi2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox txtMesaj;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.ColorDialog colorDialog2;
        private System.Windows.Forms.Button btnRengisec;
    }
}

