using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using QuanLyNhaSach.Control;

namespace QuanLyNhaSach
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }



        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {
            Globals.status = 0;
            panel1.BackColor = Color.FromArgb(100, 255, 255, 255);
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void rjTextBox1_Load_1(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void rjButton2_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void rjButton1_Click(object sender, EventArgs e)
        {
            Globals.sqlcon.Open();
            string query = "Select * from ADMINISTRATORS where username = '" + txtTaikhoan.Texts + "' and password = '" + rjTextBox2.Texts + "'";
            // Create adapter
            SqlDataAdapter sda = new SqlDataAdapter(query, Globals.sqlcon);
            DataTable dtb1 = new DataTable();
            // Fill the table with whichever entry in the DB fits the criteria of: having the username put in the txtUsername.Text
            // and password from txtPassword.Text
            sda.Fill(dtb1);
            Globals.sqlcon.Close();
            // If there is 1 element (a match has been found), allow access
            if (dtb1.Rows.Count == 1)
            {
                Globals.status = 2;
                Globals.name = dtb1.Rows[0].Field<string>(0);
                Globals.role = dtb1.Rows[0].Field<string>(3);
                Globals.username = dtb1.Rows[0].Field<string>(1);

                Close();

            }
            // If incorrect, don't allow access
            else
            {
                MessageBox.Show("Sai mật khẩu hoặc tên đăng nhập không tồn tại");
            }

        }

        private void rjTextBox2_Load(object sender, EventArgs e)
        {

        }
    }
}