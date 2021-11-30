
namespace FormAdDegisme
{
    partial class Form2
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
            this.btnAdDegis = new System.Windows.Forms.Button();
            this.txtAdDegis = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnAdDegis
            // 
            this.btnAdDegis.Location = new System.Drawing.Point(186, 126);
            this.btnAdDegis.Name = "btnAdDegis";
            this.btnAdDegis.Size = new System.Drawing.Size(75, 23);
            this.btnAdDegis.TabIndex = 0;
            this.btnAdDegis.Text = "Ad Değiştir";
            this.btnAdDegis.UseVisualStyleBackColor = true;
            this.btnAdDegis.Click += new System.EventHandler(this.btnAdDegis_Click);
            // 
            // txtAdDegis
            // 
            this.txtAdDegis.Location = new System.Drawing.Point(172, 100);
            this.txtAdDegis.Name = "txtAdDegis";
            this.txtAdDegis.Size = new System.Drawing.Size(100, 20);
            this.txtAdDegis.TabIndex = 1;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(486, 450);
            this.Controls.Add(this.txtAdDegis);
            this.Controls.Add(this.btnAdDegis);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAdDegis;
        private System.Windows.Forms.TextBox txtAdDegis;
    }
}