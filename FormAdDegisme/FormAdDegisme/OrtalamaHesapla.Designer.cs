
namespace FormAdDegisme
{
    partial class OrtalamaHesapla
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
            this.txtnot2 = new System.Windows.Forms.TextBox();
            this.txtnot1 = new System.Windows.Forms.TextBox();
            this.txtAdSoyad = new System.Windows.Forms.TextBox();
            this.btnHesapla = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtnot3 = new System.Windows.Forms.TextBox();
            this.lstSonuc = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // txtnot2
            // 
            this.txtnot2.Location = new System.Drawing.Point(241, 83);
            this.txtnot2.Name = "txtnot2";
            this.txtnot2.Size = new System.Drawing.Size(100, 20);
            this.txtnot2.TabIndex = 0;
            // 
            // txtnot1
            // 
            this.txtnot1.Location = new System.Drawing.Point(241, 57);
            this.txtnot1.Name = "txtnot1";
            this.txtnot1.Size = new System.Drawing.Size(100, 20);
            this.txtnot1.TabIndex = 1;
            // 
            // txtAdSoyad
            // 
            this.txtAdSoyad.Location = new System.Drawing.Point(241, 31);
            this.txtAdSoyad.Name = "txtAdSoyad";
            this.txtAdSoyad.Size = new System.Drawing.Size(100, 20);
            this.txtAdSoyad.TabIndex = 2;
            this.txtAdSoyad.Text = "  ";
            // 
            // btnHesapla
            // 
            this.btnHesapla.Location = new System.Drawing.Point(169, 150);
            this.btnHesapla.Name = "btnHesapla";
            this.btnHesapla.Size = new System.Drawing.Size(172, 40);
            this.btnHesapla.TabIndex = 3;
            this.btnHesapla.Text = "Ortalamayı Hesapla";
            this.btnHesapla.UseVisualStyleBackColor = true;
            this.btnHesapla.Click += new System.EventHandler(this.btnHesapla_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(182, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Ad Soyad";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(166, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "1.Sınav Notu";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(166, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "2.Sınav Notu";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(166, 112);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "3.Sınav Notu";
            // 
            // txtnot3
            // 
            this.txtnot3.Location = new System.Drawing.Point(241, 109);
            this.txtnot3.Name = "txtnot3";
            this.txtnot3.Size = new System.Drawing.Size(100, 20);
            this.txtnot3.TabIndex = 8;
            // 
            // lstSonuc
            // 
            this.lstSonuc.FormattingEnabled = true;
            this.lstSonuc.Location = new System.Drawing.Point(169, 212);
            this.lstSonuc.Name = "lstSonuc";
            this.lstSonuc.Size = new System.Drawing.Size(172, 95);
            this.lstSonuc.TabIndex = 9;
            this.lstSonuc.SelectedIndexChanged += new System.EventHandler(this.lstSonuc_SelectedIndexChanged);
            // 
            // OrtalamaHesapla
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(578, 450);
            this.Controls.Add(this.lstSonuc);
            this.Controls.Add(this.txtnot3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnHesapla);
            this.Controls.Add(this.txtAdSoyad);
            this.Controls.Add(this.txtnot1);
            this.Controls.Add(this.txtnot2);
            this.Name = "OrtalamaHesapla";
            this.Text = "OrtalamaHesapla";
            this.Load += new System.EventHandler(this.OrtalamaHesapla_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtnot2;
        private System.Windows.Forms.TextBox txtnot1;
        private System.Windows.Forms.TextBox txtAdSoyad;
        private System.Windows.Forms.Button btnHesapla;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtnot3;
        private System.Windows.Forms.ListBox lstSonuc;
    }
}