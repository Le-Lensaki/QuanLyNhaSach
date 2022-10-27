namespace QuanLyNhaSach
{
    partial class FrmLogin
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            ElipseToolDemo.ElipseControl elipseControl1;
            ElipseToolDemo.ElipseControl elipseControl2;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLogin));
            this.panel1 = new System.Windows.Forms.Panel();
            this.rjButton1 = new QuanLyNhaSach.Control.RJButton();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.rjTextBox2 = new QuanLyNhaSach.Control.RJTextBox();
            this.txtTaikhoan = new QuanLyNhaSach.Control.RJTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.rjButton2 = new QuanLyNhaSach.Control.RJButton();
            elipseControl1 = new ElipseToolDemo.ElipseControl();
            elipseControl2 = new ElipseToolDemo.ElipseControl();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // elipseControl1
            // 
            elipseControl1.CornerRadius = 30;
            elipseControl1.TargetControl = this;
            // 
            // elipseControl2
            // 
            elipseControl2.CornerRadius = 30;
            elipseControl2.TargetControl = this.panel1;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.rjButton1);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.rjTextBox2);
            this.panel1.Controls.Add(this.txtTaikhoan);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(38, 37);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(649, 445);
            this.panel1.TabIndex = 0;
            // 
            // rjButton1
            // 
            this.rjButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(181)))), ((int)(((byte)(242)))));
            this.rjButton1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(181)))), ((int)(((byte)(242)))));
            this.rjButton1.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.rjButton1.BorderRadius = 15;
            this.rjButton1.BorderSize = 0;
            this.rjButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rjButton1.FlatAppearance.BorderSize = 0;
            this.rjButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rjButton1.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.rjButton1.ForeColor = System.Drawing.Color.White;
            this.rjButton1.Location = new System.Drawing.Point(207, 348);
            this.rjButton1.Name = "rjButton1";
            this.rjButton1.Size = new System.Drawing.Size(233, 34);
            this.rjButton1.TabIndex = 6;
            this.rjButton1.Text = "Đăng nhập";
            this.rjButton1.TextColor = System.Drawing.Color.White;
            this.rjButton1.UseVisualStyleBackColor = false;
            this.rjButton1.Click += new System.EventHandler(this.rjButton1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Roboto", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(169, 237);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 27);
            this.label4.TabIndex = 5;
            this.label4.Text = "Mật khẩu";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Roboto", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(169, 154);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 27);
            this.label3.TabIndex = 4;
            this.label3.Text = "Tài khoản";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // rjTextBox2
            // 
            this.rjTextBox2.BackColor = System.Drawing.SystemColors.Window;
            this.rjTextBox2.BorderColor = System.Drawing.Color.Black;
            this.rjTextBox2.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(181)))), ((int)(((byte)(242)))));
            this.rjTextBox2.BorderRadius = 0;
            this.rjTextBox2.BorderSize = 1;
            this.rjTextBox2.Font = new System.Drawing.Font("Roboto", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rjTextBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.rjTextBox2.Location = new System.Drawing.Point(169, 268);
            this.rjTextBox2.Margin = new System.Windows.Forms.Padding(4);
            this.rjTextBox2.Multiline = false;
            this.rjTextBox2.Name = "rjTextBox2";
            this.rjTextBox2.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.rjTextBox2.PasswordChar = true;
            this.rjTextBox2.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.rjTextBox2.PlaceholderText = "";
            this.rjTextBox2.Size = new System.Drawing.Size(312, 38);
            this.rjTextBox2.TabIndex = 3;
            this.rjTextBox2.Texts = "password";
            this.rjTextBox2.UnderlinedStyle = false;
            this.rjTextBox2.Load += new System.EventHandler(this.rjTextBox2_Load);
            // 
            // txtTaikhoan
            // 
            this.txtTaikhoan.BackColor = System.Drawing.SystemColors.Window;
            this.txtTaikhoan.BorderColor = System.Drawing.Color.Black;
            this.txtTaikhoan.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(181)))), ((int)(((byte)(242)))));
            this.txtTaikhoan.BorderRadius = 0;
            this.txtTaikhoan.BorderSize = 1;
            this.txtTaikhoan.Font = new System.Drawing.Font("Roboto", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtTaikhoan.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtTaikhoan.Location = new System.Drawing.Point(169, 185);
            this.txtTaikhoan.Margin = new System.Windows.Forms.Padding(4);
            this.txtTaikhoan.Multiline = false;
            this.txtTaikhoan.Name = "txtTaikhoan";
            this.txtTaikhoan.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtTaikhoan.PasswordChar = false;
            this.txtTaikhoan.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtTaikhoan.PlaceholderText = "";
            this.txtTaikhoan.Size = new System.Drawing.Size(312, 38);
            this.txtTaikhoan.TabIndex = 2;
            this.txtTaikhoan.Texts = "lephuonghoangx4";
            this.txtTaikhoan.UnderlinedStyle = false;
            this.txtTaikhoan.Load += new System.EventHandler(this.rjTextBox1_Load_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(181)))), ((int)(((byte)(242)))));
            this.label2.Location = new System.Drawing.Point(251, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(143, 33);
            this.label2.TabIndex = 1;
            this.label2.Text = "Đăng nhập";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(181)))), ((int)(((byte)(242)))));
            this.label1.Location = new System.Drawing.Point(125, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(405, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "HỆ THỐNG QUẢN LÝ NHÀ SÁCH";
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // rjButton2
            // 
            this.rjButton2.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.rjButton2.BackgroundColor = System.Drawing.SystemColors.ActiveBorder;
            this.rjButton2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("rjButton2.BackgroundImage")));
            this.rjButton2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.rjButton2.BorderColor = System.Drawing.Color.Transparent;
            this.rjButton2.BorderRadius = 0;
            this.rjButton2.BorderSize = 0;
            this.rjButton2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rjButton2.FlatAppearance.BorderSize = 0;
            this.rjButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rjButton2.ForeColor = System.Drawing.Color.White;
            this.rjButton2.Location = new System.Drawing.Point(682, 0);
            this.rjButton2.Name = "rjButton2";
            this.rjButton2.Size = new System.Drawing.Size(38, 38);
            this.rjButton2.TabIndex = 1;
            this.rjButton2.TextColor = System.Drawing.Color.White;
            this.rjButton2.UseVisualStyleBackColor = false;
            this.rjButton2.Click += new System.EventHandler(this.rjButton2_Click);
            // 
            // FrmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(720, 512);
            this.Controls.Add(this.rjButton2);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FrmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.FrmLogin_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Label label2;
        private Control.RJTextBox txtTaikhoan;
        private Control.RJTextBox rjTextBox2;
        private Label label3;
        private Label label4;
        private Control.RJButton rjButton1;
        private Control.RJButton rjButton2;
        private ElipseToolDemo.ElipseControl elipseControl1;
        private ElipseToolDemo.ElipseControl elipseControl2;
    }
}