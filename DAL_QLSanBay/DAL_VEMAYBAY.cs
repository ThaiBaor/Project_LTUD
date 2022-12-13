using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using ET_QLSanBay;

namespace DAL_QLSanBay
{
    public class DAL_VEMAYBAY
    {
        // tao connecttion
        SqlConnection con = new SqlConnection("Data Source =.; Initial Catalog = QLSANBAY; Integrated Security = True");
        SqlCommand cmdVMB;
        SqlDataAdapter daVMB;
        DataTable dtVMB;

        // tao method
        public DataTable layDanhSachVeMayBay()
        {
            try
            {
                // mở kết nối
                con.Open();
                // khai báo command
                cmdVMB = new SqlCommand();
                cmdVMB.CommandText = "sp_layDSVEMAYBAY";
                cmdVMB.CommandType = CommandType.StoredProcedure;
                // gán kết nối
                cmdVMB.Connection = con;
                // tạo đối tượng dataAdapter
                daVMB = new SqlDataAdapter(cmdVMB);
                dtVMB = new DataTable();
                // fill data 
                daVMB.Fill(dtVMB);
            }
            catch (Exception)
            {
            }
            finally
            {
                con.Close();
            }
            return dtVMB;
        }
        public int themVeMayBay(ET_VEMAYBAY et)
        {
            try
            {
                // mở kết nối
                con.Open();
                // khai báo command
                cmdVMB = new SqlCommand("sp_themVEMAYBAY", con);
                cmdVMB.CommandType = CommandType.StoredProcedure;
                cmdVMB.Parameters.AddWithValue("@MACHUYENBAY", et.MaChuyenBay);
                cmdVMB.Parameters.AddWithValue("@MASOVE", et.MaSoVe);
                cmdVMB.Parameters.AddWithValue("@MALOAIVE", et.MaLoaiVe);
                cmdVMB.Parameters.AddWithValue("@GIAVE", et.GiaVe);
                cmdVMB.Parameters.AddWithValue("@KLHL", et.KLHL);
                cmdVMB.Parameters.AddWithValue("@MAHK", et.MaHK);
                cmdVMB.Parameters.AddWithValue("@MASOGHE", et.MaSoGhe);
                cmdVMB.Parameters.AddWithValue("@GIOKHOIHANH", et.GioKhoiHanh);
                cmdVMB.Parameters.AddWithValue("@NGAYKHOIHANH", et.NgayKhoiHanh);
                if (cmdVMB.ExecuteNonQuery() > 0)
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
        public int xoaVeMayBay(ET_VEMAYBAY et)
        {
            try
            {
                // mở kết nối
                con.Open();
                // khai báo command
                cmdVMB = new SqlCommand("sp_xoaVEMAYBAY", con);
                cmdVMB.CommandType = CommandType.StoredProcedure;             
                cmdVMB.Parameters.AddWithValue("@MASOVE", et.MaSoVe);          
                if (cmdVMB.ExecuteNonQuery() > 0)
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
        public int suaVeMayBay(ET_VEMAYBAY et)
        {
            try
            {
                // mở kết nối
                con.Open();
                // khai báo command
                cmdVMB = new SqlCommand("sp_suaVEMAYBAY", con);
                cmdVMB.CommandType = CommandType.StoredProcedure;
                cmdVMB.Parameters.AddWithValue("@MACHUYENBAY", et.MaChuyenBay);
                cmdVMB.Parameters.AddWithValue("@MASOVE", et.MaSoVe);
                cmdVMB.Parameters.AddWithValue("@MALOAIVE", et.MaLoaiVe);
                cmdVMB.Parameters.AddWithValue("@GIAVE", et.GiaVe);
                cmdVMB.Parameters.AddWithValue("@KLHL", et.KLHL);
                cmdVMB.Parameters.AddWithValue("@MAHK", et.MaHK);
                cmdVMB.Parameters.AddWithValue("@MASOGHE", et.MaSoGhe);
                cmdVMB.Parameters.AddWithValue("@GIOKHOIHANH", et.GioKhoiHanh);
                cmdVMB.Parameters.AddWithValue("@NGAYKHOIHANH", et.NgayKhoiHanh);
                if (cmdVMB.ExecuteNonQuery() > 0)
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
