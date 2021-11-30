using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormAdDegisme
{
    public partial class OrtalamaHesapla : Form
    {
        Form1 frm;
        string dosyayolu;
        public OrtalamaHesapla(Form1 frm)
        {
            InitializeComponent();

            this.frm = frm;
            txtAdSoyad.Text += lstSonuc;
            dosyayolu = "yazi.txt";
        }

        double not1, not2, not3 ,sonuc= 0;

        private void OrtalamaHesapla_Load(object sender, EventArgs e)
        {

        }

        private void btnHesapla_Click(object sender, EventArgs e)
        {
            lstSonuc.Items.Add(txtAdSoyad.Text);

            not1 = Convert.ToDouble(txtnot1.Text);
            not2 = Convert.ToDouble(txtnot2.Text);
            not3 = Convert.ToDouble(txtnot3.Text);
            sonuc = (not1 + not2 + not3) / 3;
            lstSonuc.Items.Add(sonuc.ToString());

            if (!File.Exists(dosyayolu))
            {
                File.Create(dosyayolu);

            }
            File.WriteAllText(dosyayolu,txtAdSoyad.Text);
        }

        private void lstSonuc_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
