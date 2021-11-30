using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormAdDegisme
{
    public partial class RandomToplama : Form
    {
        Random rnd = new Random();
        Form1 frm;
        public RandomToplama(Form1 frm)
        {
            InitializeComponent();
            this.frm = frm;
            btn1.Text = rnd.Next(100).ToString();
            btn2.Text = rnd.Next(100).ToString();
            btn3.Text = rnd.Next(100).ToString();
            btn1.Click += Topla_Click;
            btn2.Click += Topla_Click;
            btn3.Click += Topla_Click;

        }
        static int topla = 0;

        private void Topla_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            btn.Enabled = false;
            topla += int.Parse(btn.Text);
        }
        private void btnTopla_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Toplam:"+topla);
        }
    }
}
