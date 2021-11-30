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
    public partial class Karisik : Form
    {
        double tutar, toplamtutar;
       
        public Karisik(Form frm)
        {
            InitializeComponent();
        }

        private void btnHesapla_Click(object sender, EventArgs e)
        {
            double fiyat = 0;
            
            if (chbKalem.Checked )
            {
                fiyat = fiyat + 5.5;
            }
          if (chbDefter.Checked)
            {
                fiyat = fiyat + 20;
            }
           if (chbSilgi.Checked)
            {
                fiyat = fiyat + 4.25;
            }
            else
            {
                lblTutar.Text = "Değer Giriniz!!";
            }
            
            lblTutar.Text = fiyat.ToString();


        }

        private void btnislemiyap_Click(object sender, EventArgs e)
        {
            double sayi1, sayi2, sonuc = 0;
             sayi1 = Convert.ToDouble(txtilksayi.Text);
             sayi2 = Convert.ToDouble(txtikincisayi.Text);
            if (combox.SelectedIndex==0)
            {
                sonuc = sayi1 + sayi2;
            }
            else if (combox.SelectedIndex==1)
            {
                sonuc = sayi1 - sayi2;
            }
            else if (combox.SelectedIndex == 2)
            {
                sonuc = sayi1 * sayi2;
            }
            else if (combox.SelectedIndex == 3)
            {
                sonuc = sayi1 / sayi2;
            }
            else
            {
                lblSonuc.Text = "İşlem Seçiniz";
            }

            lblSonuc.Text =sonuc.ToString();

        }

        private void combox_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void btnuygula_Click(object sender, EventArgs e)
        {
            tutar = Convert.ToInt32(txtindirim.Text);
            if (chbindirim.Checked==true)
            {
                toplamtutar = tutar - (tutar * 0.3);
                lblfiyat.Text = toplamtutar.ToString();
            }
            else 
            {
                toplamtutar = tutar;
                lblfiyat.Text = tutar.ToString();
            }
           
        }
    }
}
