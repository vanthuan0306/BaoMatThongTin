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
    public partial class frm1va2 : Form
    {
        public frm1va2()
        {
            InitializeComponent();
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            if (chkGiaiMa.Checked)
            {
                GiaiMa();
            }
            else
            {
                MaHoa();
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            MaHoa();
        }
        private void MaHoa()
        {
            string s = "";
            string banTinRo = textBox3.Text;
            //banTinRo = banTinRo.Replace(" ", string.Empty);
            banTinRo = banTinRo.Trim().ToUpper();
            //MessageBox.Show(banTinRo);
            for (int i = 0; i < banTinRo.Length; i++)
            {
                char c = banTinRo[i];
                int n = (int)c;

                if (n == 32)
                {
                    s += ' '; // s = s + c 
                }
                else
                {
                    c = (Char)((n - 65 + (int)(numericUpDown1.Value) + 26) % 26 + 65);
                    //c = (Char)(n - 65);
                    s += c; // s = s + c 
                }
            }
            //txtBanTinDuocMaHoa.Text = s;
            txtKetQua.Text = s;
        }

        private void txtBanTinDuocMaHoa_TextChanged(object sender, EventArgs e)
        {
            GiaiMa();
        }
        private void GiaiMa()
        {
            string s = "";
            string banTinDuocMaHoa = txtBanTinDuocMaHoa.Text;
            //banTinDuocMaHoa = banTinDuocMaHoa.Replace(" ", string.Empty);
            banTinDuocMaHoa = banTinDuocMaHoa.Trim().ToUpper();
            for (int i = 0; i < banTinDuocMaHoa.Length; i++)
            {
                char c = banTinDuocMaHoa[i];
                int n = (int)c;

                if (n == 32)
                {
                    s += ' '; // s = s + c 
                }
                else
                {
                    c = (Char)((n - 65 - (int)(numericUpDown1.Value) + 26) % 26 + 65);
                    //c = (Char)(n - 65);
                    s += c; // s = s + c 
                }
            }
            //txtBanTinRo.Text = s;
            txtKetQua.Text = s;
        }

    }
}
