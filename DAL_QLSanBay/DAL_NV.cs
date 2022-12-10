using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using ET_QLSanBay;

namespace DAL_QLSanBay
{
    public class DAL_NV
    {
        // tao connecttion
        SqlConnection con = new SqlConnection("Data Source =.; Initial Catalog = QLSANBAY; Integrated Security = True");
        SqlCommand cmdNV;
        SqlDataAdapter daNV;
        DataTable dtNV;

        //  tao method
        public DataTable layDSNV()
        {
            try
            {
                // mở kết nối
                con.Open();
                // khai báo command
                cmdNV = new SqlCommand("sp_layDSNV",con);
                cmdNV.CommandType = CommandType.StoredProcedure;
                // tạo đối tượng dataAdapter
                daNV = new SqlDataAdapter(cmdNV);
                dtNV = new DataTable();
                // fill data 
                daNV.Fill(dtNV);
            }
            catch (Exception)
            {
            }
            finally
            {
                con.Close();
            }
            return dtNV;
        }
        public DataTable layDSNgQL(ET_HHK et)
        {
            try
            {
                // mở kết nối
                con.Open();
                // khai báo command
                cmdNV = new SqlCommand("sp_layDSNGQL_theoHHK", con);
                cmdNV.CommandType = CommandType.StoredProcedure;
                cmdNV.Parameters.AddWithValue("@MAHANGHK", et.MaHHK);
                // tạo đối tượng dataAdapter
                daNV = new SqlDataAdapter(cmdNV);
                dtNV = new DataTable();
                // fill data 
                daNV.Fill(dtNV);
            }
            catch (Exception)
            {
            }
            finally
            {
                con.Close();
            }
            return dtNV;
        }
        public DataTable layDanhSachPB()
        {
            try
            {
                // mở kết nối
                con.Open();
                // khai báo command
                cmdNV = new SqlCommand();
                cmdNV.CommandText = "sp_layDSPHONGBAN";
                cmdNV.CommandType = CommandType.StoredProcedure;
                // gán kết nối
                cmdNV.Connection = con;
                // tạo đối tượng dataAdapter
                daNV = new SqlDataAdapter(cmdNV);
                dtNV = new DataTable();
                // fill data 
                daNV.Fill(dtNV);
            }
            catch (Exception)
            {
            }
            finally
            {
                con.Close();
            }
            return dtNV;
        }

        public DataTable layDanhSachNV(ET_PHONGBAN et)
        {
            try
            {
                // mở kết nối
                con.Open();
                // khai báo command
                cmdNV = new SqlCommand();
                cmdNV.CommandText = "sp_layDSNV_theoPHONGBAN_theoHANGHANGKHONG";
                cmdNV.CommandType = CommandType.StoredProcedure;
                cmdNV.Parameters.AddWithValue("@MAHANGHK", et.MaHHK);
                cmdNV.Parameters.AddWithValue("@MAPHG", et.MaPhong);
                // gán kết nối
                cmdNV.Connection = con;
                // tạo đối tượng dataAdapter
                daNV = new SqlDataAdapter(cmdNV);
                dtNV = new DataTable();
                // fill data 
                daNV.Fill(dtNV);
            }
            catch (Exception)
            {
            }
            finally
            {
                con.Close();
            }
            return dtNV;
        }
        public string layTenNV(string s)
        {
            string kq = "";
            try
            {
                // mở kết nối
                con.Open();
                // khai báo command
                cmdNV = new SqlCommand("sp_layTENNHANVIEN_theoMANHANVIEN",con);
                cmdNV.CommandType = CommandType.StoredProcedure;
                cmdNV.Parameters.AddWithValue("@MANV", s);
                kq = cmdNV.ExecuteScalar().ToString();
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

        public int themNV(ET_NV et)
        {
            try
            {
                // mở kết nối
                con.Open();
                // khai báo command
                SqlCommand cmdHHK = new SqlCommand("sp_themNV", con);
                cmdHHK.CommandType = CommandType.StoredProcedure;
                cmdHHK.Parameters.AddWithValue("@MANV", et.MaNV);
                cmdHHK.Parameters.AddWithValue("@MAPHG", et.MaPhong);
                cmdHHK.Parameters.AddWithValue("@HONV", et.HoNV);
                cmdHHK.Parameters.AddWithValue("@TENNV", et.TenNV);
                cmdHHK.Parameters.AddWithValue("@NSINHNV", et.NgaySinh);
                cmdHHK.Parameters.AddWithValue("@SDTNV", et.Sdt);
                cmdHHK.Parameters.AddWithValue("@DIACHINV", et.DiaChi);
                cmdHHK.Parameters.AddWithValue("@CCCD", et.CCCD);
                cmdHHK.Parameters.AddWithValue("@MANGQL", et.MaNgQL);
                cmdHHK.Parameters.AddWithValue("@PHANLOAI", et.PhanLoai);
                cmdHHK.Parameters.AddWithValue("@PHAI", et.Phai);
                cmdHHK.Parameters.AddWithValue("@LUONG", et.Luong);
                if (cmdHHK.ExecuteNonQuery() > 0)
                {
                    return 1;
                }
                return -1;
            }
        
            catch(Exception)
            {
                return -1;
            }
            finally
            {
                 //đóng kết nối
                con.Close();
            }
        }
        public int xoaNV(ET_NV et)
        {
            try
            {
                // mở kết nối
                con.Open();
                // khai báo command
                SqlCommand cmdHHK = new SqlCommand("sp_xoaNV", con);
                cmdHHK.CommandType = CommandType.StoredProcedure;
                cmdHHK.Parameters.AddWithValue("@MANV", et.MaNV);
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
        public int suaNV(ET_NV et)
        {
            try
            {
                // mở kết nối
                con.Open();
                // khai báo command
                SqlCommand cmdHHK = new SqlCommand("sp_suaNV", con);
                cmdHHK.CommandType = CommandType.StoredProcedure;
                cmdHHK.Parameters.AddWithValue("@MANV", et.MaNV);
                cmdHHK.Parameters.AddWithValue("@MAPHG", et.MaPhong);
                cmdHHK.Parameters.AddWithValue("@HONV", et.HoNV);
                cmdHHK.Parameters.AddWithValue("@TENNV", et.TenNV);
                cmdHHK.Parameters.AddWithValue("@NSINHNV", et.NgaySinh);
                cmdHHK.Parameters.AddWithValue("@SDTNV", et.Sdt);
                cmdHHK.Parameters.AddWithValue("@DIACHINV", et.DiaChi);
                cmdHHK.Parameters.AddWithValue("@CCCD", et.CCCD);
                cmdHHK.Parameters.AddWithValue("@MANGQL", et.MaNgQL);
                cmdHHK.Parameters.AddWithValue("@PHANLOAI", et.PhanLoai);
                cmdHHK.Parameters.AddWithValue("@PHAI", et.Phai);
                cmdHHK.Parameters.AddWithValue("@LUONG", et.Luong);
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
    }
}
