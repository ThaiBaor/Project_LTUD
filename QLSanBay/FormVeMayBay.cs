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
    public partial class frmVMB : Form
    {
        public frmVMB()
        {
            InitializeComponent();
        }
        BUS_VEMAYBAY busVMB = new BUS_VEMAYBAY();
        BUS_LOAIVE busLV = new BUS_LOAIVE();
        BUS_LICHBAY busLB = new BUS_LICHBAY();
        BUS_CHUYENBAY busCB = new BUS_CHUYENBAY();
        BUS_HK busHK = new BUS_HK();
        ET_LICHBAY etLB = new ET_LICHBAY();
        ET_VEMAYBAY etVMB = new ET_VEMAYBAY();
        BUS_HHK bus_HHK = new BUS_HHK();
        ET_HHK etHHK = new ET_HHK();
        void loadData()
        {
            dgvVMB.DataSource = busVMB.layDSVeMayBay();
        }
        void loadComboboxLoaiVe()
        {
            cboLoaiVe.DataSource = busLV.layDSLoaiVe();
            cboLoaiVe.DisplayMember = "TENLOAIVE";
            cboLoaiVe.ValueMember = "MALOAIVE";
        }
        void loadComboboxHHK()
        {
            cboHHK.DataSource = bus_HHK.layDSHHK();
            cboHHK.DisplayMember = "TENHANGHK";
            cboHHK.ValueMember = "MAHANGHK";
        }
        void loadComboboxCB()
        {
            etHHK.MaHHK = cboHHK.SelectedValue.ToString();
            cboMaChuyenBay.DataSource = busCB.layDSChuyenBayTheoHHK(etHHK);
            cboMaChuyenBay.DisplayMember = "MACHUYENBAY";
            cboMaChuyenBay.ValueMember = "MACHUYENBAY";
        }
        void loadComboboxHK()
        {
            cboMaHanhKhach.DataSource = busHK.layDSTenHK();
            cboMaHanhKhach.DisplayMember = "HOTEN";
            cboMaHanhKhach.ValueMember = "MAHK";
        }
        void loadComboboxNgayKH()
        {
            etLB.GioKH = cboGioKhoiHanh.SelectedValue.ToString();
            etLB.MaCB = cboMaChuyenBay.SelectedValue.ToString();
            cboNgayKhoiHanh.DataSource = busLB.layDSNgayKH_TheoMaChuyenBay_TheoGioKH(etLB);
            cboNgayKhoiHanh.DisplayMember = "NGAYKHOIHANH";
            cboNgayKhoiHanh.ValueMember = "NGAYKHOIHANH";
        }
        void loadComboboxGioKH()
        {
            etLB.MaCB = cboMaChuyenBay.SelectedValue.ToString();
            cboGioKhoiHanh.DataSource = busLB.layDSGioKH_TheoMaChuyenBay(etLB);
            cboGioKhoiHanh.DisplayMember = "GIOKHOIHANH";
            cboGioKhoiHanh.ValueMember = "GIOKHOIHANH";
        }
        private void frmVMB_Load(object sender, EventArgs e)
        {
            loadData();
            btnThem.Enabled = false;
            txtMaSoVe.ReadOnly = true;
            loadComboboxHHK();
            loadComboboxLoaiVe();
            loadComboboxHK();
        }

        private void txtMaSoVe_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Không cho nhập vào dữ liệu khác chữ và số hay nhập nhiều hơn 10 ký tự 
            char ch = e.KeyChar;
            if (!char.IsLetterOrDigit(ch) && ch != (char)Keys.Back)
            {
                e.Handled = true;
            }
            else if (txtMaSoVe.TextLength > 10 && ch != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }

        private void txtMaSoGhe_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Không cho nhập vào dữ liệu khác chữ và số hay nhập nhiều hơn 4 ký tự 
            char ch = e.KeyChar;
            if (!char.IsLetterOrDigit(ch) && ch != (char)Keys.Back)
            {
                e.Handled = true;
            }
            else if (txtMaSoGhe.TextLength > 4 && ch != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }

        private void cboHHK_SelectionChangeCommitted(object sender, EventArgs e)
        {
            loadComboboxCB();
        }

        private void cboMaChuyenBay_SelectionChangeCommitted(object sender, EventArgs e)
        {
            loadComboboxGioKH();
            loadlbl(cboMaChuyenBay.SelectedValue.ToString());
        }
        void loadlbl(string s)
        {
            lblKH.Text = busCB.laySBKH_TheoMaChuyenBay(s);
            lblDen.Text = busCB.laySBDen_TheoMaChuyenBay(s);
            lblTrungChuyen.Text = busCB.laySBTC_TheoMaChuyenBay(s);
        }
        private void cboGioKhoiHanh_SelectionChangeCommitted(object sender, EventArgs e)
        {
            loadComboboxNgayKH();
        }

        private void dgvVMB_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btnThem.Enabled = false;
            btnCapNhat.Enabled = true;
            btnXoa.Enabled = true;
            txtMaSoVe.Text = dgvVMB.CurrentRow.Cells[1].Value.ToString();
            cboLoaiVe.Text = busLV.layTenLoaiVe(dgvVMB.CurrentRow.Cells[2].Value.ToString());
            nbKLHL.Value = Int32.Parse(dgvVMB.CurrentRow.Cells[4].Value.ToString());
            nbGiaVe.Value= Int32.Parse(dgvVMB.CurrentRow.Cells[3].Value.ToString());
            txtMaSoGhe.Text= dgvVMB.CurrentRow.Cells[6].Value.ToString();
            cboHHK.Text = bus_HHK.layTenHHK_TheoMaChuyenBay(dgvVMB.CurrentRow.Cells[0].Value.ToString());
            loadComboboxCB();
            cboMaChuyenBay.Text= dgvVMB.CurrentRow.Cells[0].Value.ToString();
            cboMaHanhKhach.Text = busHK.layTenHK_TheoMaHK(dgvVMB.CurrentRow.Cells[5].Value.ToString());
            loadComboboxGioKH();
            cboGioKhoiHanh.Text= dgvVMB.CurrentRow.Cells[7].Value.ToString();
            loadComboboxNgayKH();
            string[] s = dgvVMB.CurrentRow.Cells[8].Value.ToString().Split(' ');
            cboNgayKhoiHanh.Text= s[0];
            loadlbl(dgvVMB.CurrentRow.Cells[0].Value.ToString());
        }

        private void btnMoi_Click(object sender, EventArgs e)
        {
            btnThem.Enabled = true;
            btnXoa.Enabled = false;
            btnCapNhat.Enabled = false;
            txtMaSoVe.ReadOnly = false;
            txtMaSoVe.Clear();
            txtMaSoVe.Focus();
            txtMaSoGhe.Clear();
            nbGiaVe.Value = 0;
            nbKLHL.Value = 0;            
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (txtMaSoVe.TextLength == 0 || txtMaSoGhe.TextLength == 0 || cboHHK.SelectedValue.Equals("") || cboMaChuyenBay.SelectedValue.Equals("") || cboMaHanhKhach.SelectedValue.Equals("") || cboNgayKhoiHanh.SelectedValue.Equals("") || cboGioKhoiHanh.SelectedValue.Equals(""))
            {
                MessageBox.Show("Chưa nhập đủ dữ liệu", "Thông báo");
                txtMaSoVe.Focus();
                return;
            }
            etVMB.MaSoVe = txtMaSoVe.Text;
            etVMB.MaLoaiVe = cboLoaiVe.SelectedValue.ToString();
            etVMB.GiaVe = (int)nbGiaVe.Value;
            etVMB.KLHL = (double)nbKLHL.Value;
            etVMB.MaSoGhe = txtMaSoGhe.Text;
            etVMB.MaChuyenBay = cboMaChuyenBay.SelectedValue.ToString();
            etVMB.MaHK = cboMaHanhKhach.SelectedValue.ToString();
            etVMB.GioKhoiHanh = cboGioKhoiHanh.Text;
            etVMB.NgayKhoiHanh = DateTime.Parse(cboNgayKhoiHanh.Text);           
            int kq = busVMB.themVeMayBay(etVMB);
            if (kq > 0)
            {
                MessageBox.Show("Thêm thành công.", "Thông báo");
                loadData();

                txtMaSoVe.Clear();
                txtMaSoVe.Focus();
                txtMaSoGhe.Clear();
                nbGiaVe.Value = 0;
                nbKLHL.Value = 0;
                btnThem.Enabled = false;
                txtMaSoVe.ReadOnly = true;
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
            if (dgvVMB.SelectedRows.Count == 1)
            {
                if (MessageBox.Show("Bạn có muốn xóa không?", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {

                    etVMB.MaSoVe = txtMaSoVe.Text;
                    int kq = busVMB.xoaVeMayBay(etVMB);
                    if (kq > 0)
                    {
                        MessageBox.Show("Xóa thành công.", "Thông báo");
                        loadData();
                        txtMaSoVe.Clear();
                        txtMaSoGhe.Clear();
                        nbGiaVe.Value = 0;
                        nbKLHL.Value = 0;
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
            if (dgvVMB.SelectedRows.Count == 1)
            {
                if (MessageBox.Show("Bạn có muốn cập nhật không?", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    etVMB.MaSoVe = txtMaSoVe.Text;
                    etVMB.MaLoaiVe = cboLoaiVe.SelectedValue.ToString();
                    etVMB.GiaVe = (int)nbGiaVe.Value;
                    etVMB.KLHL = (double)nbKLHL.Value;
                    etVMB.MaSoGhe = txtMaSoGhe.Text;
                    etVMB.MaChuyenBay = cboMaChuyenBay.SelectedValue.ToString();
                    etVMB.MaHK = cboMaHanhKhach.SelectedValue.ToString();
                    etVMB.GioKhoiHanh = cboGioKhoiHanh.Text;
                    etVMB.NgayKhoiHanh = DateTime.Parse(cboNgayKhoiHanh.Text);
                    int kq = busVMB.suaVeMayBay(etVMB);
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

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmVMB_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thoát không?", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.No)
            {
                e.Cancel = true;
            }
        }
    }
}
