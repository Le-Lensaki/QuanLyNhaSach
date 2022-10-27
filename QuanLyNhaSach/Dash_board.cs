using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyNhaSach.Control;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace QuanLyNhaSach
{
    public partial class Dash_board : Form
    {
        public bool logOut = true;

        public Dash_board()
        {
            InitializeComponent();
        }

        private void Dash_board_Load(object sender, EventArgs e)
        {
            Globals.status = 0;
            logOut = false;
            lblWelcome.Text += Globals.name;
            lblRole.Text += Globals.role;

            // Kiểm tra các quy định
            Globals.sqlcon.Open();
            string query = "select * from THAMSO";
            SqlDataAdapter sda = new SqlDataAdapter(query, Globals.sqlcon);
            DataTable thamso = new DataTable();
            sda.Fill(thamso);
            Globals.sqlcon.Close();

            Globals.Slmin = thamso.Rows[0].Field<int>("LuongNhapItNhat");
            Globals.Tonbanmin = thamso.Rows[0].Field<int>("LuongTonToiThieu");
            Globals.Luongtonmax = thamso.Rows[0].Field<int>("LuongTonToiDa");
            Globals.Nomax = thamso.Rows[0].Field<int>("NoToiDa");
            Globals.tienthuvuottienno = thamso.Rows[0].Field<bool>("KiemTraSoTienThu");

          
            if (Globals.role == "Nhân viên bán hàng") Unable_button(btnNhansu);
            if (Globals.role == "Thủ kho") Unable_button(btnNhansu);
            if (Globals.role == "Thủ kho") Unable_button(btnThaydoiqd);
            if (Globals.role == "Nhân viên bán hàng") Unable_button(btnThaydoiqd);
            if (Globals.role == "Thủ kho") Unable_button(btnHoadon);
        }
        private void AddControltoPanel(UserControl c)
        {
            lbHien.Controls.Clear();
            lbHien.Controls.Add(c);
        }
        private void moveSidePanel(RJButton btn)
        {
            panelSide.Top = btn.Top;
            panelSide.Height = btn.Height;

        }
        private void btnHoadon_Click(object sender, EventArgs e)
        {
            moveSidePanel(btnHoadon);
            UC_Hoadon uchd = new UC_Hoadon();
            AddControltoPanel(uchd);
        }

        private void btnNhansu_Click(object sender, EventArgs e)
        {
            moveSidePanel(btnNhansu);
            UC_Nhansu ucns = new UC_Nhansu();
            AddControltoPanel(ucns);
        }

        private void rjButton6_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }


        private void lbDoiThongTin_Click(object sender, EventArgs e)
        {

        }


        private void btnTraCuu_Click(object sender, EventArgs e)
        {
            moveSidePanel(btnTraCuu);
            UC_Tracuu uctc = new UC_Tracuu();
            AddControltoPanel(uctc);
        }


        private void btnKhachhang_Click(object sender, EventArgs e)
        {
            moveSidePanel(btnKhachhang);
            UC_Khachhang uckh = new UC_Khachhang();
            AddControltoPanel(uckh);
        }

        private void btnBaoCao_Click(object sender, EventArgs e)
        {
            moveSidePanel(btnBaoCao);
            UC_Baocao ucbc = new UC_Baocao();
            AddControltoPanel(ucbc);
        }

        private void btnThaydoiqd_Click(object sender, EventArgs e)
        {
            moveSidePanel(btnThaydoiqd);
            lbHien.Controls.Clear();
            FormThaydoiquydinh tdqd = new FormThaydoiquydinh();
            tdqd.ShowDialog();
        }

        private void lbDoimk_Click(object sender, EventArgs e)
        {
            FormDoimatkhau dmk = new FormDoimatkhau();
            dmk.ShowDialog();
        }
        private void Unable_button(Button b)
        {
            b.Enabled = false;
            Color cl = Color.FromName("Gray");
            b.ForeColor = cl;
        }

        private void lbDangxuat_Click(object sender, EventArgs e)
        {
            Globals.status = 1;
            Close();
        }

        private void lbHien_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
