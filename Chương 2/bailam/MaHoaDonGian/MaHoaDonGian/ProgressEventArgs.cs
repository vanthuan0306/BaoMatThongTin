using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaHoaDonGian
{
    
        public class ProgressInitArgs : EventArgs
        {
            #region khai báo biến
            public int Maximun; // thành phần dữ liệu
            #endregion

            #region các hàm tạo
            public ProgressInitArgs(int Max)
            {
                this.Maximun = Max;
            }
            #endregion
        }

        public class ProgressEventArgs : EventArgs
        {
            #region khai báo bi
            public int Increment;
            #endregion
            #region các hàm tạo
            public ProgressEventArgs(int Inc)
            {
                this.Increment = Inc;
            }
            #endregion
        }
    
}
