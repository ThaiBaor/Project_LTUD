using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BUS_QLSanBay;
using ET_QLSanBay;

namespace QLSanBay
{
    public partial class frmLoaiVe : Form
    {
        public frmLoaiVe()
        {
            InitializeComponent();
        }
        BUS_LOAIVE busLV = new BUS_LOAIVE();
        ET_LOAIVE etLV = new ET_LOAIVE();
        private void frmLoaiVe_Load(object sender, EventArgs e)
        {
            loadData();
            btnThem.Enabled = false;
            txtMaLoaiVe.ReadOnly = true;
        }
        public void loadData()
        {
            dgvLoaiVe.DataSource = busLV.layDSLoaiVe();
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
            etLV.MaLoai = txtMaLoaiVe.Text;
            etLV.TenLoai = txtTenLoaiVe.Text;
            int kq = busLV.themLoaiVe(etLV);
            if (kq > 0)
            {
                MessageBox.Show("Thêm thành công.", "Thông báo");
                loadData();
            }
            else
            {
                MessageBox.Show("Thêm không thành công.", "Thông báo");
            }
            txtMaLoaiVe.Clear();
            txtTenLoaiVe.Clear();
            btnThem.Enabled = false;
            txtMaLoaiVe.ReadOnly = true;
            btnXoa.Enabled = true;
            btnCapNhat.Enabled = true;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn xóa không?", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                etLV.MaLoai = txtMaLoaiVe.Text;
                int kq = busLV.xoaLoaiVe(etLV);
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

        private void dgvLoaiVe_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMaLoaiVe.Text = dgvLoaiVe.CurrentRow.Cells[0].Value.ToString();
            txtTenLoaiVe.Text = dgvLoaiVe.CurrentRow.Cells[1].Value.ToString();
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn cập nhật không?", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                etLV.MaLoai = txtMaLoaiVe.Text;
                etLV.TenLoai = txtTenLoaiVe.Text;
                int kq = busLV.suaLoaiVe(etLV);
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

        private void btnMoi_Click(object sender, EventArgs e)
        {
            btnThem.Enabled = true;
            btnXoa.Enabled = false;
            btnCapNhat.Enabled = false;
            txtMaLoaiVe.ReadOnly = false;
            txtMaLoaiVe.Clear();
            txtTenLoaiVe.Clear();
            txtMaLoaiVe.Focus();
        }
    }
}
