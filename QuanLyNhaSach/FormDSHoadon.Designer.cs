namespace QuanLyNhaSach
{
    partial class FormDSHoadon
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
            this.lvHoaDon = new System.Windows.Forms.ListView();
            this.MaHD = new System.Windows.Forms.ColumnHeader();
            this.TenKH = new System.Windows.Forms.ColumnHeader();
            this.DienThoai = new System.Windows.Forms.ColumnHeader();
            this.NgayHoaDon = new System.Windows.Forms.ColumnHeader();
            this.TongTien = new System.Windows.Forms.ColumnHeader();
            this.SoTienTra = new System.Windows.Forms.ColumnHeader();
            this.lvCTHD = new System.Windows.Forms.ListView();
            this.STT = new System.Windows.Forms.ColumnHeader();
            this.TenSach = new System.Windows.Forms.ColumnHeader();
            this.TheLoai = new System.Windows.Forms.ColumnHeader();
            this.TacGia = new System.Windows.Forms.ColumnHeader();
            this.SoLuong = new System.Windows.Forms.ColumnHeader();
            this.DonGia = new System.Windows.Forms.ColumnHeader();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(181)))), ((int)(((byte)(242)))));
            this.label4.Location = new System.Drawing.Point(540, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(294, 33);
            this.label4.TabIndex = 13;
            this.label4.Text = "DANH SÁCH HÓA ĐƠN";
            this.label4.UseWaitCursor = true;
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // rjButton3
            // 
            this.rjButton3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(181)))), ((int)(((byte)(242)))));
            this.rjButton3.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(181)))), ((int)(((byte)(242)))));
            this.rjButton3.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.rjButton3.BorderRadius = 0;
            this.rjButton3.BorderSize = 0;
            this.rjButton3.FlatAppearance.BorderSize = 0;
            this.rjButton3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rjButton3.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rjButton3.ForeColor = System.Drawing.Color.White;
            this.rjButton3.Location = new System.Drawing.Point(1330, 0);
            this.rjButton3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rjButton3.Name = "rjButton3";
            this.rjButton3.Size = new System.Drawing.Size(57, 57);
            this.rjButton3.TabIndex = 15;
            this.rjButton3.Text = "X";
            this.rjButton3.TextColor = System.Drawing.Color.White;
            this.rjButton3.UseVisualStyleBackColor = false;
            this.rjButton3.Click += new System.EventHandler(this.rjButton3_Click);
            // 
            // lvHoaDon
            // 
            this.lvHoaDon.BackColor = System.Drawing.Color.LightSteelBlue;
            this.lvHoaDon.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.MaHD,
            this.TenKH,
            this.DienThoai,
            this.NgayHoaDon,
            this.TongTien,
            this.SoTienTra});
            this.lvHoaDon.FullRowSelect = true;
            this.lvHoaDon.GridLines = true;
            this.lvHoaDon.Location = new System.Drawing.Point(12, 102);
            this.lvHoaDon.Name = "lvHoaDon";
            this.lvHoaDon.Size = new System.Drawing.Size(661, 491);
            this.lvHoaDon.TabIndex = 17;
            this.lvHoaDon.UseCompatibleStateImageBehavior = false;
            this.lvHoaDon.View = System.Windows.Forms.View.Details;
            this.lvHoaDon.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // MaHD
            // 
            this.MaHD.Text = "Mã HD";
            this.MaHD.Width = 70;
            // 
            // TenKH
            // 
            this.TenKH.Text = "Tên khách hàng";
            this.TenKH.Width = 190;
            // 
            // DienThoai
            // 
            this.DienThoai.Text = "Điện thoại";
            this.DienThoai.Width = 100;
            // 
            // NgayHoaDon
            // 
            this.NgayHoaDon.Text = "Ngày HD";
            this.NgayHoaDon.Width = 100;
            // 
            // TongTien
            // 
            this.TongTien.Text = "Tổng tiền";
            this.TongTien.Width = 100;
            // 
            // SoTienTra
            // 
            this.SoTienTra.Text = "Số tiền nhận";
            this.SoTienTra.Width = 110;
            // 
            // lvCTHD
            // 
            this.lvCTHD.BackColor = System.Drawing.Color.LightSteelBlue;
            this.lvCTHD.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.STT,
            this.TenSach,
            this.TheLoai,
            this.TacGia,
            this.SoLuong,
            this.DonGia});
            this.lvCTHD.FullRowSelect = true;
            this.lvCTHD.GridLines = true;
            this.lvCTHD.Location = new System.Drawing.Point(714, 102);
            this.lvCTHD.Name = "lvCTHD";
            this.lvCTHD.Size = new System.Drawing.Size(661, 491);
            this.lvCTHD.TabIndex = 18;
            this.lvCTHD.UseCompatibleStateImageBehavior = false;
            this.lvCTHD.View = System.Windows.Forms.View.Details;
            // 
            // STT
            // 
            this.STT.Text = "STT";
            this.STT.Width = 50;
            // 
            // TenSach
            // 
            this.TenSach.Text = "Tên sách";
            this.TenSach.Width = 200;
            // 
            // TheLoai
            // 
            this.TheLoai.Text = "Thể loại";
            this.TheLoai.Width = 107;
            // 
            // TacGia
            // 
            this.TacGia.Text = "Tác giả";
            this.TacGia.Width = 100;
            // 
            // SoLuong
            // 
            this.SoLuong.Text = "Số lượng";
            this.SoLuong.Width = 100;
            // 
            // DonGia
            // 
            this.DonGia.Text = "Đơn giá";
            this.DonGia.Width = 100;
            // 
            // FormDSHoadon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1387, 622);
            this.Controls.Add(this.lvCTHD);
            this.Controls.Add(this.lvHoaDon);
            this.Controls.Add(this.rjButton3);
            this.Controls.Add(this.label4);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(181)))), ((int)(((byte)(242)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormDSHoadon";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormDSHoadon";
            this.Load += new System.EventHandler(this.FormDSHoadon_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label4;
        private Control.RJButton rjButton3;
        private ListView lvHoaDon;
        private ListView lvCTHD;
        private ColumnHeader MaHD;
        private ColumnHeader TenKH;
        private ColumnHeader DienThoai;
        private ColumnHeader NgayHoaDon;
        private ColumnHeader TongTien;
        private ColumnHeader SoTienTra;
        private ColumnHeader STT;
        private ColumnHeader TenSach;
        private ColumnHeader TheLoai;
        private ColumnHeader TacGia;
        private ColumnHeader SoLuong;
        private ColumnHeader DonGia;
    }
}