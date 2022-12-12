using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BUS_QLSanBay;
using ET_QLSanBay;

namespace QLSanBay
{
    public partial class frmChuyenBay : Form
    {
        public frmChuyenBay()
        {
            InitializeComponent();
        }
        BUS_CHUYENBAY busCB = new BUS_CHUYENBAY();
        BUS_HHK busHHK = new BUS_HHK();
        ET_CHUYENBAY etCB = new ET_CHUYENBAY();

        private void frmChuyenBay_Load(object sender, EventArgs e)
        {
            loadData();
            loadComboboxHHK();
            txtMaCB.ReadOnly = true;
            btnThem.Enabled = false;
        }
        void loadData()
        {
            dgvCB.DataSource = busCB.layDSChuyenBay();
        }
        void loadComboboxHHK()
        {
            cboHHK.DataSource = busHHK.layDSHHK();
            cboHHK.DisplayMember = "TENHANGHK";
            cboHHK.ValueMember = "MAHANGHK";
        }

        private void btnMoi_Click(object sender, EventArgs e)
        {
            txtMaCB.Clear();
            txtDDD.Clear();
            txtDDKH.Clear();
            txtSBD.Clear();
            txtSBKH.Clear();
            txtTC.Clear();
            txtMaCB.ReadOnly = false;
            btnThem.Enabled = true;
            btnXoa.Enabled = false;
            btnCapNhat.Enabled = false;
            txtMaCB.Focus();
        }

        private void txtMaCB_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Không cho nhập vào dữ liệu khác chữ và số hay nhập nhiều hơn 10 ký tự 
            char ch = e.KeyChar;
            if (!char.IsLetterOrDigit(ch) && ch != (char)Keys.Back)
            {
                e.Handled = true;
            }
            else if (txtMaCB.TextLength > 10 && ch != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }

        private void txtSBKH_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Không cho nhập vào dữ liệu nhiều hơn 100 ký tự 
            char ch = e.KeyChar;
            if (txtSBKH.TextLength > 100 && ch != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }

        private void txtDDKH_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Không cho nhập vào dữ liệu nhiều hơn 100 ký tự 
            char ch = e.KeyChar;
            if (txtDDKH.TextLength > 100 && ch != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }

        private void txtTC_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Không cho nhập vào dữ liệu nhiều hơn 100 ký tự 
            char ch = e.KeyChar;
            if (txtTC.TextLength > 100 && ch != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }

        private void txtSBD_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Không cho nhập vào dữ liệu nhiều hơn 100 ký tự 
            char ch = e.KeyChar;
            if (txtSBD.TextLength > 100 && ch != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }

        private void txtDDD_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Không cho nhập vào dữ liệu nhiều hơn 100 ký tự 
            char ch = e.KeyChar;
            if (txtDDD.TextLength > 100 && ch != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }

        private void dgvCB_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMaCB.Text = dgvCB.CurrentRow.Cells[0].Value.ToString();
            txtSBKH.Text= dgvCB.CurrentRow.Cells[1].Value.ToString();
            txtDDKH.Text= dgvCB.CurrentRow.Cells[2].Value.ToString();
            txtSBD.Text= dgvCB.CurrentRow.Cells[3].Value.ToString();
            txtDDD.Text= dgvCB.CurrentRow.Cells[4].Value.ToString();
            txtTC.Text= dgvCB.CurrentRow.Cells[5].Value.ToString();
            cboHHK.Text = busHHK.layTenHHK(dgvCB.CurrentRow.Cells[6].Value.ToString());
            btnThem.Enabled = false;
            btnXoa.Enabled = true;
            btnCapNhat.Enabled = true;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (txtMaCB.TextLength==0 || txtSBKH.TextLength==0 || txtDDKH.TextLength==0 || txtSBD.TextLength==0 || txtDDD.TextLength==0)
            {
                MessageBox.Show("Chưa nhập đủ dữ liệu", "Thông báo");
                txtMaCB.Focus();
                return;
            }
            etCB.MaChuyenBay = txtMaCB.Text;
            etCB.SanBayKH = txtSBKH.Text;
            etCB.DiaDiemKH = txtDDKH.Text;
            etCB.SanBayDen = txtSBD.Text;
            etCB.DiaDiemDen = txtDDD.Text;
            etCB.SanBayTC = txtTC.Text;
            etCB.MaHHK = cboHHK.SelectedValue.ToString();
            int kq = busCB.themChuyenBay(etCB);
            if (kq > 0)
            {
                MessageBox.Show("Thêm thành công.", "Thông báo");
                loadData();
                txtMaCB.Clear();
                txtDDD.Clear();
                txtDDKH.Clear();
                txtSBD.Clear();
                txtSBKH.Clear();
                txtTC.Clear();
                btnThem.Enabled = false;
                txtMaCB.ReadOnly = true;
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
            if (MessageBox.Show("Bạn có muốn xóa không?", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                etCB.MaChuyenBay = txtMaCB.Text;
                int kq = busCB.xoaChuyenBay(etCB);
                if (kq > 0)
                {
                    MessageBox.Show("Xóa thành công.", "Thông báo");
                    loadData();
                    txtMaCB.Clear();
                    txtDDD.Clear();
                    txtDDKH.Clear();
                    txtSBD.Clear();
                    txtSBKH.Clear();
                    txtTC.Clear();
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
                etCB.MaChuyenBay = txtMaCB.Text;
                etCB.SanBayKH = txtSBKH.Text;
                etCB.DiaDiemKH = txtDDKH.Text;
                etCB.SanBayDen = txtSBD.Text;
                etCB.DiaDiemDen = txtDDD.Text;
                etCB.SanBayTC = txtTC.Text;
                etCB.MaHHK = cboHHK.SelectedValue.ToString();
                int kq = busCB.suaChuyenBay(etCB);
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

        private void frmChuyenBay_FormClosing(object sender, FormClosingEventArgs e)
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
