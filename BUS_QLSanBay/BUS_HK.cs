using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using ET_QLSanBay;
using DAL_QLSanBay;

namespace BUS_QLSanBay
{
    public class BUS_HK
    {
        DAL_HK dalHK = new DAL_HK();
        public DataTable layDSHK()
        {
            return dalHK.layDSHK();
        }
        public int themHK(ET_HK et)
        {
            return dalHK.themHK(et);
        }
        public int xoaHK(ET_HK et)
        {
            return dalHK.xoaK(et);
        }
        public int suaHK(ET_HK et)
        {
            return dalHK.suaHK(et);
        }
    }
}
