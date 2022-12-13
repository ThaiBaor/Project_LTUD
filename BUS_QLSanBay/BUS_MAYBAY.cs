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
    public class BUS_MAYBAY
    {
        DAL_MAYBAY dalMB = new DAL_MAYBAY();
        public DataTable layDSMayBay()
        {
            return dalMB.layDanhSachMayBay();
        }
        public DataTable layDSMayBay_TheoHHK(ET_HHK et)
        {
            return dalMB.layDanhSachMayBay_TheoHHK(et);
        }
        public int themMayBay(ET_MAYBAY et)
        {
            return dalMB.themMayBay(et);
        }
        public int xoaMayBay(ET_MAYBAY et)
        {
            return dalMB.xoaMayBay(et);
        }
        public int suaMayBay(ET_MAYBAY et)
        {
            return dalMB.suaMayBay(et);
        }
        public string laySoHieuMayBay_TheoMaChuyenBay(string s)
        {
            return dalMB.laySoHieuMayBay_TheoMaChuyenBay(s);
        }
    }
}
