using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BUS_QLSanBay;
using ET_QLSanBay;

namespace QLSanBay
{
    public partial class frmHHK : Form
    {
        public frmHHK()
        {
            InitializeComponent();
        }
        BUS_HHK busHHK = new BUS_HHK();
        ET_HHK etHHK = new ET_HHK();
        
        private void frmHHK_Load(object sender, EventArgs e)
        {
            loadData();
            btnThem.Enabled = false;
            txtMaHHK.ReadOnly = true;
        }
        public void loadData()
        {
            dgvHHK.DataSource = busHHK.layDSHHK();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (txtMaHHK.TextLength == 0 || txtTenHHK.TextLength == 0)
            {
                MessageBox.Show("Chưa nhập dữ liệu", "Thông báo");
                txtMaHHK.Focus();
                return;
            }
            etHHK.MaHHK = txtMaHHK.Text;
            etHHK.TenHHK = txtTenHHK.Text;
            int kq = busHHK.themHHK(etHHK);
            if (kq > 0)
            {
                MessageBox.Show("Thêm thành công.","Thông báo");
                loadData();
            }
            else
            {
                MessageBox.Show("Thêm không thành công.", "Thông báo");
            }
            txtMaHHK.Clear();
            txtTenHHK.Clear();
            btnThem.Enabled = false;
            txtMaHHK.ReadOnly = true;
            btnXoa.Enabled = true;
            btnCapNhat.Enabled = true;
        }

        private void dgvHHK_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMaHHK.Text = dgvHHK.CurrentRow.Cells[0].Value.ToString();
            txtTenHHK.Text = dgvHHK.CurrentRow.Cells[1].Value.ToString();
            etHHK.MaHHK = txtMaHHK.Text;
            etHHK.TenHHK = txtTenHHK.Text;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn xóa không?","Thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                etHHK.MaHHK = txtMaHHK.Text;
                int kq = busHHK.xoaHHK(etHHK);
                if (kq > 0)
                {
                    MessageBox.Show("Xóa thành công.", "Thông báo");
                    loadData();
                }
                else
                {
                    MessageBox.Show("Xóa không thành công.", "Thông báo");
                }
            }            
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn cập nhật không?", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                etHHK.MaHHK = txtMaHHK.Text;
                etHHK.TenHHK = txtTenHHK.Text;
                int kq = busHHK.capNhatHHK(etHHK);
                if (kq > 0)
                {
                    MessageBox.Show("Cập nhật thành công.", "Thông báo");
                    loadData();
                }
                else
                {
                    MessageBox.Show("Cập nhật không thành công.", "Thông báo");
                }
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

        private void btnMoi_Click(object sender, EventArgs e)
        {
            txtMaHHK.Enabled = true;
            txtMaHHK.Clear();
            txtMaHHK.Focus();
            txtTenHHK.Clear();
            btnThem.Enabled = true;
            txtMaHHK.ReadOnly = false;
            btnXoa.Enabled = false;
            btnCapNhat.Enabled = false;
        }
    }
}
