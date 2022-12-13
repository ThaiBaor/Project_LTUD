using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ET_QLSanBay
{
    public class ET_LICHBAY
    {
        private string maCB;
        private string soHieuMB;
        private string gioKH;
        private DateTime ngayKH;
        public string MaCB
        {
            get
            {
                return maCB;
            }
            set
            {
                maCB = value;
            }
        }
        public string SoHieuMB
        {
            get
            {
                return soHieuMB;
            }
            set
            {
                soHieuMB = value;
            }
        }
        public string GioKH
        {
            get
            {
                return gioKH;
            }
            set
            {
                gioKH = value;
            }
        }
        public DateTime NgayKH
        {
            get
            {
                return ngayKH;
            }
            set
            {
                ngayKH = value;
            }
        }
    }
}
