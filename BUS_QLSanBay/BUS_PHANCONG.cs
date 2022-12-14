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
    public class BUS_PHANCONG
    {
        DAL_PHANCONG dalPC = new DAL_PHANCONG();
        public DataTable layDSPhanCong()
        {
            return dalPC.layDanhSachPhanCong();
        }
        public int themPhanCong(ET_PHANCONG et)
        {
            return dalPC.themPhanCong(et);
        }
        public int xoaPhanCong(ET_PHANCONG et)
        {
            return dalPC.xoaPhanCong(et);
        }
        public int suaPhanCong(ET_PHANCONG et)
        {
            return dalPC.suaPhanCong(et);
        }
    }
}
