namespace QuanLyNhaSach
{
    partial class FormPhieunhapsach
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
            this.rjButton1 = new QuanLyNhaSach.Control.RJButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtBoxTheloai = new QuanLyNhaSach.Control.RJTextBox();
            this.txtBoxTacgia = new QuanLyNhaSach.Control.RJTextBox();
            this.txtBoxDongianhap = new QuanLyNhaSach.Control.RJTextBox();
            this.dtpNgay = new System.Windows.Forms.DateTimePicker();
            this.rjButton2 = new QuanLyNhaSach.Control.RJButton();
            this.rjButton3 = new QuanLyNhaSach.Control.RJButton();
            this.rjButton4 = new QuanLyNhaSach.Control.RJButton();
            this.txtBoxSoluong = new QuanLyNhaSach.Control.RJTextBox();
            this.lv_nhapSach = new System.Windows.Forms.ListView();
            this.TenSach = new System.Windows.Forms.ColumnHeader();
            this.TheLoai = new System.Windows.Forms.ColumnHeader();
            this.TacGia = new System.Windows.Forms.ColumnHeader();
            this.SoLuong = new System.Windows.Forms.ColumnHeader();
            this.DonGia = new System.Windows.Forms.ColumnHeader();
            this.cboxXuat = new System.Windows.Forms.CheckBox();
            this.Save = new System.Windows.Forms.SaveFileDialog();
            this.txtBoxTensach = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // rjButton1
            // 
            this.rjButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(181)))), ((int)(((byte)(242)))));
            this.rjButton1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(181)))), ((int)(((byte)(242)))));
            this.rjButton1.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.rjButton1.BorderRadius = 0;
            this.rjButton1.BorderSize = 0;
            this.rjButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rjButton1.FlatAppearance.BorderSize = 0;
            this.rjButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rjButton1.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rjButton1.ForeColor = System.Drawing.Color.White;
            this.rjButton1.Location = new System.Drawing.Point(854, -3);
            this.rjButton1.Name = "rjButton1";
            this.rjButton1.Size = new System.Drawing.Size(57, 57);
            this.rjButton1.TabIndex = 0;
            this.rjButton1.Text = "x";
            this.rjButton1.TextColor = System.Drawing.Color.White;
            this.rjButton1.UseVisualStyleBackColor = false;
            this.rjButton1.Click += new System.EventHandler(this.rjButton1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(181)))), ((int)(((byte)(242)))));
            this.label1.Location = new System.Drawing.Point(321, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(214, 33);
            this.label1.TabIndex = 1;
            this.label1.Text = "Phiếu nhập sách";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Roboto", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(181)))), ((int)(((byte)(242)))));
            this.label2.Location = new System.Drawing.Point(23, 176);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 27);
            this.label2.TabIndex = 2;
            this.label2.Text = "Ngày nhập";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Roboto", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(181)))), ((int)(((byte)(242)))));
            this.label3.Location = new System.Drawing.Point(413, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 27);
            this.label3.TabIndex = 3;
            this.label3.Text = "Tên sách";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Roboto", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(181)))), ((int)(((byte)(242)))));
            this.label4.Location = new System.Drawing.Point(413, 118);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 27);
            this.label4.TabIndex = 4;
            this.label4.Text = "Thể loại";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Roboto", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(181)))), ((int)(((byte)(242)))));
            this.label5.Location = new System.Drawing.Point(413, 176);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 27);
            this.label5.TabIndex = 5;
            this.label5.Text = "Tác giả";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Roboto", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(181)))), ((int)(((byte)(242)))));
            this.label6.Location = new System.Drawing.Point(413, 232);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(141, 27);
            this.label6.TabIndex = 6;
            this.label6.Text = "Đơn giá nhập";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Roboto", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(181)))), ((int)(((byte)(242)))));
            this.label7.Location = new System.Drawing.Point(413, 292);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(153, 27);
            this.label7.TabIndex = 7;
            this.label7.Text = "Số lượng nhập";
            // 
            // txtBoxTheloai
            // 
            this.txtBoxTheloai.BackColor = System.Drawing.SystemColors.Window;
            this.txtBoxTheloai.BorderColor = System.Drawing.Color.Black;
            this.txtBoxTheloai.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(181)))), ((int)(((byte)(242)))));
            this.txtBoxTheloai.BorderRadius = 0;
            this.txtBoxTheloai.BorderSize = 1;
            this.txtBoxTheloai.Font = new System.Drawing.Font("Roboto", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtBoxTheloai.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtBoxTheloai.Location = new System.Drawing.Point(604, 106);
            this.txtBoxTheloai.Margin = new System.Windows.Forms.Padding(4);
            this.txtBoxTheloai.Multiline = false;
            this.txtBoxTheloai.Name = "txtBoxTheloai";
            this.txtBoxTheloai.Padding = new System.Windows.Forms.Padding(11, 9, 11, 9);
            this.txtBoxTheloai.PasswordChar = false;
            this.txtBoxTheloai.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtBoxTheloai.PlaceholderText = "";
            this.txtBoxTheloai.Size = new System.Drawing.Size(205, 42);
            this.txtBoxTheloai.TabIndex = 9;
            this.txtBoxTheloai.Texts = "";
            this.txtBoxTheloai.UnderlinedStyle = false;
            // 
            // txtBoxTacgia
            // 
            this.txtBoxTacgia.BackColor = System.Drawing.SystemColors.Window;
            this.txtBoxTacgia.BorderColor = System.Drawing.Color.Black;
            this.txtBoxTacgia.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(181)))), ((int)(((byte)(242)))));
            this.txtBoxTacgia.BorderRadius = 0;
            this.txtBoxTacgia.BorderSize = 1;
            this.txtBoxTacgia.Font = new System.Drawing.Font("Roboto", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtBoxTacgia.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtBoxTacgia.Location = new System.Drawing.Point(604, 164);
            this.txtBoxTacgia.Margin = new System.Windows.Forms.Padding(4);
            this.txtBoxTacgia.Multiline = false;
            this.txtBoxTacgia.Name = "txtBoxTacgia";
            this.txtBoxTacgia.Padding = new System.Windows.Forms.Padding(11, 9, 11, 9);
            this.txtBoxTacgia.PasswordChar = false;
            this.txtBoxTacgia.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtBoxTacgia.PlaceholderText = "";
            this.txtBoxTacgia.Size = new System.Drawing.Size(205, 42);
            this.txtBoxTacgia.TabIndex = 10;
            this.txtBoxTacgia.Texts = "";
            this.txtBoxTacgia.UnderlinedStyle = false;
            // 
            // txtBoxDongianhap
            // 
            this.txtBoxDongianhap.BackColor = System.Drawing.SystemColors.Window;
            this.txtBoxDongianhap.BorderColor = System.Drawing.Color.Black;
            this.txtBoxDongianhap.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(181)))), ((int)(((byte)(242)))));
            this.txtBoxDongianhap.BorderRadius = 0;
            this.txtBoxDongianhap.BorderSize = 1;
            this.txtBoxDongianhap.Font = new System.Drawing.Font("Roboto", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtBoxDongianhap.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtBoxDongianhap.Location = new System.Drawing.Point(604, 220);
            this.txtBoxDongianhap.Margin = new System.Windows.Forms.Padding(4);
            this.txtBoxDongianhap.Multiline = false;
            this.txtBoxDongianhap.Name = "txtBoxDongianhap";
            this.txtBoxDongianhap.Padding = new System.Windows.Forms.Padding(11, 9, 11, 9);
            this.txtBoxDongianhap.PasswordChar = false;
            this.txtBoxDongianhap.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtBoxDongianhap.PlaceholderText = "";
            this.txtBoxDongianhap.Size = new System.Drawing.Size(205, 42);
            this.txtBoxDongianhap.TabIndex = 11;
            this.txtBoxDongianhap.Texts = "";
            this.txtBoxDongianhap.UnderlinedStyle = false;
            // 
            // dtpNgay
            // 
            this.dtpNgay.CustomFormat = "dd/MM/yyyy";
            this.dtpNgay.Font = new System.Drawing.Font("Roboto", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dtpNgay.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNgay.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dtpNgay.Location = new System.Drawing.Point(164, 176);
            this.dtpNgay.Name = "dtpNgay";
            this.dtpNgay.Size = new System.Drawing.Size(205, 30);
            this.dtpNgay.TabIndex = 12;
            this.dtpNgay.Value = new System.DateTime(2022, 1, 5, 0, 0, 0, 0);
            // 
            // rjButton2
            // 
            this.rjButton2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(181)))), ((int)(((byte)(242)))));
            this.rjButton2.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(181)))), ((int)(((byte)(242)))));
            this.rjButton2.BorderColor = System.Drawing.Color.White;
            this.rjButton2.BorderRadius = 10;
            this.rjButton2.BorderSize = 2;
            this.rjButton2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rjButton2.FlatAppearance.BorderSize = 0;
            this.rjButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rjButton2.Font = new System.Drawing.Font("Roboto", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.rjButton2.ForeColor = System.Drawing.Color.White;
            this.rjButton2.Location = new System.Drawing.Point(586, 703);
            this.rjButton2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rjButton2.Name = "rjButton2";
            this.rjButton2.Size = new System.Drawing.Size(169, 53);
            this.rjButton2.TabIndex = 37;
            this.rjButton2.Text = "HOÀN TẤT";
            this.rjButton2.TextColor = System.Drawing.Color.White;
            this.rjButton2.UseVisualStyleBackColor = false;
            this.rjButton2.Click += new System.EventHandler(this.rjButton2_Click);
            // 
            // rjButton3
            // 
            this.rjButton3.BackColor = System.Drawing.Color.White;
            this.rjButton3.BackgroundColor = System.Drawing.Color.White;
            this.rjButton3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(181)))), ((int)(((byte)(242)))));
            this.rjButton3.BorderRadius = 10;
            this.rjButton3.BorderSize = 2;
            this.rjButton3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rjButton3.FlatAppearance.BorderSize = 0;
            this.rjButton3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rjButton3.Font = new System.Drawing.Font("Roboto", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.rjButton3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(181)))), ((int)(((byte)(242)))));
            this.rjButton3.Location = new System.Drawing.Point(144, 703);
            this.rjButton3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rjButton3.Name = "rjButton3";
            this.rjButton3.Size = new System.Drawing.Size(169, 53);
            this.rjButton3.TabIndex = 38;
            this.rjButton3.Text = "XÓA";
            this.rjButton3.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(181)))), ((int)(((byte)(242)))));
            this.rjButton3.UseVisualStyleBackColor = false;
            this.rjButton3.Click += new System.EventHandler(this.rjButton3_Click);
            // 
            // rjButton4
            // 
            this.rjButton4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(181)))), ((int)(((byte)(242)))));
            this.rjButton4.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(181)))), ((int)(((byte)(242)))));
            this.rjButton4.BorderColor = System.Drawing.Color.White;
            this.rjButton4.BorderRadius = 10;
            this.rjButton4.BorderSize = 2;
            this.rjButton4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rjButton4.FlatAppearance.BorderSize = 0;
            this.rjButton4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rjButton4.Font = new System.Drawing.Font("Roboto", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.rjButton4.ForeColor = System.Drawing.Color.White;
            this.rjButton4.Location = new System.Drawing.Point(519, 327);
            this.rjButton4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rjButton4.Name = "rjButton4";
            this.rjButton4.Size = new System.Drawing.Size(169, 53);
            this.rjButton4.TabIndex = 39;
            this.rjButton4.Text = "Thêm chi tiết";
            this.rjButton4.TextColor = System.Drawing.Color.White;
            this.rjButton4.UseVisualStyleBackColor = false;
            this.rjButton4.Click += new System.EventHandler(this.rjButton4_Click);
            // 
            // txtBoxSoluong
            // 
            this.txtBoxSoluong.BackColor = System.Drawing.SystemColors.Window;
            this.txtBoxSoluong.BorderColor = System.Drawing.Color.Black;
            this.txtBoxSoluong.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(181)))), ((int)(((byte)(242)))));
            this.txtBoxSoluong.BorderRadius = 0;
            this.txtBoxSoluong.BorderSize = 1;
            this.txtBoxSoluong.Font = new System.Drawing.Font("Roboto", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtBoxSoluong.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtBoxSoluong.Location = new System.Drawing.Point(604, 280);
            this.txtBoxSoluong.Margin = new System.Windows.Forms.Padding(4);
            this.txtBoxSoluong.Multiline = false;
            this.txtBoxSoluong.Name = "txtBoxSoluong";
            this.txtBoxSoluong.Padding = new System.Windows.Forms.Padding(11, 9, 11, 9);
            this.txtBoxSoluong.PasswordChar = false;
            this.txtBoxSoluong.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtBoxSoluong.PlaceholderText = "";
            this.txtBoxSoluong.Size = new System.Drawing.Size(205, 42);
            this.txtBoxSoluong.TabIndex = 40;
            this.txtBoxSoluong.Texts = "";
            this.txtBoxSoluong.UnderlinedStyle = false;
            // 
            // lv_nhapSach
            // 
            this.lv_nhapSach.BackColor = System.Drawing.Color.LightSteelBlue;
            this.lv_nhapSach.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.TenSach,
            this.TheLoai,
            this.TacGia,
            this.SoLuong,
            this.DonGia});
            this.lv_nhapSach.Font = new System.Drawing.Font("Roboto", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lv_nhapSach.FullRowSelect = true;
            this.lv_nhapSach.GridLines = true;
            this.lv_nhapSach.Location = new System.Drawing.Point(23, 387);
            this.lv_nhapSach.Name = "lv_nhapSach";
            this.lv_nhapSach.Size = new System.Drawing.Size(862, 309);
            this.lv_nhapSach.TabIndex = 42;
            this.lv_nhapSach.UseCompatibleStateImageBehavior = false;
            this.lv_nhapSach.View = System.Windows.Forms.View.Details;
            this.lv_nhapSach.SelectedIndexChanged += new System.EventHandler(this.lv_nhapSach_SelectedIndexChanged);
            // 
            // TenSach
            // 
            this.TenSach.Text = "Tên sách";
            this.TenSach.Width = 300;
            // 
            // TheLoai
            // 
            this.TheLoai.Text = "Thể loại";
            this.TheLoai.Width = 150;
            // 
            // TacGia
            // 
            this.TacGia.Text = "Tác giả";
            this.TacGia.Width = 180;
            // 
            // SoLuong
            // 
            this.SoLuong.Text = "Số Lượng";
            this.SoLuong.Width = 105;
            // 
            // DonGia
            // 
            this.DonGia.Text = "Đơn giá nhập";
            this.DonGia.Width = 123;
            // 
            // cboxXuat
            // 
            this.cboxXuat.AutoSize = true;
            this.cboxXuat.Font = new System.Drawing.Font("Roboto", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.cboxXuat.Location = new System.Drawing.Point(337, 768);
            this.cboxXuat.Name = "cboxXuat";
            this.cboxXuat.Size = new System.Drawing.Size(242, 31);
            this.cboxXuat.TabIndex = 43;
            this.cboxXuat.Text = "Xuất phiếu nhập sách";
            this.cboxXuat.UseVisualStyleBackColor = true;
            // 
            // Save
            // 
            this.Save.DefaultExt = "xlsx";
            this.Save.FileName = "TenPhieuNS";
            // 
            // txtBoxTensach
            // 
            this.txtBoxTensach.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtBoxTensach.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtBoxTensach.Font = new System.Drawing.Font("Roboto", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtBoxTensach.Location = new System.Drawing.Point(604, 59);
            this.txtBoxTensach.Name = "txtBoxTensach";
            this.txtBoxTensach.Size = new System.Drawing.Size(205, 30);
            this.txtBoxTensach.TabIndex = 44;
            // 
            // FormPhieunhapsach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(908, 808);
            this.Controls.Add(this.txtBoxTensach);
            this.Controls.Add(this.cboxXuat);
            this.Controls.Add(this.lv_nhapSach);
            this.Controls.Add(this.txtBoxSoluong);
            this.Controls.Add(this.rjButton4);
            this.Controls.Add(this.rjButton3);
            this.Controls.Add(this.rjButton2);
            this.Controls.Add(this.dtpNgay);
            this.Controls.Add(this.txtBoxDongianhap);
            this.Controls.Add(this.txtBoxTacgia);
            this.Controls.Add(this.txtBoxTheloai);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rjButton1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormPhieunhapsach";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormPhieunhapsach";
            this.Load += new System.EventHandler(this.FormPhieunhapsach_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Control.RJButton rjButton1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Control.RJTextBox txtBoxTheloai;
        private Control.RJTextBox txtBoxTacgia;
        private Control.RJTextBox txtBoxDongianhap;
        private DateTimePicker dtpNgay;
        private Control.RJButton rjButton2;
        private Control.RJButton rjButton3;
        private Control.RJButton rjButton4;
        private Control.RJTextBox txtBoxSoluong;
        private ListView lv_nhapSach;
        private ColumnHeader TenSach;
        private ColumnHeader TheLoai;
        private ColumnHeader TacGia;
        private ColumnHeader SoLuong;
        private ColumnHeader DonGia;
        private CheckBox cboxXuat;
        private SaveFileDialog Save;
        private TextBox txtBoxTensach;
    }
}