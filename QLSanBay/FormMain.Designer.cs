namespace QLSanBay
{
    partial class frmMain
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mnuForm = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuHHK = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuMayBay = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuPB = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuNV = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuVeMB = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuLoaiVe = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuPC = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuLichBay = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuChuyenBay = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuHanhKhach = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuBaoCao = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuBaoCao_VeMayBay = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuForm,
            this.mnuBaoCao});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(379, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mnuForm
            // 
            this.mnuForm.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuHHK,
            this.mnuPB,
            this.mnuNV,
            this.mnuVeMB,
            this.mnuPC,
            this.mnuLichBay,
            this.mnuHanhKhach});
            this.mnuForm.Name = "mnuForm";
            this.mnuForm.Size = new System.Drawing.Size(73, 24);
            this.mnuForm.Text = "Quản lý";
            // 
            // mnuHHK
            // 
            this.mnuHHK.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuMayBay});
            this.mnuHHK.Name = "mnuHHK";
            this.mnuHHK.Size = new System.Drawing.Size(215, 26);
            this.mnuHHK.Text = "Hãng Hàng Không";
            this.mnuHHK.Click += new System.EventHandler(this.mnuHHK_Click);
            // 
            // mnuMayBay
            // 
            this.mnuMayBay.Name = "mnuMayBay";
            this.mnuMayBay.Size = new System.Drawing.Size(148, 26);
            this.mnuMayBay.Text = "Máy Bay";
            this.mnuMayBay.Click += new System.EventHandler(this.mnuMayBay_Click);
            // 
            // mnuPB
            // 
            this.mnuPB.Name = "mnuPB";
            this.mnuPB.Size = new System.Drawing.Size(215, 26);
            this.mnuPB.Text = "Phòng Ban";
            this.mnuPB.Click += new System.EventHandler(this.mnuPB_Click);
            // 
            // mnuNV
            // 
            this.mnuNV.Name = "mnuNV";
            this.mnuNV.Size = new System.Drawing.Size(215, 26);
            this.mnuNV.Text = "Nhân Viên";
            this.mnuNV.Click += new System.EventHandler(this.mnuNV_Click);
            // 
            // mnuVeMB
            // 
            this.mnuVeMB.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuLoaiVe});
            this.mnuVeMB.Name = "mnuVeMB";
            this.mnuVeMB.Size = new System.Drawing.Size(215, 26);
            this.mnuVeMB.Text = "Vé Máy Bay";
            this.mnuVeMB.Click += new System.EventHandler(this.mnuVeMB_Click);
            // 
            // mnuLoaiVe
            // 
            this.mnuLoaiVe.Name = "mnuLoaiVe";
            this.mnuLoaiVe.Size = new System.Drawing.Size(140, 26);
            this.mnuLoaiVe.Text = "Loại Vé";
            this.mnuLoaiVe.Click += new System.EventHandler(this.mnuLoaiVe_Click);
            // 
            // mnuPC
            // 
            this.mnuPC.Name = "mnuPC";
            this.mnuPC.Size = new System.Drawing.Size(215, 26);
            this.mnuPC.Text = "Phân Công";
            this.mnuPC.Click += new System.EventHandler(this.mnuPC_Click);
            // 
            // mnuLichBay
            // 
            this.mnuLichBay.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuChuyenBay});
            this.mnuLichBay.Name = "mnuLichBay";
            this.mnuLichBay.Size = new System.Drawing.Size(215, 26);
            this.mnuLichBay.Text = "Lịch Bay";
            this.mnuLichBay.Click += new System.EventHandler(this.mnuLichBay_Click);
            // 
            // mnuChuyenBay
            // 
            this.mnuChuyenBay.Name = "mnuChuyenBay";
            this.mnuChuyenBay.Size = new System.Drawing.Size(168, 26);
            this.mnuChuyenBay.Text = "Chuyến Bay";
            this.mnuChuyenBay.Click += new System.EventHandler(this.mnuChuyenBay_Click);
            // 
            // mnuHanhKhach
            // 
            this.mnuHanhKhach.Name = "mnuHanhKhach";
            this.mnuHanhKhach.Size = new System.Drawing.Size(215, 26);
            this.mnuHanhKhach.Text = "Hành Khách";
            this.mnuHanhKhach.Click += new System.EventHandler(this.mnuHanhKhach_Click);
            // 
            // mnuBaoCao
            // 
            this.mnuBaoCao.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuBaoCao_VeMayBay});
            this.mnuBaoCao.Name = "mnuBaoCao";
            this.mnuBaoCao.Size = new System.Drawing.Size(77, 24);
            this.mnuBaoCao.Text = "Báo cáo";
            // 
            // mnuBaoCao_VeMayBay
            // 
            this.mnuBaoCao_VeMayBay.Name = "mnuBaoCao_VeMayBay";
            this.mnuBaoCao_VeMayBay.Size = new System.Drawing.Size(224, 26);
            this.mnuBaoCao_VeMayBay.Text = "Vé Máy Bay";
            this.mnuBaoCao_VeMayBay.Click += new System.EventHandler(this.mnuBaoCao_VeMayBay_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(379, 322);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmMain";
            this.Text = "Quản Lý Sân Bay";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mnuForm;
        private System.Windows.Forms.ToolStripMenuItem mnuHHK;
        private System.Windows.Forms.ToolStripMenuItem mnuPB;
        private System.Windows.Forms.ToolStripMenuItem mnuNV;
        private System.Windows.Forms.ToolStripMenuItem mnuVeMB;
        private System.Windows.Forms.ToolStripMenuItem mnuLoaiVe;
        private System.Windows.Forms.ToolStripMenuItem mnuPC;
        private System.Windows.Forms.ToolStripMenuItem mnuMayBay;
        private System.Windows.Forms.ToolStripMenuItem mnuLichBay;
        private System.Windows.Forms.ToolStripMenuItem mnuChuyenBay;
        private System.Windows.Forms.ToolStripMenuItem mnuHanhKhach;
        private System.Windows.Forms.ToolStripMenuItem mnuBaoCao;
        private System.Windows.Forms.ToolStripMenuItem mnuBaoCao_VeMayBay;
    }
}

