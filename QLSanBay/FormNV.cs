using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Globalization;
using System.Windows.Forms;
using ET_QLSanBay;
using BUS_QLSanBay;

namespace QLSanBay
{
    public partial class frmNV : Form
    {
        public frmNV()
        {
            InitializeComponent();
        }
        BUS_NV busNV = new BUS_NV();
        BUS_HHK busHHK = new BUS_HHK();
        BUS_PHONBAN busPB = new BUS_PHONBAN();
        ET_NV etNV = new ET_NV();
        ET_HHK etHHK = new ET_HHK();
        void loadData()
        {
            dgvNV.DataSource= busNV.layDSNV();
        }
        void loadComboboxHHK()
        {
            cboHHK.DataSource = busHHK.layDSHHK();
            cboHHK.DisplayMember = "TENHANGHK";
            cboHHK.ValueMember = "MAHANGHK";
        }
        void loadComboboxPB()
        {
            etHHK.MaHHK = cboHHK.SelectedValue.ToString();
            cboPB.DataSource = busPB.layDSPB_TheoHHK(etHHK);
            cboPB.DisplayMember = "TENPHG";
            cboPB.ValueMember = "MAPHONG";
        }
        void loadComboboxNGQL()
        {
            etHHK.MaHHK = cboHHK.SelectedValue.ToString();
            cboNGQL.DataSource = busNV.layDSNgQL(etHHK);
            cboNGQL.ValueMember = "MANV";
            cboNGQL.DisplayMember = "HOTEN";
        }

        private void txtMaNV_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Không cho nhập vào dữ liệu khác chữ và số hay nhập nhiều hơn 10 ký tự 
            char ch = e.KeyChar;
            if (!char.IsLetterOrDigit(ch) && ch != (char)Keys.Back)
            {
                e.Handled = true;
            }
            else if (txtMaNV.TextLength > 10 && ch != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }

        private void txtHoNV_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Không cho nhập vào dữ liệu khác chữ hay nhập nhiều hơn 30 ký tự 
            char ch = e.KeyChar;
            if (!char.IsLetter(ch) && ch != (char)Keys.Back && !char.IsWhiteSpace(ch))
            {
                e.Handled = true;
            }
            else if (txtHoNV.TextLength > 30 && ch != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }

        private void txtTenNV_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Không cho nhập vào dữ liệu khác chữ hay nhập nhiều hơn 15 ký tự 
            char ch = e.KeyChar;
            if (!char.IsLetter(ch) && ch != (char)Keys.Back)
            {
                e.Handled = true;
            }
            else if (txtTenNV.TextLength > 15 && ch != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }
     
        private void dtP_ValueChanged(object sender, EventArgs e)
        {
            if (dtP.Value.Year > 2004)
            {
                MessageBox.Show("Ngày sinh không thể lớn hơn 12/12/2004", "Thông báo");
                dtP.Value = DateTime.Parse("1/1/2004");
            }
        }

        private void txtDiaChi_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Không cho nhập vào dữ liệu nhiều hơn 100 ký tự 
            char ch = e.KeyChar;           
            if (txtDiaChi.TextLength > 100 && ch != (char)Keys.Back)
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

        private void txtCCCD_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Không cho nhập vào dữ liệu khác số hay nhập nhiều hơn 12 ký tự 
            char ch = e.KeyChar;
            if (!char.IsDigit(ch) && ch != (char)Keys.Back)
            {
                e.Handled = true;
            }
            else if (txtCCCD.TextLength > 12 && ch != (char)Keys.Back)
            {
                e.Handled = true;
            }            
        }

        private void txtPhanLoai_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Không cho nhập vào dữ liệu khác chữ hay nhập nhiều hơn 50 ký tự 
            char ch = e.KeyChar;
            if (!char.IsLetter(ch) && ch != (char)Keys.Back && !char.IsWhiteSpace(ch))
            {
                e.Handled = true;
            }
            else if (txtPhanLoai.TextLength > 50 && ch != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }

        private void txtLuong_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Không cho nhập vào dữ liệu khác số 
            char ch = e.KeyChar;
            if (!char.IsDigit(ch) && ch != (char)Keys.Back)
            {
                e.Handled = true;
            }            
        }

        private void frmNV_Load(object sender, EventArgs e)
        {
            loadData();
            loadComboboxHHK();
            rdoNam.Checked = true;
            txtMaNV.ReadOnly = true;
            btnThem.Enabled = false;
            dtP.CustomFormat = "dd/MM/yyyy";
        }

        private void cboHHK_SelectionChangeCommitted(object sender, EventArgs e)
        {
            loadComboboxPB();
            loadComboboxNGQL();
        }

        private void btnMoi_Click(object sender, EventArgs e)
        {
            btnThem.Enabled = true;
            btnXoa.Enabled = false;
            btnCapNhat.Enabled = false;
            txtMaNV.ReadOnly = false;
            txtMaNV.Clear();
            txtTenNV.Clear();
            txtHoNV.Clear();
            txtPhanLoai.Clear();
            txtSDT.Clear();
            txtDiaChi.Clear();
            txtCCCD.Clear();
            txtLuong.Clear();
            txtMaNV.Focus();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (txtMaNV.TextLength == 0 || txtHoNV.TextLength == 0 || txtTenNV.TextLength == 0 || txtDiaChi.TextLength == 0 || txtCCCD.TextLength == 0 || txtLuong.TextLength == 0 || txtPhanLoai.TextLength == 0)
            {
                MessageBox.Show("Chưa nhập đủ dữ liệu", "Thông báo");
                txtMaNV.Focus();
                return;
            }
            etNV.MaNV = txtMaNV.Text;
            etNV.HoNV = txtHoNV.Text;
            etNV.TenNV = txtTenNV.Text;
            etNV.NgaySinh = dtP.Value;
            if (txtSDT.TextLength == 0)
            {
                etNV.Sdt = "null";
            }
            else
            {
                etNV.Sdt = txtSDT.Text;
            }
            etNV.DiaChi = txtDiaChi.Text;
            etNV.CCCD = txtCCCD.Text;
            etNV.MaNgQL = cboNGQL.SelectedValue.ToString();
            if (rdoNam.Checked == true)
            {
                etNV.Phai = "NAM";
            }
            else
            {
                etNV.Phai = "NỮ";
            }
            etNV.MaPhong = cboPB.SelectedValue.ToString();
            etNV.PhanLoai = txtPhanLoai.Text;
            etNV.Luong = Int32.Parse(txtLuong.Text);
            int kq = busNV.themNV(etNV);
            if (kq > 0)
            {
                MessageBox.Show("Thêm thành công.", "Thông báo");
                loadData();
                txtMaNV.Clear();
                txtTenNV.Clear();
                txtHoNV.Clear();
                txtPhanLoai.Clear();
                txtSDT.Clear();
                txtDiaChi.Clear();
                txtCCCD.Clear();
                txtLuong.Clear();
                txtMaNV.Focus();
                btnThem.Enabled = false;
                txtMaNV.ReadOnly = true;
                btnXoa.Enabled = true;
                btnCapNhat.Enabled = true;
            }
            else
            {
                MessageBox.Show("Thêm không thành công.", $"Thông báo");
            }
        }

        private void dgvNV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btnCapNhat.Enabled = true;
            btnXoa.Enabled = true;
            btnThem.Enabled = false;
            txtMaNV.Text = dgvNV.CurrentRow.Cells[0].Value.ToString();
            txtHoNV.Text= dgvNV.CurrentRow.Cells[2].Value.ToString();
            txtTenNV.Text = dgvNV.CurrentRow.Cells[3].Value.ToString();
            dtP.Value = (DateTime)dgvNV.CurrentRow.Cells[4].Value;
            txtSDT.Text= dgvNV.CurrentRow.Cells[5].Value.ToString();
            txtDiaChi.Text= dgvNV.CurrentRow.Cells[6].Value.ToString();
            txtCCCD.Text= dgvNV.CurrentRow.Cells[7].Value.ToString();
            if (dgvNV.CurrentRow.Cells[8].Value.ToString().Equals("NAM"))
            {
                rdoNam.Checked = true;
            }
            else
            {
                rdoNu.Checked = true;
            }
            loadComboboxPB();
            loadComboboxNGQL();
            cboHHK.Text = busHHK.layTenHHK_TheoMaPhong(dgvNV.CurrentRow.Cells[1].Value.ToString());
            cboPB.Text = busPB.layTenPhongBan_TheoMaPhong(dgvNV.CurrentRow.Cells[1].Value.ToString());
            cboNGQL.Text = busNV.layTenNV(dgvNV.CurrentRow.Cells[9].Value.ToString());
            txtPhanLoai.Text = dgvNV.CurrentRow.Cells[10].Value.ToString();
            txtLuong.Text = dgvNV.CurrentRow.Cells[11].Value.ToString();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dgvNV.SelectedRows.Count == 1)
            {
                if (MessageBox.Show("Bạn có muốn xóa không?", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {

                    etNV.MaNV = txtMaNV.Text;
                    int kq = busNV.xoaNV(etNV);
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
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            if (dgvNV.SelectedRows.Count == 1)
            {
                if (MessageBox.Show("Bạn có muốn sửa không?", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    etNV.MaNV = txtMaNV.Text;
                    etNV.HoNV = txtHoNV.Text;
                    etNV.TenNV = txtTenNV.Text;
                    etNV.NgaySinh = dtP.Value;
                    if (txtSDT.TextLength == 0)
                    {
                        etNV.Sdt = "null";
                    }
                    else
                    {
                        etNV.Sdt = txtSDT.Text;
                    }
                    etNV.DiaChi = txtDiaChi.Text;
                    etNV.CCCD = txtCCCD.Text;
                    etNV.MaNgQL = cboNGQL.SelectedValue.ToString();
                    if (rdoNam.Checked == true)
                    {
                        etNV.Phai = "NAM";
                    }
                    else
                    {
                        etNV.Phai = "NỮ";
                    }
                    etNV.MaPhong = cboPB.SelectedValue.ToString();
                    etNV.PhanLoai = txtPhanLoai.Text;
                    etNV.Luong = Int32.Parse(txtLuong.Text);
                    int kq = busNV.suaNV(etNV);
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

        private void frmNV_FormClosing(object sender, FormClosingEventArgs e)
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
