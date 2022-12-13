
namespace QLSanBay
{
    partial class frmLichBay
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
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cboMaCB = new System.Windows.Forms.ComboBox();
            this.dtpHK = new System.Windows.Forms.DateTimePicker();
            this.btnCapNhat = new System.Windows.Forms.Button();
            this.btnMoi = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.cboSoHieu = new System.Windows.Forms.ComboBox();
            this.dgvLichBay = new System.Windows.Forms.DataGridView();
            this.mtxtGioKH = new System.Windows.Forms.MaskedTextBox();
            this.btnThem = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.cboHHK = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLichBay)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Chuyến Bay";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(43, 169);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 17);
            this.label3.TabIndex = 1;
            this.label3.Text = "Giờ Khởi Hành";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(44, 118);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(116, 17);
            this.label4.TabIndex = 0;
            this.label4.Text = "Số Hiệu Máy Bay";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(43, 218);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(111, 17);
            this.label5.TabIndex = 1;
            this.label5.Text = "Ngày Khởi Hành";
            // 
            // cboMaCB
            // 
            this.cboMaCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboMaCB.FormattingEnabled = true;
            this.cboMaCB.Location = new System.Drawing.Point(172, 73);
            this.cboMaCB.Name = "cboMaCB";
            this.cboMaCB.Size = new System.Drawing.Size(187, 24);
            this.cboMaCB.TabIndex = 4;
            // 
            // dtpHK
            // 
            this.dtpHK.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpHK.Location = new System.Drawing.Point(172, 218);
            this.dtpHK.Name = "dtpHK";
            this.dtpHK.Size = new System.Drawing.Size(157, 22);
            this.dtpHK.TabIndex = 5;
            // 
            // btnCapNhat
            // 
            this.btnCapNhat.Location = new System.Drawing.Point(578, 52);
            this.btnCapNhat.Name = "btnCapNhat";
            this.btnCapNhat.Size = new System.Drawing.Size(85, 34);
            this.btnCapNhat.TabIndex = 6;
            this.btnCapNhat.Text = "Cập Nhật";
            this.btnCapNhat.UseVisualStyleBackColor = true;
            this.btnCapNhat.Click += new System.EventHandler(this.btnCapNhat_Click);
            // 
            // btnMoi
            // 
            this.btnMoi.Location = new System.Drawing.Point(446, 94);
            this.btnMoi.Name = "btnMoi";
            this.btnMoi.Size = new System.Drawing.Size(85, 34);
            this.btnMoi.TabIndex = 7;
            this.btnMoi.Text = "Mới";
            this.btnMoi.UseVisualStyleBackColor = true;
            this.btnMoi.Click += new System.EventHandler(this.btnMoi_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(578, 182);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(85, 34);
            this.btnThoat.TabIndex = 8;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(578, 115);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(85, 34);
            this.btnXoa.TabIndex = 9;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // cboSoHieu
            // 
            this.cboSoHieu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboSoHieu.FormattingEnabled = true;
            this.cboSoHieu.Location = new System.Drawing.Point(172, 115);
            this.cboSoHieu.Name = "cboSoHieu";
            this.cboSoHieu.Size = new System.Drawing.Size(187, 24);
            this.cboSoHieu.TabIndex = 4;
            // 
            // dgvLichBay
            // 
            this.dgvLichBay.AllowUserToDeleteRows = false;
            this.dgvLichBay.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvLichBay.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLichBay.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvLichBay.Location = new System.Drawing.Point(0, 279);
            this.dgvLichBay.MultiSelect = false;
            this.dgvLichBay.Name = "dgvLichBay";
            this.dgvLichBay.ReadOnly = true;
            this.dgvLichBay.RowHeadersWidth = 51;
            this.dgvLichBay.RowTemplate.Height = 24;
            this.dgvLichBay.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvLichBay.Size = new System.Drawing.Size(704, 199);
            this.dgvLichBay.TabIndex = 11;
            this.dgvLichBay.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvLichBay_CellClick);
            // 
            // mtxtGioKH
            // 
            this.mtxtGioKH.Location = new System.Drawing.Point(172, 169);
            this.mtxtGioKH.Mask = "00:00";
            this.mtxtGioKH.Name = "mtxtGioKH";
            this.mtxtGioKH.Size = new System.Drawing.Size(79, 22);
            this.mtxtGioKH.TabIndex = 12;
            this.mtxtGioKH.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.mtxtGioKH.ValidatingType = typeof(System.DateTime);
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(446, 145);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(85, 34);
            this.btnThem.TabIndex = 7;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(44, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 17);
            this.label2.TabIndex = 13;
            this.label2.Text = "Hãng Hàng Không";
            // 
            // cboHHK
            // 
            this.cboHHK.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboHHK.FormattingEnabled = true;
            this.cboHHK.Location = new System.Drawing.Point(172, 31);
            this.cboHHK.Name = "cboHHK";
            this.cboHHK.Size = new System.Drawing.Size(187, 24);
            this.cboHHK.TabIndex = 14;
            this.cboHHK.SelectionChangeCommitted += new System.EventHandler(this.cboHHK_SelectionChangeCommitted);
            // 
            // frmLichBay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(704, 478);
            this.Controls.Add(this.cboHHK);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.mtxtGioKH);
            this.Controls.Add(this.dgvLichBay);
            this.Controls.Add(this.btnCapNhat);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.btnMoi);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.dtpHK);
            this.Controls.Add(this.cboSoHieu);
            this.Controls.Add(this.cboMaCB);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmLichBay";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Lịch Bay";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmLichBay_FormClosing);
            this.Load += new System.EventHandler(this.frmLichBay_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLichBay)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cboMaCB;
        private System.Windows.Forms.DateTimePicker dtpHK;
        private System.Windows.Forms.Button btnCapNhat;
        private System.Windows.Forms.Button btnMoi;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.ComboBox cboSoHieu;
        private System.Windows.Forms.DataGridView dgvLichBay;
        private System.Windows.Forms.MaskedTextBox mtxtGioKH;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cboHHK;
    }
}