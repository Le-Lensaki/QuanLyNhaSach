namespace QuanLyNhaSach
{
    partial class FormThaydoiquydinh
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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtBoxNomax = new System.Windows.Forms.TextBox();
            this.txtLuongtonmax = new System.Windows.Forms.TextBox();
            this.txtBoxSlmin = new System.Windows.Forms.TextBox();
            this.txtBoxTonbanmin = new System.Windows.Forms.TextBox();
            this.cbVuotTienNo = new System.Windows.Forms.CheckBox();
            this.rjButton1 = new QuanLyNhaSach.Control.RJButton();
            this.rjButton3 = new QuanLyNhaSach.Control.RJButton();
            this.label7 = new System.Windows.Forms.Label();
            this.rjButton2 = new QuanLyNhaSach.Control.RJButton();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Roboto", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(181)))), ((int)(((byte)(242)))));
            this.label2.Location = new System.Drawing.Point(111, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(219, 27);
            this.label2.TabIndex = 15;
            this.label2.Text = "Số lượng nhập ít nhất";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Roboto", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(181)))), ((int)(((byte)(242)))));
            this.label1.Location = new System.Drawing.Point(111, 145);
            this.label1.MaximumSize = new System.Drawing.Size(286, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(248, 54);
            this.label1.TabIndex = 16;
            this.label1.Text = "Chỉ nhập các sách có số lượng tồn ít hơn";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Roboto", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(181)))), ((int)(((byte)(242)))));
            this.label3.Location = new System.Drawing.Point(111, 306);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(269, 27);
            this.label3.TabIndex = 17;
            this.label3.Text = "Khách hàng nợ không quá ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Roboto", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(181)))), ((int)(((byte)(242)))));
            this.label4.Location = new System.Drawing.Point(111, 236);
            this.label4.MaximumSize = new System.Drawing.Size(286, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(250, 54);
            this.label4.TabIndex = 18;
            this.label4.Text = "Lượng tồn sau khi bán ít nhất";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Roboto", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.Color.Navy;
            this.label5.Location = new System.Drawing.Point(111, 209);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(130, 27);
            this.label5.TabIndex = 19;
            this.label5.Text = "2.  Bán sách";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Roboto", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(70)))), ((int)(((byte)(155)))));
            this.label6.Location = new System.Drawing.Point(111, 62);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(149, 27);
            this.label6.TabIndex = 20;
            this.label6.Text = "1.  Nhập sách ";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // txtBoxNomax
            // 
            this.txtBoxNomax.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtBoxNomax.Location = new System.Drawing.Point(415, 301);
            this.txtBoxNomax.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtBoxNomax.Multiline = true;
            this.txtBoxNomax.Name = "txtBoxNomax";
            this.txtBoxNomax.Size = new System.Drawing.Size(205, 32);
            this.txtBoxNomax.TabIndex = 21;
            this.txtBoxNomax.Text = "20000";
            this.txtBoxNomax.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBoxNomax_KeyPress);
            // 
            // txtLuongtonmax
            // 
            this.txtLuongtonmax.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtLuongtonmax.Location = new System.Drawing.Point(415, 146);
            this.txtLuongtonmax.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtLuongtonmax.Multiline = true;
            this.txtLuongtonmax.Name = "txtLuongtonmax";
            this.txtLuongtonmax.Size = new System.Drawing.Size(205, 32);
            this.txtLuongtonmax.TabIndex = 22;
            this.txtLuongtonmax.Text = "300";
            this.txtLuongtonmax.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            this.txtLuongtonmax.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtLuongtonmax_KeyPress);
            // 
            // txtBoxSlmin
            // 
            this.txtBoxSlmin.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtBoxSlmin.Location = new System.Drawing.Point(415, 103);
            this.txtBoxSlmin.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtBoxSlmin.Multiline = true;
            this.txtBoxSlmin.Name = "txtBoxSlmin";
            this.txtBoxSlmin.Size = new System.Drawing.Size(205, 32);
            this.txtBoxSlmin.TabIndex = 23;
            this.txtBoxSlmin.Text = "150";
            this.txtBoxSlmin.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBoxSlmin_KeyPress);
            // 
            // txtBoxTonbanmin
            // 
            this.txtBoxTonbanmin.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtBoxTonbanmin.Location = new System.Drawing.Point(415, 237);
            this.txtBoxTonbanmin.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtBoxTonbanmin.Multiline = true;
            this.txtBoxTonbanmin.Name = "txtBoxTonbanmin";
            this.txtBoxTonbanmin.Size = new System.Drawing.Size(205, 32);
            this.txtBoxTonbanmin.TabIndex = 24;
            this.txtBoxTonbanmin.Text = "20";
            this.txtBoxTonbanmin.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBoxTonbanmin_KeyPress);
            // 
            // cbVuotTienNo
            // 
            this.cbVuotTienNo.AutoSize = true;
            this.cbVuotTienNo.Checked = true;
            this.cbVuotTienNo.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbVuotTienNo.Font = new System.Drawing.Font("Roboto", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.cbVuotTienNo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(181)))), ((int)(((byte)(242)))));
            this.cbVuotTienNo.Location = new System.Drawing.Point(111, 354);
            this.cbVuotTienNo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbVuotTienNo.MaximumSize = new System.Drawing.Size(571, 40);
            this.cbVuotTienNo.Name = "cbVuotTienNo";
            this.cbVuotTienNo.Size = new System.Drawing.Size(537, 31);
            this.cbVuotTienNo.TabIndex = 33;
            this.cbVuotTienNo.Text = "Số tiền không vượt quá số tiền khách hàng đang nợ ";
            this.cbVuotTienNo.UseVisualStyleBackColor = true;
            // 
            // rjButton1
            // 
            this.rjButton1.BackColor = System.Drawing.Color.White;
            this.rjButton1.BackgroundColor = System.Drawing.Color.White;
            this.rjButton1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(181)))), ((int)(((byte)(242)))));
            this.rjButton1.BorderRadius = 10;
            this.rjButton1.BorderSize = 2;
            this.rjButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rjButton1.FlatAppearance.BorderSize = 0;
            this.rjButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rjButton1.Font = new System.Drawing.Font("Roboto", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.rjButton1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(181)))), ((int)(((byte)(242)))));
            this.rjButton1.Location = new System.Drawing.Point(91, 413);
            this.rjButton1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rjButton1.Name = "rjButton1";
            this.rjButton1.Size = new System.Drawing.Size(169, 53);
            this.rjButton1.TabIndex = 35;
            this.rjButton1.Text = "HUỶ";
            this.rjButton1.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(181)))), ((int)(((byte)(242)))));
            this.rjButton1.UseVisualStyleBackColor = false;
            this.rjButton1.Click += new System.EventHandler(this.rjButton1_Click);
            // 
            // rjButton3
            // 
            this.rjButton3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(181)))), ((int)(((byte)(242)))));
            this.rjButton3.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(181)))), ((int)(((byte)(242)))));
            this.rjButton3.BorderColor = System.Drawing.Color.White;
            this.rjButton3.BorderRadius = 10;
            this.rjButton3.BorderSize = 2;
            this.rjButton3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rjButton3.FlatAppearance.BorderSize = 0;
            this.rjButton3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rjButton3.Font = new System.Drawing.Font("Roboto", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.rjButton3.ForeColor = System.Drawing.Color.White;
            this.rjButton3.Location = new System.Drawing.Point(479, 413);
            this.rjButton3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rjButton3.Name = "rjButton3";
            this.rjButton3.Size = new System.Drawing.Size(169, 53);
            this.rjButton3.TabIndex = 36;
            this.rjButton3.Text = "HOÀN TẤT";
            this.rjButton3.TextColor = System.Drawing.Color.White;
            this.rjButton3.UseVisualStyleBackColor = false;
            this.rjButton3.Click += new System.EventHandler(this.rjButton3_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(181)))), ((int)(((byte)(242)))));
            this.label7.Location = new System.Drawing.Point(263, 13);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(233, 33);
            this.label7.TabIndex = 37;
            this.label7.Text = "Thay đổi quy định";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // rjButton2
            // 
            this.rjButton2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(181)))), ((int)(((byte)(242)))));
            this.rjButton2.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(181)))), ((int)(((byte)(242)))));
            this.rjButton2.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.rjButton2.BorderRadius = 0;
            this.rjButton2.BorderSize = 0;
            this.rjButton2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rjButton2.FlatAppearance.BorderSize = 0;
            this.rjButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rjButton2.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rjButton2.ForeColor = System.Drawing.Color.White;
            this.rjButton2.Location = new System.Drawing.Point(743, 0);
            this.rjButton2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rjButton2.Name = "rjButton2";
            this.rjButton2.Size = new System.Drawing.Size(57, 57);
            this.rjButton2.TabIndex = 38;
            this.rjButton2.Text = "X";
            this.rjButton2.TextColor = System.Drawing.Color.White;
            this.rjButton2.UseVisualStyleBackColor = false;
            this.rjButton2.Click += new System.EventHandler(this.rjButton2_Click);
            // 
            // FormThaydoiquydinh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 493);
            this.Controls.Add(this.rjButton2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.rjButton3);
            this.Controls.Add(this.rjButton1);
            this.Controls.Add(this.cbVuotTienNo);
            this.Controls.Add(this.txtBoxTonbanmin);
            this.Controls.Add(this.txtBoxSlmin);
            this.Controls.Add(this.txtLuongtonmax);
            this.Controls.Add(this.txtBoxNomax);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FormThaydoiquydinh";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormThaydoiquydinh";
            this.Load += new System.EventHandler(this.FormThaydoiquydinh_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label2;
        private Label label1;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox txtBoxNomax;
        private TextBox txtLuongtonmax;
        private TextBox txtBoxSlmin;
        private TextBox txtBoxTonbanmin;
        private CheckBox cbVuotTienNo;
        private Control.RJButton rjButton1;
        private Control.RJButton rjButton3;
        private Label label7;
        private Control.RJButton rjButton2;
    }
}