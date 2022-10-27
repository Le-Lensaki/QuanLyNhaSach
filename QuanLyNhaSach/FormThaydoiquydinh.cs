using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace QuanLyNhaSach
{
    public partial class FormThaydoiquydinh : Form
    {
        public FormThaydoiquydinh()
        {
            InitializeComponent();
        }
        private bool isEmpty()
        {
            if (txtBoxNomax.TextLength == 0)
            {
                return false;
            }
            if (txtBoxSlmin.TextLength == 0)
            {
                return false;
            }
            if (txtLuongtonmax.TextLength == 0)
            {
                return false;
            }
            if (txtBoxTonbanmin.TextLength == 0)
            {
                return false;
            }
            return true;
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void rjButton2_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void rjButton1_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void rjButton3_Click(object sender, EventArgs e)
        {
            if (!isEmpty())
            {
                MessageBox.Show("Nhập tất cả các mục còn trống");
            }
            else
            {
                DialogResult dialogResult = MessageBox.Show("Bạn có chắc chắn?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dialogResult == DialogResult.Yes)
                {
                    Globals.Slmin = int.Parse(txtBoxSlmin.Text);
                    Globals.Luongtonmax = int.Parse(txtLuongtonmax.Text);
                    Globals.Nomax = int.Parse(txtBoxNomax.Text);
                    Globals.Tonbanmin = int.Parse(txtBoxTonbanmin.Text);
                    if (cbVuotTienNo.CheckState == CheckState.Checked) Globals.tienthuvuottienno = true;
                    else Globals.tienthuvuottienno = false;

                    //Ghi vào DATABASE;
                    using (SqlConnection con = new SqlConnection(Globals.sqlcon.ConnectionString))
                    using (SqlCommand command = con.CreateCommand())
                    {
                        command.CommandText = "update THAMSO " +
                            "set LuongNhapItNhat = @Slmin, LuongTonToiDa = @Luongtonmax, NoToiDa = @Nomax, LuongTonToiThieu = @Tonbanmin, KiemTraSoTienThu = @Vuottienthu";
                        command.Parameters.AddWithValue("@Slmin", Globals.Slmin.ToString());
                        command.Parameters.AddWithValue("@Luongtonmax", Globals.Luongtonmax.ToString());
                        command.Parameters.AddWithValue("@Nomax", Globals.Nomax.ToString());
                        command.Parameters.AddWithValue("@Tonbanmin", Globals.Tonbanmin.ToString());
                        if (Globals.tienthuvuottienno) command.Parameters.AddWithValue("@Vuottienthu", "1");
                        else command.Parameters.AddWithValue("@Vuottienthu", "0");

                        con.Open();
                        command.ExecuteNonQuery();
                        con.Close();
                    }

                    this.Dispose();
                }

            }
        }

        private void FormThaydoiquydinh_Load(object sender, EventArgs e)
        {
            txtBoxSlmin.Text = Globals.Slmin.ToString();
            txtLuongtonmax.Text = Globals.Luongtonmax.ToString();
            txtBoxNomax.Text = Globals.Nomax.ToString();
            txtBoxTonbanmin.Text = Globals.Tonbanmin.ToString();
            if (Globals.tienthuvuottienno) cbVuotTienNo.CheckState = CheckState.Checked;
            else cbVuotTienNo.CheckState = CheckState.Unchecked;
        }

        private void txtBoxSlmin_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtLuongtonmax_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtBoxTonbanmin_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtBoxNomax_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
