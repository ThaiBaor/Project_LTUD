
namespace QLSanBay
{
    partial class frmVMB
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
            this.txtMaSoVe = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtMaSoGhe = new System.Windows.Forms.TextBox();
            this.cboMaChuyenBay = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cboLoaiVe = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cboMaHanhKhach = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cboGioKhoiHanh = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.dgvVMB = new System.Windows.Forms.DataGridView();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnCapNhat = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.cboNgayKhoiHanh = new System.Windows.Forms.ComboBox();
            this.btnMoi = new System.Windows.Forms.Button();
            this.nbGiaVe = new System.Windows.Forms.NumericUpDown();
            this.nbKLHL = new System.Windows.Forms.NumericUpDown();
            this.label10 = new System.Windows.Forms.Label();
            this.cboHHK = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.lblKH = new System.Windows.Forms.Label();
            this.lblDen = new System.Windows.Forms.Label();
            this.lblTrungChuyen = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVMB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nbGiaVe)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nbKLHL)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(466, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã Chuyến Bay";
            // 
            // txtMaSoVe
            // 
            this.txtMaSoVe.Location = new System.Drawing.Point(168, 31);
            this.txtMaSoVe.Name = "txtMaSoVe";
            this.txtMaSoVe.Size = new System.Drawing.Size(243, 22);
            this.txtMaSoVe.TabIndex = 1;
            this.txtMaSoVe.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMaSoVe_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(57, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mã Số Vé";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(56, 153);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(211, 17);
            this.label3.TabIndex = 0;
            this.label3.Text = "Khối Lượng Hành Lý (Tối đa 20)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(56, 197);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 17);
            this.label4.TabIndex = 0;
            this.label4.Text = "Mã Số Ghế";
            // 
            // txtMaSoGhe
            // 
            this.txtMaSoGhe.Location = new System.Drawing.Point(167, 196);
            this.txtMaSoGhe.Name = "txtMaSoGhe";
            this.txtMaSoGhe.Size = new System.Drawing.Size(158, 22);
            this.txtMaSoGhe.TabIndex = 1;
            this.txtMaSoGhe.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMaSoGhe_KeyPress);
            // 
            // cboMaChuyenBay
            // 
            this.cboMaChuyenBay.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboMaChuyenBay.FormattingEnabled = true;
            this.cboMaChuyenBay.Location = new System.Drawing.Point(593, 71);
            this.cboMaChuyenBay.Name = "cboMaChuyenBay";
            this.cboMaChuyenBay.Size = new System.Drawing.Size(223, 24);
            this.cboMaChuyenBay.TabIndex = 2;
            this.cboMaChuyenBay.SelectionChangeCommitted += new System.EventHandler(this.cboMaChuyenBay_SelectionChangeCommitted);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(56, 112);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 17);
            this.label5.TabIndex = 3;
            this.label5.Text = "Giá Vé";
            // 
            // cboLoaiVe
            // 
            this.cboLoaiVe.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboLoaiVe.FormattingEnabled = true;
            this.cboLoaiVe.Location = new System.Drawing.Point(168, 68);
            this.cboLoaiVe.Name = "cboLoaiVe";
            this.cboLoaiVe.Size = new System.Drawing.Size(243, 24);
            this.cboLoaiVe.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(57, 71);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 17);
            this.label6.TabIndex = 3;
            this.label6.Text = "Loại Vé";
            // 
            // cboMaHanhKhach
            // 
            this.cboMaHanhKhach.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboMaHanhKhach.FormattingEnabled = true;
            this.cboMaHanhKhach.Location = new System.Drawing.Point(593, 109);
            this.cboMaHanhKhach.Name = "cboMaHanhKhach";
            this.cboMaHanhKhach.Size = new System.Drawing.Size(223, 24);
            this.cboMaHanhKhach.TabIndex = 2;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(466, 112);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(86, 17);
            this.label7.TabIndex = 3;
            this.label7.Text = "Hành Khách";
            // 
            // cboGioKhoiHanh
            // 
            this.cboGioKhoiHanh.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboGioKhoiHanh.FormattingEnabled = true;
            this.cboGioKhoiHanh.Location = new System.Drawing.Point(593, 151);
            this.cboGioKhoiHanh.Name = "cboGioKhoiHanh";
            this.cboGioKhoiHanh.Size = new System.Drawing.Size(73, 24);
            this.cboGioKhoiHanh.TabIndex = 2;
            this.cboGioKhoiHanh.SelectionChangeCommitted += new System.EventHandler(this.cboGioKhoiHanh_SelectionChangeCommitted);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(466, 153);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(100, 17);
            this.label8.TabIndex = 3;
            this.label8.Text = "Giờ Khởi Hành";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(466, 196);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(111, 17);
            this.label9.TabIndex = 3;
            this.label9.Text = "Ngày Khởi Hành";
            // 
            // dgvVMB
            // 
            this.dgvVMB.AllowUserToAddRows = false;
            this.dgvVMB.AllowUserToDeleteRows = false;
            this.dgvVMB.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvVMB.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVMB.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvVMB.Location = new System.Drawing.Point(0, 322);
            this.dgvVMB.MultiSelect = false;
            this.dgvVMB.Name = "dgvVMB";
            this.dgvVMB.ReadOnly = true;
            this.dgvVMB.RowHeadersWidth = 51;
            this.dgvVMB.RowTemplate.Height = 24;
            this.dgvVMB.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvVMB.Size = new System.Drawing.Size(1312, 272);
            this.dgvVMB.TabIndex = 5;
            this.dgvVMB.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvVMB_CellClick);
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(162, 255);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(105, 35);
            this.btnThem.TabIndex = 6;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(925, 255);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(105, 35);
            this.btnXoa.TabIndex = 6;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnCapNhat
            // 
            this.btnCapNhat.Location = new System.Drawing.Point(1046, 255);
            this.btnCapNhat.Name = "btnCapNhat";
            this.btnCapNhat.Size = new System.Drawing.Size(105, 35);
            this.btnCapNhat.TabIndex = 6;
            this.btnCapNhat.Text = "Cập Nhật";
            this.btnCapNhat.UseVisualStyleBackColor = true;
            this.btnCapNhat.Click += new System.EventHandler(this.btnCapNhat_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(1171, 255);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(105, 35);
            this.btnThoat.TabIndex = 6;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // cboNgayKhoiHanh
            // 
            this.cboNgayKhoiHanh.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboNgayKhoiHanh.FormattingEnabled = true;
            this.cboNgayKhoiHanh.Location = new System.Drawing.Point(593, 197);
            this.cboNgayKhoiHanh.Name = "cboNgayKhoiHanh";
            this.cboNgayKhoiHanh.Size = new System.Drawing.Size(155, 24);
            this.cboNgayKhoiHanh.TabIndex = 2;
            // 
            // btnMoi
            // 
            this.btnMoi.Location = new System.Drawing.Point(51, 255);
            this.btnMoi.Name = "btnMoi";
            this.btnMoi.Size = new System.Drawing.Size(105, 34);
            this.btnMoi.TabIndex = 7;
            this.btnMoi.Text = "Mới";
            this.btnMoi.UseVisualStyleBackColor = true;
            this.btnMoi.Click += new System.EventHandler(this.btnMoi_Click);
            // 
            // nbGiaVe
            // 
            this.nbGiaVe.Location = new System.Drawing.Point(179, 107);
            this.nbGiaVe.Maximum = new decimal(new int[] {
            30000000,
            0,
            0,
            0});
            this.nbGiaVe.Name = "nbGiaVe";
            this.nbGiaVe.Size = new System.Drawing.Size(158, 22);
            this.nbGiaVe.TabIndex = 8;
            this.nbGiaVe.ThousandsSeparator = true;
            // 
            // nbKLHL
            // 
            this.nbKLHL.Location = new System.Drawing.Point(273, 153);
            this.nbKLHL.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.nbKLHL.Name = "nbKLHL";
            this.nbKLHL.Size = new System.Drawing.Size(64, 22);
            this.nbKLHL.TabIndex = 9;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(466, 34);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(125, 17);
            this.label10.TabIndex = 10;
            this.label10.Text = "Hãng Hàng Không";
            // 
            // cboHHK
            // 
            this.cboHHK.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboHHK.FormattingEnabled = true;
            this.cboHHK.Location = new System.Drawing.Point(611, 34);
            this.cboHHK.Name = "cboHHK";
            this.cboHHK.Size = new System.Drawing.Size(205, 24);
            this.cboHHK.TabIndex = 11;
            this.cboHHK.SelectionChangeCommitted += new System.EventHandler(this.cboHHK_SelectionChangeCommitted);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(855, 41);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(78, 17);
            this.label11.TabIndex = 12;
            this.label11.Text = "Khởi Hành:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(858, 79);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(42, 17);
            this.label12.TabIndex = 13;
            this.label12.Text = "Đến: ";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(858, 114);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(102, 17);
            this.label13.TabIndex = 14;
            this.label13.Text = "Trung Chuyển:";
            // 
            // lblKH
            // 
            this.lblKH.AutoSize = true;
            this.lblKH.Location = new System.Drawing.Point(939, 41);
            this.lblKH.Name = "lblKH";
            this.lblKH.Size = new System.Drawing.Size(0, 17);
            this.lblKH.TabIndex = 15;
            // 
            // lblDen
            // 
            this.lblDen.AutoSize = true;
            this.lblDen.Location = new System.Drawing.Point(939, 80);
            this.lblDen.Name = "lblDen";
            this.lblDen.Size = new System.Drawing.Size(0, 17);
            this.lblDen.TabIndex = 16;
            // 
            // lblTrungChuyen
            // 
            this.lblTrungChuyen.AutoSize = true;
            this.lblTrungChuyen.Location = new System.Drawing.Point(966, 114);
            this.lblTrungChuyen.Name = "lblTrungChuyen";
            this.lblTrungChuyen.Size = new System.Drawing.Size(0, 17);
            this.lblTrungChuyen.TabIndex = 17;
            // 
            // frmVMB
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1312, 594);
            this.Controls.Add(this.lblTrungChuyen);
            this.Controls.Add(this.lblDen);
            this.Controls.Add(this.lblKH);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.cboHHK);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.nbKLHL);
            this.Controls.Add(this.nbGiaVe);
            this.Controls.Add(this.btnMoi);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnCapNhat);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.dgvVMB);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cboNgayKhoiHanh);
            this.Controls.Add(this.cboGioKhoiHanh);
            this.Controls.Add(this.cboMaHanhKhach);
            this.Controls.Add(this.cboLoaiVe);
            this.Controls.Add(this.cboMaChuyenBay);
            this.Controls.Add(this.txtMaSoGhe);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtMaSoVe);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmVMB";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Vé Máy Bay";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmVMB_FormClosing);
            this.Load += new System.EventHandler(this.frmVMB_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvVMB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nbGiaVe)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nbKLHL)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMaSoVe;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtMaSoGhe;
        private System.Windows.Forms.ComboBox cboMaChuyenBay;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cboLoaiVe;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cboMaHanhKhach;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cboGioKhoiHanh;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridView dgvVMB;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnCapNhat;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.ComboBox cboNgayKhoiHanh;
        private System.Windows.Forms.Button btnMoi;
        private System.Windows.Forms.NumericUpDown nbGiaVe;
        private System.Windows.Forms.NumericUpDown nbKLHL;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cboHHK;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label lblKH;
        private System.Windows.Forms.Label lblDen;
        private System.Windows.Forms.Label lblTrungChuyen;
    }
}