using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ET_QLSanBay
{
    public class ET_PHANCONG
    {
        private string maChuyenBay;
        private string maNV;
        private string gioKH;
        private DateTime ngayKH;
        private int soGioBay;

        public string MaChuyenBay
        {
            get
            {
                return maChuyenBay;
            }
            set
            {
                maChuyenBay = value;
            }
        }
        public string MaNV
        {
            get
            {
                return maNV;
            }
            set
            {
                maNV = value;
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
        public int SoGioBay
        {
            get
            {
                return soGioBay;
            }
            set
            {
                soGioBay = value;
            }
        }
    }
}
