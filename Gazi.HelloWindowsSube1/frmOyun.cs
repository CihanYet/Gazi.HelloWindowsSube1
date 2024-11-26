using Oyun.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gazi.HelloWindowsSube1
{
    public partial class frmOyun : Form
    {

        int skor = 0, sure = 3, maxskor = 0;
        bool basla = true;
        Seviye seviye;

        Random rnd = new Random();
        public frmOyun(User usr, Seviye seviye)
        {
            InitializeComponent();
            this.seviye = seviye;
            SeviyeIslemleri(seviye);
            lblKullanici.Text = $"{usr.Ad} {usr.Soyad} {usr.Sehir}";
            lblSure.Text = sure.ToString();
        }

        void SeviyeIslemleri(Seviye seviye)
        { 
            switch (seviye)
            {
                case Seviye.Kolay:
                    this.Size = new Size(300, 300);
                    sure = 15;
                    break;
                case Seviye.Orta:
                    this.Size = new Size(500, 500);
                    sure = 10;
                    break;
                case Seviye.Zor:
                    this.Size = new Size(700, 700);
                    sure = 5;
                    break;              
            }

            btnOyun.Location = new Point(rnd.Next(this.ClientSize.Width - btnOyun.Width - pnlGosterge.Width), rnd.Next(this.ClientSize.Height - btnOyun.Height));
        }

        private void button1_MouseMove(object sender, MouseEventArgs e)
        {
            if (basla)
            {
                tmrSure.Start();
                basla = false;
            }

            skor++;
            lblSkor.Text = skor.ToString();

            btnOyun.Location = new Point(rnd.Next(this.ClientSize.Width - btnOyun.Width - pnlGosterge.Width), rnd.Next(this.ClientSize.Height - btnOyun.Height));
        }

        private void tmrSure_Tick(object sender, EventArgs e)
        {
            sure--;
            lblSure.Text = sure.ToString();
            if (sure == 0)
            {
                tmrSure.Stop();
                btnOyun.Enabled = false;
                if (skor > maxskor)
                {
                    maxskor = skor;
                }
                DialogResult cvp = MessageBox.Show($"Oyun bitti.Skorunuz:{skor}\nYeniden başlamak ister misiniz?", "Oyun Bitti", MessageBoxButtons.YesNo);
                if (cvp == DialogResult.Yes)
                {
                    Basla();
                }
                else
                {
                    MessageBox.Show($"Oyun Bitti.Aldığınız en yüksek skor:{maxskor}");
                }
            }
        }

        void Basla()
        {
            SeviyeIslemleri(this.seviye);
            btnOyun.Enabled = true;
            basla = true;
            lblSure.Text = sure.ToString();
            skor = 0;
            lblSkor.Text = skor.ToString();
        }

        private void frmOyun_SizeChanged(object sender, EventArgs e)
        {
            //pnlGosterge.Location = new Point(this.ClientSize.Width - pnlGosterge.Width, 0);
            //pnlGosterge.Height = this.ClientSize.Height;
        }
    }
}
