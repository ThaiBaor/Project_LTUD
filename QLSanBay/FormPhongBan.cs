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
    public partial class frmPhongBan : Form
    {
        public frmPhongBan()
        {
            InitializeComponent();
        }

        private void frmPhongBan_Load(object sender, EventArgs e)
        {
            loadCombobox();
            loadDataGridView();                       
        }
        // tạo connect
        SqlConnection con = new SqlConnection("Data Source =.; Initial Catalog = QLSANBAY; Integrated Security = True");
        void loadDataGridView()
        {
            try
            {                 
                // mở kết nối
                con.Open();
                #region loadData cho gridview
                // khai báo command
                SqlCommand cmdPB = new SqlCommand();
                cmdPB.CommandText = "sp_layDSPhongBan";
                cmdPB.CommandType = CommandType.StoredProcedure;
                // gán kết nối
                cmdPB.Connection = con;
                // tạo đối tượng dataAdapter
                SqlDataAdapter da = new SqlDataAdapter(cmdPB);
                DataTable dtPB = new DataTable();
                // fill data 
                da.Fill(dtPB);
                // gán dữ liệu cho bảng
                dgvPhongBan.DataSource = dtPB;
                // đóng kết nối
                #endregion                
                con.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show($"Lỗi kết nối: {e.Message}");
            }
        }
        void loadCombobox()
        {
            try
            {
                con.Open();
                #region cboHHK
                SqlCommand cmdDSHHK = new SqlCommand("sp_layDSHANGHANGKHONG",con);
                cmdDSHHK.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter da = new SqlDataAdapter(cmdDSHHK);
                DataSet ds = new DataSet();
                da.Fill(ds);
                cboMaHHK.Items.Clear();
                cboMaHHK.DisplayMember = "TENHANGHK";
                cboMaHHK.ValueMember = "MAHANGHK";
                cboMaHHK.DataSource = ds.Tables[0];
                #endregion
                #region cboNhanVien
                SqlCommand cmdDSNhanVien = new SqlCommand("sp_layDSNV", con);
                cmdDSNhanVien.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter da1 = new SqlDataAdapter(cmdDSNhanVien);
                DataSet ds1 = new DataSet();
                da1.Fill(ds1);
                cboTrgPhong.Items.Clear();
                cboTrgPhong.DisplayMember = "TENNV";
                cboTrgPhong.ValueMember = "MANV";
                cboTrgPhong.DataSource = ds1.Tables[0];
                #endregion
                con.Close();
            }
            catch(Exception e)
            {
                con.Close();
                MessageBox.Show("Loi"+e.Message);
            }
        }


        private void dgvPhongBan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMaPhong.Text = dgvPhongBan.CurrentRow.Cells[0].Value.ToString();
            txtTenPhong.Text = dgvPhongBan.CurrentRow.Cells[1].Value.ToString();
            foreach (object item in cboMaHHK.Items)
            {
                if (item.ToString().Equals(dgvPhongBan.CurrentRow.Cells[3].Value.ToString())==true)
                {
                    cboMaHHK.SelectedItem = item;
                }
            }
            //for (int i = 0; i < cboMaHHK.Items.Count; i++)
            //{
            //    if (cboMaHHK.Items[i].ToString().Equals(dgvPhongBan.CurrentRow.Cells[3].Value.ToString()))
            //    {
            //        cboMaHHK.SelectedIndex = i;
            //    }
            //}
            cboTrgPhong.SelectedText= dgvPhongBan.CurrentRow.Cells[2].Value.ToString();

        }

        private void txtMaPhong_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Không cho nhập vào dữ liệu khác chữ và số hay nhập nhiều hơn 10 ký tự 
            char ch = e.KeyChar;
            if (!char.IsLetterOrDigit(ch) && ch != (char)Keys.Back)
            {
                e.Handled = true;
            }
            else if (txtMaPhong.TextLength > 10 && ch != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }

        private void txtTenPhong_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Không cho nhập vào dữ liệu khác chữ hay nhập nhiều hơn 25 ký tự 
            char ch = e.KeyChar;
            if (!char.IsLetter(ch) && ch != (char)Keys.Back && !char.IsWhiteSpace(ch))
            {
                e.Handled = true;
            }
            else if (txtTenPhong.TextLength > 25 && ch != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (txtMaPhong.TextLength == 0 || txtTenPhong.TextLength == 0)
            {
                MessageBox.Show("Chưa nhập dữ liệu", "Thông báo");
                txtMaPhong.Focus();
                return;
            }
            int kq = 0;
            try
            {
                // mở kết nối
                con.Open();
                // khai báo command
                SqlCommand cmdHHK = new SqlCommand("sp_themPHONGBAN", con);
                cmdHHK.CommandType = CommandType.StoredProcedure;
                cmdHHK.Parameters.AddWithValue("@MAPHONG", txtMaPhong.Text);
                cmdHHK.Parameters.AddWithValue("@TENPHG", txtTenPhong.Text);
                cmdHHK.Parameters.AddWithValue("@MAHANGHK",cboMaHHK.SelectedValue);
                cmdHHK.Parameters.AddWithValue("@TRPHG", " ");
                kq = cmdHHK.ExecuteNonQuery();
                // đóng kết nối
                con.Close();
            }
            catch (Exception ex)
            {
                con.Close();
                MessageBox.Show($"Lỗi dữ liệu: Mã Phòng ban đã tồn tại", "Thông báo");
            }
            finally
            {
                if (kq > 0)
                {
                    MessageBox.Show("Thêm thành công", "Thông báo");
                    loadDataGridView();
                }
                else
                {
                    MessageBox.Show("Thêm không thành công", "Thông báo");
                }
                txtMaPhong.Clear();
                txtTenPhong.Clear();
                txtMaPhong.Focus();
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
                SqlCommand cmdPB = new SqlCommand("sp_xoaPHONGBAN", con);
                cmdPB.CommandType = CommandType.StoredProcedure;
                cmdPB.Parameters.AddWithValue("@MAPHONG", txtMaPhong.Text);
                if (MessageBox.Show("Bạn có muốn xóa không?", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    kq = cmdPB.ExecuteNonQuery();
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
                    // load lại dữ liệu
                    loadDataGridView();
                }
                else if (kq == -2)
                {
                }
                else
                {
                    MessageBox.Show("Xóa không thành công", "Thông báo");
                }
                txtMaPhong.Clear();
                txtTenPhong.Clear();
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
                SqlCommand cmdPB = new SqlCommand("sp_suaPHONGBAN", con);
                cmdPB.CommandType = CommandType.StoredProcedure;
                cmdPB.Parameters.AddWithValue("@MAPHONG", txtMaPhong.Text);
                cmdPB.Parameters.AddWithValue("@TENPHG", txtTenPhong.Text);
                cmdPB.Parameters.AddWithValue("@MAHANGHK",cboMaHHK.SelectedValue);
                cmdPB.Parameters.AddWithValue("@TRGPHG", cboTrgPhong.SelectedValue);
                kq = cmdPB.ExecuteNonQuery();
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
                    loadDataGridView();
                }
                else
                {
                    MessageBox.Show("Cập nhật không thành công do 'Mã phòng ban' không bị thay đổi hoặc 'Tên phòng ban' không không hợp lệ", "Thông báo");
                }
                txtMaPhong.Clear();
                txtTenPhong.Clear();
                txtMaPhong.Focus();
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmPhongBan_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thoát không?", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.No)
            {
                e.Cancel = true;
            }
        }
    }
}
