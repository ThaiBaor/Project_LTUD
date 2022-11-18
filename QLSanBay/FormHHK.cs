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
        // tao connect
        SqlConnection con = new SqlConnection("Data Source =.; Initial Catalog = QLSANBAY; Integrated Security = True");
        public void loadData()
        {
            txtMaHHK.ReadOnly = false;
            try
            {
                // mo ket noi
                con.Open();
                // khai bao command
                SqlCommand cmdHHK = new SqlCommand();
                cmdHHK.CommandText = "sp_layDSHANGHANGKHONG";
                cmdHHK.CommandType = CommandType.StoredProcedure;
                // gan ket noi
                cmdHHK.Connection = con;
                // tao doi tuong dataAdapter
                SqlDataAdapter da = new SqlDataAdapter(cmdHHK);
                DataTable dtHHK = new DataTable();
                // fill data
                da.Fill(dtHHK);
                // gan du lieu cho bang
                dgvHHK.DataSource = dtHHK;
                // dong ket noi
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
                // mo ket noi
                con.Open();
                // khai bao command
                SqlCommand cmdHHK = new SqlCommand("sp_themHANGHANGKHONG", con);
                cmdHHK.CommandText = "sp_themHANGHANGKHONG";
                cmdHHK.CommandType = CommandType.StoredProcedure;
                cmdHHK.Parameters.AddWithValue("@MAHANGHK", txtMaHHK.Text);
                cmdHHK.Parameters.AddWithValue("@TENHANGHK", txtTenHHK.Text);
                kq = cmdHHK.ExecuteNonQuery();
                // dong ket noi
                con.Close();
            }
            catch (Exception ex)
            {
                con.Close();
                MessageBox.Show($"Lỗi kết nối: {ex.Message}");
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
            txtMaHHK.ReadOnly = true;
            txtMaHHK.Text = dgvHHK.CurrentRow.Cells[0].Value.ToString();
            txtTenHHK.Text = dgvHHK.CurrentRow.Cells[1].Value.ToString();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            int kq = -1;
            try
            {
                // mo ket noi
                con.Open();
                // khai bao command
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
                // dong ket noi
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
                // mo ket noi
                con.Open();
                // khai bao command
                SqlCommand cmdHHK = new SqlCommand("sp_suaHANGHANGKHONG", con);
                cmdHHK.CommandText = "sp_suaHANGHANGKHONG";
                cmdHHK.CommandType = CommandType.StoredProcedure;
                cmdHHK.Parameters.AddWithValue("@MAHANGHK", txtMaHHK.Text);
                cmdHHK.Parameters.AddWithValue("@TENHANGHK", txtTenHHK.Text);
                kq = cmdHHK.ExecuteNonQuery();
                // dong ket noi
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi kết nối: {ex.Message}");
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
                    MessageBox.Show("Cập nhật không thành công", "Thông báo");
                }
                txtMaHHK.Clear();
                txtTenHHK.Clear();
                txtMaHHK.Focus();
            }
        }

        private void txtMaHHK_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Khong cho nhap vao du lieu khac so va chu hay lon hon 10 ky tu
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
            // Khong cho nhap vao du lieu khac chu hay lon hon 25 ky tu
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
    }
}
