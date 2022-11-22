using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace QLSanBay
{
    public partial class frmLoaiVe : Form
    {
        public frmLoaiVe()
        {
            InitializeComponent();
        }

        private void frmLoaiVe_Load(object sender, EventArgs e)
        {
            loadData();
        }
        // tạo connect
        SqlConnection con = new SqlConnection("Data Source =.; Initial Catalog = QLSANBAY; Integrated Security = True");
        public void loadData()
        {
            try
            {
                // mở kết nối
                con.Open();
                // khai báo command
                SqlCommand cmdLV = new SqlCommand();
                cmdLV.CommandText = "sp_layDSLOAIVE";
                cmdLV.CommandType = CommandType.StoredProcedure;
                // gán kết nối
                cmdLV.Connection = con;
                // tạo đối tượng dataAdapter
                SqlDataAdapter da = new SqlDataAdapter(cmdLV);
                DataTable dtLV = new DataTable();
                // fill data 
                da.Fill(dtLV);
                // gán dữ liệu cho bảng
                dgvLoaiVe.DataSource = dtLV;
                // đóng kết nối
                con.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show($"Lỗi kết nối: {e.Message}");
            }
        }

        private void txtMaLoaiVe_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Không cho nhập vào dữ liệu khác chữ hay nhập nhiều hơn 3 ký tự 
            char ch = e.KeyChar;
            if (!char.IsLetter(ch) && ch != (char)Keys.Back)
            {
                e.Handled = true;
            }
            else if (txtMaLoaiVe.TextLength > 3 && ch != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }

        private void txtTenLoaiVe_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Không cho nhập vào dữ liệu khác chữ hay nhập nhiều hơn 20 ký tự 
            char ch = e.KeyChar;
            if (!char.IsLetter(ch) && ch != (char)Keys.Back && !char.IsWhiteSpace(ch))
            {
                e.Handled = true;
            }
            else if (txtMaLoaiVe.TextLength > 20 && ch != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (txtMaLoaiVe.TextLength == 0 || txtTenLoaiVe.TextLength == 0)
            {
                MessageBox.Show("Chưa nhập dữ liệu", "Thông báo");
                txtMaLoaiVe.Focus();
                return;
            }
            int kq = 0;
            try
            {
                // mở kết nối
                con.Open();
                // khai báo command
                SqlCommand cmdLV = new SqlCommand("sp_themLOAIVE", con);
                cmdLV.CommandType = CommandType.StoredProcedure;
                cmdLV.Parameters.AddWithValue("@MALOAIVE", txtMaLoaiVe.Text);
                cmdLV.Parameters.AddWithValue("@TENLOAIVE", txtTenLoaiVe.Text);
                kq = cmdLV.ExecuteNonQuery();
                // đóng kết nối
                con.Close();
            }
            catch (Exception ex)
            {
                con.Close();
                MessageBox.Show($"Lỗi dữ liệu: 'Mã loại vé' đã tồn tại!", "Thông báo");
            }
            finally
            {
                if (kq > 0)
                {
                    MessageBox.Show("Thêm thành công", "Thông báo");
                    loadData();
                }
                else
                {
                    MessageBox.Show("Thêm không thành công", "Thông báo");
                }
                txtMaLoaiVe.Clear();
                txtTenLoaiVe.Clear();
                txtMaLoaiVe.Focus();
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            int kq = -1;
            try
            {
                // mở kết nối
                con.Open();
                // khai báo command
                SqlCommand cmdLV = new SqlCommand("sp_xoaLOAIVE", con);
                cmdLV.CommandType = CommandType.StoredProcedure;
                cmdLV.Parameters.AddWithValue("@MALOAIVE", txtMaLoaiVe.Text);
                if (MessageBox.Show("Bạn có muốn xóa không?", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    kq = cmdLV.ExecuteNonQuery();
                }
                else
                {
                    kq = -2;
                }
                con.Close();
                // đóng kết nối
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi kết nối: {ex.Message}");
            }
            finally
            {
                if (kq > 0)
                {
                    MessageBox.Show("Xóa thành công", "Thông báo");
                    loadData();
                }
                else if (kq == -2)
                {
                }
                else
                {
                    MessageBox.Show("Xóa không thành công", "Thông báo");
                }
                txtMaLoaiVe.Clear();
                txtTenLoaiVe.Clear();
            }
        }

        private void dgvLoaiVe_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMaLoaiVe.Text = dgvLoaiVe.CurrentRow.Cells[0].Value.ToString();
            txtTenLoaiVe.Text = dgvLoaiVe.CurrentRow.Cells[1].Value.ToString();
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            int kq = -1;
            try
            {
                // mở kết nối
                con.Open();
                // khai báo command
                SqlCommand cmdHHK = new SqlCommand("sp_suaLOAIVE", con);
                cmdHHK.CommandType = CommandType.StoredProcedure;
                cmdHHK.Parameters.AddWithValue("@MAHANGHK", txtMaLoaiVe.Text);
                cmdHHK.Parameters.AddWithValue("@TENHANGHK", txtTenLoaiVe.Text);
                kq = cmdHHK.ExecuteNonQuery();
                // đóng kết nối
                con.Close();
            }
            catch (Exception ex)
            {
                con.Close();
                MessageBox.Show($"Lỗi kết nối: {ex.Message}!");
            }
            finally
            {
                if (kq > 0)
                {
                    MessageBox.Show("Cập nhật thành công", "Thông báo");
                    loadData();
                }
                else
                {
                    MessageBox.Show("Cập nhật không thành công do 'Mã loại vé' bị thay đổi hoặc 'Tên loại vé' không hợp lệ", "Thông báo");
                }
                txtMaLoaiVe.Clear();
                txtTenLoaiVe.Clear();
                txtMaLoaiVe.Focus();
            }
        }

        private void frmLoaiVe_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thoát không?", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
