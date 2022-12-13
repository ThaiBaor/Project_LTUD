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
    public partial class frmLichBay : Form
    {
        public frmLichBay()
        {
            InitializeComponent();
        }
        BUS_LICHBAY busLB = new BUS_LICHBAY();
        BUS_HHK busHHK = new BUS_HHK();
        BUS_CHUYENBAY busCB = new BUS_CHUYENBAY();
        BUS_MAYBAY busMB = new BUS_MAYBAY();
        ET_LICHBAY etLB = new ET_LICHBAY();
        ET_HHK etHHK = new ET_HHK();
        void loadData()
        {
            dgvLichBay.DataSource = busLB.layDSLichBay();
        }
        void loadComboboxHHK()
        {
            cboHHK.DataSource = busHHK.layDSHHK();
            cboHHK.DisplayMember = "TENHANGHK";
            cboHHK.ValueMember = "MAHANGHK";
        }
        void loadComboboxCB()
        {
            etHHK.MaHHK = cboHHK.SelectedValue.ToString();
            cboMaCB.DataSource = busCB.layDSChuyenBayTheoHHK(etHHK);
            cboMaCB.DisplayMember = "MACHUYENBAY";
            cboMaCB.ValueMember = "MACHUYENBAY";
        }
        void loadComboboxMB()
        {
            etHHK.MaHHK = cboHHK.SelectedValue.ToString();
            cboSoHieu.DataSource = busMB.layDSMayBay_TheoHHK(etHHK);
            cboSoHieu.DisplayMember = "SOHIEU";
            cboSoHieu.ValueMember = "SOHIEU";
        }
        private void frmLichBay_Load(object sender, EventArgs e)
        {
            btnThem.Enabled = false;
            cboHHK.Enabled = false;
            cboMaCB.Enabled = false;
            mtxtGioKH.Enabled = false;
            dtpHK.Enabled = false;
            loadData();
            loadComboboxHHK();
        }

        private void cboHHK_SelectionChangeCommitted(object sender, EventArgs e)
        {
            loadComboboxCB();
            loadComboboxMB();
        }

        private void btnMoi_Click(object sender, EventArgs e)
        {
            cboHHK.Enabled = true;
            cboMaCB.Enabled = true;
            mtxtGioKH.Enabled = true;
            dtpHK.Enabled = true;
            btnThem.Enabled = true;
            btnXoa.Enabled = false;
            btnCapNhat.Enabled = false;
        }

        private void dgvLichBay_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btnThem.Enabled = false;
            btnCapNhat.Enabled = true;
            btnXoa.Enabled = true;
            cboHHK.Enabled = false;
            cboMaCB.Enabled = false;
            cboSoHieu.Enabled = true;
            mtxtGioKH.Enabled = false;
            dtpHK.Enabled = false;
            loadComboboxCB();
            loadComboboxMB();
            cboHHK.Text = busHHK.layTenHHK_TheoMaChuyenBay(dgvLichBay.CurrentRow.Cells[0].Value.ToString());
            cboMaCB.Text = dgvLichBay.CurrentRow.Cells[0].Value.ToString();
            cboSoHieu.Text = dgvLichBay.CurrentRow.Cells[3].Value.ToString();
            mtxtGioKH.Text = dgvLichBay.CurrentRow.Cells[1].Value.ToString();
            dtpHK.Value = (DateTime)dgvLichBay.CurrentRow.Cells[2].Value;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (mtxtGioKH.TextLength == 0)
            {
                MessageBox.Show("Chưa nhập giờ khởi hành","Thông báo");
                return;
            }
            etLB.MaCB = cboMaCB.SelectedValue.ToString();
            etLB.SoHieuMB = cboSoHieu.SelectedValue.ToString();
            etLB.GioKH = mtxtGioKH.Text;
            etLB.NgayKH = dtpHK.Value;
            int kq = busLB.themLichBay(etLB);
            if (kq > 0)
            {
                MessageBox.Show("Thêm thành công.", "Thông báo");
                loadData();
            }
            else
            {
                MessageBox.Show("Thêm không thành công.", "Thông báo");
            }
            mtxtGioKH.Clear();
            btnThem.Enabled = false;
            cboHHK.Enabled = false;
            btnXoa.Enabled = true;
            cboMaCB.Enabled = false;
            cboSoHieu.Enabled = false;
            btnCapNhat.Enabled = true;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn xóa không?", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                etLB.MaCB = cboMaCB.SelectedValue.ToString();
                etLB.GioKH = mtxtGioKH.Text;
                etLB.NgayKH = dtpHK.Value;
                int kq = busLB.xoaLichBay(etLB);
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
                etLB.MaCB = cboMaCB.SelectedValue.ToString();
                etLB.GioKH = mtxtGioKH.Text;
                etLB.NgayKH = dtpHK.Value;
                etLB.SoHieuMB = cboSoHieu.SelectedValue.ToString();
                int kq = busLB.suaLichBay(etLB);
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

        private void frmLichBay_FormClosing(object sender, FormClosingEventArgs e)
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
