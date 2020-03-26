using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaHoaDonGian.DES
{
    class ProcessDES : CommonProcess
    {
        #region các biến cố
        public event frmMaHoaGiaiMa.ProgressInitHandler InitProgress;
        public event frmMaHoaGiaiMa.ProgressEventHandler IncrementPrgress;
        #endregion

        #region các hàm tạo
        public ProcessDES(frmMaHoaGiaiMa.ProgressEventArgs IncProg,
            frmMaHoaGiaiMa.ProgressInitHandler InitProg)
        {
            this.In = IncProg;
            this.InitProgress = InitProg;
        }

        #endregion
    }
}
