
namespace FormAdDegisme
{
    partial class Karisik
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
            this.chbindirim = new System.Windows.Forms.CheckBox();
            this.btnuygula = new System.Windows.Forms.Button();
            this.txtindirim = new System.Windows.Forms.TextBox();
            this.lblfiyat = new System.Windows.Forms.Label();
            this.btnHesapla = new System.Windows.Forms.Button();
            this.chbKalem = new System.Windows.Forms.CheckBox();
            this.chbDefter = new System.Windows.Forms.CheckBox();
            this.chbSilgi = new System.Windows.Forms.CheckBox();
            this.lblTutar = new System.Windows.Forms.Label();
            this.combox = new System.Windows.Forms.ComboBox();
            this.txtilksayi = new System.Windows.Forms.TextBox();
            this.txtikincisayi = new System.Windows.Forms.TextBox();
            this.btnislemiyap = new System.Windows.Forms.Button();
            this.lblSonuc = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // chbindirim
            // 
            this.chbindirim.AutoSize = true;
            this.chbindirim.Location = new System.Drawing.Point(21, 38);
            this.chbindirim.Name = "chbindirim";
            this.chbindirim.Size = new System.Drawing.Size(82, 17);
            this.chbindirim.TabIndex = 0;
            this.chbindirim.Text = "%30 İndirim ";
            this.chbindirim.UseVisualStyleBackColor = true;
            // 
            // btnuygula
            // 
            this.btnuygula.Location = new System.Drawing.Point(21, 61);
            this.btnuygula.Name = "btnuygula";
            this.btnuygula.Size = new System.Drawing.Size(75, 23);
            this.btnuygula.TabIndex = 1;
            this.btnuygula.Text = "Uygula";
            this.btnuygula.UseVisualStyleBackColor = true;
            this.btnuygula.Click += new System.EventHandler(this.btnuygula_Click);
            // 
            // txtindirim
            // 
            this.txtindirim.Location = new System.Drawing.Point(12, 12);
            this.txtindirim.Name = "txtindirim";
            this.txtindirim.Size = new System.Drawing.Size(100, 20);
            this.txtindirim.TabIndex = 2;
            // 
            // lblfiyat
            // 
            this.lblfiyat.AutoSize = true;
            this.lblfiyat.Location = new System.Drawing.Point(49, 97);
            this.lblfiyat.Name = "lblfiyat";
            this.lblfiyat.Size = new System.Drawing.Size(13, 13);
            this.lblfiyat.TabIndex = 3;
            this.lblfiyat.Text = "0";
            // 
            // btnHesapla
            // 
            this.btnHesapla.Location = new System.Drawing.Point(209, 92);
            this.btnHesapla.Name = "btnHesapla";
            this.btnHesapla.Size = new System.Drawing.Size(75, 23);
            this.btnHesapla.TabIndex = 4;
            this.btnHesapla.Text = "Hesapla";
            this.btnHesapla.UseVisualStyleBackColor = true;
            this.btnHesapla.Click += new System.EventHandler(this.btnHesapla_Click);
            // 
            // chbKalem
            // 
            this.chbKalem.AutoSize = true;
            this.chbKalem.Location = new System.Drawing.Point(209, 15);
            this.chbKalem.Name = "chbKalem";
            this.chbKalem.Size = new System.Drawing.Size(85, 17);
            this.chbKalem.TabIndex = 5;
            this.chbKalem.Text = "Kalem -> 5.5";
            this.chbKalem.UseVisualStyleBackColor = true;
            // 
            // chbDefter
            // 
            this.chbDefter.AutoSize = true;
            this.chbDefter.Location = new System.Drawing.Point(209, 38);
            this.chbDefter.Name = "chbDefter";
            this.chbDefter.Size = new System.Drawing.Size(79, 17);
            this.chbDefter.TabIndex = 6;
            this.chbDefter.Text = "Defter ->20";
            this.chbDefter.UseVisualStyleBackColor = true;
            // 
            // chbSilgi
            // 
            this.chbSilgi.AutoSize = true;
            this.chbSilgi.Location = new System.Drawing.Point(209, 61);
            this.chbSilgi.Name = "chbSilgi";
            this.chbSilgi.Size = new System.Drawing.Size(78, 17);
            this.chbSilgi.TabIndex = 7;
            this.chbSilgi.Text = "Silgi ->4.25";
            this.chbSilgi.UseVisualStyleBackColor = true;
            // 
            // lblTutar
            // 
            this.lblTutar.AutoSize = true;
            this.lblTutar.Location = new System.Drawing.Point(239, 129);
            this.lblTutar.Name = "lblTutar";
            this.lblTutar.Size = new System.Drawing.Size(13, 13);
            this.lblTutar.TabIndex = 8;
            this.lblTutar.Text = "0";
            // 
            // combox
            // 
            this.combox.FormattingEnabled = true;
            this.combox.Items.AddRange(new object[] {
            "Topla",
            "Çıkar",
            "Çarp",
            "Böl"});
            this.combox.Location = new System.Drawing.Point(514, 31);
            this.combox.Name = "combox";
            this.combox.Size = new System.Drawing.Size(121, 21);
            this.combox.TabIndex = 9;
            this.combox.SelectedIndexChanged += new System.EventHandler(this.combox_SelectedIndexChanged);
            // 
            // txtilksayi
            // 
            this.txtilksayi.Location = new System.Drawing.Point(392, 32);
            this.txtilksayi.Name = "txtilksayi";
            this.txtilksayi.Size = new System.Drawing.Size(100, 20);
            this.txtilksayi.TabIndex = 10;
            // 
            // txtikincisayi
            // 
            this.txtikincisayi.Location = new System.Drawing.Point(392, 58);
            this.txtikincisayi.Name = "txtikincisayi";
            this.txtikincisayi.Size = new System.Drawing.Size(100, 20);
            this.txtikincisayi.TabIndex = 11;
            // 
            // btnislemiyap
            // 
            this.btnislemiyap.Location = new System.Drawing.Point(404, 87);
            this.btnislemiyap.Name = "btnislemiyap";
            this.btnislemiyap.Size = new System.Drawing.Size(75, 23);
            this.btnislemiyap.TabIndex = 12;
            this.btnislemiyap.Text = "İşlemi Yap";
            this.btnislemiyap.UseVisualStyleBackColor = true;
            this.btnislemiyap.Click += new System.EventHandler(this.btnislemiyap_Click);
            // 
            // lblSonuc
            // 
            this.lblSonuc.AutoSize = true;
            this.lblSonuc.Location = new System.Drawing.Point(553, 62);
            this.lblSonuc.Name = "lblSonuc";
            this.lblSonuc.Size = new System.Drawing.Size(13, 13);
            this.lblSonuc.TabIndex = 13;
            this.lblSonuc.Text = "0";
            // 
            // Karisik
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblSonuc);
            this.Controls.Add(this.btnislemiyap);
            this.Controls.Add(this.txtikincisayi);
            this.Controls.Add(this.txtilksayi);
            this.Controls.Add(this.combox);
            this.Controls.Add(this.lblTutar);
            this.Controls.Add(this.chbSilgi);
            this.Controls.Add(this.chbDefter);
            this.Controls.Add(this.chbKalem);
            this.Controls.Add(this.btnHesapla);
            this.Controls.Add(this.lblfiyat);
            this.Controls.Add(this.txtindirim);
            this.Controls.Add(this.btnuygula);
            this.Controls.Add(this.chbindirim);
            this.Name = "Karisik";
            this.Text = "Karisik";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox chbindirim;
        private System.Windows.Forms.Button btnuygula;
        private System.Windows.Forms.TextBox txtindirim;
        private System.Windows.Forms.Label lblfiyat;
        private System.Windows.Forms.Button btnHesapla;
        private System.Windows.Forms.CheckBox chbKalem;
        private System.Windows.Forms.CheckBox chbDefter;
        private System.Windows.Forms.CheckBox chbSilgi;
        private System.Windows.Forms.Label lblTutar;
        private System.Windows.Forms.ComboBox combox;
        private System.Windows.Forms.TextBox txtilksayi;
        private System.Windows.Forms.TextBox txtikincisayi;
        private System.Windows.Forms.Button btnislemiyap;
        private System.Windows.Forms.Label lblSonuc;
    }
}