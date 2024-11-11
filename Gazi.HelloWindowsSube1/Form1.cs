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
    public partial class Form1 : Form
    {
        public Form1()
        {
            var btn = new Button();
            btn.Text = "Bizim Buton";
            btn.Size = new Size(100, 50);
            btn.Location = new Point(50, 100);
            btn.Name = "btn";
            btn.Click += Btn_Click;
            this.Controls.Add(btn);
            InitializeComponent();
        }

        private void Btn_Click(object sender, EventArgs e)
        {
            MessageBox.Show((int.Parse(txtSayi1.Text) + int.Parse(txtSayi2.Text)).ToString());
        }

        private void btnHelloWindows_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("Test");
            checkBox1.Text = "Deneme";
        }

       
    }
}
