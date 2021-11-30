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
    
    public partial class SayiOyun : Form
    {
        byte zorluk=3;
       
        public SayiOyun(Form1 frm)
        {
            InitializeComponent();
            
        }

        private void btnOyna_Click(object sender, EventArgs e)
        {
            if (txtad.Text=="" || txtsoyad.Text=="")
            {
                MessageBox.Show("Bütün Alanlar Doldurulmalıdır!");
            }
            else
            {
                if (rdbkolay.Checked)
                {
                    zorluk = 1;
                }
               else if (rdborta.Checked)
                {
                    zorluk = 2;
                }
                else if (rdbzor.Checked)
                {
                    zorluk = 3;
                }
                else
                {
                    zorluk = 1;

                }

            }

            OyunAlani oyna = new OyunAlani(txtad.Text, txtsoyad.Text,zorluk);
            oyna.ShowDialog();

        }
    }
}
