using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using ET_QLSanBay;
using DAL_QLSanBay;

namespace BUS_QLSanBay
{
    public class BUS_LICHBAY
    {
        DAL_LICHBAY dalLB = new DAL_LICHBAY();
        public DataTable layDSLichBay()
        {
            return dalLB.layDanhSachLichBay();
        }
        public DataTable layDSGioKH_TheoMaChuyenBay(ET_LICHBAY et)
        {
            return dalLB.LayDanhSachGioKH_TheoMaChuyenBay(et);
        }
        public DataTable layDSNgayKH_TheoMaChuyenBay_TheoGioKH(ET_LICHBAY et)
        {
            return dalLB.LayDanhSachNgayKH_TheoMaChuyenBay_TheoGioKH(et);
        }
        public int themLichBay(ET_LICHBAY et)
        {
            return dalLB.themLichBay(et);
        }
        public int xoaLichBay(ET_LICHBAY et)
        {
            return dalLB.xoaLichBay(et);
        }
        public int suaLichBay(ET_LICHBAY et)
        {
            return dalLB.suaLichBay(et);
        }
    }
}
