using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using ET_QLSanBay;

namespace DAL_QLSanBay
{
    public class DAL_HK
    {
        // tao connecttion
        SqlConnection con = new SqlConnection("Data Source =.; Initial Catalog = QLSANBAY; Integrated Security = True");
        SqlCommand cmdHK;
        SqlDataAdapter daHK;
        DataTable dtHK;

        // tao method
        public DataTable layDSHK()
        {
            try
            {
                // mở kết nối
                con.Open();
                // khai báo command
                cmdHK = new SqlCommand("sp_layDSHANHKHACH", con);
                cmdHK.CommandType = CommandType.StoredProcedure;
                // tạo đối tượng dataAdapter
                daHK = new SqlDataAdapter(cmdHK);
                dtHK = new DataTable();
                // fill data 
                daHK.Fill(dtHK);
            }
            catch (Exception)
            {
            }
            finally
            {
                con.Close();
            }
            return dtHK;
        }
        public int themHK(ET_HK et)
        {
            try
            {
                // mở kết nối
                con.Open();
                // khai báo command
                cmdHK = new SqlCommand("sp_themHANHKHACH", con);
                cmdHK.CommandType = CommandType.StoredProcedure;
                cmdHK.Parameters.AddWithValue("@MAHK", et.MaHK);
                cmdHK.Parameters.AddWithValue("@TENHK", et.TenHK);
                cmdHK.Parameters.AddWithValue("@HOKH", et.HoHK);
                cmdHK.Parameters.AddWithValue("@NAMSINHHK", et.NgSinh);
                cmdHK.Parameters.AddWithValue("@QT", et.QuocTich);
                cmdHK.Parameters.AddWithValue("@PHAI", et.GioiTinh);
                cmdHK.Parameters.AddWithValue("@SDTHK", et.Sdt);
                cmdHK.Parameters.AddWithValue("@DIACHIHK", et.DiaChi);
                cmdHK.Parameters.AddWithValue("@SOHOCHIEU", et.HoChieu);
                if (cmdHK.ExecuteNonQuery() > 0)
                {
                    return 1;
                }
                return -1;
            }

            catch (Exception)
            {
                return -1;
            }
            finally
            {
                //đóng kết nối
                con.Close();
            }
        }
        public int suaHK(ET_HK et)
        {
            try
            {
                // mở kết nối
                con.Open();
                // khai báo command
                cmdHK = new SqlCommand("sp_suaHANHKHACH", con);
                cmdHK.CommandType = CommandType.StoredProcedure;
                cmdHK.Parameters.AddWithValue("@MAHK", et.MaHK);
                cmdHK.Parameters.AddWithValue("@TENHK", et.TenHK);
                cmdHK.Parameters.AddWithValue("@HOKH", et.HoHK);
                cmdHK.Parameters.AddWithValue("@NAMSINHHK", et.NgSinh);
                cmdHK.Parameters.AddWithValue("@QT", et.QuocTich);
                cmdHK.Parameters.AddWithValue("@PHAI", et.GioiTinh);
                cmdHK.Parameters.AddWithValue("@SDTHK", et.Sdt);
                cmdHK.Parameters.AddWithValue("@DIACHIHK", et.DiaChi);
                cmdHK.Parameters.AddWithValue("@SOHOCHIEU", et.HoChieu);
                if (cmdHK.ExecuteNonQuery() > 0)
                {
                    return 1;
                }
                return -1;
            }

            catch (Exception)
            {
                return -1;
            }
            finally
            {
                //đóng kết nối
                con.Close();
            }
        }
        public int xoaK(ET_HK et)
        {
            try
            {
                // mở kết nối
                con.Open();
                // khai báo command
                cmdHK = new SqlCommand("sp_xoaHANHKHACH", con);
                cmdHK.CommandType = CommandType.StoredProcedure;
                cmdHK.Parameters.AddWithValue("@MAHK", et.MaHK);                
                if (cmdHK.ExecuteNonQuery() > 0)
                {
                    return 1;
                }
                return -1;
            }

            catch (Exception)
            {
                return -1;
            }
            finally
            {
                //đóng kết nối
                con.Close();
            }
        }

    }
}
