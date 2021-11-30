
namespace FormAdDegisme
{
    partial class SayiTahmin
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
            this.btntahmin = new System.Windows.Forms.Button();
            this.txttahmin = new System.Windows.Forms.TextBox();
            this.lblskor = new System.Windows.Forms.Label();
            this.lbltekrar = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btntahmin
            // 
            this.btntahmin.Location = new System.Drawing.Point(212, 145);
            this.btntahmin.Name = "btntahmin";
            this.btntahmin.Size = new System.Drawing.Size(100, 24);
            this.btntahmin.TabIndex = 0;
            this.btntahmin.Text = "Sayıyı Tahmin Et";
            this.btntahmin.UseVisualStyleBackColor = true;
            this.btntahmin.Click += new System.EventHandler(this.btntahmin_Click);
            // 
            // txttahmin
            // 
            this.txttahmin.Location = new System.Drawing.Point(212, 104);
            this.txttahmin.Name = "txttahmin";
            this.txttahmin.Size = new System.Drawing.Size(100, 20);
            this.txttahmin.TabIndex = 2;
            this.txttahmin.TextChanged += new System.EventHandler(this.txttahmin_TextChanged);
            // 
            // lblskor
            // 
            this.lblskor.AutoSize = true;
            this.lblskor.Location = new System.Drawing.Point(256, 64);
            this.lblskor.Name = "lblskor";
            this.lblskor.Size = new System.Drawing.Size(13, 13);
            this.lblskor.TabIndex = 3;
            this.lblskor.Text = "0";
            this.lblskor.Click += new System.EventHandler(this.lblskor_Click);
            // 
            // lbltekrar
            // 
            this.lbltekrar.AutoSize = true;
            this.lbltekrar.Location = new System.Drawing.Point(231, 39);
            this.lbltekrar.Name = "lbltekrar";
            this.lbltekrar.Size = new System.Drawing.Size(61, 13);
            this.lbltekrar.TabIndex = 4;
            this.lbltekrar.Text = "Tahmin Et!!";
            // 
            // SayiTahmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(588, 450);
            this.Controls.Add(this.lbltekrar);
            this.Controls.Add(this.lblskor);
            this.Controls.Add(this.txttahmin);
            this.Controls.Add(this.btntahmin);
            this.Name = "SayiTahmin";
            this.Text = "SayiTahmin";
            this.Load += new System.EventHandler(this.SayiTahmin_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btntahmin;
        private System.Windows.Forms.TextBox txttahmin;
        private System.Windows.Forms.Label lblskor;
        private System.Windows.Forms.Label lbltekrar;
    }
}