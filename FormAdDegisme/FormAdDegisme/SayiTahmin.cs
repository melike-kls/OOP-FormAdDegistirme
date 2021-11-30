using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace FormAdDegisme
{
    public partial class SayiTahmin : Form
    {
        int skor= 0;
        int sayi;
        public SayiTahmin(Form1 frm)
        {
            InitializeComponent();
          
        }

        private void SayiTahmin_Load(object sender, EventArgs e)
        {
            
        }

        private void btntahmin_Click(object sender, EventArgs e)
        {
            
            Random rnd = new Random();
            sayi = rnd.Next(5);
            btntahmin.Enabled = true; 
            
            int tahmin =Convert.ToInt32(txttahmin.Text);

           if (tahmin == sayi)
           {
                lbltekrar.Text = "İYİ GİDİYORSUN";
                skor = skor + 10;
            }
            else if (skor == 100)
            {
                lbltekrar.Text = "KAZANDINNN";
                btntahmin.Enabled = false;
            }
            else if (skor == -100)
            {
                lbltekrar.Text = "KAYBETTİN";
                btntahmin.Enabled = false;

            }

            else if (tahmin != sayi)
            {
                lbltekrar.Text = "TEKRAR DENE";
                skor = skor - 10;
            }
           


            lblskor.Text =skor.ToString();
            txttahmin.Clear();
        }

        private void txttahmin_TextChanged(object sender, EventArgs e)
        {
           
            
        }

        private void lblskor_Click(object sender, EventArgs e)
        {

        }
    }
}
