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

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAc_Click(object sender, EventArgs e)
        {
            Form2 frm1 = new Form2(this);
            frm1.ShowDialog();
        }

        private void btnRandom_Click(object sender, EventArgs e)
        {
            RandomToplama rndtoplama = new RandomToplama(this);
            rndtoplama.ShowDialog();
        }

        private void btnorthsp_Click(object sender, EventArgs e)
        {
            OrtalamaHesapla orthsp = new OrtalamaHesapla(this);
            orthsp.ShowDialog();
        }

        private void btnSayiOyna_Click(object sender, EventArgs e)
        {
            SayiOyun syoyna = new SayiOyun(this);
            syoyna.ShowDialog();
        }

        private void btnSayiTahmin_Click(object sender, EventArgs e)
        {
            SayiTahmin thm = new SayiTahmin(this);
            thm.ShowDialog();
        }

        private void btnKarisik_Click(object sender, EventArgs e)
        {
            Karisik krs = new Karisik(this);
            krs.ShowDialog();
        }
    }
}
