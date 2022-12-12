using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using ET_QLSanBay;

namespace DAL_QLSanBay
{
    public class DAL_LOAIVE
    {
        // tao connecttion
        SqlConnection con = new SqlConnection("Data Source =.; Initial Catalog = QLSANBAY; Integrated Security = True");
        SqlCommand cmdLV;
        SqlDataAdapter daLV;
        DataTable dtLV;

        // tao method
        public DataTable layDSLoaiVe()
        {
            try
            {
                // mở kết nối
                con.Open();
                // khai báo command
                cmdLV = new SqlCommand("sp_layDSLOAIVE", con);
                cmdLV.CommandType = CommandType.StoredProcedure;
                // tạo đối tượng dataAdapter
                daLV = new SqlDataAdapter(cmdLV);
                dtLV = new DataTable();
                // fill data 
                daLV.Fill(dtLV);
            }
            catch (Exception)
            {
            }
            finally
            {
                con.Close();
            }
            return dtLV;
        }
        public int themLoaiVe(ET_LOAIVE et)
        {
            try
            {
                // mở kết nối
                con.Open();
                // khai báo command
                cmdLV= new SqlCommand("sp_themLOAIVE", con);
                cmdLV.CommandType = CommandType.StoredProcedure;
                cmdLV.Parameters.AddWithValue("@MALOAIVE", et.MaLoai);
                cmdLV.Parameters.AddWithValue("@TENLOAIVE", et.TenLoai);                
                if (cmdLV.ExecuteNonQuery() > 0)
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
        public int xoaLoaiVe(ET_LOAIVE et)
        {
            try
            {
                // mở kết nối
                con.Open();
                // khai báo command
                cmdLV = new SqlCommand("sp_xoaLOAIVE", con);
                cmdLV.CommandType = CommandType.StoredProcedure;
                cmdLV.Parameters.AddWithValue("@MALOAIVE", et.MaLoai);
                if (cmdLV.ExecuteNonQuery() > 0)
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
        public int suaLoaiVe(ET_LOAIVE et)
        {
            try
            {
                // mở kết nối
                con.Open();
                // khai báo command
                cmdLV = new SqlCommand("sp_suaLOAIVE", con);
                cmdLV.CommandType = CommandType.StoredProcedure;
                cmdLV.Parameters.AddWithValue("@MALOAIVE", et.MaLoai);
                cmdLV.Parameters.AddWithValue("@TENLOAIVE", et.TenLoai);
                if (cmdLV.ExecuteNonQuery() > 0)
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
