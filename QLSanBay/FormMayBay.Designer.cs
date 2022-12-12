
namespace QLSanBay
{
    partial class frmMayBay
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
            this.txtSoHieu = new System.Windows.Forms.TextBox();
            this.cboHHK = new System.Windows.Forms.ComboBox();
            this.dgvMayBay = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnCapNhat = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnMoi = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMayBay)).BeginInit();
            this.SuspendLayout();
            // 
            // txtSoHieu
            // 
            this.txtSoHieu.Location = new System.Drawing.Point(212, 38);
            this.txtSoHieu.Name = "txtSoHieu";
            this.txtSoHieu.Size = new System.Drawing.Size(161, 22);
            this.txtSoHieu.TabIndex = 0;
            this.txtSoHieu.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSoHieu_KeyPress);
            // 
            // cboHHK
            // 
            this.cboHHK.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboHHK.FormattingEnabled = true;
            this.cboHHK.Location = new System.Drawing.Point(212, 79);
            this.cboHHK.Name = "cboHHK";
            this.cboHHK.Size = new System.Drawing.Size(161, 24);
            this.cboHHK.TabIndex = 1;
            // 
            // dgvMayBay
            // 
            this.dgvMayBay.AllowUserToAddRows = false;
            this.dgvMayBay.AllowUserToDeleteRows = false;
            this.dgvMayBay.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvMayBay.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMayBay.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvMayBay.Location = new System.Drawing.Point(0, 218);
            this.dgvMayBay.MultiSelect = false;
            this.dgvMayBay.Name = "dgvMayBay";
            this.dgvMayBay.ReadOnly = true;
            this.dgvMayBay.RowHeadersWidth = 51;
            this.dgvMayBay.RowTemplate.Height = 24;
            this.dgvMayBay.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMayBay.Size = new System.Drawing.Size(479, 121);
            this.dgvMayBay.TabIndex = 2;
            this.dgvMayBay.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMayBay_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(60, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Số Hiệu";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(60, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Hãng Hàng Không";
            // 
            // btnCapNhat
            // 
            this.btnCapNhat.Location = new System.Drawing.Point(291, 148);
            this.btnCapNhat.Name = "btnCapNhat";
            this.btnCapNhat.Size = new System.Drawing.Size(85, 34);
            this.btnCapNhat.TabIndex = 10;
            this.btnCapNhat.Text = "Cập Nhật";
            this.btnCapNhat.UseVisualStyleBackColor = true;
            this.btnCapNhat.Click += new System.EventHandler(this.btnCapNhat_Click);
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(24, 167);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(85, 34);
            this.btnThem.TabIndex = 11;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(382, 148);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(85, 34);
            this.btnThoat.TabIndex = 12;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(190, 148);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(85, 34);
            this.btnXoa.TabIndex = 13;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnMoi
            // 
            this.btnMoi.Location = new System.Drawing.Point(24, 128);
            this.btnMoi.Name = "btnMoi";
            this.btnMoi.Size = new System.Drawing.Size(85, 33);
            this.btnMoi.TabIndex = 14;
            this.btnMoi.Text = "Mới";
            this.btnMoi.UseVisualStyleBackColor = true;
            this.btnMoi.Click += new System.EventHandler(this.btnMoi_Click);
            // 
            // frmMayBay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(479, 339);
            this.Controls.Add(this.btnMoi);
            this.Controls.Add(this.btnCapNhat);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvMayBay);
            this.Controls.Add(this.cboHHK);
            this.Controls.Add(this.txtSoHieu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmMayBay";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Máy Bay";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMayBay_FormClosing);
            this.Load += new System.EventHandler(this.frmMayBay_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMayBay)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtSoHieu;
        private System.Windows.Forms.ComboBox cboHHK;
        private System.Windows.Forms.DataGridView dgvMayBay;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnCapNhat;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnMoi;
    }
}