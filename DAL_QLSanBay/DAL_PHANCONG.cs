using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using ET_QLSanBay;

namespace DAL_QLSanBay
{
    public class DAL_PHANCONG
    {
        // tao connecttion
        SqlConnection con = new SqlConnection("Data Source =.; Initial Catalog = QLSANBAY; Integrated Security = True");
        SqlCommand cmdPC;
        SqlDataAdapter daPC;
        DataTable dtPC;

        // tao method
        public DataTable layDanhSachPhanCong()
        {
            try
            {
                // mở kết nối
                con.Open();
                // khai báo command
                cmdPC = new SqlCommand("sp_layDSPHANCONG",con);
                cmdPC.CommandType = CommandType.StoredProcedure;
                // tạo đối tượng dataAdapter
                daPC = new SqlDataAdapter(cmdPC);
                dtPC = new DataTable();
                // fill data 
                daPC.Fill(dtPC);
            }
            catch (Exception)
            {
            }
            finally
            {
                con.Close();
            }
            return dtPC;
        }
        public int themPhanCong(ET_PHANCONG et)
        {
            try
            {
                // mở kết nối
                con.Open();
                // khai báo command
                cmdPC = new SqlCommand("sp_themPHANCONG", con);
                cmdPC.CommandType = CommandType.StoredProcedure;
                cmdPC.Parameters.AddWithValue("@MANV", et.MaNV);
                cmdPC.Parameters.AddWithValue("@MACHUYENBAY", et.MaChuyenBay);
                cmdPC.Parameters.AddWithValue("@NGAYKHOIHANH", et.NgayKH);
                cmdPC.Parameters.AddWithValue("@GIOKHOIHANH", et.GioKH);
                cmdPC.Parameters.AddWithValue("@SOGIOBAY", et.SoGioBay);
                if (cmdPC.ExecuteNonQuery() > 0)
                {
                    return 1;
                }
                // đóng kết nối
            }
            catch (Exception ex)
            {
                return -1;
            }
            finally
            {
                con.Close();
            }
            return 1;
        }
        public int xoaPhanCong(ET_PHANCONG et)
        {
            try
            {
                // mở kết nối
                con.Open();
                // khai báo command
                cmdPC = new SqlCommand("sp_xoaPHANCONG", con);
                cmdPC.CommandType = CommandType.StoredProcedure;
                cmdPC.Parameters.AddWithValue("@MANV", et.MaNV);
                cmdPC.Parameters.AddWithValue("@MACHUYENBAY", et.MaChuyenBay);
                cmdPC.Parameters.AddWithValue("@NGAYKHOIHANH", et.NgayKH);
                cmdPC.Parameters.AddWithValue("@GIOKHOIHANH", et.GioKH);
                if (cmdPC.ExecuteNonQuery() > 0)
                {
                    return 1;
                }
                // đóng kết nối
            }
            catch (Exception ex)
            {
                return -1;
            }
            finally
            {
                con.Close();
            }
            return 1;
        }
        public int suaPhanCong(ET_PHANCONG et)
        {
            try
            {
                // mở kết nối
                con.Open();
                // khai báo command
                cmdPC = new SqlCommand("sp_suaPHANCONG", con);
                cmdPC.CommandType = CommandType.StoredProcedure;
                cmdPC.Parameters.AddWithValue("@MANV", et.MaNV);
                cmdPC.Parameters.AddWithValue("@MACHUYENBAY", et.MaChuyenBay);
                cmdPC.Parameters.AddWithValue("@NGAYKHOIHANH", et.NgayKH);
                cmdPC.Parameters.AddWithValue("@GIOKHOIHANH", et.GioKH);
                cmdPC.Parameters.AddWithValue("@SOGIOBAY", et.SoGioBay);
                if (cmdPC.ExecuteNonQuery() > 0)
                {
                    return 1;
                }
                // đóng kết nối
            }
            catch (Exception ex)
            {
                return -1;
            }
            finally
            {
                con.Close();
            }
            return 1;
        }

    }
}
