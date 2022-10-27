namespace QuanLyNhaSach
{
    partial class Dash_board
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
            ElipseToolDemo.ElipseControl elipseControl1;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dash_board));
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbDangxuat = new System.Windows.Forms.Label();
            this.lbDoimk = new System.Windows.Forms.Label();
            this.btnThaydoiqd = new QuanLyNhaSach.Control.RJButton();
            this.btnNhansu = new QuanLyNhaSach.Control.RJButton();
            this.btnBaoCao = new QuanLyNhaSach.Control.RJButton();
            this.btnKhachhang = new QuanLyNhaSach.Control.RJButton();
            this.btnHoadon = new QuanLyNhaSach.Control.RJButton();
            this.btnTraCuu = new QuanLyNhaSach.Control.RJButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.rjButton6 = new QuanLyNhaSach.Control.RJButton();
            this.label3 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lblRole = new System.Windows.Forms.Label();
            this.lblWelcome = new System.Windows.Forms.Label();
            this.lbHien = new System.Windows.Forms.Label();
            this.panelSide = new System.Windows.Forms.Panel();
            elipseControl1 = new ElipseToolDemo.ElipseControl();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // elipseControl1
            // 
            elipseControl1.CornerRadius = 30;
            elipseControl1.TargetControl = this;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(181)))), ((int)(((byte)(242)))));
            this.panel1.Controls.Add(this.lbDangxuat);
            this.panel1.Controls.Add(this.lbDoimk);
            this.panel1.Controls.Add(this.btnThaydoiqd);
            this.panel1.Controls.Add(this.btnNhansu);
            this.panel1.Controls.Add(this.btnBaoCao);
            this.panel1.Controls.Add(this.btnKhachhang);
            this.panel1.Controls.Add(this.btnHoadon);
            this.panel1.Controls.Add(this.btnTraCuu);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(341, 806);
            this.panel1.TabIndex = 0;
            // 
            // lbDangxuat
            // 
            this.lbDangxuat.AutoSize = true;
            this.lbDangxuat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbDangxuat.Font = new System.Drawing.Font("Roboto", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbDangxuat.ForeColor = System.Drawing.Color.White;
            this.lbDangxuat.Location = new System.Drawing.Point(99, 750);
            this.lbDangxuat.Name = "lbDangxuat";
            this.lbDangxuat.Size = new System.Drawing.Size(125, 30);
            this.lbDangxuat.TabIndex = 12;
            this.lbDangxuat.Text = "Đăng xuất";
            this.lbDangxuat.Click += new System.EventHandler(this.lbDangxuat_Click);
            // 
            // lbDoimk
            // 
            this.lbDoimk.AutoSize = true;
            this.lbDoimk.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbDoimk.Font = new System.Drawing.Font("Roboto", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbDoimk.ForeColor = System.Drawing.Color.White;
            this.lbDoimk.Location = new System.Drawing.Point(83, 702);
            this.lbDoimk.Name = "lbDoimk";
            this.lbDoimk.Size = new System.Drawing.Size(160, 30);
            this.lbDoimk.TabIndex = 11;
            this.lbDoimk.Text = "Đổi mật khẩu";
            this.lbDoimk.Click += new System.EventHandler(this.lbDoimk_Click);
            // 
            // btnThaydoiqd
            // 
            this.btnThaydoiqd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(181)))), ((int)(((byte)(242)))));
            this.btnThaydoiqd.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(181)))), ((int)(((byte)(242)))));
            this.btnThaydoiqd.BorderColor = System.Drawing.Color.Transparent;
            this.btnThaydoiqd.BorderRadius = 0;
            this.btnThaydoiqd.BorderSize = 0;
            this.btnThaydoiqd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnThaydoiqd.FlatAppearance.BorderSize = 0;
            this.btnThaydoiqd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThaydoiqd.Font = new System.Drawing.Font("Roboto", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnThaydoiqd.ForeColor = System.Drawing.Color.White;
            this.btnThaydoiqd.Image = ((System.Drawing.Image)(resources.GetObject("btnThaydoiqd.Image")));
            this.btnThaydoiqd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThaydoiqd.Location = new System.Drawing.Point(14, 500);
            this.btnThaydoiqd.Name = "btnThaydoiqd";
            this.btnThaydoiqd.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnThaydoiqd.Size = new System.Drawing.Size(327, 63);
            this.btnThaydoiqd.TabIndex = 10;
            this.btnThaydoiqd.Text = "       Thay đổi quy định";
            this.btnThaydoiqd.TextColor = System.Drawing.Color.White;
            this.btnThaydoiqd.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnThaydoiqd.UseVisualStyleBackColor = true;
            this.btnThaydoiqd.Click += new System.EventHandler(this.btnThaydoiqd_Click);
            // 
            // btnNhansu
            // 
            this.btnNhansu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(181)))), ((int)(((byte)(242)))));
            this.btnNhansu.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(181)))), ((int)(((byte)(242)))));
            this.btnNhansu.BorderColor = System.Drawing.Color.Transparent;
            this.btnNhansu.BorderRadius = 0;
            this.btnNhansu.BorderSize = 0;
            this.btnNhansu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNhansu.FlatAppearance.BorderSize = 0;
            this.btnNhansu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNhansu.Font = new System.Drawing.Font("Roboto", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnNhansu.ForeColor = System.Drawing.Color.White;
            this.btnNhansu.Image = ((System.Drawing.Image)(resources.GetObject("btnNhansu.Image")));
            this.btnNhansu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNhansu.Location = new System.Drawing.Point(14, 425);
            this.btnNhansu.Name = "btnNhansu";
            this.btnNhansu.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnNhansu.Size = new System.Drawing.Size(327, 63);
            this.btnNhansu.TabIndex = 9;
            this.btnNhansu.Text = "       Nhân viên";
            this.btnNhansu.TextColor = System.Drawing.Color.White;
            this.btnNhansu.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnNhansu.UseVisualStyleBackColor = true;
            this.btnNhansu.Click += new System.EventHandler(this.btnNhansu_Click);
            // 
            // btnBaoCao
            // 
            this.btnBaoCao.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(181)))), ((int)(((byte)(242)))));
            this.btnBaoCao.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(181)))), ((int)(((byte)(242)))));
            this.btnBaoCao.BorderColor = System.Drawing.Color.Transparent;
            this.btnBaoCao.BorderRadius = 0;
            this.btnBaoCao.BorderSize = 0;
            this.btnBaoCao.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBaoCao.FlatAppearance.BorderSize = 0;
            this.btnBaoCao.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBaoCao.Font = new System.Drawing.Font("Roboto", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnBaoCao.ForeColor = System.Drawing.Color.White;
            this.btnBaoCao.Image = ((System.Drawing.Image)(resources.GetObject("btnBaoCao.Image")));
            this.btnBaoCao.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBaoCao.Location = new System.Drawing.Point(14, 350);
            this.btnBaoCao.Name = "btnBaoCao";
            this.btnBaoCao.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnBaoCao.Size = new System.Drawing.Size(327, 63);
            this.btnBaoCao.TabIndex = 8;
            this.btnBaoCao.Text = "       Báo cáo tháng";
            this.btnBaoCao.TextColor = System.Drawing.Color.White;
            this.btnBaoCao.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnBaoCao.UseVisualStyleBackColor = true;
            this.btnBaoCao.Click += new System.EventHandler(this.btnBaoCao_Click);
            // 
            // btnKhachhang
            // 
            this.btnKhachhang.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(181)))), ((int)(((byte)(242)))));
            this.btnKhachhang.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(181)))), ((int)(((byte)(242)))));
            this.btnKhachhang.BorderColor = System.Drawing.Color.Transparent;
            this.btnKhachhang.BorderRadius = 0;
            this.btnKhachhang.BorderSize = 0;
            this.btnKhachhang.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnKhachhang.FlatAppearance.BorderSize = 0;
            this.btnKhachhang.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKhachhang.Font = new System.Drawing.Font("Roboto", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnKhachhang.ForeColor = System.Drawing.Color.White;
            this.btnKhachhang.Image = ((System.Drawing.Image)(resources.GetObject("btnKhachhang.Image")));
            this.btnKhachhang.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnKhachhang.Location = new System.Drawing.Point(14, 275);
            this.btnKhachhang.Name = "btnKhachhang";
            this.btnKhachhang.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnKhachhang.Size = new System.Drawing.Size(327, 63);
            this.btnKhachhang.TabIndex = 7;
            this.btnKhachhang.Text = "       Khách hàng";
            this.btnKhachhang.TextColor = System.Drawing.Color.White;
            this.btnKhachhang.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnKhachhang.UseVisualStyleBackColor = true;
            this.btnKhachhang.Click += new System.EventHandler(this.btnKhachhang_Click);
            // 
            // btnHoadon
            // 
            this.btnHoadon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(181)))), ((int)(((byte)(242)))));
            this.btnHoadon.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(181)))), ((int)(((byte)(242)))));
            this.btnHoadon.BorderColor = System.Drawing.Color.Transparent;
            this.btnHoadon.BorderRadius = 0;
            this.btnHoadon.BorderSize = 0;
            this.btnHoadon.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHoadon.FlatAppearance.BorderSize = 0;
            this.btnHoadon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHoadon.Font = new System.Drawing.Font("Roboto", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnHoadon.ForeColor = System.Drawing.Color.White;
            this.btnHoadon.Image = ((System.Drawing.Image)(resources.GetObject("btnHoadon.Image")));
            this.btnHoadon.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHoadon.Location = new System.Drawing.Point(14, 200);
            this.btnHoadon.Name = "btnHoadon";
            this.btnHoadon.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnHoadon.Size = new System.Drawing.Size(327, 63);
            this.btnHoadon.TabIndex = 6;
            this.btnHoadon.Text = "       Hóa đơn";
            this.btnHoadon.TextColor = System.Drawing.Color.White;
            this.btnHoadon.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnHoadon.UseVisualStyleBackColor = true;
            this.btnHoadon.Click += new System.EventHandler(this.btnHoadon_Click);
            // 
            // btnTraCuu
            // 
            this.btnTraCuu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(181)))), ((int)(((byte)(242)))));
            this.btnTraCuu.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(181)))), ((int)(((byte)(242)))));
            this.btnTraCuu.BorderColor = System.Drawing.Color.Transparent;
            this.btnTraCuu.BorderRadius = 0;
            this.btnTraCuu.BorderSize = 0;
            this.btnTraCuu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTraCuu.FlatAppearance.BorderSize = 0;
            this.btnTraCuu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTraCuu.Font = new System.Drawing.Font("Roboto", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnTraCuu.ForeColor = System.Drawing.Color.White;
            this.btnTraCuu.Image = ((System.Drawing.Image)(resources.GetObject("btnTraCuu.Image")));
            this.btnTraCuu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTraCuu.Location = new System.Drawing.Point(14, 125);
            this.btnTraCuu.Name = "btnTraCuu";
            this.btnTraCuu.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnTraCuu.Size = new System.Drawing.Size(327, 63);
            this.btnTraCuu.TabIndex = 5;
            this.btnTraCuu.Text = "       Sách";
            this.btnTraCuu.TextColor = System.Drawing.Color.White;
            this.btnTraCuu.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnTraCuu.UseVisualStyleBackColor = true;
            this.btnTraCuu.Click += new System.EventHandler(this.btnTraCuu_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(341, 125);
            this.panel2.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(113, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 100);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.rjButton6);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Font = new System.Drawing.Font("Roboto", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.panel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(181)))), ((int)(((byte)(242)))));
            this.panel3.Location = new System.Drawing.Point(341, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1071, 44);
            this.panel3.TabIndex = 1;
            // 
            // rjButton6
            // 
            this.rjButton6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(181)))), ((int)(((byte)(242)))));
            this.rjButton6.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(181)))), ((int)(((byte)(242)))));
            this.rjButton6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.rjButton6.BorderColor = System.Drawing.Color.Transparent;
            this.rjButton6.BorderRadius = 0;
            this.rjButton6.BorderSize = 0;
            this.rjButton6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rjButton6.FlatAppearance.BorderSize = 0;
            this.rjButton6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rjButton6.ForeColor = System.Drawing.Color.White;
            this.rjButton6.Image = ((System.Drawing.Image)(resources.GetObject("rjButton6.Image")));
            this.rjButton6.Location = new System.Drawing.Point(1009, 0);
            this.rjButton6.Name = "rjButton6";
            this.rjButton6.Size = new System.Drawing.Size(62, 44);
            this.rjButton6.TabIndex = 3;
            this.rjButton6.TextColor = System.Drawing.Color.White;
            this.rjButton6.UseVisualStyleBackColor = false;
            this.rjButton6.Click += new System.EventHandler(this.rjButton6_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(63, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(394, 30);
            this.label3.TabIndex = 0;
            this.label3.Text = "Hệ thống quản lý nhà sách Fahasa";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(181)))), ((int)(((byte)(242)))));
            this.panel4.Controls.Add(this.lblRole);
            this.panel4.Controls.Add(this.lblWelcome);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Font = new System.Drawing.Font("Roboto", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.panel4.ForeColor = System.Drawing.Color.White;
            this.panel4.Location = new System.Drawing.Point(341, 44);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1071, 81);
            this.panel4.TabIndex = 2;
            // 
            // lblRole
            // 
            this.lblRole.AutoSize = true;
            this.lblRole.Font = new System.Drawing.Font("Roboto", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblRole.Location = new System.Drawing.Point(63, 42);
            this.lblRole.Name = "lblRole";
            this.lblRole.Size = new System.Drawing.Size(106, 27);
            this.lblRole.TabIndex = 1;
            this.lblRole.Text = "Chức vụ:  ";
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Font = new System.Drawing.Font("Roboto", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblWelcome.Location = new System.Drawing.Point(63, 7);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(101, 27);
            this.lblWelcome.TabIndex = 0;
            this.lblWelcome.Text = "Xin chào ";
            this.lblWelcome.Click += new System.EventHandler(this.label4_Click);
            // 
            // lbHien
            // 
            this.lbHien.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbHien.Location = new System.Drawing.Point(341, 125);
            this.lbHien.Margin = new System.Windows.Forms.Padding(5);
            this.lbHien.Name = "lbHien";
            this.lbHien.Size = new System.Drawing.Size(1071, 681);
            this.lbHien.TabIndex = 3;
            this.lbHien.Click += new System.EventHandler(this.lbHien_Click);
            // 
            // panelSide
            // 
            this.panelSide.BackColor = System.Drawing.Color.White;
            this.panelSide.Location = new System.Drawing.Point(0, 125);
            this.panelSide.Margin = new System.Windows.Forms.Padding(0);
            this.panelSide.Name = "panelSide";
            this.panelSide.Size = new System.Drawing.Size(8, 63);
            this.panelSide.TabIndex = 13;
            // 
            // Dash_board
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1412, 806);
            this.Controls.Add(this.panelSide);
            this.Controls.Add(this.lbHien);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Dash_board";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dash_board";
            this.Load += new System.EventHandler(this.Dash_board_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private PictureBox pictureBox1;
        private Control.RJButton btnTraCuu;
        private Control.RJButton btnNhansu;
        private Control.RJButton btnBaoCao;
        private Control.RJButton btnKhachhang;
        private Control.RJButton btnHoadon;
        private Control.RJButton btnThaydoiqd;
        private Label lbDangxuat;
        private Label lbDoimk;
        private Panel panel4;
        private Panel panel3;
        private Label label3;
        private Label lblRole;
        private Label lblWelcome;
        private Control.RJButton rjButton6;
        private Label lbHien;
        private Panel panelSide;
    }
}