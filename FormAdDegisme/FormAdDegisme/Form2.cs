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

    public partial class Form2 : Form
    {
        Form1 frm;
        public Form2(Form1 frm1)
        {
            InitializeComponent();
            this.frm = frm1;
        }

        private void btnAdDegis_Click(object sender, EventArgs e)
        {
           
            frm.Text = txtAdDegis.Text;
          
        }

    }
}
