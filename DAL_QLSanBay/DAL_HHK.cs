using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using ET_QLSanBay;

namespace DAL_QLSanBay
{
    public class DAL_HHK
    {
        // tao connecttion
        SqlConnection con = new SqlConnection("Data Source =.; Initial Catalog = QLSANBAY; Integrated Security = True");
        SqlCommand cmdHHK;
        SqlDataAdapter daHHK;
        DataTable dtHHK;

        // tao method
        public DataTable layDanhSachHHK()
        {
            try
            {
                // mở kết nối
                con.Open();
                // khai báo command
                cmdHHK = new SqlCommand();
                cmdHHK.CommandText = "sp_layDSHANGHANGKHONG";
                cmdHHK.CommandType = CommandType.StoredProcedure;
                // gán kết nối
                cmdHHK.Connection = con;
                // tạo đối tượng dataAdapter
                daHHK = new SqlDataAdapter(cmdHHK);
                dtHHK = new DataTable();
                // fill data 
                daHHK.Fill(dtHHK);
            }
            catch (Exception)
            {
            }
            finally
            {
                con.Close();
            }
            return dtHHK;
        }
        public string layTenHHK(string s)
        {
            string kq = " ";
            try
            {
                // mở kết nối
                con.Open();
                // khai báo command
                cmdHHK = new SqlCommand("sp_layTENHANGHANGKHONG_theoMAHANGHANGKHONG",con);
                cmdHHK.CommandType = CommandType.StoredProcedure;
                cmdHHK.Parameters.AddWithValue("@MAHANGHK", s);
                kq = cmdHHK.ExecuteScalar().ToString();
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
        public string layTenHHK_TheoMaPhong(string s)
        {
            string kq = " ";
            try
            {
                // mở kết nối
                con.Open();
                // khai báo command
                cmdHHK = new SqlCommand("sp_layTENHHK_THEOMAPHONG", con);
                cmdHHK.CommandType = CommandType.StoredProcedure;
                cmdHHK.Parameters.AddWithValue("@MAPHG", s);
                kq = cmdHHK.ExecuteScalar().ToString();
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
        public int themHHK(ET_HHK et)
        {
            try
            {
                // mở kết nối
                con.Open();
                // khai báo command
                SqlCommand cmdHHK = new SqlCommand("sp_themHANGHANGKHONG", con);
                cmdHHK.CommandType = CommandType.StoredProcedure;
                cmdHHK.Parameters.AddWithValue("@MAHANGHK", et.MaHHK);
                cmdHHK.Parameters.AddWithValue("@TENHANGHK", et.TenHHK);
                if (cmdHHK.ExecuteNonQuery() > 0)
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
        public int xoaHHK(ET_HHK et)
        {
            try
            {
                // mở kết nối
                con.Open();
                // khai báo command
                SqlCommand cmdHHK = new SqlCommand("sp_xoaHangHangKhong", con);
                cmdHHK.CommandType = CommandType.StoredProcedure;
                cmdHHK.Parameters.AddWithValue("@MAHANGHK", et.MaHHK);
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
        public int capNhatHHK(ET_HHK et)
        {
            try
            {
                // mở kết nối
                con.Open();
                // khai báo command
                SqlCommand cmdHHK = new SqlCommand("sp_suaHANGHANGKHONG", con);
                cmdHHK.CommandType = CommandType.StoredProcedure;
                cmdHHK.Parameters.AddWithValue("@TENHANGHK", et.TenHHK);
                cmdHHK.Parameters.AddWithValue("@MAHANGHK", et.MaHHK);
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

