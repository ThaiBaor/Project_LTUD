using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace QLSanBay
{
    public partial class frmPhongBan : Form
    {
        public frmPhongBan()
        {
            InitializeComponent();
        }

        private void frmPhongBan_Load(object sender, EventArgs e)
        {
            loadData();
        }
        // tạo connect
        SqlConnection con = new SqlConnection("Data Source =.; Initial Catalog = QLSANBAY; Integrated Security = True");
        public void loadData()
        {
            try
            {
                 
                // mở kết nối
                con.Open();
                #region loadData cho gridview
                // khai báo command
                SqlCommand cmdPB = new SqlCommand();
                cmdPB.CommandText = "sp_layDSPhongBan";
                cmdPB.CommandType = CommandType.StoredProcedure;
                // gán kết nối
                cmdPB.Connection = con;
                // tạo đối tượng dataAdapter
                SqlDataAdapter da = new SqlDataAdapter(cmdPB);
                DataTable dtPB = new DataTable();
                // fill data 
                da.Fill(dtPB);
                // gán dữ liệu cho bảng
                dgvPhongBan.DataSource = dtPB;
                // đóng kết nối
                #endregion

                #region loadData cho combobox
                // khai báo command
                SqlCommand cmdDSHHK = new SqlCommand();
                cmdDSHHK.CommandText = "sp_layDSHANGHANGKHONG";
                cmdDSHHK.CommandType = CommandType.StoredProcedure;
                // gán kết nối
                cmdDSHHK.Connection = con;
                // tạo đối tượng dataAdapter
                SqlDataAdapter da1 = new SqlDataAdapter(cmdDSHHK);
                DataSet ds = new DataSet();
                da1.Fill(ds, "HHK");
                // fill data 
                da.Fill(dtPB);
                cboMaHHK.DisplayMember = "TENHANGHK";
                cboMaHHK.ValueMember = "MAHANGHK";
                // gán dữ liệu cho bảng
                dgvPhongBan.DataSource = ds.Tables["HHK"];
                // đóng kết nối
                #endregion

                con.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show($"Lỗi kết nối: {e.Message}");
            }
        }

        private void dgvPhongBan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMaPhong.Text = dgvPhongBan.CurrentRow.Cells[0].Value.ToString();
            txtTenPhong.Text = dgvPhongBan.CurrentRow.Cells[2].Value.ToString();
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
            if (!char.IsLetter(ch) && ch != (char)Keys.Back)
            {
                e.Handled = true;
            }
            else if (txtMaPhong.TextLength > 25 && ch != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }
    }
}
