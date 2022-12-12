using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using ET_QLSanBay;

namespace DAL_QLSanBay
{
    public class DAL_MAYBAY
    {
        // tao connecttion
        SqlConnection con = new SqlConnection("Data Source =.; Initial Catalog = QLSANBAY; Integrated Security = True");
        SqlCommand cmdMB;
        SqlDataAdapter daMB;
        DataTable dtMB;

        // tao method
        public DataTable layDanhSachMayBay()
        {
            try
            {
                // mở kết nối
                con.Open();
                // khai báo command
                cmdMB = new SqlCommand("sp_layDSMAYBAY", con);
                cmdMB.CommandType = CommandType.StoredProcedure;
                // tạo đối tượng dataAdapter
                daMB = new SqlDataAdapter(cmdMB);
                dtMB = new DataTable();
                // fill data 
                daMB.Fill(dtMB);
            }
            catch (Exception)
            {
            }
            finally
            {
                con.Close();
            }
            return dtMB;
        }
        public int themMayBay(ET_MAYBAY et)
        {
            try
            {
                // mở kết nối
                con.Open();
                // khai báo command
                cmdMB = new SqlCommand("sp_themMAYBAY", con);
                cmdMB.CommandType = CommandType.StoredProcedure;
                cmdMB.Parameters.AddWithValue("@SOHIEU", et.SoHieu);
                cmdMB.Parameters.AddWithValue("@MAHANGHK", et.MaHHK);
                if (cmdMB.ExecuteNonQuery() > 0)
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
        public int xoaMayBay(ET_MAYBAY et)
        {
            try
            {
                // mở kết nối
                con.Open();
                // khai báo command
                cmdMB = new SqlCommand("sp_xoaMAYBAY", con);
                cmdMB.CommandType = CommandType.StoredProcedure;
                cmdMB.Parameters.AddWithValue("@SOHIEU", et.SoHieu);
                if (cmdMB.ExecuteNonQuery() > 0)
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
        public int suaMayBay(ET_MAYBAY et)
        {
            try
            {
                // mở kết nối
                con.Open();
                // khai báo command
                cmdMB = new SqlCommand("sp_suaMAYBAY", con);
                cmdMB.CommandType = CommandType.StoredProcedure;
                cmdMB.Parameters.AddWithValue("@SOHIEU", et.SoHieu);
                cmdMB.Parameters.AddWithValue("@MAHANGHK", et.MaHHK);
                if (cmdMB.ExecuteNonQuery() > 0)
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
