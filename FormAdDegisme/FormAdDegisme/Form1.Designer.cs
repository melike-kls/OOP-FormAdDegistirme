
namespace FormAdDegisme
{
    partial class Form1
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
            this.btnAc = new System.Windows.Forms.Button();
            this.btnRandom = new System.Windows.Forms.Button();
            this.btnorthsp = new System.Windows.Forms.Button();
            this.btnSayiOyna = new System.Windows.Forms.Button();
            this.btnSayiTahmin = new System.Windows.Forms.Button();
            this.btnKarisik = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAc
            // 
            this.btnAc.Location = new System.Drawing.Point(219, 43);
            this.btnAc.Name = "btnAc";
            this.btnAc.Size = new System.Drawing.Size(75, 23);
            this.btnAc.TabIndex = 0;
            this.btnAc.Text = "Form2 Aç";
            this.btnAc.UseVisualStyleBackColor = true;
            this.btnAc.Click += new System.EventHandler(this.btnAc_Click);
            // 
            // btnRandom
            // 
            this.btnRandom.Location = new System.Drawing.Point(190, 89);
            this.btnRandom.Name = "btnRandom";
            this.btnRandom.Size = new System.Drawing.Size(140, 25);
            this.btnRandom.TabIndex = 1;
            this.btnRandom.Text = "Random Toplamayı Aç";
            this.btnRandom.UseVisualStyleBackColor = true;
            this.btnRandom.Click += new System.EventHandler(this.btnRandom_Click);
            // 
            // btnorthsp
            // 
            this.btnorthsp.Location = new System.Drawing.Point(190, 138);
            this.btnorthsp.Name = "btnorthsp";
            this.btnorthsp.Size = new System.Drawing.Size(140, 23);
            this.btnorthsp.TabIndex = 2;
            this.btnorthsp.Text = "Ortalama Hesaplamayı Aç";
            this.btnorthsp.UseVisualStyleBackColor = true;
            this.btnorthsp.Click += new System.EventHandler(this.btnorthsp_Click);
            // 
            // btnSayiOyna
            // 
            this.btnSayiOyna.Location = new System.Drawing.Point(190, 187);
            this.btnSayiOyna.Name = "btnSayiOyna";
            this.btnSayiOyna.Size = new System.Drawing.Size(140, 23);
            this.btnSayiOyna.TabIndex = 3;
            this.btnSayiOyna.Text = "Sayı Toplama Oyna";
            this.btnSayiOyna.UseVisualStyleBackColor = true;
            this.btnSayiOyna.Click += new System.EventHandler(this.btnSayiOyna_Click);
            // 
            // btnSayiTahmin
            // 
            this.btnSayiTahmin.Location = new System.Drawing.Point(190, 235);
            this.btnSayiTahmin.Name = "btnSayiTahmin";
            this.btnSayiTahmin.Size = new System.Drawing.Size(140, 23);
            this.btnSayiTahmin.TabIndex = 4;
            this.btnSayiTahmin.Text = "Sayı Tahmin Oyna";
            this.btnSayiTahmin.UseVisualStyleBackColor = true;
            this.btnSayiTahmin.Click += new System.EventHandler(this.btnSayiTahmin_Click);
            // 
            // btnKarisik
            // 
            this.btnKarisik.Location = new System.Drawing.Point(190, 283);
            this.btnKarisik.Name = "btnKarisik";
            this.btnKarisik.Size = new System.Drawing.Size(140, 23);
            this.btnKarisik.TabIndex = 5;
            this.btnKarisik.Text = "Karışık Aç";
            this.btnKarisik.UseVisualStyleBackColor = true;
            this.btnKarisik.Click += new System.EventHandler(this.btnKarisik_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(605, 450);
            this.Controls.Add(this.btnKarisik);
            this.Controls.Add(this.btnSayiTahmin);
            this.Controls.Add(this.btnSayiOyna);
            this.Controls.Add(this.btnorthsp);
            this.Controls.Add(this.btnRandom);
            this.Controls.Add(this.btnAc);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAc;
        private System.Windows.Forms.Button btnRandom;
        private System.Windows.Forms.Button btnorthsp;
        private System.Windows.Forms.Button btnSayiOyna;
        private System.Windows.Forms.Button btnSayiTahmin;
        private System.Windows.Forms.Button btnKarisik;
    }
}

