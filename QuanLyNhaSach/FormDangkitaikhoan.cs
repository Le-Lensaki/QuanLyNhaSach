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
    public partial class FormDangkitaikhoan : Form
    {
        ComboBox cur;
        public FormDangkitaikhoan()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void rjButton1_Click(object sender, EventArgs e)
        {
            string selected = ""; //Chức vụ
            if (cur != null)
            {
                selected = cur.Text;
            }
            if (txtBoxHoten.Texts != "" && txtBoxMatkhau.Texts != "" && txtBoxNhaplaimatkhau.Texts != "" && txtBoxTentk.Texts != "" && selected != "")
            {
                bool isExist = false; //Cần kiểm tra tên tài khoản có trong database chưa, tồn tại rồi thì true, không thì false

                Globals.sqlcon.Open();
                string query = "select * from ADMINISTRATORS where username = '" + txtBoxTentk.Texts + "'";
                SqlDataAdapter sda = new SqlDataAdapter(query, Globals.sqlcon);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                Globals.sqlcon.Close();

                if (dt.Rows.Count != 0) isExist = true;
                if (!isExist && txtBoxMatkhau.Texts == txtBoxNhaplaimatkhau.Texts)
                {
                    //Thêm vào DATABASE
                    string transact = @"insert into ADMINISTRATORS values(@hoten, @username, @password, @role)";
                    SqlCommand cmd = new SqlCommand(transact, Globals.sqlcon);
                    cmd.Parameters.AddWithValue("@hoten", txtBoxHoten.Texts);
                    cmd.Parameters.AddWithValue("@username", txtBoxTentk.Texts);
                    cmd.Parameters.AddWithValue("@password", txtBoxMatkhau.Texts);
                    cmd.Parameters.AddWithValue("@role", cbBoxChucVu.SelectedItem.ToString());
                    cmd.Connection.Open();
                    cmd.ExecuteNonQuery();

                    cmd.Connection.Close();

                    MessageBox.Show("Đăng kí tài khoản thành công!");
                    this.Dispose();
                }
                else
                {
                    if (isExist)
                    {
                        MessageBox.Show("Tên tài khoản đã tồn tại!");
                    }
                    else
                    {
                        MessageBox.Show("Mật khẩu đã nhập không khớp với nhau!");
                    }
                }
            }
            else
            {
                MessageBox.Show("Cần nhập tất các các mục!");
            }
        }

        private void rjButton2_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void rjTextBox1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void rjComboBox1_OnSelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void rjTextBox4_Load(object sender, EventArgs e)
        {

        }

        private void rjButton3_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void cbBoxChucVu_OnSelectedIndexChanged(object sender, EventArgs e)
        {
            cur = sender as ComboBox;
        }
    }
}
