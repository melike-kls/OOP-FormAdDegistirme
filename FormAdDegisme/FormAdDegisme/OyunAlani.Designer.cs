
namespace FormAdDegisme
{
    partial class OyunAlani
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.pnlDurum = new System.Windows.Forms.Panel();
            this.lblAd = new System.Windows.Forms.Label();
            this.lblisim = new System.Windows.Forms.Label();
            this.lblSoyad = new System.Windows.Forms.Label();
            this.lblsoyisim = new System.Windows.Forms.Label();
            this.lbltime = new System.Windows.Forms.Label();
            this.lblsure = new System.Windows.Forms.Label();
            this.lblskor = new System.Windows.Forms.Label();
            this.lblscore = new System.Windows.Forms.Label();
            this.tmrsure = new System.Windows.Forms.Timer(this.components);
            this.tmrskor = new System.Windows.Forms.Timer(this.components);
            this.pnlDurum.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlDurum
            // 
            this.pnlDurum.BackColor = System.Drawing.Color.SkyBlue;
            this.pnlDurum.Controls.Add(this.lblscore);
            this.pnlDurum.Controls.Add(this.lblskor);
            this.pnlDurum.Controls.Add(this.lblsure);
            this.pnlDurum.Controls.Add(this.lbltime);
            this.pnlDurum.Controls.Add(this.lblsoyisim);
            this.pnlDurum.Controls.Add(this.lblSoyad);
            this.pnlDurum.Controls.Add(this.lblisim);
            this.pnlDurum.Controls.Add(this.lblAd);
            this.pnlDurum.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlDurum.Location = new System.Drawing.Point(634, 0);
            this.pnlDurum.Name = "pnlDurum";
            this.pnlDurum.Size = new System.Drawing.Size(166, 450);
            this.pnlDurum.TabIndex = 0;
            this.pnlDurum.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // lblAd
            // 
            this.lblAd.AutoSize = true;
            this.lblAd.Location = new System.Drawing.Point(16, 39);
            this.lblAd.Name = "lblAd";
            this.lblAd.Size = new System.Drawing.Size(23, 13);
            this.lblAd.TabIndex = 0;
            this.lblAd.Text = "Ad:";
            // 
            // lblisim
            // 
            this.lblisim.AutoSize = true;
            this.lblisim.Location = new System.Drawing.Point(42, 39);
            this.lblisim.Name = "lblisim";
            this.lblisim.Size = new System.Drawing.Size(19, 13);
            this.lblisim.TabIndex = 1;
            this.lblisim.Text = "ad";
            // 
            // lblSoyad
            // 
            this.lblSoyad.AutoSize = true;
            this.lblSoyad.Location = new System.Drawing.Point(67, 39);
            this.lblSoyad.Name = "lblSoyad";
            this.lblSoyad.Size = new System.Drawing.Size(40, 13);
            this.lblSoyad.TabIndex = 2;
            this.lblSoyad.Text = "Soyad:";
            // 
            // lblsoyisim
            // 
            this.lblsoyisim.AutoSize = true;
            this.lblsoyisim.Location = new System.Drawing.Point(110, 39);
            this.lblsoyisim.Name = "lblsoyisim";
            this.lblsoyisim.Size = new System.Drawing.Size(35, 13);
            this.lblsoyisim.TabIndex = 3;
            this.lblsoyisim.Text = "soyad";
            // 
            // lbltime
            // 
            this.lbltime.AutoSize = true;
            this.lbltime.Location = new System.Drawing.Point(19, 103);
            this.lbltime.Name = "lbltime";
            this.lbltime.Size = new System.Drawing.Size(26, 13);
            this.lbltime.TabIndex = 4;
            this.lbltime.Text = "time";
            // 
            // lblsure
            // 
            this.lblsure.AutoSize = true;
            this.lblsure.Location = new System.Drawing.Point(16, 81);
            this.lblsure.Name = "lblsure";
            this.lblsure.Size = new System.Drawing.Size(29, 13);
            this.lblsure.TabIndex = 5;
            this.lblsure.Text = "Süre";
            // 
            // lblskor
            // 
            this.lblskor.AutoSize = true;
            this.lblskor.Location = new System.Drawing.Point(88, 81);
            this.lblskor.Name = "lblskor";
            this.lblskor.Size = new System.Drawing.Size(29, 13);
            this.lblskor.TabIndex = 6;
            this.lblskor.Text = "Skor";
            // 
            // lblscore
            // 
            this.lblscore.AutoSize = true;
            this.lblscore.Location = new System.Drawing.Point(88, 103);
            this.lblscore.Name = "lblscore";
            this.lblscore.Size = new System.Drawing.Size(33, 13);
            this.lblscore.TabIndex = 7;
            this.lblscore.Text = "score";
            // 
            // tmrsure
            // 
            this.tmrsure.Interval = 1000;
            this.tmrsure.Tick += new System.EventHandler(this.tmrsure_Tick);
            // 
            // tmrskor
            // 
            this.tmrskor.Interval = 1000;
            this.tmrskor.Tick += new System.EventHandler(this.tmrskor_Tick);
            // 
            // OyunAlani
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pnlDurum);
            this.Name = "OyunAlani";
            this.Text = "OyunAlani";
            this.Load += new System.EventHandler(this.OyunAlani_Load);
            this.pnlDurum.ResumeLayout(false);
            this.pnlDurum.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlDurum;
        private System.Windows.Forms.Label lblscore;
        private System.Windows.Forms.Label lblskor;
        private System.Windows.Forms.Label lblsure;
        private System.Windows.Forms.Label lbltime;
        private System.Windows.Forms.Label lblsoyisim;
        private System.Windows.Forms.Label lblSoyad;
        private System.Windows.Forms.Label lblisim;
        private System.Windows.Forms.Label lblAd;
        private System.Windows.Forms.Timer tmrsure;
        private System.Windows.Forms.Timer tmrskor;
    }
}