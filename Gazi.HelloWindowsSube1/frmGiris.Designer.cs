namespace Gazi.HelloWindowsSube1
{
    partial class frmGiris
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
            this.grpKullanici = new System.Windows.Forms.GroupBox();
            this.lblSoyad = new System.Windows.Forms.Label();
            this.lblAd = new System.Windows.Forms.Label();
            this.txtSoyad = new System.Windows.Forms.TextBox();
            this.txtAd = new System.Windows.Forms.TextBox();
            this.btnGiris = new System.Windows.Forms.Button();
            this.txtSehir = new System.Windows.Forms.TextBox();
            this.lblSehir = new System.Windows.Forms.Label();
            this.grpSeviye = new System.Windows.Forms.GroupBox();
            this.rdKolay = new System.Windows.Forms.RadioButton();
            this.rdOrta = new System.Windows.Forms.RadioButton();
            this.rdZor = new System.Windows.Forms.RadioButton();
            this.grpKullanici.SuspendLayout();
            this.grpSeviye.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpKullanici
            // 
            this.grpKullanici.Controls.Add(this.lblSehir);
            this.grpKullanici.Controls.Add(this.txtSehir);
            this.grpKullanici.Controls.Add(this.lblSoyad);
            this.grpKullanici.Controls.Add(this.lblAd);
            this.grpKullanici.Controls.Add(this.txtSoyad);
            this.grpKullanici.Controls.Add(this.txtAd);
            this.grpKullanici.Location = new System.Drawing.Point(21, 26);
            this.grpKullanici.Name = "grpKullanici";
            this.grpKullanici.Size = new System.Drawing.Size(263, 147);
            this.grpKullanici.TabIndex = 0;
            this.grpKullanici.TabStop = false;
            this.grpKullanici.Text = "Kullanıcı Bilgileri";
            // 
            // lblSoyad
            // 
            this.lblSoyad.AutoSize = true;
            this.lblSoyad.Location = new System.Drawing.Point(39, 86);
            this.lblSoyad.Name = "lblSoyad";
            this.lblSoyad.Size = new System.Drawing.Size(52, 13);
            this.lblSoyad.TabIndex = 3;
            this.lblSoyad.Text = "Soyadınız";
            // 
            // lblAd
            // 
            this.lblAd.AutoSize = true;
            this.lblAd.Location = new System.Drawing.Point(39, 56);
            this.lblAd.Name = "lblAd";
            this.lblAd.Size = new System.Drawing.Size(35, 13);
            this.lblAd.TabIndex = 2;
            this.lblAd.Text = "Adınız";
            // 
            // txtSoyad
            // 
            this.txtSoyad.Location = new System.Drawing.Point(91, 79);
            this.txtSoyad.Name = "txtSoyad";
            this.txtSoyad.Size = new System.Drawing.Size(100, 20);
            this.txtSoyad.TabIndex = 1;
            // 
            // txtAd
            // 
            this.txtAd.Location = new System.Drawing.Point(91, 53);
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(100, 20);
            this.txtAd.TabIndex = 0;
            // 
            // btnGiris
            // 
            this.btnGiris.Location = new System.Drawing.Point(21, 250);
            this.btnGiris.Name = "btnGiris";
            this.btnGiris.Size = new System.Drawing.Size(263, 23);
            this.btnGiris.TabIndex = 4;
            this.btnGiris.Text = "GİRİŞ";
            this.btnGiris.UseVisualStyleBackColor = true;
            this.btnGiris.Click += new System.EventHandler(this.btnGiris_Click);
            // 
            // txtSehir
            // 
            this.txtSehir.Location = new System.Drawing.Point(91, 105);
            this.txtSehir.Name = "txtSehir";
            this.txtSehir.Size = new System.Drawing.Size(100, 20);
            this.txtSehir.TabIndex = 4;
            // 
            // lblSehir
            // 
            this.lblSehir.AutoSize = true;
            this.lblSehir.Location = new System.Drawing.Point(40, 111);
            this.lblSehir.Name = "lblSehir";
            this.lblSehir.Size = new System.Drawing.Size(31, 13);
            this.lblSehir.TabIndex = 5;
            this.lblSehir.Text = "Şehir";
            // 
            // grpSeviye
            // 
            this.grpSeviye.Controls.Add(this.rdZor);
            this.grpSeviye.Controls.Add(this.rdOrta);
            this.grpSeviye.Controls.Add(this.rdKolay);
            this.grpSeviye.Location = new System.Drawing.Point(21, 179);
            this.grpSeviye.Name = "grpSeviye";
            this.grpSeviye.Size = new System.Drawing.Size(263, 58);
            this.grpSeviye.TabIndex = 5;
            this.grpSeviye.TabStop = false;
            this.grpSeviye.Text = "Seviye İşlemleri";
            // 
            // rdKolay
            // 
            this.rdKolay.AutoSize = true;
            this.rdKolay.Checked = true;
            this.rdKolay.Location = new System.Drawing.Point(23, 22);
            this.rdKolay.Name = "rdKolay";
            this.rdKolay.Size = new System.Drawing.Size(51, 17);
            this.rdKolay.TabIndex = 0;
            this.rdKolay.TabStop = true;
            this.rdKolay.Text = "Kolay";
            this.rdKolay.UseVisualStyleBackColor = true;
            // 
            // rdOrta
            // 
            this.rdOrta.AutoSize = true;
            this.rdOrta.Location = new System.Drawing.Point(100, 22);
            this.rdOrta.Name = "rdOrta";
            this.rdOrta.Size = new System.Drawing.Size(45, 17);
            this.rdOrta.TabIndex = 1;
            this.rdOrta.TabStop = true;
            this.rdOrta.Text = "Orta";
            this.rdOrta.UseVisualStyleBackColor = true;
            // 
            // rdZor
            // 
            this.rdZor.AutoSize = true;
            this.rdZor.Location = new System.Drawing.Point(175, 22);
            this.rdZor.Name = "rdZor";
            this.rdZor.Size = new System.Drawing.Size(41, 17);
            this.rdZor.TabIndex = 2;
            this.rdZor.TabStop = true;
            this.rdZor.Text = "Zor";
            this.rdZor.UseVisualStyleBackColor = true;
            // 
            // frmGiris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(303, 299);
            this.Controls.Add(this.grpSeviye);
            this.Controls.Add(this.btnGiris);
            this.Controls.Add(this.grpKullanici);
            this.Name = "frmGiris";
            this.Text = "frmGiriscs";
            this.grpKullanici.ResumeLayout(false);
            this.grpKullanici.PerformLayout();
            this.grpSeviye.ResumeLayout(false);
            this.grpSeviye.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpKullanici;
        private System.Windows.Forms.Label lblSoyad;
        private System.Windows.Forms.Label lblAd;
        private System.Windows.Forms.TextBox txtSoyad;
        private System.Windows.Forms.TextBox txtAd;
        private System.Windows.Forms.Button btnGiris;
        private System.Windows.Forms.Label lblSehir;
        private System.Windows.Forms.TextBox txtSehir;
        private System.Windows.Forms.GroupBox grpSeviye;
        private System.Windows.Forms.RadioButton rdZor;
        private System.Windows.Forms.RadioButton rdOrta;
        private System.Windows.Forms.RadioButton rdKolay;
    }
}