using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.SqlClient;
using System.Data;
using System.Text;
using ET_QLSanBay;
using DAL_QLSanBay;

namespace BUS_QLSanBay
{
    public class BUS_VEMAYBAY
    {
        DAL_VEMAYBAY dalVMB = new DAL_VEMAYBAY();
        public DataTable layDSVeMayBay()
        {
            return dalVMB.layDanhSachVeMayBay();
        }
        public int themVeMayBay(ET_VEMAYBAY et)
        {
            return dalVMB.themVeMayBay(et);
        }
        public int xoaVeMayBay(ET_VEMAYBAY et)
        {
            return dalVMB.xoaVeMayBay(et);
        }
        public int suaVeMayBay(ET_VEMAYBAY et)
        {
            return dalVMB.suaVeMayBay(et);
        }
    }
}
