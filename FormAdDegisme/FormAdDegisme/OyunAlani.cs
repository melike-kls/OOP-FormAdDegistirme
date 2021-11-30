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
    public partial class OyunAlani : Form
    {
        int speed;
        static int time = 3;
        static int toplam = 0;

        Random rnd = new Random();
        public OyunAlani(string ad, string soyad,byte zorluk)
        {
            InitializeComponent();
            lblisim.Text = ad;
            lblsoyisim.Text = soyad;

            switch (zorluk)
            {
                case 1:
                    time = 20;
                    speed = 1000;
                    break;
                case 2:
                    time = 15;
                    speed = 700;
                    break;
                case 3:
                    time = 10;
                    speed = 500;
                    break;
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void OyunAlani_Load(object sender, EventArgs e)
        {
            tmrsure.Start();
            tmrskor.Start();

            tmrskor.Interval = speed;
        }

        private void tmrsure_Tick(object sender, EventArgs e)
        {
            Button btn = new Button();
            btn.BackColor = Color.FromArgb(rnd.Next(256), rnd.Next(256), rnd.Next(256));
            btn.Size = new Size(50, 50);
            btn.Text = rnd.Next(100).ToString();
            btn.Location = new Point(rnd.Next(this.ClientSize.Width - pnlDurum.Width - btn.Width), rnd.Next(this.ClientSize.Height - btn.Height));
            btn.Click += Btn_Click;

            this.Controls.Add(btn);
            
        }
        private void Btn_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            toplam += int.Parse(btn.Text);
            lblscore.Text =$"{ toplam }";
            btn.Dispose();
        }

        private void tmrskor_Tick(object sender, EventArgs e)
        {
           time--;
            lbltime.Text = time.ToString();
            if (time == 0)
            {
                
                tmrsure.Stop();
                tmrskor.Stop();
                foreach (Control item in this.Controls)
                {
                    if (item is Button)
                    {
                        item.Enabled = false;
                    }
                }
                DialogResult cvp = MessageBox.Show($"Oyun Bitti. Skorunuz:{toplam} \nYeniden Başlamak İstiyorr Musunuz?"
                , "Yeniden Başlatma Onayı", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (cvp == DialogResult.Yes)
                {
                    Application.Restart();
                }
                else
                {
                    Application.Exit();
                }
            }

        }
    }
}
