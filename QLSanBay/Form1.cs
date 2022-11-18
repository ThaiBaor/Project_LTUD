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
    }
}
