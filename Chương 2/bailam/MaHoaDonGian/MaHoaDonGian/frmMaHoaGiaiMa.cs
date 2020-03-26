using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MaHoaDonGian
{
    public partial class frmMaHoaGiaiMa : Form
    {
        #region các khai báo
        public delegate void ProgressInitHandler(object sender, ProgressInitArgs e);
        public delegate void ProgressEventHandler(object sender, ProgressEventArgs e);
        public static event ProgressEventHandler IncrementPrgress;
        public static event ProgressInitHandler InitProgress;

        private MaHoa cryptographer = null;
        private int elapsed = 0;

        public class ProgressEventArgs
        {
            public static implicit operator ProgressEventHandler(ProgressEventArgs v)
            {
                throw new NotImplementedException();
            }
        }

        #endregion
    }
}
