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
    public partial class frmNV : Form
    {
        public frmNV()
        {
            InitializeComponent();
        }
        // tạo connect
        SqlConnection con = new SqlConnection("Data Source =.; Initial Catalog = QLSANBAY; Integrated Security = True");
        void loadDataGridView()
        {
            try
            {
                // mở kết nối
                con.Open();
                // khai báo command
                SqlCommand cmdNV = new SqlCommand();
                cmdNV.CommandText = "sp_layDSNV";
                cmdNV.CommandType = CommandType.StoredProcedure;
                // gán kết nối
                cmdNV.Connection = con;
                // tạo đối tượng sqlDataAdapter bằng sqlCommand
                SqlDataAdapter da = new SqlDataAdapter(cmdNV);
                DataTable dtNV = new DataTable();
                // fill data 
                da.Fill(dtNV);
                // gán dữ liệu cho bảng
                dgvNV.DataSource = dtNV;
                // đóng kết nối
                con.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show($"Lỗi kết nối: {e.Message}");
            }
        }
        void loadCombobox()
        {
            try
            {
                con.Open();
                #region cboNGQL                
                #endregion
                #region cboPB
                SqlCommand cmdDSPB = new SqlCommand("sp_layDSPHONGBAN", con);
                cmdDSPB.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter da1 = new SqlDataAdapter(cmdDSPB);
                DataSet ds1 = new DataSet();
                da1.Fill(ds1);
                cboPB.Items.Clear();
                cboPB.DisplayMember = "TENPHG";
                cboPB.ValueMember = "MAPHONG";
                cboPB.DataSource = ds1.Tables[0];
                #endregion
                #region cboHHK
                SqlCommand cmdDSHHK = new SqlCommand("sp_layDSHANGHANGKHONG", con);
                cmdDSHHK.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter da2 = new SqlDataAdapter(cmdDSHHK);
                DataSet ds2 = new DataSet();
                da2.Fill(ds2);
                cboHHK.Items.Clear();
                cboHHK.DisplayMember = "TENHANGHK";
                cboHHK.ValueMember = "MAHANGHK";
                cboHHK.DataSource = ds2.Tables[0];
                #endregion
                con.Close();
            }
            catch (Exception e)
            {
                con.Close();
                MessageBox.Show("Loi" + e.Message);
            }
        }

        private void txtMaNV_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Không cho nhập vào dữ liệu khác chữ và số hay nhập nhiều hơn 10 ký tự 
            char ch = e.KeyChar;
            if (!char.IsLetterOrDigit(ch) && ch != (char)Keys.Back)
            {
                e.Handled = true;
            }
            else if (txtMaNV.TextLength > 10 && ch != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }

        private void txtHoNV_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Không cho nhập vào dữ liệu khác chữ hay nhập nhiều hơn 30 ký tự 
            char ch = e.KeyChar;
            if (!char.IsLetter(ch) && ch != (char)Keys.Back && !char.IsWhiteSpace(ch))
            {
                e.Handled = true;
            }
            else if (txtHoNV.TextLength > 30 && ch != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }

        private void txtTenNV_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Không cho nhập vào dữ liệu khác chữ hay nhập nhiều hơn 15 ký tự 
            char ch = e.KeyChar;
            if (!char.IsLetter(ch) && ch != (char)Keys.Back)
            {
                e.Handled = true;
            }
            else if (txtTenNV.TextLength > 15 && ch != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }
     
        private void dtP_ValueChanged(object sender, EventArgs e)
        {
            if (dtP.Value.Year > 2004)
            {
                MessageBox.Show("Ngày sinh không thể lớn hơn 12/12/2004", "Thông báo");
                dtP.Value = DateTime.Parse("1/1/2004");
            }
        }

        private void txtDiaChi_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Không cho nhập vào dữ liệu nhiều hơn 100 ký tự 
            char ch = e.KeyChar;           
            if (txtDiaChi.TextLength > 100 && ch != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }

        private void txtSDT_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Không cho nhập vào dữ liệu khác số hay nhập nhiều hơn 10 ký tự 
            char ch = e.KeyChar;
            if (!char.IsDigit(ch) && ch != (char)Keys.Back)
            {
                e.Handled = true;
            }
            else if (txtSDT.TextLength > 10 && ch != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }

        private void txtCCCD_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Không cho nhập vào dữ liệu khác số hay nhập nhiều hơn 12 ký tự 
            char ch = e.KeyChar;
            if (!char.IsDigit(ch) && ch != (char)Keys.Back)
            {
                e.Handled = true;
            }
            else if (txtCCCD.TextLength > 12 && ch != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }

        private void txtPhanLoai_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Không cho nhập vào dữ liệu khác chữ hay nhập nhiều hơn 50 ký tự 
            char ch = e.KeyChar;
            if (!char.IsLetter(ch) && ch != (char)Keys.Back && !char.IsWhiteSpace(ch))
            {
                e.Handled = true;
            }
            else if (txtPhanLoai.TextLength > 50 && ch != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }

        private void txtLuong_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Không cho nhập vào dữ liệu khác số 
            char ch = e.KeyChar;
            if (!char.IsDigit(ch) && ch != (char)Keys.Back)
            {
                e.Handled = true;
            }            
        }

        private void frmNV_Load(object sender, EventArgs e)
        {
            loadDataGridView();
            loadCombobox();
            rdoNam.Checked = true;
        }
    }
}
