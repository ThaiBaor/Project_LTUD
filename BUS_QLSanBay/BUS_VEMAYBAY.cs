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
        public DataTable layDSVeMayBay_TheoTenHHK(string tenHHK)
        {
            return dalVMB.layDanhSachVeMayBay_TheoTenHHK(tenHHK);
        }
        public DataTable layDSVeMayBay_TheoMaSoVe(string maSoVe)
        {
            return dalVMB.layDanhSachVeMayBay_TheoMaSoVe(maSoVe);
        }
        public DataTable layDSVeMayBay_TheoTenLoaiVe(string tenLoaiVe)
        {
            return dalVMB.layDanhSachVeMayBay_TheoLoaiVe(tenLoaiVe);
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
