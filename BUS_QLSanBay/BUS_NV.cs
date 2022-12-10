using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using DAL_QLSanBay;
using ET_QLSanBay;

namespace BUS_QLSanBay
{
    public class BUS_NV
    {
        DAL_NV dalNV = new DAL_NV();
        public DataTable layDSNV()
        {
            return dalNV.layDSNV();
        }
        public DataTable layDSPB()
        {
            return dalNV.layDanhSachPB();
        }
        public DataTable layDSNV(ET_PHONGBAN et)
        {
            return dalNV.layDanhSachNV(et);
        }

        public string layTenNV(string s)
        {
            return dalNV.layTenNV(s);
        }
        public DataTable layDSNgQL(ET_HHK et)
        {
            return dalNV.layDSNgQL(et);
        }
        public int themNV(ET_NV et)
        {
            return dalNV.themNV(et);
        }
        public int xoaNV(ET_NV et)
        {
            return dalNV.xoaNV(et);
        }
        public int suaNV(ET_NV et)
        {
            return dalNV.suaNV(et);
        }
    }
}
