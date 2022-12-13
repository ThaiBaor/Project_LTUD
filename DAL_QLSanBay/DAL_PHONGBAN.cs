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
        
        // tao method
        public DataTable layDSPB()
        {
            try
            {
                // mở kết nối
                con.Open();
                // khai báo command
                cmdPB = new SqlCommand("sp_layDSPHONGBAN", con);
                cmdPB.CommandType = CommandType.StoredProcedure;
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
        public DataTable layDanhSachPB_TheoHHK(ET_HHK et)
        {
            try
            {
                // mở kết nối
                con.Open();
                // khai báo command
                cmdPB = new SqlCommand("sp_layDSPB_theoHHK", con);
                cmdPB.CommandType = CommandType.StoredProcedure;
                cmdPB.Parameters.AddWithValue("@MAHANGHK", et.MaHHK);
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
        public string layTenPhongBan_TheoMaPhong(string s)
        {
            string kq = "";
            try
            {
                // mở kết nối
                con.Open();
                // khai báo command
                cmdPB = new SqlCommand("sp_layTENPHONGBAN_THEOMAPHONG", con);
                cmdPB.CommandType = CommandType.StoredProcedure;
                cmdPB.Parameters.AddWithValue("@MAPHG", s);
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
    }
}
