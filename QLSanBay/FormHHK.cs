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
    public partial class frmHHK : Form
    {
        public frmHHK()
        {
            InitializeComponent();
        }

        private void frmHHK_Load(object sender, EventArgs e)
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
                SqlCommand cmdHHK = new SqlCommand();
                cmdHHK.CommandText = "sp_layDSHANGHANGKHONG";
                cmdHHK.CommandType = CommandType.StoredProcedure;
                // gán kết nối
                cmdHHK.Connection = con;
                // tạo đối tượng dataAdapter
                SqlDataAdapter da = new SqlDataAdapter(cmdHHK);
                DataTable dtHHK = new DataTable();
                // fill data 
                da.Fill(dtHHK);
                // gán dữ liệu cho bảng
                dgvHHK.DataSource = dtHHK;
                // đóng kết nối
                con.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show($"Lỗi kết nối: {e.Message}");
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (txtMaHHK.TextLength == 0 || txtTenHHK.TextLength == 0)
            {
                MessageBox.Show("Chưa nhập dữ liệu", "Thông báo");
                txtMaHHK.Focus();
                return;
            }
            int kq = 0;
            try
            {
                // mở kết nối
                con.Open();
                // khai báo command
                SqlCommand cmdHHK = new SqlCommand("sp_themHANGHANGKHONG", con);
                cmdHHK.CommandText = "sp_themHANGHANGKHONG";
                cmdHHK.CommandType = CommandType.StoredProcedure;
                cmdHHK.Parameters.AddWithValue("@MAHANGHK", txtMaHHK.Text);
                cmdHHK.Parameters.AddWithValue("@TENHANGHK", txtTenHHK.Text);
                kq = cmdHHK.ExecuteNonQuery();
                // đóng kết nối
                con.Close();
            }
            catch (Exception ex)
            {
                con.Close();
                MessageBox.Show($"Lỗi dữ liệu: Mã hãng hàng không đã tồn tại!", "Thông báo");
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
                txtMaHHK.Clear();
                txtTenHHK.Clear();
                txtMaHHK.Focus();
            }
        }

        private void dgvHHK_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMaHHK.Text = dgvHHK.CurrentRow.Cells[0].Value.ToString();
            txtTenHHK.Text = dgvHHK.CurrentRow.Cells[1].Value.ToString();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            int kq = -1;
            try
            {
                // mở kết nối
                con.Open();
                // khai báo command
                SqlCommand cmdHHK = new SqlCommand("sp_xoaHANGHANGKHONG", con);
                cmdHHK.CommandText = "sp_xoaHANGHANGKHONG";
                cmdHHK.CommandType = CommandType.StoredProcedure;
                cmdHHK.Parameters.AddWithValue("@MAHANGHK", txtMaHHK.Text);
                if (MessageBox.Show("Bạn có muốn xóa không?", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    kq = cmdHHK.ExecuteNonQuery();
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
                txtMaHHK.Clear();
                txtTenHHK.Clear();
            }
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            int kq = -1;
            try
            {
                // mở kết nối
                con.Open();
                // khai báo command
                SqlCommand cmdHHK = new SqlCommand("sp_suaHANGHANGKHONG", con);
                cmdHHK.CommandText = "sp_suaHANGHANGKHONG";
                cmdHHK.CommandType = CommandType.StoredProcedure;
                cmdHHK.Parameters.AddWithValue("@MAHANGHK", txtMaHHK.Text);
                cmdHHK.Parameters.AddWithValue("@TENHANGHK", txtTenHHK.Text);
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
                    MessageBox.Show("Cập nhật không thành công do 'Mã hãng hàng' không bị thay đổi hoặc 'Tên hãng hàng' không không hợp lệ", "Thông báo");
                }
                txtMaHHK.Clear();
                txtTenHHK.Clear();
                txtMaHHK.Focus();
            }
        }

        private void txtMaHHK_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Không cho nhập vào dữ liệu khác chữ và số hay nhập nhiều hơn 10 ký tự 
            char ch = e.KeyChar;
            if (!char.IsLetterOrDigit(ch) && ch != (char)Keys.Back)
            {
                e.Handled = true;
            }
            else if (txtMaHHK.TextLength > 10 && ch != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }

        private void txtTenHHK_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Không cho nhập vào dữ liệu khác chữ hay nhập nhiều hơn 25 ký tự 
            char ch = e.KeyChar;
            if (!char.IsLetter(ch) && !char.IsWhiteSpace(ch) && ch != (char)Keys.Back)
            {
                e.Handled = true;
            }
            else if (txtTenHHK.TextLength > 25 && ch != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmHHK_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thoát không?", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.No)
            {
                e.Cancel = true;
            }
        }
    }
}
