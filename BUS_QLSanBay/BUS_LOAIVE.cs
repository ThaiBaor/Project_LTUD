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
    public class BUS_LOAIVE
    {
        DAL_LOAIVE dalLV = new DAL_LOAIVE();
        public DataTable layDSLoaiVe()
        {
            return dalLV.layDSLoaiVe();
        }
        public int themLoaiVe(ET_LOAIVE et)
        {
            return dalLV.themLoaiVe(et);
        }
        public int xoaLoaiVe(ET_LOAIVE et)
        {
            return dalLV.xoaLoaiVe(et);
        }
        public int suaLoaiVe(ET_LOAIVE et)
        {
            return dalLV.suaLoaiVe(et);
        }
    }
}
