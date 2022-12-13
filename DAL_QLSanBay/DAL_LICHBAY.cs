using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using ET_QLSanBay;

namespace DAL_QLSanBay
{
    public class DAL_LICHBAY
    {
        // tao connecttion
        SqlConnection con = new SqlConnection("Data Source =.; Initial Catalog = QLSANBAY; Integrated Security = True");
        SqlCommand cmdLB;
        SqlDataAdapter daLB;
        DataTable dtLB;

        // tao method
        public DataTable layDanhSachLichBay()
        {
            try
            {
                // mở kết nối
                con.Open();
                // khai báo command
                cmdLB = new SqlCommand("sp_layDSLICHBAY",con);
                cmdLB.CommandType = CommandType.StoredProcedure;
                // gán kết nối
                // tạo đối tượng dataAdapter
                daLB = new SqlDataAdapter(cmdLB);
                dtLB = new DataTable();
                // fill data 
                daLB.Fill(dtLB);
            }
            catch (Exception)
            {
            }
            finally
            {
                con.Close();
            }
            return dtLB;
        }
        public DataTable LayDanhSachGioKH_TheoMaChuyenBay(ET_LICHBAY et)
        {
            try
            {
                // mở kết nối
                con.Open();
                // khai báo command
                cmdLB = new SqlCommand("sp_layDSGIOKHOIHANH_theoMACHUYENBAY", con);
                cmdLB.CommandType = CommandType.StoredProcedure;
                cmdLB.Parameters.AddWithValue("MACHUYENBAY", et.MaCB);
                // gán kết nối
                // tạo đối tượng dataAdapter
                daLB = new SqlDataAdapter(cmdLB);
                dtLB = new DataTable();
                // fill data 
                daLB.Fill(dtLB);
            }
            catch (Exception)
            {
            }
            finally
            {
                con.Close();
            }
            return dtLB;
        }
        public DataTable LayDanhSachNgayKH_TheoMaChuyenBay_TheoGioKH(ET_LICHBAY et)
        {
            try
            {
                // mở kết nối
                con.Open();
                // khai báo command
                cmdLB = new SqlCommand("sp_layDSNGAYKHOIHANH_theoMACHUYENBAYVAGIOKHOIHANH", con);
                cmdLB.CommandType = CommandType.StoredProcedure;
                cmdLB.Parameters.AddWithValue("MACHUYENBAY", et.MaCB);
                cmdLB.Parameters.AddWithValue("GIOKHOIHANH", et.GioKH);
                // gán kết nối
                // tạo đối tượng dataAdapter
                daLB = new SqlDataAdapter(cmdLB);
                dtLB = new DataTable();
                // fill data 
                daLB.Fill(dtLB);
            }
            catch (Exception)
            {
            }
            finally
            {
                con.Close();
            }
            return dtLB;
        }
        public int themLichBay(ET_LICHBAY et)
        {
            try
            {
                // mở kết nối
                con.Open();
                // khai báo command
                cmdLB = new SqlCommand("sp_themLICHBAY", con);
                cmdLB.CommandType = CommandType.StoredProcedure;
                cmdLB.Parameters.AddWithValue("@MACHUYENBAY", et.MaCB);
                cmdLB.Parameters.AddWithValue("@SOHIEU", et.SoHieuMB);
                cmdLB.Parameters.AddWithValue("@GIOKHOIHANH", et.GioKH);
                cmdLB.Parameters.AddWithValue("@NGAYKHOIHANH", et.NgayKH);
                if (cmdLB.ExecuteNonQuery() > 0)
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
        public int xoaLichBay(ET_LICHBAY et)
        {
            try
            {
                // mở kết nối
                con.Open();
                // khai báo command
                cmdLB = new SqlCommand("sp_xoaLICHBAY", con);
                cmdLB.CommandType = CommandType.StoredProcedure;
                cmdLB.Parameters.AddWithValue("@MACHUYENBAY", et.MaCB);
                cmdLB.Parameters.AddWithValue("@GIOKHOIHANH", et.GioKH);
                cmdLB.Parameters.AddWithValue("@NGAYKHOIHANH", et.NgayKH);
                if (cmdLB.ExecuteNonQuery() > 0)
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
        public int suaLichBay(ET_LICHBAY et)
        {
            try
            {
                // mở kết nối
                con.Open();
                // khai báo command
                cmdLB = new SqlCommand("sp_suaLICHBAY", con);
                cmdLB.CommandType = CommandType.StoredProcedure;
                cmdLB.Parameters.AddWithValue("@MACHUYENBAY", et.MaCB);
                cmdLB.Parameters.AddWithValue("@SOHIEU", et.SoHieuMB);
                cmdLB.Parameters.AddWithValue("@GIOKHOIHANH", et.GioKH);
                cmdLB.Parameters.AddWithValue("@NGAYKHOIHANH", et.NgayKH);
                if (cmdLB.ExecuteNonQuery() > 0)
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
