using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;

namespace QLSanBay
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void mnuHHK_Click(object sender, EventArgs e)
        {
            frmHHK HHKform = new frmHHK();
            HHKform.ShowDialog();
        }

        private void mnuPB_Click(object sender, EventArgs e)
        {
            frmPhongBan PBform = new frmPhongBan();
            PBform.ShowDialog();
        }

        private void mnuNV_Click(object sender, EventArgs e)
        {
            frmNV NVForm = new frmNV();
            NVForm.ShowDialog();
        }

        private void mnuLoaiVe_Click(object sender, EventArgs e)
        {
            frmLoaiVe LVForm = new frmLoaiVe();
            LVForm.ShowDialog();
        }

        private void mnuVeMB_Click(object sender, EventArgs e)
        {
            frmVMB VMBForm = new frmVMB();
            VMBForm.ShowDialog();
;        }

        private void mnuPC_Click(object sender, EventArgs e)
        {
            frmPC PCForm = new frmPC();
            PCForm.ShowDialog();
        }

        private void mnuMayBay_Click(object sender, EventArgs e)
        {
            frmMayBay MBForm = new frmMayBay();
            MBForm.ShowDialog();
        }

        private void mnuChuyenBay_Click(object sender, EventArgs e)
        {
            frmChuyenBay CBForm = new frmChuyenBay();
            CBForm.ShowDialog();
        }

        private void mnuLichBay_Click(object sender, EventArgs e)
        {
            frmLichBay LBForm = new frmLichBay();
            LBForm.ShowDialog();
        }

        private void mnuHanhKhach_Click(object sender, EventArgs e)
        {
            frmHanhKhach HKForm = new frmHanhKhach();
            HKForm.ShowDialog();
        }

        private void mnuBaoCao_VeMayBay_Click(object sender, EventArgs e)
        {
            frmReport_VMB ReportForm = new frmReport_VMB();
            ReportForm.ShowDialog();
        }
    }
}
