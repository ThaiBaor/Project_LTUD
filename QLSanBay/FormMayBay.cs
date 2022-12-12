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
    public partial class frmMayBay : Form
    {
        public frmMayBay()
        {
            InitializeComponent();
        }
        BUS_MAYBAY busMB = new BUS_MAYBAY();
        BUS_HHK busHHK = new BUS_HHK();
        ET_MAYBAY etMB = new ET_MAYBAY();
        void loadData()
        {
            dgvMayBay.DataSource = busMB.layDSMayBay();
        }
        void loadCombobox()
        {
            cboHHK.DataSource = busHHK.layDSHHK();
            cboHHK.DisplayMember = "TENHANGHK";
            cboHHK.ValueMember = "MAHANGHK";
        }
        private void txtSoHieu_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Không cho nhập vào dữ liệu khác chữ và số hay nhập nhiều hơn 11 ký tự 
            char ch = e.KeyChar;
            if (!char.IsLetterOrDigit(ch) && ch != (char)Keys.Back)
            {
                e.Handled = true;
            }
            else if (txtSoHieu.TextLength > 11 && ch != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }

        private void frmMayBay_Load(object sender, EventArgs e)
        {
            loadData();
            loadCombobox();
            txtSoHieu.ReadOnly = true;
            btnThem.Enabled = false;
        }

        private void btnMoi_Click(object sender, EventArgs e)
        {
            btnThem.Enabled = true;
            txtSoHieu.ReadOnly = false;
            txtSoHieu.Focus();
            btnXoa.Enabled = false;
            btnCapNhat.Enabled = false;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (txtSoHieu.TextLength == 0 )
            {
                MessageBox.Show("Chưa nhập dữ liệu", "Thông báo");
                txtSoHieu.Focus();
                return;
            }
            etMB.SoHieu = txtSoHieu.Text;
            etMB.MaHHK = cboHHK.SelectedValue.ToString();
            int kq = busMB.themMayBay(etMB);
            if (kq > 0)
            {
                MessageBox.Show("Thêm thành công.", "Thông báo");
                loadData();
            }
            else
            {
                MessageBox.Show("Thêm không thành công.", "Thông báo");
            }
            txtSoHieu.Clear();
            btnThem.Enabled = false;
            txtSoHieu.ReadOnly = true;
            btnXoa.Enabled = true;
            btnCapNhat.Enabled = true;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn xóa không?", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                etMB.SoHieu = txtSoHieu.Text;
                int kq = busMB.xoaMayBay(etMB);
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
                etMB.SoHieu = txtSoHieu.Text;
                etMB.MaHHK = cboHHK.SelectedValue.ToString();
                int kq = busMB.suaMayBay(etMB);
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

        private void frmMayBay_FormClosing(object sender, FormClosingEventArgs e)
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

        private void dgvMayBay_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtSoHieu.Text = dgvMayBay.CurrentRow.Cells[0].Value.ToString();
            cboHHK.Text = busHHK.layTenHHK(dgvMayBay.CurrentRow.Cells[1].Value.ToString());
        }
    }
}
