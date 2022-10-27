using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyNhaSach
{
    public partial class FormDoimatkhau : Form
    {
        public FormDoimatkhau()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void rjButton1_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void rjButton2_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void rjTextBox1_Load(object sender, EventArgs e)
        {

        }

        private void rjButton3_Click(object sender, EventArgs e)
        {
            if (txtBoxMKCu.Texts == "" || txtBoxMatkhau.Texts == "" || txtBoxNhaplaimatkhau.Texts == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ các trường", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (txtBoxMatkhau.Texts != txtBoxNhaplaimatkhau.Texts)
            {
                MessageBox.Show("Mật khẩu không khớp", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            Globals.sqlcon.Open();
            using (SqlCommand command = Globals.sqlcon.CreateCommand())
            {
                command.CommandText = "update ADMINISTRATORS " +
                    "set PASSWORD = '" + txtBoxMatkhau.Texts + "' where USERNAME = '" + Globals.username + "'";
                command.ExecuteNonQuery();
            }
            Globals.sqlcon.Close();
            MessageBox.Show("Thay đổi mật khẩu thành công", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Dispose();
        }
    }
}
