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
        public DataTable layDSPB()
        {
            return dalPB.layDanhSachPB();
        }
        public DataTable layDSNV(ET_PHONGBAN et)
        {
            return dalPB.layDanhSachNV(et);
        }       
        
        public string layTenNV(string s)
        {
            return dalPB.layTenNV(s);
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
