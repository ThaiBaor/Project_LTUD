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
    public partial class frmPhongBan : Form
    {
        public frmPhongBan()
        {
            InitializeComponent();
        }
        BUS_PHONBAN busPB = new BUS_PHONBAN();
        BUS_HHK busHHK = new BUS_HHK();
        ET_PHONGBAN etPB = new ET_PHONGBAN();
        BUS_NV busNV = new BUS_NV();
        ET_HHK etHHK = new ET_HHK();
        private void frmPhongBan_Load(object sender, EventArgs e)
        {
            loadComboboxTenHHK();
            loadData();
            txtMaPhong.ReadOnly = true;
            btnThem.Enabled = false;

        }
        void loadData()
        {
            dgvPhongBan.DataSource = busPB.layDSPB();
        }
        void loadComboboxTenHHK()
        {
            cboMaHHK.DataSource = busHHK.layDSHHK();
            cboMaHHK.ValueMember = "MAHANGHK";
            cboMaHHK.DisplayMember = "TENHANGHK";          
        }
        void loadComboboxTRPHG()
        {
            etHHK.MaHHK = cboMaHHK.SelectedValue.ToString();
            cboTrgPhong.DataSource = busNV.layDSNgQL(etHHK);
            cboTrgPhong.ValueMember = "MANV";
            cboTrgPhong.DisplayMember = "HOTEN";
        }
        

        private void dgvPhongBan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMaPhong.Text = dgvPhongBan.CurrentRow.Cells[0].Value.ToString();
            txtTenPhong.Text = dgvPhongBan.CurrentRow.Cells[2].Value.ToString();
            cboMaHHK.Text = busHHK.layTenHHK(dgvPhongBan.CurrentRow.Cells[1].Value.ToString());
            loadComboboxTRPHG();
            cboTrgPhong.Text = busNV.layTenNV(dgvPhongBan.CurrentRow.Cells[3].Value.ToString());
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
            etPB.MaPhong = txtMaPhong.Text;
            etPB.MaHHK = cboMaHHK.SelectedValue.ToString();
            etPB.TenPhong = txtTenPhong.Text;
            etPB.TrgPhong = "null";
            int kq = busPB.themPB(etPB);
            if (kq > 0)
            {
                MessageBox.Show("Thêm thành công. ", "Thông báo");
                loadData();
            }
            else
            {
                MessageBox.Show("Thêm không thành công. ", "Thông báo");
            }
            txtMaPhong.Clear();
            txtTenPhong.Clear();
            txtMaPhong.ReadOnly = true;
            btnThem.Enabled = false;
            btnCapNhat.Enabled = true;
            btnXoa.Enabled = true;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn xóa không?", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                etPB.MaPhong = txtMaPhong.Text;
                int kq = busPB.xoaPB(etPB);
                if (kq > 0)
                {
                    MessageBox.Show("Xóa thành công. ", "Thông báo");
                    loadData();
                }
                else
                {
                    MessageBox.Show("Xóa không thành công. ", "Thông báo");
                }
            }

        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn cập nhật không?", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                etPB.MaPhong = txtMaPhong.Text;
                etPB.MaHHK = cboMaHHK.SelectedValue.ToString();
                etPB.TenPhong = txtTenPhong.Text;
                etPB.TrgPhong = cboTrgPhong.SelectedValue.ToString();
                int kq = busPB.capNhatPB(etPB);
                if (kq > 0)
                {
                    MessageBox.Show("Cập nhật thành công. ", "Thông báo");
                    loadData();
                }
                else
                {
                    MessageBox.Show("Cập nhật không thành công. ", "Thông báo");
                }
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

        private void btnMoi_Click(object sender, EventArgs e)
        {
            txtMaPhong.Clear();
            txtTenPhong.Clear();
            txtMaPhong.Focus();
            txtMaPhong.ReadOnly = false;
            btnThem.Enabled = true;
            btnCapNhat.Enabled = false;
            btnXoa.Enabled = false;
        }

        private void cboMaHHK_SelectionChangeCommitted(object sender, EventArgs e)
        {
            loadComboboxTRPHG();
        }
    }
}