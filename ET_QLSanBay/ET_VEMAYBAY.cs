using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ET_QLSanBay
{
    public class ET_VEMAYBAY
    {
        private string maSoVe;
        private string maLoaiVe;
        private int giaVe;
        private double kLHL;
        private string maSoGhe;
        private string maHK;
        private string maChuyenBay;
        private string gioKhoiHanh;
        private DateTime ngayKhoiHanh;

        public string MaSoVe
        {
            get
            {
                return maSoVe;
            }
            set
            {
                maSoVe = value;
            }
        }
        public string MaLoaiVe
        {
            get
            {
                return maLoaiVe;
            }
            set
            {
                maLoaiVe = value;
            }
        }
        public string MaSoGhe
        {
            get
            {
                return maSoGhe;
            }
            set
            {
                maSoGhe = value;
            }
        }
        public string MaHK
        {
            get
            {
                return maHK;
            }
            set
            {
                maHK = value;
            }
        }
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
        public string GioKhoiHanh
        {
            get
            {
                return gioKhoiHanh;
            }
            set
            {
                gioKhoiHanh = value;
            }
        }
        public DateTime NgayKhoiHanh
        {
            get
            {
                return ngayKhoiHanh;

            }
            set
            {
                ngayKhoiHanh = value;
            }
        }
        public int GiaVe
        {
            get
            {
                return giaVe;
            }
            set
            {
                giaVe = value;
            }
        }
        public double KLHL
        {
            get
            {
                return kLHL;
            }
            set
            {
                kLHL = value;
            }
        }
    }
}
