using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using ET_QLSanBay;
using DAL_QLSanBay;

namespace BUS_QLSanBay
{
    public class BUS_PHONBAN
    {
        DAL_PHONGBAN dalPB = new DAL_PHONGBAN();
        
        public DataTable layDSPB_TheoHHK(ET_HHK et)
        {
            return dalPB.layDanhSachPB_TheoHHK(et);
        }
        public DataTable layDSPB()
        {
            return dalPB.layDSPB();
        }
        public string layTenPhongBan_TheoMaPhong(string s)
        {
            return dalPB.layTenPhongBan_TheoMaPhong(s);
        }
        public int themPB(ET_PHONGBAN et)
        {
            return dalPB.themPB(et);
        }
        public int xoaPB(ET_PHONGBAN et)
        {
            return dalPB.xoaPB(et);
        }
        public int capNhatPB(ET_PHONGBAN et)
        {
            return dalPB.capNhatPB(et);
        }
    }
}
