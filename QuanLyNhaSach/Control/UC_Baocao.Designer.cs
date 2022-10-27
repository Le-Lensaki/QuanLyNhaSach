namespace QuanLyNhaSach.Control
{
    partial class UC_Baocao
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_Baocao));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.rjButton4 = new QuanLyNhaSach.Control.RJButton();
            this.dtpThangNam = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.rjButton2 = new QuanLyNhaSach.Control.RJButton();
            this.rjButton1 = new QuanLyNhaSach.Control.RJButton();
            this.dgvCongno = new System.Windows.Forms.DataGridView();
            this.STT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenKH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NoDau = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PhatSinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NoCuoi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvTon = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chonDuongDan = new System.Windows.Forms.SaveFileDialog();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCongno)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTon)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1071, 10);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 671);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1071, 10);
            this.panel2.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(1061, 10);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(10, 661);
            this.panel3.TabIndex = 2;
            // 
            // panel4
            // 
            this.panel4.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel4.Location = new System.Drawing.Point(0, 10);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(10, 661);
            this.panel4.TabIndex = 3;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(181)))), ((int)(((byte)(242)))));
            this.panel5.Controls.Add(this.rjButton4);
            this.panel5.Controls.Add(this.dtpThangNam);
            this.panel5.Controls.Add(this.label2);
            this.panel5.Controls.Add(this.rjButton2);
            this.panel5.Controls.Add(this.rjButton1);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(10, 10);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1051, 114);
            this.panel5.TabIndex = 4;
            this.panel5.Paint += new System.Windows.Forms.PaintEventHandler(this.panel5_Paint);
            // 
            // rjButton4
            // 
            this.rjButton4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(185)))), ((int)(((byte)(129)))));
            this.rjButton4.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(185)))), ((int)(((byte)(129)))));
            this.rjButton4.BorderColor = System.Drawing.Color.White;
            this.rjButton4.BorderRadius = 8;
            this.rjButton4.BorderSize = 3;
            this.rjButton4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rjButton4.FlatAppearance.BorderSize = 0;
            this.rjButton4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rjButton4.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.rjButton4.ForeColor = System.Drawing.Color.White;
            this.rjButton4.Image = ((System.Drawing.Image)(resources.GetObject("rjButton4.Image")));
            this.rjButton4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.rjButton4.Location = new System.Drawing.Point(869, 15);
            this.rjButton4.Name = "rjButton4";
            this.rjButton4.Padding = new System.Windows.Forms.Padding(5);
            this.rjButton4.Size = new System.Drawing.Size(179, 73);
            this.rjButton4.TabIndex = 70;
            this.rjButton4.Text = "          Xuất Excel";
            this.rjButton4.TextColor = System.Drawing.Color.White;
            this.rjButton4.UseVisualStyleBackColor = false;
            this.rjButton4.Click += new System.EventHandler(this.rjButton4_Click);
            // 
            // dtpThangNam
            // 
            this.dtpThangNam.CustomFormat = "MM/yyyy";
            this.dtpThangNam.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpThangNam.Location = new System.Drawing.Point(658, 48);
            this.dtpThangNam.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dtpThangNam.Name = "dtpThangNam";
            this.dtpThangNam.Size = new System.Drawing.Size(205, 32);
            this.dtpThangNam.TabIndex = 69;
            this.dtpThangNam.Value = new System.DateTime(2022, 1, 6, 0, 0, 0, 0);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Roboto", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(532, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 27);
            this.label2.TabIndex = 68;
            this.label2.Text = "Tháng/Năm";
            // 
            // rjButton2
            // 
            this.rjButton2.BackColor = System.Drawing.Color.RoyalBlue;
            this.rjButton2.BackgroundColor = System.Drawing.Color.RoyalBlue;
            this.rjButton2.BorderColor = System.Drawing.Color.White;
            this.rjButton2.BorderRadius = 8;
            this.rjButton2.BorderSize = 3;
            this.rjButton2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rjButton2.FlatAppearance.BorderSize = 0;
            this.rjButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rjButton2.Font = new System.Drawing.Font("Roboto", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.rjButton2.ForeColor = System.Drawing.Color.White;
            this.rjButton2.Image = ((System.Drawing.Image)(resources.GetObject("rjButton2.Image")));
            this.rjButton2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.rjButton2.Location = new System.Drawing.Point(274, 15);
            this.rjButton2.Name = "rjButton2";
            this.rjButton2.Padding = new System.Windows.Forms.Padding(5);
            this.rjButton2.Size = new System.Drawing.Size(237, 74);
            this.rjButton2.TabIndex = 67;
            this.rjButton2.Text = "         Báo cáo công nợ";
            this.rjButton2.TextColor = System.Drawing.Color.White;
            this.rjButton2.UseVisualStyleBackColor = false;
            this.rjButton2.Click += new System.EventHandler(this.rjButton2_Click);
            // 
            // rjButton1
            // 
            this.rjButton1.BackColor = System.Drawing.Color.RoyalBlue;
            this.rjButton1.BackgroundColor = System.Drawing.Color.RoyalBlue;
            this.rjButton1.BorderColor = System.Drawing.Color.White;
            this.rjButton1.BorderRadius = 8;
            this.rjButton1.BorderSize = 3;
            this.rjButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rjButton1.FlatAppearance.BorderSize = 0;
            this.rjButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rjButton1.Font = new System.Drawing.Font("Roboto", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.rjButton1.ForeColor = System.Drawing.Color.White;
            this.rjButton1.Image = ((System.Drawing.Image)(resources.GetObject("rjButton1.Image")));
            this.rjButton1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.rjButton1.Location = new System.Drawing.Point(18, 15);
            this.rjButton1.Name = "rjButton1";
            this.rjButton1.Padding = new System.Windows.Forms.Padding(5);
            this.rjButton1.Size = new System.Drawing.Size(238, 74);
            this.rjButton1.TabIndex = 66;
            this.rjButton1.Text = "     Báo cáo tồn";
            this.rjButton1.TextColor = System.Drawing.Color.White;
            this.rjButton1.UseVisualStyleBackColor = false;
            this.rjButton1.Click += new System.EventHandler(this.rjButton1_Click);
            // 
            // dgvCongno
            // 
            this.dgvCongno.AllowUserToAddRows = false;
            this.dgvCongno.AllowUserToDeleteRows = false;
            this.dgvCongno.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.dgvCongno.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCongno.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.STT,
            this.TenKH,
            this.NoDau,
            this.PhatSinh,
            this.NoCuoi});
            this.dgvCongno.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvCongno.Location = new System.Drawing.Point(10, 124);
            this.dgvCongno.Name = "dgvCongno";
            this.dgvCongno.RowHeadersWidth = 51;
            this.dgvCongno.RowTemplate.Height = 29;
            this.dgvCongno.Size = new System.Drawing.Size(1051, 547);
            this.dgvCongno.TabIndex = 5;
            this.dgvCongno.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dgvCongno.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.dgvCongno_RowPostPaint);
            // 
            // STT
            // 
            this.STT.HeaderText = "STT";
            this.STT.MinimumWidth = 6;
            this.STT.Name = "STT";
            this.STT.Width = 80;
            // 
            // TenKH
            // 
            this.TenKH.DataPropertyName = "TenKH";
            this.TenKH.HeaderText = "Khách hàng";
            this.TenKH.MinimumWidth = 6;
            this.TenKH.Name = "TenKH";
            this.TenKH.Width = 300;
            // 
            // NoDau
            // 
            this.NoDau.DataPropertyName = "NoDau";
            this.NoDau.HeaderText = "Nợ đầu";
            this.NoDau.MinimumWidth = 6;
            this.NoDau.Name = "NoDau";
            this.NoDau.Width = 210;
            // 
            // PhatSinh
            // 
            this.PhatSinh.DataPropertyName = "PhatSinh";
            this.PhatSinh.HeaderText = "Phát sinh";
            this.PhatSinh.MinimumWidth = 6;
            this.PhatSinh.Name = "PhatSinh";
            this.PhatSinh.Width = 210;
            // 
            // NoCuoi
            // 
            this.NoCuoi.DataPropertyName = "NoCuoi";
            this.NoCuoi.HeaderText = "Nợ Cuối";
            this.NoCuoi.MinimumWidth = 6;
            this.NoCuoi.Name = "NoCuoi";
            this.NoCuoi.Width = 198;
            // 
            // dgvTon
            // 
            this.dgvTon.AllowUserToAddRows = false;
            this.dgvTon.AllowUserToDeleteRows = false;
            this.dgvTon.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.dgvTon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTon.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.dgvTon.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvTon.Location = new System.Drawing.Point(10, 124);
            this.dgvTon.Name = "dgvTon";
            this.dgvTon.RowHeadersWidth = 51;
            this.dgvTon.RowTemplate.Height = 29;
            this.dgvTon.Size = new System.Drawing.Size(1051, 547);
            this.dgvTon.TabIndex = 6;
            this.dgvTon.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTon_CellContentClick);
            this.dgvTon.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.dgvTon_RowPostPaint);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "STT";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 80;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "TenSach";
            this.dataGridViewTextBoxColumn2.HeaderText = "Sách";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 300;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "TonDau";
            this.dataGridViewTextBoxColumn3.HeaderText = "Tồn đầu";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 210;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "TonPhatSinh";
            this.dataGridViewTextBoxColumn4.HeaderText = "Phát sinh";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 210;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "TonCuoi";
            this.dataGridViewTextBoxColumn5.HeaderText = "Tồn Cuối";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Width = 198;
            // 
            // chonDuongDan
            // 
            this.chonDuongDan.DefaultExt = "xlsx";
            this.chonDuongDan.FileName = "Tenfilebaocao";
            // 
            // UC_Baocao
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.dgvTon);
            this.Controls.Add(this.dgvCongno);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Name = "UC_Baocao";
            this.Size = new System.Drawing.Size(1071, 681);
            this.Load += new System.EventHandler(this.UC_Baocao_Load);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCongno)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTon)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private Panel panel4;
        private Panel panel5;
        private RJButton rjButton2;
        private RJButton rjButton1;
        private DateTimePicker dtpThangNam;
        private Label label2;
        private RJButton rjButton4;
        private DataGridView dgvCongno;
        private DataGridView dgvTon;
        private DataGridViewTextBoxColumn STT;
        private DataGridViewTextBoxColumn TenKH;
        private DataGridViewTextBoxColumn NoDau;
        private DataGridViewTextBoxColumn PhatSinh;
        private DataGridViewTextBoxColumn NoCuoi;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private SaveFileDialog chonDuongDan;
    }
}
