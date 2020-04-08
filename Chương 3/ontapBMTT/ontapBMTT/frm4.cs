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
    public partial class frm4 : Form
    {
        public frm4()
        {
            InitializeComponent();
        }

        private void btnGiaiCau4_Click(object sender, EventArgs e)
        {
            txtTongKiTuCau4.Text = TinhTongSoKiTu(txtChuoiCau4.Text.Trim()).ToString();
            TinhTongSoChuCaiXuatHien(txtChuoiCau4.Text.Trim());
            TinhTongSoCapTrung(txtChuoiCau4.Text.Trim());
        }
        private void TinhTongSoCapTrung(string chuoi)
        {
            chuoi = String.Join("", chuoi.Where(c => !char.IsWhiteSpace(c)));
            chuoi = chuoi.Trim().ToUpper();
            List<string> mangCapTrung = new List<string>();
            List<string> mangTam = new List<string>();
            /*if (chuoi.StartsWith("0x"))
            {
                //return
                MessageBox.Show(chuoi.Skip(2)
                 .Select((x, i) => new { index = i, value = x })
                 .GroupBy(pair => pair.index / 2)
                 .Select(grp => string.Join("", grp.Select(x => x.value)))
                 .Select(x => Convert.ToByte(x, 16))
                 .ToArray().ToString());
            }*/
            int j = 1;
            for (int i = 0; i < chuoi.Length; i++)
            {
                if (j == chuoi.Length)
                {
                    break;
                }
                else
                {
                    string cap = "";
                    cap = cap + chuoi[i] + chuoi[j];
                    mangTam.Add(cap);
                    j++;
                }
            }
            var FreQ = from x in mangTam
                       group x by x into y
                       select y;
            foreach (var ArrEle in FreQ)
            {
                if (ArrEle.Count() > 1)
                {
                    mangCapTrung.Add(ArrEle.Key + ": " + ArrEle.Count());
                }
            }
            txtTongSoCapTrungCau4.Text = mangCapTrung.Count().ToString();
            richTextBoxCapTrungCau4.Text = String.Join("\n", mangCapTrung);
        }

        private void TinhTongSoChuCaiXuatHien(string chuoi)
        {
            chuoi = String.Join("", chuoi.Where(c => !char.IsWhiteSpace(c)));
            chuoi = chuoi.Trim().ToUpper();
            List<string> mangKiTuXuatHien = new List<string>();
            /*chuoi
            .Where(Char.IsLetterOrDigit)
            .GroupBy(c => c)
            .Aggregate((seed, next) =>
            {
                mangKiTuXuatHien.Add(next.Key + ": " + next.Count());
                return seed;
            });
            richTextBoxSoChuCaiCau4.Text = String.Join("\n", mangKiTuXuatHien);
            txtTongSoChuCaiXuatHienCau4.Text = mangKiTuXuatHien.Count().ToString();*/

            var FreQ = from x in chuoi
                       group x by x into y
                       select y;
            foreach (var ArrEle in FreQ)
            {
                mangKiTuXuatHien.Add(ArrEle.Key + ": " + ArrEle.Count());
            }
            richTextBoxSoChuCaiCau4.Text = String.Join("\n", mangKiTuXuatHien);
            txtTongSoChuCaiXuatHienCau4.Text = mangKiTuXuatHien.Count().ToString();
        }

        private int TinhTongSoKiTu(string chuoi)
        {
            chuoi = String.Join("", chuoi.Where(c => !char.IsWhiteSpace(c)));
            /*chuoi = chuoi.Replace("\n", string.Empty);
            chuoi = chuoi.Replace("\t", string.Empty);*/
            return chuoi.Length;
        }
        }
    }
