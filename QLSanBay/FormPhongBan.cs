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
            txtTrgPhong.Text = dgvPhongBan.CurrentRow.Cells[3].Value.ToString();
        }
    }
}
