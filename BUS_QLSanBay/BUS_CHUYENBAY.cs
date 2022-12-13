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
    public class BUS_CHUYENBAY
    {
        DAL_CHUYENBAY dalCB = new DAL_CHUYENBAY();
        public DataTable layDSChuyenBay()
        {
            return dalCB.layDSChuyenBay();
        }
        public DataTable layDSChuyenBayTheoHHK(ET_HHK et)
        {
            return dalCB.layDSChuyenBayTheoHHK(et);
        }
        public string laySBKH_TheoMaChuyenBay(string s)
        {
            return dalCB.layNoiKH_TheoMaChuyenBay(s);
        }
        public string laySBDen_TheoMaChuyenBay(string s)
        {
            return dalCB.layNoiDen_TheoMaChuyenBay(s);
        }
        public string laySBTC_TheoMaChuyenBay(string s)
        {
            return dalCB.layNoiTC_TheoMaChuyenBay(s);
        }
        public int themChuyenBay(ET_CHUYENBAY et)
        {
            return dalCB.themChuyenBay(et);
        }
        public int xoaChuyenBay(ET_CHUYENBAY et)
        {
            return dalCB.xoaChuyenBay(et);
        }
        public int suaChuyenBay(ET_CHUYENBAY et)
        {
            return dalCB.suaChuyenBay(et);
        }
    }
}
