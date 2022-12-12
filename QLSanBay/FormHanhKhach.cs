using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ET_QLSanBay;
using BUS_QLSanBay;

namespace QLSanBay
{
    public partial class frmHanhKhach : Form
    {
        public frmHanhKhach()
        {
            InitializeComponent();
        }
        BUS_HK busHK = new BUS_HK();
        ET_HK etHK = new ET_HK();
        void loadData()
        {
            dgvHK.DataSource = busHK.layDSHK();
        }
        private void frmHanhKhach_Load(object sender, EventArgs e)
        {
            loadData();
            btnThem.Enabled = false;
            rdoNam.Checked = true;
            txtMaHK.ReadOnly = true;
            dtpHK.CustomFormat = "dd/MM/yyyy";
        }

        private void txtMaHK_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Không cho nhập vào dữ liệu khác chữ và số hay nhập nhiều hơn 10 ký tự 
            char ch = e.KeyChar;
            if (!char.IsLetterOrDigit(ch) && ch != (char)Keys.Back)
            {
                e.Handled = true;
            }
            else if (txtMaHK.TextLength > 10 && ch != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }

        private void txtHoHK_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Không cho nhập vào dữ liệu khác chữ hay nhập nhiều hơn 30 ký tự 
            char ch = e.KeyChar;
            if (!char.IsLetter(ch) && ch != (char)Keys.Back && !char.IsWhiteSpace(ch))
            {
                e.Handled = true;
            }
            else if (txtHoHK.TextLength > 30 && ch != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }

        private void txtTenHK_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Không cho nhập vào dữ liệu khác chữ hay nhập nhiều hơn 15 ký tự 
            char ch = e.KeyChar;
            if (!char.IsLetter(ch) && ch != (char)Keys.Back)
            {
                e.Handled = true;
            }
            else if (txtTenHK.TextLength > 15 && ch != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }

        private void txtQT_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Không cho nhập vào dữ liệu khác chữ hay nhập nhiều hơn 15 ký tự 
            char ch = e.KeyChar;
            if (!char.IsLetter(ch) && ch != (char)Keys.Back)
            {
                e.Handled = true;
            }
            else if (txtQT.TextLength > 15 && ch != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }

        private void txtDiaChiHK_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Không cho nhập vào dữ liệu nhiều hơn 100 ký tự 
            char ch = e.KeyChar;
            if (txtDiaChiHK.TextLength > 100 && ch != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }

        private void txtHoChieu_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Không cho nhập vào dữ liệu khác số hay nhập nhiều hơn 9 ký tự 
            char ch = e.KeyChar;
            if (!char.IsDigit(ch) && ch != (char)Keys.Back)
            {
                e.Handled = true;
            }
            else if (txtHoChieu.TextLength > 9 && ch != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }

        private void txtSDT_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Không cho nhập vào dữ liệu khác số hay nhập nhiều hơn 10 ký tự 
            char ch = e.KeyChar;
            if (!char.IsDigit(ch) && ch != (char)Keys.Back)
            {
                e.Handled = true;
            }
            else if (txtSDT.TextLength > 10 && ch != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }

        private void btnMoi_Click(object sender, EventArgs e)
        {
            txtMaHK.ReadOnly = false;
            txtMaHK.Clear();
            txtMaHK.Focus();
            txtHoChieu.Clear();
            txtTenHK.Clear();
            txtQT.Clear();
            txtDiaChiHK.Clear();
            txtSDT.Clear();
            txtHoChieu.Clear();
            btnThem.Enabled = true;
            btnXoa.Enabled = false;
            btnCapNhat.Enabled = false;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (txtMaHK.TextLength==0 || txtHoHK.TextLength==0 || txtTenHK.TextLength==0 || txtQT.TextLength==0 || txtHoChieu.TextLength == 0)
            {
                MessageBox.Show("Chưa nhập đủ dữ liệu", "Thông báo");
                txtMaHK.Focus();
                return;
            }
            etHK.MaHK = txtMaHK.Text;
            etHK.HoHK = txtHoHK.Text;
            etHK.TenHK = txtTenHK.Text;
            etHK.QuocTich = txtQT.Text;
            etHK.GioiTinh = (rdoNam.Checked == true )? "NAM" : "Nữ";
            etHK.NgSinh = dtpHK.Value;
            etHK.DiaChi = (txtDiaChiHK.TextLength==0)?txtDiaChiHK.Text:"null";
            etHK.HoChieu = txtHoChieu.Text;
            etHK.Sdt = (txtSDT.TextLength==0)?txtSDT.Text:"null";
            int kq = busHK.themHK(etHK);
            if (kq > 0)
            {
                MessageBox.Show("Thêm thành công.", "Thông báo");
                loadData();
                txtMaHK.Clear();
                txtMaHK.Focus();
                txtHoChieu.Clear();
                txtTenHK.Clear();
                txtQT.Clear();
                txtDiaChiHK.Clear();
                txtSDT.Clear();
                txtHoChieu.Clear();
                btnThem.Enabled = false;
                txtMaHK.ReadOnly = true;
                btnXoa.Enabled = true;
                btnCapNhat.Enabled = true;
            }
            else
            {
                MessageBox.Show("Thêm không thành công.", $"Thông báo");
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dgvHK.SelectedRows.Count == 1)
            {
                if (MessageBox.Show("Bạn có muốn xóa không?", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {

                    etHK.MaHK = txtMaHK.Text;
                    int kq = busHK.xoaHK(etHK);
                    if (kq > 0)
                    {
                        MessageBox.Show("Xóa thành công.", "Thông báo");
                        loadData();
                        txtMaHK.Clear();
                        txtHoChieu.Clear();
                        txtTenHK.Clear();
                        txtQT.Clear();
                        txtDiaChiHK.Clear();
                        txtSDT.Clear();
                        txtHoChieu.Clear();
                    }
                    else
                    {
                        MessageBox.Show("Xóa không thành công.", "Thông báo");
                    }
                }
            }
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            if (dgvHK.SelectedRows.Count == 1)
            {
                if (MessageBox.Show("Bạn có muốn sửa không?", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    etHK.MaHK = txtMaHK.Text;
                    etHK.HoHK = txtHoHK.Text;
                    etHK.TenHK = txtTenHK.Text;
                    etHK.QuocTich = txtQT.Text;
                    etHK.GioiTinh = (rdoNam.Checked == true) ? "NAM" : "Nữ";
                    etHK.NgSinh = dtpHK.Value;
                    etHK.DiaChi = (txtDiaChiHK.TextLength == 0) ? "null" :txtDiaChiHK.Text;
                    etHK.HoChieu = txtHoChieu.Text;
                    etHK.Sdt = (txtSDT.TextLength == 0) ? "null":txtSDT.Text;
                    int kq = busHK.suaHK(etHK);
                    if (kq > 0)
                    {
                        MessageBox.Show("Sửa thành công.", "Thông báo");
                        loadData();
                    }
                    else
                    {
                        MessageBox.Show("Sửa không thành công.", "Thông báo");
                    }
                }
            }
        }

        private void frmHanhKhach_FormClosing(object sender, FormClosingEventArgs e)
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

        private void dgvHK_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMaHK.Text = dgvHK.CurrentRow.Cells[0].Value.ToString();
            txtHoHK.Text= dgvHK.CurrentRow.Cells[1].Value.ToString();
            txtTenHK.Text= dgvHK.CurrentRow.Cells[2].Value.ToString();
            dtpHK.Value= (DateTime)dgvHK.CurrentRow.Cells[3].Value;
            txtQT.Text= dgvHK.CurrentRow.Cells[4].Value.ToString();
            if (dgvHK.CurrentRow.Cells[5].Value.ToString().Equals("NAM"))
            {
                rdoNam.Checked = true;
            }
            else
            {
                rdoNu.Checked = true;
            }
            txtSDT.Text = dgvHK.CurrentRow.Cells[6].Value.ToString();
            txtDiaChiHK.Text = dgvHK.CurrentRow.Cells[7].Value.ToString();
            txtHoChieu.Text = dgvHK.CurrentRow.Cells[8].Value.ToString();
        }
    }
}
