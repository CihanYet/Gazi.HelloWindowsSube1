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

        int skor = 0;
        public frmOyun(string ad,string soyad)
        {
            InitializeComponent();
            lblKullanici.Text = ad + " " + soyad;
        }

        private void button1_MouseMove(object sender, MouseEventArgs e)
        {
            skor++;
            lblSkor.Text = skor.ToString();
            var rnd = new Random();
            btnOyun.Location = new Point(rnd.Next(this.ClientSize.Width - btnOyun.Width - pnlGosterge.Width), rnd.Next(this.ClientSize.Height - btnOyun.Height));
        }

        private void frmOyun_SizeChanged(object sender, EventArgs e)
        {
            //pnlGosterge.Location = new Point(this.ClientSize.Width - pnlGosterge.Width, 0);
            //pnlGosterge.Height = this.ClientSize.Height;
        }
    }
}
