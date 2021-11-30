
namespace FormAdDegisme
{
    partial class SayiOyun
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
            this.btnOyna = new System.Windows.Forms.Button();
            this.txtad = new System.Windows.Forms.TextBox();
            this.rdbkolay = new System.Windows.Forms.RadioButton();
            this.rdborta = new System.Windows.Forms.RadioButton();
            this.rdbzor = new System.Windows.Forms.RadioButton();
            this.txtsoyad = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnOyna
            // 
            this.btnOyna.Location = new System.Drawing.Point(266, 203);
            this.btnOyna.Name = "btnOyna";
            this.btnOyna.Size = new System.Drawing.Size(75, 23);
            this.btnOyna.TabIndex = 0;
            this.btnOyna.Text = "OYNA";
            this.btnOyna.UseVisualStyleBackColor = true;
            this.btnOyna.Click += new System.EventHandler(this.btnOyna_Click);
            // 
            // txtad
            // 
            this.txtad.Location = new System.Drawing.Point(253, 77);
            this.txtad.Name = "txtad";
            this.txtad.Size = new System.Drawing.Size(100, 20);
            this.txtad.TabIndex = 1;
            // 
            // rdbkolay
            // 
            this.rdbkolay.AutoSize = true;
            this.rdbkolay.Location = new System.Drawing.Point(178, 166);
            this.rdbkolay.Name = "rdbkolay";
            this.rdbkolay.Size = new System.Drawing.Size(51, 17);
            this.rdbkolay.TabIndex = 2;
            this.rdbkolay.TabStop = true;
            this.rdbkolay.Text = "Kolay";
            this.rdbkolay.UseVisualStyleBackColor = true;
            // 
            // rdborta
            // 
            this.rdborta.AutoSize = true;
            this.rdborta.Location = new System.Drawing.Point(280, 166);
            this.rdborta.Name = "rdborta";
            this.rdborta.Size = new System.Drawing.Size(45, 17);
            this.rdborta.TabIndex = 3;
            this.rdborta.TabStop = true;
            this.rdborta.Text = "Orta";
            this.rdborta.UseVisualStyleBackColor = true;
            // 
            // rdbzor
            // 
            this.rdbzor.AutoSize = true;
            this.rdbzor.Location = new System.Drawing.Point(379, 166);
            this.rdbzor.Name = "rdbzor";
            this.rdbzor.Size = new System.Drawing.Size(41, 17);
            this.rdbzor.TabIndex = 4;
            this.rdbzor.TabStop = true;
            this.rdbzor.Text = "Zor";
            this.rdbzor.UseVisualStyleBackColor = true;
            // 
            // txtsoyad
            // 
            this.txtsoyad.Location = new System.Drawing.Point(253, 115);
            this.txtsoyad.Name = "txtsoyad";
            this.txtsoyad.Size = new System.Drawing.Size(100, 20);
            this.txtsoyad.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(212, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Adınız";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(195, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Soyadınız";
            // 
            // SayiOyun
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(691, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtsoyad);
            this.Controls.Add(this.rdbzor);
            this.Controls.Add(this.rdborta);
            this.Controls.Add(this.rdbkolay);
            this.Controls.Add(this.txtad);
            this.Controls.Add(this.btnOyna);
            this.Name = "SayiOyun";
            this.Text = "SayiOyun";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOyna;
        private System.Windows.Forms.TextBox txtad;
        private System.Windows.Forms.RadioButton rdbkolay;
        private System.Windows.Forms.RadioButton rdborta;
        private System.Windows.Forms.RadioButton rdbzor;
        private System.Windows.Forms.TextBox txtsoyad;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}