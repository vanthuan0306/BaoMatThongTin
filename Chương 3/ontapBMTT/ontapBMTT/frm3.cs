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
    public partial class frm3 : Form
    {
        public static string chuCaiRo = "abcdefghijklmnopqrstuvwxyz";
        public static string chuCaiDuocMaHoa = "SCJAXUFBQKTPRWEZHVLIGYDNMO";
        public frm3()
        {
            InitializeComponent();
            txtChuCaiRoCau3.Text = chuCaiRo;
            txtChuCaiDuocMaHoaCau3.Text = chuCaiDuocMaHoa;
        }

        private void txtChuCaiRoCau3_TextChanged(object sender, EventArgs e)
        {
            if (txtChuCaiRoCau3.Text.Length == 26 && txtChuCaiDuocMaHoaCau3.Text.Length == 26)
            {
                chuCaiRo = txtChuCaiRoCau3.Text.Trim();
                chuCaiDuocMaHoa = txtChuCaiDuocMaHoaCau3.Text.Trim();
                if (chkGiaiMaCau3.Checked)
                {
                    txtBanTinRoCau3.Enabled = false;
                    txtBanTinDuocMaHoaCau3.Enabled = true;
                    txtBanTinRoCau3.Clear();
                    txtBanTinDuocMaHoaCau3.Clear();
                }
                else
                {
                    txtBanTinRoCau3.Enabled = true;
                    txtBanTinDuocMaHoaCau3.Enabled = false;
                    txtBanTinRoCau3.Clear();
                    txtBanTinDuocMaHoaCau3.Clear();
                }
            }
            else
            {
                txtBanTinRoCau3.Enabled = false;
                txtBanTinDuocMaHoaCau3.Enabled = false;
            }
        }

        private void txtChuCaiDuocMaHoaCau3_TextChanged(object sender, EventArgs e)
        {
            if (txtChuCaiRoCau3.Text.Length == 26 && txtChuCaiDuocMaHoaCau3.Text.Length == 26)
            {
                chuCaiRo = txtChuCaiRoCau3.Text.Trim();
                chuCaiDuocMaHoa = txtChuCaiDuocMaHoaCau3.Text.Trim();
                if (chkGiaiMaCau3.Checked)
                {
                    txtBanTinRoCau3.Enabled = false;
                    txtBanTinDuocMaHoaCau3.Enabled = true;
                    txtBanTinRoCau3.Clear();
                    txtBanTinDuocMaHoaCau3.Clear();
                }
                else
                {
                    txtBanTinRoCau3.Enabled = true;
                    txtBanTinDuocMaHoaCau3.Enabled = false;
                    txtBanTinRoCau3.Clear();
                    txtBanTinDuocMaHoaCau3.Clear();
                }
            }
            else
            {
                txtBanTinRoCau3.Enabled = false;
                txtBanTinDuocMaHoaCau3.Enabled = false;
            }
        }

        private void txtBanTinRoCau3_TextChanged(object sender, EventArgs e)
        {
            string s = "";
            string banTinRoCau3 = txtBanTinRoCau3.Text;
            banTinRoCau3 = banTinRoCau3.Trim().ToLower();
            for (int i = 0; i < banTinRoCau3.Length; i++)
            {
                if ((int)banTinRoCau3[i] == 32)
                {
                    s += ' ';
                }
                for (int j = 0; j < chuCaiRo.Length; j++)
                {
                    if (banTinRoCau3[i] == chuCaiRo[j])
                    {
                        s += chuCaiDuocMaHoa[j];
                    }
                }
            }
            txtKetQuaCau3.Text = s;
        }

        private void txtBanTinDuocMaHoaCau3_TextChanged(object sender, EventArgs e)
        {
            string s = "";
            string banTinDuocMaHoaCau3 = txtBanTinDuocMaHoaCau3.Text;
            banTinDuocMaHoaCau3 = banTinDuocMaHoaCau3.Trim().ToUpper();
            for (int i = 0; i < banTinDuocMaHoaCau3.Length; i++)
            {
                if ((int)banTinDuocMaHoaCau3[i] == 32)
                {
                    s += ' ';
                }
                for (int j = 0; j < chuCaiDuocMaHoa.Length; j++)
                {
                    if (banTinDuocMaHoaCau3[i] == chuCaiDuocMaHoa[j])
                    {
                        s += chuCaiRo[j];
                    }
                }
            }
            txtKetQuaCau3.Text = s;
        }

        private void chkGiaiMaCau3_CheckedChanged(object sender, EventArgs e)
        {
            if (txtChuCaiRoCau3.Text.Length == 26 && txtChuCaiDuocMaHoaCau3.Text.Length == 26)
            {
                if (chkGiaiMaCau3.Checked)
                {
                    txtBanTinRoCau3.Enabled = false;
                    txtBanTinDuocMaHoaCau3.Enabled = true;
                    txtBanTinRoCau3.Clear();
                    txtBanTinDuocMaHoaCau3.Clear();
                }
                else
                {
                    txtBanTinRoCau3.Enabled = true;
                    txtBanTinDuocMaHoaCau3.Enabled = false;
                    txtBanTinRoCau3.Clear();
                    txtBanTinDuocMaHoaCau3.Clear();
                }
            }
            else
            {
                txtBanTinRoCau3.Enabled = false;
                txtBanTinDuocMaHoaCau3.Enabled = false;
            }
        }
    }
}
