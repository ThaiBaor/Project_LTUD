﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using ET_QLSanBay;
using DAL_QLSanBay;

namespace BUS_QLSanBay
{
    public class BUS_HHK
    {
        DAL_HHK dalHHK = new DAL_HHK();
        public DataTable layDSHHK()
        {
            return dalHHK.layDanhSachHHK();
        }
        public int themHHK(ET_HHK et)
        {
            return dalHHK.themHHK(et);
        }
        public int xoaHHK(ET_HHK et)
        {
            return dalHHK.xoaHHK(et);
        }
        public int capNhatHHK(ET_HHK et)
        {
            return dalHHK.capNhatHHK(et);
        }
    }
}