namespace QLSanBay
{
    partial class frmHHK
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
            this.txtMaHHK = new System.Windows.Forms.TextBox();
            this.txtTenHHK = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnCapNhat = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.dgvHHK = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHHK)).BeginInit();
            this.SuspendLayout();
            // 
            // txtMaHHK
            // 
            this.txtMaHHK.Location = new System.Drawing.Point(168, 42);
            this.txtMaHHK.Name = "txtMaHHK";
            this.txtMaHHK.Size = new System.Drawing.Size(223, 20);
            this.txtMaHHK.TabIndex = 1;
            this.txtMaHHK.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMaHHK_KeyPress);
            // 
            // txtTenHHK
            // 
            this.txtTenHHK.Location = new System.Drawing.Point(168, 78);
            this.txtTenHHK.Name = "txtTenHHK";
            this.txtTenHHK.Size = new System.Drawing.Size(223, 20);
            this.txtTenHHK.TabIndex = 2;
            this.txtTenHHK.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTenHHK_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(48, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã Hãng Hàng Không";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(48, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Tên Hãng Hàng Không";
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(31, 119);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(72, 30);
            this.btnThem.TabIndex = 3;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(133, 119);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(72, 30);
            this.btnXoa.TabIndex = 4;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnCapNhat
            // 
            this.btnCapNhat.Location = new System.Drawing.Point(245, 119);
            this.btnCapNhat.Name = "btnCapNhat";
            this.btnCapNhat.Size = new System.Drawing.Size(72, 30);
            this.btnCapNhat.TabIndex = 5;
            this.btnCapNhat.Text = "Cập Nhật";
            this.btnCapNhat.UseVisualStyleBackColor = true;
            this.btnCapNhat.Click += new System.EventHandler(this.btnCapNhat_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(358, 117);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(72, 32);
            this.btnThoat.TabIndex = 6;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            // 
            // dgvHHK
            // 
            this.dgvHHK.AllowUserToAddRows = false;
            this.dgvHHK.AllowUserToDeleteRows = false;
            this.dgvHHK.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvHHK.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            this.dgvHHK.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHHK.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvHHK.Location = new System.Drawing.Point(0, 176);
            this.dgvHHK.MultiSelect = false;
            this.dgvHHK.Name = "dgvHHK";
            this.dgvHHK.ReadOnly = true;
            this.dgvHHK.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvHHK.Size = new System.Drawing.Size(478, 150);
            this.dgvHHK.TabIndex = 3;
            this.dgvHHK.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvHHK_CellClick);
            // 
            // frmHHK
            // 
            this.AcceptButton = this.btnThem;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(478, 326);
            this.Controls.Add(this.dgvHHK);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnCapNhat);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtTenHHK);
            this.Controls.Add(this.txtMaHHK);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmHHK";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Hãng Hàng Không";
            this.Load += new System.EventHandler(this.frmHHK_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHHK)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtMaHHK;
        private System.Windows.Forms.TextBox txtTenHHK;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnCapNhat;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.DataGridView dgvHHK;
    }
}