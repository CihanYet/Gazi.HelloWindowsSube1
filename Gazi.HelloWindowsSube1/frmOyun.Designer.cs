namespace Gazi.HelloWindowsSube1
{
    partial class frmOyun
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
            this.btnOyun = new System.Windows.Forms.Button();
            this.pnlGosterge = new System.Windows.Forms.Panel();
            this.lblSure = new System.Windows.Forms.Label();
            this.lblKullanici = new System.Windows.Forms.Label();
            this.lblSkor = new System.Windows.Forms.Label();
            this.tmrSure = new System.Windows.Forms.Timer(this.components);
            this.pnlGosterge.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnOyun
            // 
            this.btnOyun.Location = new System.Drawing.Point(279, 195);
            this.btnOyun.Name = "btnOyun";
            this.btnOyun.Size = new System.Drawing.Size(40, 40);
            this.btnOyun.TabIndex = 0;
            this.btnOyun.UseVisualStyleBackColor = true;
            this.btnOyun.MouseMove += new System.Windows.Forms.MouseEventHandler(this.button1_MouseMove);
            // 
            // pnlGosterge
            // 
            this.pnlGosterge.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.pnlGosterge.Controls.Add(this.lblSure);
            this.pnlGosterge.Controls.Add(this.lblKullanici);
            this.pnlGosterge.Controls.Add(this.lblSkor);
            this.pnlGosterge.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlGosterge.Location = new System.Drawing.Point(828, 0);
            this.pnlGosterge.Name = "pnlGosterge";
            this.pnlGosterge.Size = new System.Drawing.Size(124, 452);
            this.pnlGosterge.TabIndex = 1;
            // 
            // lblSure
            // 
            this.lblSure.AutoSize = true;
            this.lblSure.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSure.Location = new System.Drawing.Point(47, 19);
            this.lblSure.Name = "lblSure";
            this.lblSure.Size = new System.Drawing.Size(0, 25);
            this.lblSure.TabIndex = 2;
            // 
            // lblKullanici
            // 
            this.lblKullanici.AutoSize = true;
            this.lblKullanici.Location = new System.Drawing.Point(37, 164);
            this.lblKullanici.Name = "lblKullanici";
            this.lblKullanici.Size = new System.Drawing.Size(35, 13);
            this.lblKullanici.TabIndex = 1;
            this.lblKullanici.Text = "label1";
            // 
            // lblSkor
            // 
            this.lblSkor.AutoSize = true;
            this.lblSkor.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSkor.Location = new System.Drawing.Point(35, 67);
            this.lblSkor.Name = "lblSkor";
            this.lblSkor.Size = new System.Drawing.Size(23, 25);
            this.lblSkor.TabIndex = 0;
            this.lblSkor.Text = "0";
            // 
            // tmrSure
            // 
            this.tmrSure.Interval = 1000;
            this.tmrSure.Tick += new System.EventHandler(this.tmrSure_Tick);
            // 
            // frmOyun
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(952, 452);
            this.Controls.Add(this.pnlGosterge);
            this.Controls.Add(this.btnOyun);
            this.Name = "frmOyun";
            this.Text = "frmOyun";
            this.SizeChanged += new System.EventHandler(this.frmOyun_SizeChanged);
            this.pnlGosterge.ResumeLayout(false);
            this.pnlGosterge.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnOyun;
        private System.Windows.Forms.Panel pnlGosterge;
        private System.Windows.Forms.Label lblSkor;
        private System.Windows.Forms.Label lblKullanici;
        private System.Windows.Forms.Label lblSure;
        private System.Windows.Forms.Timer tmrSure;
    }
}