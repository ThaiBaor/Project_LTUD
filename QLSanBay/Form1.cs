using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

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
    }
}
