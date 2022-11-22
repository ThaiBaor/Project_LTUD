
namespace QLSanBay
{
    partial class frmLoaiVe
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
            this.txtMaLoaiVe = new System.Windows.Forms.TextBox();
            this.txtTenLoaiVe = new System.Windows.Forms.TextBox();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnCapNhat = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.dgvLoaiVe = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLoaiVe)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã Loại Vé";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Tên Loại Vé";
            // 
            // txtMaLoaiVe
            // 
            this.txtMaLoaiVe.Location = new System.Drawing.Point(126, 42);
            this.txtMaLoaiVe.Name = "txtMaLoaiVe";
            this.txtMaLoaiVe.Size = new System.Drawing.Size(177, 22);
            this.txtMaLoaiVe.TabIndex = 1;
            this.txtMaLoaiVe.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMaLoaiVe_KeyPress);
            // 
            // txtTenLoaiVe
            // 
            this.txtTenLoaiVe.Location = new System.Drawing.Point(126, 92);
            this.txtTenLoaiVe.Name = "txtTenLoaiVe";
            this.txtTenLoaiVe.Size = new System.Drawing.Size(177, 22);
            this.txtTenLoaiVe.TabIndex = 1;
            this.txtTenLoaiVe.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTenLoaiVe_KeyPress);
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(356, 45);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(86, 25);
            this.btnThem.TabIndex = 2;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(356, 92);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(86, 25);
            this.btnXoa.TabIndex = 2;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnCapNhat
            // 
            this.btnCapNhat.Location = new System.Drawing.Point(456, 45);
            this.btnCapNhat.Name = "btnCapNhat";
            this.btnCapNhat.Size = new System.Drawing.Size(86, 25);
            this.btnCapNhat.TabIndex = 2;
            this.btnCapNhat.Text = "Cập Nhật";
            this.btnCapNhat.UseVisualStyleBackColor = true;
            this.btnCapNhat.Click += new System.EventHandler(this.btnCapNhat_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(456, 93);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(86, 25);
            this.btnThoat.TabIndex = 2;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // dgvLoaiVe
            // 
            this.dgvLoaiVe.AllowUserToAddRows = false;
            this.dgvLoaiVe.AllowUserToDeleteRows = false;
            this.dgvLoaiVe.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvLoaiVe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLoaiVe.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvLoaiVe.Location = new System.Drawing.Point(0, 154);
            this.dgvLoaiVe.MultiSelect = false;
            this.dgvLoaiVe.Name = "dgvLoaiVe";
            this.dgvLoaiVe.ReadOnly = true;
            this.dgvLoaiVe.RowHeadersWidth = 51;
            this.dgvLoaiVe.RowTemplate.Height = 24;
            this.dgvLoaiVe.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvLoaiVe.Size = new System.Drawing.Size(590, 150);
            this.dgvLoaiVe.TabIndex = 3;
            this.dgvLoaiVe.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvLoaiVe_CellClick);
            // 
            // frmLoaiVe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(590, 304);
            this.Controls.Add(this.dgvLoaiVe);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnCapNhat);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.txtTenLoaiVe);
            this.Controls.Add(this.txtMaLoaiVe);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmLoaiVe";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Loại Vé";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmLoaiVe_FormClosing);
            this.Load += new System.EventHandler(this.frmLoaiVe_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLoaiVe)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMaLoaiVe;
        private System.Windows.Forms.TextBox txtTenLoaiVe;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnCapNhat;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.DataGridView dgvLoaiVe;
    }
}