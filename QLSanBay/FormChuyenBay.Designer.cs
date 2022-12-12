
namespace QLSanBay
{
    partial class frmChuyenBay
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
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtMaCB = new System.Windows.Forms.TextBox();
            this.txtSBKH = new System.Windows.Forms.TextBox();
            this.txtDDKH = new System.Windows.Forms.TextBox();
            this.txtTC = new System.Windows.Forms.TextBox();
            this.txtSBD = new System.Windows.Forms.TextBox();
            this.txtDDD = new System.Windows.Forms.TextBox();
            this.cboHHK = new System.Windows.Forms.ComboBox();
            this.dgvCB = new System.Windows.Forms.DataGridView();
            this.btnCapNhat = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnMoi = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCB)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(54, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã Chuyến Bay";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(54, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Sân Bay Khởi Hành";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(54, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(135, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Địa Điểm Khỏi Hành";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(54, 169);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(214, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "Sân Bay Trung Chuyển (Nếu có)";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(627, 52);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 17);
            this.label5.TabIndex = 8;
            this.label5.Text = "Sân Bay Đến";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(627, 88);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(95, 17);
            this.label6.TabIndex = 10;
            this.label6.Text = "Địa Điểm Đến";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(627, 125);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(125, 17);
            this.label7.TabIndex = 12;
            this.label7.Text = "Hãng Hàng Không";
            // 
            // txtMaCB
            // 
            this.txtMaCB.Location = new System.Drawing.Point(202, 48);
            this.txtMaCB.Name = "txtMaCB";
            this.txtMaCB.Size = new System.Drawing.Size(325, 22);
            this.txtMaCB.TabIndex = 1;
            this.txtMaCB.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMaCB_KeyPress);
            // 
            // txtSBKH
            // 
            this.txtSBKH.Location = new System.Drawing.Point(202, 85);
            this.txtSBKH.Name = "txtSBKH";
            this.txtSBKH.Size = new System.Drawing.Size(325, 22);
            this.txtSBKH.TabIndex = 3;
            this.txtSBKH.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSBKH_KeyPress);
            // 
            // txtDDKH
            // 
            this.txtDDKH.Location = new System.Drawing.Point(202, 124);
            this.txtDDKH.Name = "txtDDKH";
            this.txtDDKH.Size = new System.Drawing.Size(325, 22);
            this.txtDDKH.TabIndex = 5;
            this.txtDDKH.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDDKH_KeyPress);
            // 
            // txtTC
            // 
            this.txtTC.Location = new System.Drawing.Point(287, 169);
            this.txtTC.Name = "txtTC";
            this.txtTC.Size = new System.Drawing.Size(298, 22);
            this.txtTC.TabIndex = 7;
            this.txtTC.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTC_KeyPress);
            // 
            // txtSBD
            // 
            this.txtSBD.Location = new System.Drawing.Point(738, 49);
            this.txtSBD.Name = "txtSBD";
            this.txtSBD.Size = new System.Drawing.Size(296, 22);
            this.txtSBD.TabIndex = 9;
            this.txtSBD.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSBD_KeyPress);
            // 
            // txtDDD
            // 
            this.txtDDD.Location = new System.Drawing.Point(738, 88);
            this.txtDDD.Name = "txtDDD";
            this.txtDDD.Size = new System.Drawing.Size(296, 22);
            this.txtDDD.TabIndex = 11;
            this.txtDDD.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDDD_KeyPress);
            // 
            // cboHHK
            // 
            this.cboHHK.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboHHK.FormattingEnabled = true;
            this.cboHHK.Location = new System.Drawing.Point(767, 122);
            this.cboHHK.Name = "cboHHK";
            this.cboHHK.Size = new System.Drawing.Size(267, 24);
            this.cboHHK.TabIndex = 13;
            // 
            // dgvCB
            // 
            this.dgvCB.AllowUserToAddRows = false;
            this.dgvCB.AllowUserToDeleteRows = false;
            this.dgvCB.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCB.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCB.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvCB.Location = new System.Drawing.Point(0, 305);
            this.dgvCB.MultiSelect = false;
            this.dgvCB.Name = "dgvCB";
            this.dgvCB.ReadOnly = true;
            this.dgvCB.RowHeadersWidth = 51;
            this.dgvCB.RowTemplate.Height = 24;
            this.dgvCB.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCB.Size = new System.Drawing.Size(1130, 202);
            this.dgvCB.TabIndex = 3;
            this.dgvCB.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCB_CellClick);
            // 
            // btnCapNhat
            // 
            this.btnCapNhat.Location = new System.Drawing.Point(890, 230);
            this.btnCapNhat.Name = "btnCapNhat";
            this.btnCapNhat.Size = new System.Drawing.Size(85, 34);
            this.btnCapNhat.TabIndex = 17;
            this.btnCapNhat.Text = "Cập Nhật";
            this.btnCapNhat.UseVisualStyleBackColor = true;
            this.btnCapNhat.Click += new System.EventHandler(this.btnCapNhat_Click);
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(145, 230);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(85, 34);
            this.btnThem.TabIndex = 15;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(996, 230);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(85, 34);
            this.btnThoat.TabIndex = 18;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(789, 230);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(85, 34);
            this.btnXoa.TabIndex = 16;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnMoi
            // 
            this.btnMoi.Location = new System.Drawing.Point(54, 230);
            this.btnMoi.Name = "btnMoi";
            this.btnMoi.Size = new System.Drawing.Size(85, 34);
            this.btnMoi.TabIndex = 14;
            this.btnMoi.Text = "Mới";
            this.btnMoi.UseVisualStyleBackColor = true;
            this.btnMoi.Click += new System.EventHandler(this.btnMoi_Click);
            // 
            // frmChuyenBay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1130, 507);
            this.Controls.Add(this.btnMoi);
            this.Controls.Add(this.btnCapNhat);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.dgvCB);
            this.Controls.Add(this.cboHHK);
            this.Controls.Add(this.txtDDD);
            this.Controls.Add(this.txtSBD);
            this.Controls.Add(this.txtDDKH);
            this.Controls.Add(this.txtTC);
            this.Controls.Add(this.txtSBKH);
            this.Controls.Add(this.txtMaCB);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmChuyenBay";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Chuyến Bay";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmChuyenBay_FormClosing);
            this.Load += new System.EventHandler(this.frmChuyenBay_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCB)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtMaCB;
        private System.Windows.Forms.TextBox txtSBKH;
        private System.Windows.Forms.TextBox txtDDKH;
        private System.Windows.Forms.TextBox txtTC;
        private System.Windows.Forms.TextBox txtSBD;
        private System.Windows.Forms.TextBox txtDDD;
        private System.Windows.Forms.ComboBox cboHHK;
        private System.Windows.Forms.DataGridView dgvCB;
        private System.Windows.Forms.Button btnCapNhat;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnMoi;
    }
}