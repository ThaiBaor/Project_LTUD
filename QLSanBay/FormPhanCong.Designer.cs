
namespace QLSanBay
{
    partial class frmPC
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.cboMaNV = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cboMaCB = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cboNgayKH = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cboGioKH = new System.Windows.Forms.ComboBox();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.dgvPhanCong = new System.Windows.Forms.DataGridView();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnCapNhat = new System.Windows.Forms.Button();
            this.btnMoi = new System.Windows.Forms.Button();
            this.nbSoGioBay = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.cboHHK = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhanCong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nbSoGioBay)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(48, 233);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Số Giờ Bay";
            // 
            // cboMaNV
            // 
            this.cboMaNV.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboMaNV.Enabled = false;
            this.cboMaNV.FormattingEnabled = true;
            this.cboMaNV.Location = new System.Drawing.Point(163, 106);
            this.cboMaNV.Name = "cboMaNV";
            this.cboMaNV.Size = new System.Drawing.Size(219, 24);
            this.cboMaNV.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(43, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Nhân Viên";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(43, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 17);
            this.label3.TabIndex = 0;
            this.label3.Text = "Chuyến Bay";
            // 
            // cboMaCB
            // 
            this.cboMaCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboMaCB.Enabled = false;
            this.cboMaCB.FormattingEnabled = true;
            this.cboMaCB.Location = new System.Drawing.Point(163, 68);
            this.cboMaCB.Name = "cboMaCB";
            this.cboMaCB.Size = new System.Drawing.Size(219, 24);
            this.cboMaCB.TabIndex = 2;
            this.cboMaCB.SelectionChangeCommitted += new System.EventHandler(this.cboMaCB_SelectionChangeCommitted);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(43, 191);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(111, 17);
            this.label4.TabIndex = 0;
            this.label4.Text = "Ngày Khởi Hành";
            // 
            // cboNgayKH
            // 
            this.cboNgayKH.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboNgayKH.Enabled = false;
            this.cboNgayKH.FormattingEnabled = true;
            this.cboNgayKH.Location = new System.Drawing.Point(165, 190);
            this.cboNgayKH.Name = "cboNgayKH";
            this.cboNgayKH.Size = new System.Drawing.Size(217, 24);
            this.cboNgayKH.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(43, 153);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 17);
            this.label5.TabIndex = 0;
            this.label5.Text = "Giờ Khởi Hành";
            // 
            // cboGioKH
            // 
            this.cboGioKH.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboGioKH.Enabled = false;
            this.cboGioKH.FormattingEnabled = true;
            this.cboGioKH.Location = new System.Drawing.Point(163, 150);
            this.cboGioKH.Name = "cboGioKH";
            this.cboGioKH.Size = new System.Drawing.Size(219, 24);
            this.cboGioKH.TabIndex = 2;
            this.cboGioKH.SelectionChangeCommitted += new System.EventHandler(this.cboGioKH_SelectionChangeCommitted);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(591, 60);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(93, 35);
            this.btnXoa.TabIndex = 3;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnThem
            // 
            this.btnThem.Enabled = false;
            this.btnThem.Location = new System.Drawing.Point(457, 139);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(93, 35);
            this.btnThem.TabIndex = 4;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // dgvPhanCong
            // 
            this.dgvPhanCong.AllowUserToAddRows = false;
            this.dgvPhanCong.AllowUserToDeleteRows = false;
            this.dgvPhanCong.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPhanCong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPhanCong.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvPhanCong.Location = new System.Drawing.Point(0, 274);
            this.dgvPhanCong.MultiSelect = false;
            this.dgvPhanCong.Name = "dgvPhanCong";
            this.dgvPhanCong.ReadOnly = true;
            this.dgvPhanCong.RowHeadersWidth = 51;
            this.dgvPhanCong.RowTemplate.Height = 24;
            this.dgvPhanCong.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPhanCong.Size = new System.Drawing.Size(731, 192);
            this.dgvPhanCong.TabIndex = 5;
            this.dgvPhanCong.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPhanCong_CellClick);
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(591, 171);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(93, 37);
            this.btnThoat.TabIndex = 3;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            // 
            // btnCapNhat
            // 
            this.btnCapNhat.Location = new System.Drawing.Point(591, 118);
            this.btnCapNhat.Name = "btnCapNhat";
            this.btnCapNhat.Size = new System.Drawing.Size(93, 35);
            this.btnCapNhat.TabIndex = 4;
            this.btnCapNhat.Text = "Cập Nhật";
            this.btnCapNhat.UseVisualStyleBackColor = true;
            this.btnCapNhat.Click += new System.EventHandler(this.btnCapNhat_Click);
            // 
            // btnMoi
            // 
            this.btnMoi.Location = new System.Drawing.Point(457, 98);
            this.btnMoi.Name = "btnMoi";
            this.btnMoi.Size = new System.Drawing.Size(93, 35);
            this.btnMoi.TabIndex = 6;
            this.btnMoi.Text = "Mới";
            this.btnMoi.UseVisualStyleBackColor = true;
            this.btnMoi.Click += new System.EventHandler(this.btnMoi_Click);
            // 
            // nbSoGioBay
            // 
            this.nbSoGioBay.Location = new System.Drawing.Point(165, 233);
            this.nbSoGioBay.Maximum = new decimal(new int[] {
            24,
            0,
            0,
            0});
            this.nbSoGioBay.Name = "nbSoGioBay";
            this.nbSoGioBay.Size = new System.Drawing.Size(82, 22);
            this.nbSoGioBay.TabIndex = 8;
            this.nbSoGioBay.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(43, 36);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(125, 17);
            this.label6.TabIndex = 9;
            this.label6.Text = "Hãng Hàng Không";
            // 
            // cboHHK
            // 
            this.cboHHK.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboHHK.Enabled = false;
            this.cboHHK.FormattingEnabled = true;
            this.cboHHK.Location = new System.Drawing.Point(179, 29);
            this.cboHHK.Name = "cboHHK";
            this.cboHHK.Size = new System.Drawing.Size(203, 24);
            this.cboHHK.TabIndex = 10;
            this.cboHHK.SelectionChangeCommitted += new System.EventHandler(this.cboHHK_SelectionChangeCommitted);
            // 
            // frmPC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(731, 466);
            this.Controls.Add(this.cboHHK);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.nbSoGioBay);
            this.Controls.Add(this.btnMoi);
            this.Controls.Add(this.dgvPhanCong);
            this.Controls.Add(this.btnCapNhat);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.cboGioKH);
            this.Controls.Add(this.cboNgayKH);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cboMaCB);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cboMaNV);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmPC";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Phân Công";
            this.Load += new System.EventHandler(this.frmPC_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhanCong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nbSoGioBay)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboMaNV;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cboMaCB;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cboNgayKH;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cboGioKH;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.DataGridView dgvPhanCong;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnCapNhat;
        private System.Windows.Forms.Button btnMoi;
        private System.Windows.Forms.NumericUpDown nbSoGioBay;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cboHHK;
    }
}