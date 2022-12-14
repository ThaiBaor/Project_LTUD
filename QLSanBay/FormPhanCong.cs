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
    public partial class frmPC : Form
    {
        public frmPC()
        {
            InitializeComponent();
        }
        BUS_HHK busHHK = new BUS_HHK();
        BUS_CHUYENBAY busCB = new BUS_CHUYENBAY();
        BUS_NV busNV = new BUS_NV();
        BUS_PHANCONG busPC = new BUS_PHANCONG();
        BUS_LICHBAY busLB = new BUS_LICHBAY();
        ET_HHK etHHK = new ET_HHK();
        ET_LICHBAY etLB = new ET_LICHBAY();
        ET_PHANCONG etPC = new ET_PHANCONG();

        private void frmPC_Load(object sender, EventArgs e)
        {
            loadComboboxHHK();
            loadData();
        }
        void loadData()
        {
            dgvPhanCong.DataSource = busPC.layDSPhanCong();
        }
        void loadComboboxHHK()
        {
            cboHHK.DataSource = busHHK.layDSHHK();
            cboHHK.DisplayMember = "TENHANGHK";
            cboHHK.ValueMember = "MAHANGHK";
        }
        void loadComboboxCB(string s)
        {
            etHHK.MaHHK = s;
            cboMaCB.DataSource = busCB.layDSChuyenBayTheoHHK(etHHK);
            cboMaCB.DisplayMember = "MACHUYENBAY";
            cboMaCB.ValueMember = "MACHUYENBAY";
        }
        void loadComboboxNV(string s)
        {
            etHHK.MaHHK = s;
            cboMaNV.DataSource = busNV.layDSTenNV_TheoHHK(etHHK);
            cboMaNV.DisplayMember = "HOTEN";
            cboMaNV.ValueMember = "MANV";
        }
        void loadComboboxNgayKH()
        {
            etLB.GioKH = cboGioKH.SelectedValue.ToString();
            etLB.MaCB = cboMaCB.SelectedValue.ToString();
            cboNgayKH.DataSource = busLB.layDSNgayKH_TheoMaChuyenBay_TheoGioKH(etLB);
            cboNgayKH.DisplayMember = "NGAYKHOIHANH";
            cboNgayKH.ValueMember = "NGAYKHOIHANH";
        }
        void loadComboboxGioKH()
        {
            etLB.MaCB = cboMaCB.SelectedValue.ToString();
            cboGioKH.DataSource = busLB.layDSGioKH_TheoMaChuyenBay(etLB);
            cboGioKH.DisplayMember = "GIOKHOIHANH";
            cboGioKH.ValueMember = "GIOKHOIHANH";
        }

        private void cboHHK_SelectionChangeCommitted(object sender, EventArgs e)
        {
            loadComboboxCB(cboHHK.SelectedValue.ToString());
            loadComboboxNV(cboHHK.SelectedValue.ToString());
        }

        private void cboMaCB_SelectionChangeCommitted(object sender, EventArgs e)
        {
            loadComboboxGioKH();
        }

        private void cboGioKH_SelectionChangeCommitted(object sender, EventArgs e)
        {
            loadComboboxNgayKH();
        }

        private void btnMoi_Click(object sender, EventArgs e)
        {
            btnThem.Enabled = true;
            cboHHK.Enabled = true;
            cboMaCB.Enabled = true;
            cboMaNV.Enabled = true;
            cboGioKH.Enabled = true;
            cboNgayKH.Enabled = true;
            btnCapNhat.Enabled = false;
            btnXoa.Enabled = false;
            nbSoGioBay.Value = 0;
        }

        private void dgvPhanCong_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            cboHHK.Text = busHHK.layTenHHK_TheoMaChuyenBay(dgvPhanCong.CurrentRow.Cells[1].Value.ToString());
            loadComboboxCB(cboHHK.SelectedValue.ToString());
            cboMaCB.Text = dgvPhanCong.CurrentRow.Cells[1].Value.ToString();
            loadComboboxNV(cboHHK.SelectedValue.ToString());
            cboMaNV.Text = busNV.layTenNV(dgvPhanCong.CurrentRow.Cells[0].Value.ToString());
            loadComboboxGioKH();
            loadComboboxNgayKH();
            cboGioKH.Text = dgvPhanCong.CurrentRow.Cells[2].Value.ToString();
            string[] s = dgvPhanCong.CurrentRow.Cells[3].Value.ToString().Split(' ');
            cboNgayKH.Text = s[0];
            nbSoGioBay.Value = Int32.Parse(dgvPhanCong.CurrentRow.Cells[4].Value.ToString());
            btnThem.Enabled = false;
            btnXoa.Enabled = true;
            btnCapNhat.Enabled = true;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            cboHHK.Enabled = true;
            cboMaCB.Enabled = true;
            cboMaNV.Enabled = true;
            cboNgayKH.Enabled = true;
            cboGioKH.Enabled = true;
            nbSoGioBay.Value = 0;
            etPC.MaChuyenBay = cboMaCB.SelectedValue.ToString();
            etPC.MaNV = cboMaNV.SelectedValue.ToString();
            etPC.GioKH = cboGioKH.SelectedValue.ToString();
            etPC.NgayKH = DateTime.Parse(cboNgayKH.Text);
            etPC.SoGioBay =(int)nbSoGioBay.Value;
            int kq = busPC.themPhanCong(etPC);
            if (kq > 0)
            {
                MessageBox.Show("Thêm thành công.", "Thông báo");
                loadData();
                cboHHK.Enabled = false;
                cboMaCB.Enabled = false;
                cboMaNV.Enabled = false;
                cboGioKH.Enabled = false;
                cboNgayKH.Enabled = false;
                nbSoGioBay.Value = 0;
                btnThem.Enabled = false;
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
            if (dgvPhanCong.SelectedRows.Count == 1)
            {
                if (MessageBox.Show("Bạn có muốn xóa không?", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {

                    etPC.MaChuyenBay = cboMaCB.SelectedValue.ToString();
                    etPC.MaNV = cboMaNV.SelectedValue.ToString();
                    etPC.GioKH = cboGioKH.SelectedValue.ToString();
                    etPC.NgayKH = DateTime.Parse(cboNgayKH.Text);
                    int kq = busPC.xoaPhanCong(etPC);
                    if (kq > 0)
                    {
                        MessageBox.Show("Xóa thành công.", "Thông báo");
                        loadData();
                        nbSoGioBay.Value = 0;
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
            if (dgvPhanCong.SelectedRows.Count == 1)
            {
                if (MessageBox.Show("Bạn có muốn cập nhật không?", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    etPC.MaChuyenBay = cboMaCB.SelectedValue.ToString();
                    etPC.MaNV = cboMaNV.SelectedValue.ToString();
                    etPC.GioKH = cboGioKH.SelectedValue.ToString();
                    etPC.NgayKH = DateTime.Parse(cboNgayKH.Text);
                    etPC.SoGioBay = (int)nbSoGioBay.Value;
                    int kq = busPC.suaPhanCong(etPC);
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
        }
    }
}
