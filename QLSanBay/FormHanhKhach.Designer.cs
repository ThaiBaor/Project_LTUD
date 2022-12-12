
namespace QLSanBay
{
    partial class frmHanhKhach
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtMaHK = new System.Windows.Forms.TextBox();
            this.txtTenHK = new System.Windows.Forms.TextBox();
            this.txtHoHK = new System.Windows.Forms.TextBox();
            this.txtQT = new System.Windows.Forms.TextBox();
            this.txtDiaChiHK = new System.Windows.Forms.TextBox();
            this.txtHoChieu = new System.Windows.Forms.TextBox();
            this.txtSDT = new System.Windows.Forms.TextBox();
            this.dtpHK = new System.Windows.Forms.DateTimePicker();
            this.rdoNam = new System.Windows.Forms.RadioButton();
            this.rdoNu = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.dgvHK = new System.Windows.Forms.DataGridView();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnCapNhat = new System.Windows.Forms.Button();
            this.btnMoi = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHK)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã Hành Khách";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Tên Hành Khách";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(40, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Họ Hành Khách";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(41, 153);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "Quốc Tịch";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(41, 199);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 17);
            this.label6.TabIndex = 8;
            this.label6.Text = "Giới Tính";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(574, 73);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 17);
            this.label7.TabIndex = 13;
            this.label7.Text = "Địa Chỉ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(574, 112);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(87, 17);
            this.label8.TabIndex = 15;
            this.label8.Text = "Số Hộ Chiếu";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(574, 154);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(98, 17);
            this.label9.TabIndex = 17;
            this.label9.Text = "Số Điện Thoại";
            // 
            // txtMaHK
            // 
            this.txtMaHK.Location = new System.Drawing.Point(166, 32);
            this.txtMaHK.Name = "txtMaHK";
            this.txtMaHK.Size = new System.Drawing.Size(281, 22);
            this.txtMaHK.TabIndex = 1;
            this.txtMaHK.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMaHK_KeyPress);
            // 
            // txtTenHK
            // 
            this.txtTenHK.Location = new System.Drawing.Point(166, 114);
            this.txtTenHK.Name = "txtTenHK";
            this.txtTenHK.Size = new System.Drawing.Size(281, 22);
            this.txtTenHK.TabIndex = 5;
            this.txtTenHK.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTenHK_KeyPress);
            // 
            // txtHoHK
            // 
            this.txtHoHK.Location = new System.Drawing.Point(166, 73);
            this.txtHoHK.Name = "txtHoHK";
            this.txtHoHK.Size = new System.Drawing.Size(281, 22);
            this.txtHoHK.TabIndex = 3;
            this.txtHoHK.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtHoHK_KeyPress);
            // 
            // txtQT
            // 
            this.txtQT.Location = new System.Drawing.Point(166, 153);
            this.txtQT.Name = "txtQT";
            this.txtQT.Size = new System.Drawing.Size(281, 22);
            this.txtQT.TabIndex = 7;
            this.txtQT.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtQT_KeyPress);
            // 
            // txtDiaChiHK
            // 
            this.txtDiaChiHK.Location = new System.Drawing.Point(681, 73);
            this.txtDiaChiHK.Name = "txtDiaChiHK";
            this.txtDiaChiHK.Size = new System.Drawing.Size(270, 22);
            this.txtDiaChiHK.TabIndex = 14;
            this.txtDiaChiHK.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDiaChiHK_KeyPress);
            // 
            // txtHoChieu
            // 
            this.txtHoChieu.Location = new System.Drawing.Point(681, 112);
            this.txtHoChieu.Name = "txtHoChieu";
            this.txtHoChieu.Size = new System.Drawing.Size(270, 22);
            this.txtHoChieu.TabIndex = 16;
            this.txtHoChieu.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtHoChieu_KeyPress);
            // 
            // txtSDT
            // 
            this.txtSDT.Location = new System.Drawing.Point(681, 151);
            this.txtSDT.Name = "txtSDT";
            this.txtSDT.Size = new System.Drawing.Size(270, 22);
            this.txtSDT.TabIndex = 18;
            this.txtSDT.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSDT_KeyPress);
            // 
            // dtpHK
            // 
            this.dtpHK.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpHK.Location = new System.Drawing.Point(681, 35);
            this.dtpHK.Name = "dtpHK";
            this.dtpHK.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dtpHK.Size = new System.Drawing.Size(162, 22);
            this.dtpHK.TabIndex = 12;
            // 
            // rdoNam
            // 
            this.rdoNam.AutoSize = true;
            this.rdoNam.Location = new System.Drawing.Point(44, 236);
            this.rdoNam.Name = "rdoNam";
            this.rdoNam.Size = new System.Drawing.Size(58, 21);
            this.rdoNam.TabIndex = 9;
            this.rdoNam.TabStop = true;
            this.rdoNam.Text = "Nam";
            this.rdoNam.UseVisualStyleBackColor = true;
            // 
            // rdoNu
            // 
            this.rdoNu.AutoSize = true;
            this.rdoNu.Location = new System.Drawing.Point(125, 236);
            this.rdoNu.Name = "rdoNu";
            this.rdoNu.Size = new System.Drawing.Size(47, 21);
            this.rdoNu.TabIndex = 10;
            this.rdoNu.TabStop = true;
            this.rdoNu.Text = "Nữ";
            this.rdoNu.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(574, 35);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 17);
            this.label5.TabIndex = 11;
            this.label5.Text = "Ngày Sinh";
            // 
            // dgvHK
            // 
            this.dgvHK.AllowUserToAddRows = false;
            this.dgvHK.AllowUserToDeleteRows = false;
            this.dgvHK.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvHK.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHK.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvHK.Location = new System.Drawing.Point(0, 309);
            this.dgvHK.MultiSelect = false;
            this.dgvHK.Name = "dgvHK";
            this.dgvHK.ReadOnly = true;
            this.dgvHK.RowHeadersWidth = 51;
            this.dgvHK.RowTemplate.Height = 24;
            this.dgvHK.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvHK.Size = new System.Drawing.Size(1074, 211);
            this.dgvHK.TabIndex = 4;
            this.dgvHK.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvHK_CellClick);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(696, 235);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(85, 34);
            this.btnXoa.TabIndex = 21;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(543, 236);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(85, 34);
            this.btnThem.TabIndex = 20;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(878, 236);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(85, 34);
            this.btnThoat.TabIndex = 23;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnCapNhat
            // 
            this.btnCapNhat.Location = new System.Drawing.Point(787, 235);
            this.btnCapNhat.Name = "btnCapNhat";
            this.btnCapNhat.Size = new System.Drawing.Size(85, 34);
            this.btnCapNhat.TabIndex = 22;
            this.btnCapNhat.Text = "Cập Nhật";
            this.btnCapNhat.UseVisualStyleBackColor = true;
            this.btnCapNhat.Click += new System.EventHandler(this.btnCapNhat_Click);
            // 
            // btnMoi
            // 
            this.btnMoi.Location = new System.Drawing.Point(452, 236);
            this.btnMoi.Name = "btnMoi";
            this.btnMoi.Size = new System.Drawing.Size(85, 32);
            this.btnMoi.TabIndex = 19;
            this.btnMoi.Text = "Mới";
            this.btnMoi.UseVisualStyleBackColor = true;
            this.btnMoi.Click += new System.EventHandler(this.btnMoi_Click);
            // 
            // frmHanhKhach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1074, 520);
            this.Controls.Add(this.btnMoi);
            this.Controls.Add(this.btnCapNhat);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.dgvHK);
            this.Controls.Add(this.rdoNu);
            this.Controls.Add(this.rdoNam);
            this.Controls.Add(this.dtpHK);
            this.Controls.Add(this.txtSDT);
            this.Controls.Add(this.txtHoChieu);
            this.Controls.Add(this.txtQT);
            this.Controls.Add(this.txtDiaChiHK);
            this.Controls.Add(this.txtHoHK);
            this.Controls.Add(this.txtTenHK);
            this.Controls.Add(this.txtMaHK);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmHanhKhach";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Hành Khách";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmHanhKhach_FormClosing);
            this.Load += new System.EventHandler(this.frmHanhKhach_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHK)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtMaHK;
        private System.Windows.Forms.TextBox txtTenHK;
        private System.Windows.Forms.TextBox txtHoHK;
        private System.Windows.Forms.TextBox txtQT;
        private System.Windows.Forms.TextBox txtDiaChiHK;
        private System.Windows.Forms.TextBox txtHoChieu;
        private System.Windows.Forms.TextBox txtSDT;
        private System.Windows.Forms.DateTimePicker dtpHK;
        private System.Windows.Forms.RadioButton rdoNam;
        private System.Windows.Forms.RadioButton rdoNu;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dgvHK;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnCapNhat;
        private System.Windows.Forms.Button btnMoi;
    }
}