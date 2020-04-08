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
    public partial class frm5 : Form
    {
        public frm5()
        {
            InitializeComponent();
        }

        private void btnTinhCau5_Click(object sender, EventArgs e)
        {
            long thuong, sodu, sobichia, sochia;
            sobichia = long.Parse(txtSoBiChiaCau5.Text.Trim().ToString());
            sochia = long.Parse(txtSoChiaCau5.Text.Trim().ToString());
            thuong = sobichia / sochia;
            sodu = sobichia % sochia;
            txtThuongCau5.Text = thuong.ToString();
            txtSoDuCau5.Text = sodu.ToString();
        }
    }
}
