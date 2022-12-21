using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;

namespace QLSanBay
{
    public partial class frm_ReportVMB_theoMA : Form
    {
        public frm_ReportVMB_theoMA()
        {
            InitializeComponent();
        }

        private void btnXem_Click(object sender, EventArgs e)
        {
            // khai báo biến tham số
            ParameterValues para = new ParameterValues();
            ParameterDiscreteValue value = new ParameterDiscreteValue();
            value.Value = txtMaSoVe.Text;
            para.Add(value);

            // khởi tạo report và truyền tham số 
            Report_VEMAYBAY_THEOMA rp = new Report_VEMAYBAY_THEOMA();
            rp.DataDefinition.ParameterFields["@MASOVE"].ApplyCurrentValues(para);
            crvVMB.ReportSource = rp;
        }
    }
}
