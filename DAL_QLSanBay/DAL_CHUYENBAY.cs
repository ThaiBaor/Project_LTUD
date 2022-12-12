using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using ET_QLSanBay;

namespace DAL_QLSanBay
{
    public class DAL_CHUYENBAY
    {
        // tao connecttion
        SqlConnection con = new SqlConnection("Data Source =.; Initial Catalog = QLSANBAY; Integrated Security = True");
        SqlCommand cmdCB;
        SqlDataAdapter daCB;
        DataTable dtCB;

        // tao method
        public DataTable layDSChuyenBay()
        {
            try
            {
                // mở kết nối
                con.Open();
                // khai báo command
                cmdCB = new SqlCommand("sp_layDSCHUYENBAY", con);
                cmdCB.CommandType = CommandType.StoredProcedure;
                // tạo đối tượng dataAdapter
                daCB = new SqlDataAdapter(cmdCB);
                dtCB = new DataTable();
                // fill data 
                daCB.Fill(dtCB);
            }
            catch (Exception)
            {
            }
            finally
            {
                con.Close();
            }
            return dtCB;
        }
        public int themChuyenBay(ET_CHUYENBAY et)
        {
            try
            {
                // mở kết nối
                con.Open();
                // khai báo command
                cmdCB = new SqlCommand("sp_themCHUYENBAY", con);
                cmdCB.CommandType = CommandType.StoredProcedure;
                cmdCB.Parameters.AddWithValue("@MACHUYENBAY", et.MaChuyenBay);
                cmdCB.Parameters.AddWithValue("@SBKHOIHANH", et.SanBayKH);
                cmdCB.Parameters.AddWithValue("@DDIEMKHOIHANH", et.SanBayKH);
                cmdCB.Parameters.AddWithValue("@SBDEN", et.SanBayDen);
                cmdCB.Parameters.AddWithValue("@DDIEMDEN", et.DiaDiemDen);
                cmdCB.Parameters.AddWithValue("@SBTRUNGCHUYEN", et.SanBayTC);
                cmdCB.Parameters.AddWithValue("@MAHANGHK", et.MaHHK);
                if (cmdCB.ExecuteNonQuery() > 0)
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
        public int xoaChuyenBay(ET_CHUYENBAY et)
        {
            try
            {
                // mở kết nối
                con.Open();
                // khai báo command
                cmdCB = new SqlCommand("sp_xoaCHUYENBAY", con);
                cmdCB.CommandType = CommandType.StoredProcedure;
                cmdCB.Parameters.AddWithValue("@MACHUYENBAY", et.MaChuyenBay);
                if (cmdCB.ExecuteNonQuery() > 0)
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
        public int suaChuyenBay(ET_CHUYENBAY et)
        {
            try
            {
                // mở kết nối
                con.Open();
                // khai báo command
                cmdCB = new SqlCommand("sp_suaCHUYENBAY", con);
                cmdCB.CommandType = CommandType.StoredProcedure;
                cmdCB.Parameters.AddWithValue("@MACHUYENBAY", et.MaChuyenBay);
                cmdCB.Parameters.AddWithValue("@SBKHOIHANH", et.SanBayKH);
                cmdCB.Parameters.AddWithValue("@DDIEMKHOIHANH", et.SanBayKH);
                cmdCB.Parameters.AddWithValue("@SBDEN", et.SanBayDen);
                cmdCB.Parameters.AddWithValue("@DDIEMDEN", et.DiaDiemDen);
                cmdCB.Parameters.AddWithValue("@SBTRUNGCHUYEN", et.SanBayTC);
                cmdCB.Parameters.AddWithValue("@MAHANGHK", et.MaHHK);
                if (cmdCB.ExecuteNonQuery() > 0)
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
