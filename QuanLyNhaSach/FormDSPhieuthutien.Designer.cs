namespace QuanLyNhaSach
{
    partial class FormDSPhieuthutien
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
            this.label4 = new System.Windows.Forms.Label();
            this.rjButton3 = new QuanLyNhaSach.Control.RJButton();
            this.lvPhieuThu = new System.Windows.Forms.ListView();
            this.MaPT = new System.Windows.Forms.ColumnHeader();
            this.TenKH = new System.Windows.Forms.ColumnHeader();
            this.DienThoai = new System.Windows.Forms.ColumnHeader();
            this.NgayThuTien = new System.Windows.Forms.ColumnHeader();
            this.TienThu = new System.Windows.Forms.ColumnHeader();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(181)))), ((int)(((byte)(242)))));
            this.label4.Location = new System.Drawing.Point(161, 24);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(377, 33);
            this.label4.TabIndex = 14;
            this.label4.Text = "DANH SÁCH PHIẾU THU TIỀN";
            this.label4.UseWaitCursor = true;
            // 
            // rjButton3
            // 
            this.rjButton3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(181)))), ((int)(((byte)(242)))));
            this.rjButton3.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(181)))), ((int)(((byte)(242)))));
            this.rjButton3.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.rjButton3.BorderRadius = 0;
            this.rjButton3.BorderSize = 0;
            this.rjButton3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rjButton3.FlatAppearance.BorderSize = 0;
            this.rjButton3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rjButton3.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rjButton3.ForeColor = System.Drawing.Color.White;
            this.rjButton3.Location = new System.Drawing.Point(645, 0);
            this.rjButton3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rjButton3.Name = "rjButton3";
            this.rjButton3.Size = new System.Drawing.Size(57, 57);
            this.rjButton3.TabIndex = 16;
            this.rjButton3.Text = "X";
            this.rjButton3.TextColor = System.Drawing.Color.White;
            this.rjButton3.UseVisualStyleBackColor = false;
            this.rjButton3.Click += new System.EventHandler(this.rjButton3_Click);
            // 
            // lvPhieuThu
            // 
            this.lvPhieuThu.BackColor = System.Drawing.Color.LightSteelBlue;
            this.lvPhieuThu.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.MaPT,
            this.TenKH,
            this.DienThoai,
            this.NgayThuTien,
            this.TienThu});
            this.lvPhieuThu.Font = new System.Drawing.Font("Roboto", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lvPhieuThu.FullRowSelect = true;
            this.lvPhieuThu.GridLines = true;
            this.lvPhieuThu.Location = new System.Drawing.Point(20, 90);
            this.lvPhieuThu.Name = "lvPhieuThu";
            this.lvPhieuThu.Size = new System.Drawing.Size(661, 491);
            this.lvPhieuThu.TabIndex = 17;
            this.lvPhieuThu.UseCompatibleStateImageBehavior = false;
            this.lvPhieuThu.View = System.Windows.Forms.View.Details;
            this.lvPhieuThu.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // MaPT
            // 
            this.MaPT.Text = "Mã Phiếu thu";
            this.MaPT.Width = 125;
            // 
            // TenKH
            // 
            this.TenKH.Text = "Tên khách hàng";
            this.TenKH.Width = 150;
            // 
            // DienThoai
            // 
            this.DienThoai.Text = "Điện thoại";
            this.DienThoai.Width = 100;
            // 
            // NgayThuTien
            // 
            this.NgayThuTien.Text = "Ngày thu tiền";
            this.NgayThuTien.Width = 150;
            // 
            // TienThu
            // 
            this.TienThu.Text = "Số tiền thu";
            this.TienThu.Width = 132;
            // 
            // FormDSPhieuthutien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(702, 622);
            this.Controls.Add(this.lvPhieuThu);
            this.Controls.Add(this.rjButton3);
            this.Controls.Add(this.label4);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormDSPhieuthutien";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormDSPhieuthutien";
            this.Load += new System.EventHandler(this.FormDSPhieuthutien_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label4;
        private Control.RJButton rjButton3;
        private ListView lvPhieuThu;
        private ColumnHeader MaPT;
        private ColumnHeader TenKH;
        private ColumnHeader DienThoai;
        private ColumnHeader NgayThuTien;
        private ColumnHeader TienThu;
    }
}