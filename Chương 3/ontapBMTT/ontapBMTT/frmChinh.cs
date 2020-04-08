using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ontapBMTT
{
    public partial class frmChinh : Form
    {
        public frmChinh()
        {
            InitializeComponent();
        }


        private void btn1va2_Click(object sender, EventArgs e)
        {
            frm1va2 frm1Va2 = new frm1va2();
            frm1Va2.ShowDialog();
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            frm3 Frm3 = new frm3();
            Frm3.ShowDialog();
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            frm4 Frm4 = new frm4();
            Frm4.ShowDialog();
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            frm5 Frm5 = new frm5();
            Frm5.ShowDialog();
        }
    }
}
