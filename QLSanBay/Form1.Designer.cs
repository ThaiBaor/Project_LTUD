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
            this.mnuPB = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuNV = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuVeMB = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuLoaiVe = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuPC = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuForm});
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
            this.mnuPC});
            this.mnuForm.Name = "mnuForm";
            this.mnuForm.Size = new System.Drawing.Size(57, 24);
            this.mnuForm.Text = "Form";
            // 
            // mnuHHK
            // 
            this.mnuHHK.Name = "mnuHHK";
            this.mnuHHK.Size = new System.Drawing.Size(224, 26);
            this.mnuHHK.Text = "Hãng Hàng Không";
            this.mnuHHK.Click += new System.EventHandler(this.mnuHHK_Click);
            // 
            // mnuPB
            // 
            this.mnuPB.Name = "mnuPB";
            this.mnuPB.Size = new System.Drawing.Size(224, 26);
            this.mnuPB.Text = "Phòng Ban";
            this.mnuPB.Click += new System.EventHandler(this.mnuPB_Click);
            // 
            // mnuNV
            // 
            this.mnuNV.Name = "mnuNV";
            this.mnuNV.Size = new System.Drawing.Size(224, 26);
            this.mnuNV.Text = "Nhân Viên";
            this.mnuNV.Click += new System.EventHandler(this.mnuNV_Click);
            // 
            // mnuVeMB
            // 
            this.mnuVeMB.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuLoaiVe});
            this.mnuVeMB.Name = "mnuVeMB";
            this.mnuVeMB.Size = new System.Drawing.Size(224, 26);
            this.mnuVeMB.Text = "Vé Máy Bay";
            // 
            // mnuLoaiVe
            // 
            this.mnuLoaiVe.Name = "mnuLoaiVe";
            this.mnuLoaiVe.Size = new System.Drawing.Size(224, 26);
            this.mnuLoaiVe.Text = "Loại Vé";
            this.mnuLoaiVe.Click += new System.EventHandler(this.mnuLoaiVe_Click);
            // 
            // mnuPC
            // 
            this.mnuPC.Name = "mnuPC";
            this.mnuPC.Size = new System.Drawing.Size(224, 26);
            this.mnuPC.Text = "Phân Công";
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
    }
}

