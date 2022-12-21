
namespace QLSanBay
{
    partial class frm_ReportVMB_theoMA
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
            this.txtMaSoVe = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnXem = new System.Windows.Forms.Button();
            this.crvVMB = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.Report_VEMAYBAY_THEOMA1 = new QLSanBay.Report_VEMAYBAY_THEOMA();
            this.SuspendLayout();
            // 
            // txtMaSoVe
            // 
            this.txtMaSoVe.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaSoVe.Location = new System.Drawing.Point(202, 21);
            this.txtMaSoVe.Name = "txtMaSoVe";
            this.txtMaSoVe.Size = new System.Drawing.Size(151, 38);
            this.txtMaSoVe.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(25, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 39);
            this.label1.TabIndex = 1;
            this.label1.Text = "Mã số vé";
            // 
            // btnXem
            // 
            this.btnXem.Location = new System.Drawing.Point(380, 22);
            this.btnXem.Name = "btnXem";
            this.btnXem.Size = new System.Drawing.Size(84, 37);
            this.btnXem.TabIndex = 2;
            this.btnXem.Text = "Xem";
            this.btnXem.UseVisualStyleBackColor = true;
            this.btnXem.Click += new System.EventHandler(this.btnXem_Click);
            // 
            // crvVMB
            // 
            this.crvVMB.ActiveViewIndex = 0;
            this.crvVMB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crvVMB.Cursor = System.Windows.Forms.Cursors.Default;
            this.crvVMB.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.crvVMB.Location = new System.Drawing.Point(0, 205);
            this.crvVMB.Name = "crvVMB";
            this.crvVMB.ReportSource = this.Report_VEMAYBAY_THEOMA1;
            this.crvVMB.Size = new System.Drawing.Size(1837, 850);
            this.crvVMB.TabIndex = 3;
            // 
            // frm_ReportVMB_theoMA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1837, 1055);
            this.Controls.Add(this.crvVMB);
            this.Controls.Add(this.btnXem);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtMaSoVe);
            this.Name = "frm_ReportVMB_theoMA";
            this.Text = "FormReportVEMAYBAY_THEOMA";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtMaSoVe;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnXem;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer crvVMB;
        private Report_VEMAYBAY_THEOMA Report_VEMAYBAY_THEOMA1;
    }
}