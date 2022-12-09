using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using ET_QLSanBay;

namespace DAL_QLSanBay
{
    public class DAL_PHONGBAN
    {
        // tao connecttion
        SqlConnection con = new SqlConnection("Data Source =.; Initial Catalog = QLSANBAY; Integrated Security = True");
        SqlCommand cmdPB;
        SqlDataAdapter daPB;
        DataTable dtPB;

        public DataTable layDanhSachPB()
        {
            try
            {
                // mở kết nối
                con.Open();
                // khai báo command
                cmdPB = new SqlCommand();
                cmdPB.CommandText = "sp_layDSPHONGBAN";
                cmdPB.CommandType = CommandType.StoredProcedure;
                // gán kết nối
                cmdPB.Connection = con;
                // tạo đối tượng dataAdapter
                daPB = new SqlDataAdapter(cmdPB);
                dtPB = new DataTable();
                // fill data 
                daPB.Fill(dtPB);
            }
            catch (Exception)
            {
            }
            finally
            {
                con.Close();
            }
            return dtPB;
        }
        
        public DataTable layDanhSachNV(ET_PHONGBAN et)
        {
            try
            {
                // mở kết nối
                con.Open();
                // khai báo command
                cmdPB = new SqlCommand();
                cmdPB.CommandText = "sp_layDSNV_theoPHONGBAN_theoHANGHANGKHONG";
                cmdPB.CommandType = CommandType.StoredProcedure;
                cmdPB.Parameters.AddWithValue("@MAHANGHK", et.MaHHK);
                cmdPB.Parameters.AddWithValue("@MAPHG", et.MaPhong);
                // gán kết nối
                cmdPB.Connection = con;
                // tạo đối tượng dataAdapter
                daPB = new SqlDataAdapter(cmdPB);
                dtPB = new DataTable();
                // fill data 
                daPB.Fill(dtPB);
            }
            catch (Exception)
            {
            }
            finally
            {
                con.Close();
            }
            return dtPB;
        }
        
        public string layTenNV(string s)
        {
            string kq = "";
            try
            {
                // mở kết nối
                con.Open();
                // khai báo command
                cmdPB = new SqlCommand();
                cmdPB.CommandText = "sp_layTENNHANVIEN_theoMANHANVIEN";
                cmdPB.CommandType = CommandType.StoredProcedure;
                cmdPB.Parameters.AddWithValue("@MANV", s);
                // gán kết nối
                cmdPB.Connection = con;

                kq = cmdPB.ExecuteScalar().ToString();
            }
            catch (Exception)
            {
            }
            finally
            {
                con.Close();
            }
            return kq;
        }
        public int themPB(ET_PHONGBAN et)
        {
            try
            {
                // mở kết nối
                con.Open();
                // khai báo command
                SqlCommand cmdHHK = new SqlCommand("sp_themPHONGBAN", con);
                cmdHHK.CommandType = CommandType.StoredProcedure;
                cmdHHK.Parameters.AddWithValue("@MAPHONG", et.MaPhong);
                cmdHHK.Parameters.AddWithValue("@MAHANGHK", et.MaHHK);
                cmdHHK.Parameters.AddWithValue("@TENPHG", et.TenPhong);
                cmdHHK.Parameters.AddWithValue("@TRPHG", et.TrgPhong);
                if (cmdHHK.ExecuteNonQuery() > 0)
                {
                    return 1;
                }
                return -1;
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
        }
        public int xoaPB(ET_PHONGBAN et)
        {
            try
            {
                // mở kết nối
                con.Open();
                // khai báo command
                SqlCommand cmdHHK = new SqlCommand("sp_xoaPHONGBAN", con);
                cmdHHK.CommandType = CommandType.StoredProcedure;
                cmdHHK.Parameters.AddWithValue("@MAPHONG", et.MaPhong);
                if (cmdHHK.ExecuteNonQuery() > 0)
                {
                    return 1;
                }
                return -1;
            }
            catch (Exception ex)
            {
                return -1;
            }
            finally
            {
                // đóng kết nối
                con.Close();
            }
        }
        public int capNhatPB(ET_PHONGBAN et)
        {
            try
            {
                // mở kết nối
                con.Open();
                // khai báo command
                SqlCommand cmdHHK = new SqlCommand("sp_suaPHONGBAN", con);
                cmdHHK.CommandType = CommandType.StoredProcedure;
                cmdHHK.Parameters.AddWithValue("@MAPHONG", et.MaPhong);
                cmdHHK.Parameters.AddWithValue("@MAHANGHK", et.MaHHK);
                cmdHHK.Parameters.AddWithValue("@TENPHG", et.TenPhong);
                cmdHHK.Parameters.AddWithValue("@TRPHG", et.TrgPhong);
                if (cmdHHK.ExecuteNonQuery() > 0)
                {
                    return 1;
                }
                return -1;
            }
            catch (Exception ex)
            {
                return -1;
            }
            finally
            {
                // đóng kết nối
                con.Close();
            }
        }
    }
}
