using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Linq;

namespace QuanLyNhaSach.Control
{
    public partial class UC_Hoadon : UserControl
    {

        DataSet sach;
        DataView dv;
        bool dontHandle = false;
        int tongTien, maHD;
        DialogResult taotaikhoan;
        string diachi, email;

        public List<cSach> CSachList(DataTable dt)
        {
            List<cSach> sachList = new List<cSach>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                cSach csach = new cSach();
                csach.MaSach = dt.Rows[i]["MaSach"].ToString();
                csach.TenSach = dt.Rows[i]["TenSach"].ToString();
                csach.TheLoai = dt.Rows[i]["TheLoai"].ToString();
                csach.TacGia = dt.Rows[i]["TacGia"].ToString();
                csach.SoLuong = Convert.ToInt32(dt.Rows[i]["SoLuong"]);
                csach.DonGiaNhap = Convert.ToInt32(dt.Rows[i]["DonGiaNhap"]);
                sachList.Add(csach);
            }
            return sachList;
        }

        public class cSach
        {
            public string MaSach { get; set; }
            public string TenSach { get; set; }
            public string TheLoai { get; set; }
            public string TacGia { get; set; }
            public int SoLuong { get; set; }
            public int DonGiaNhap { get; set; }
        }
        public UC_Hoadon()
        {
            InitializeComponent();
            dtpNgay.Value = System.DateTime.Now;

            dtpNgay.MaxDate = System.DateTime.Now;
            txtBoxSodienthoai.GotFocus += txtBoxSodienthoai_GotFocus;
        }

        private void UC_Hoadon_Load(object sender, EventArgs e)
        {
            Globals.sqlcon.Open();
            string query = "select MaSach, TenSach, TheLoai, TacGia, SoLuong, DonGiaNhap from SACH where SoLuong > 0";
            SqlCommand com = new SqlCommand(query, Globals.sqlcon);
            com.CommandType = CommandType.Text;
            SqlDataAdapter sda = new SqlDataAdapter(com);
            sach = new DataSet();
            sda.Fill(sach, "Sach_Details");
            Globals.sqlcon.Close();

            cbTenSach.DataSource = CSachList(sach.Tables[0]);
            cbTenSach.DisplayMember = "TenSach";
            cbTenSach.ValueMember = "MaSach";
            cbTenSach.SelectedIndex = -1;

            cbTheLoai.Items.Add("Tất cả");
            cbTacGia.Items.Add("Tất cả");
            for (int i = 0; i < sach.Tables[0].Rows.Count; ++i)
            {
                var val = sach.Tables[0].Rows[i]["TheLoai"].ToString();

                if (!cbTheLoai.Items.Contains(val))
                    cbTheLoai.Items.Add(val);
            }

            for (int i = 0; i < sach.Tables[0].Rows.Count; ++i)
            {
                var val = sach.Tables[0].Rows[i]["TacGia"].ToString();

                if (!cbTacGia.Items.Contains(val))
                    cbTacGia.Items.Add(val);
            }

            

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel10_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void rjTextBox1_Load(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void panel11_Paint(object sender, PaintEventArgs e)
        {

        }
        private void txtBoxSodienthoai_GotFocus(object sender, EventArgs e)
        {
            Globals.sqlcon.Open();
            using (SqlCommand command = Globals.sqlcon.CreateCommand())
            {
                command.CommandText = "select DienThoai from KHACHHANG where TenKH = N'" + txtBoxHoten.Texts + "'";
                SqlDataReader dr = command.ExecuteReader();
                if (dr.Read())
                    txtBoxSodienthoai.Text = dr[0].ToString();
            }
            Globals.sqlcon.Close();
        }

        private void txtBoxHoten_KeyPress(object sender, KeyPressEventArgs e)
        {
            lblCheck.Visible = false;
        }

        private void txtBoxSodienthoai_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void cbTheLoai_OnSelectedIndexChanged(object sender, EventArgs e)
        {
            if (dontHandle) return;
            string expr = "";
            if (cbTheLoai.SelectedItem.ToString() != "Tất cả")
                expr += "TheLoai = '" + cbTheLoai.SelectedItem.ToString() + "' AND ";
            if (cbTacGia.SelectedItem != null && cbTacGia.SelectedItem.ToString() != "Tất cả")
                expr += "TacGia = '" + cbTacGia.SelectedItem.ToString() + "' AND ";
            if (expr.Length != 0)
                expr = expr.Substring(0, expr.Length - 5);
            cbTenSach.SelectedItem = null;

            dv = new DataView(sach.Tables[0])
            {
                RowFilter = expr
            };
            cbTenSach.DataSource = dv.ToTable().Rows.Cast<DataRow>().Select(r => new cSach
            {
                MaSach = r["MaSach"].ToString(),
                TenSach = r["TenSach"].ToString(),
                TheLoai = r["TheLoai"].ToString(),
                TacGia = r["TacGia"].ToString(),
                SoLuong = r.Field<int>("SoLuong"),
                DonGiaNhap = r.Field<int>("DonGiaNhap")
            })
            .ToList<cSach>();
            cbTenSach.SelectedIndex = -1;
            txtBoxDongia.Text = null;
        }

        private void cbTacGia_OnSelectedIndexChanged(object sender, EventArgs e)
        {
            if (dontHandle) return;
            string expr = "";
            if (cbTheLoai.SelectedItem.ToString() != "Tất cả")
                expr += "TheLoai = '" + cbTheLoai.SelectedItem.ToString() + "' AND ";
            if (cbTacGia.SelectedItem.ToString() != "Tất cả")
                expr += "TacGia = '" + cbTacGia.SelectedItem.ToString() + "' AND ";
            if (expr.Length != 0)
                expr = expr.Substring(0, expr.Length - 5);
            cbTenSach.SelectedItem = null;

            dv = new DataView(sach.Tables[0])
            {
                RowFilter = expr
            };
            cbTenSach.DataSource = dv.ToTable().Rows.Cast<DataRow>().Select(r => new cSach
            {
                MaSach = r["MaSach"].ToString(),
                TenSach = r["TenSach"].ToString(),
                TheLoai = r["TheLoai"].ToString(),
                TacGia = r["TacGia"].ToString(),
                SoLuong = r.Field<int>("SoLuong"),
                DonGiaNhap = r.Field<int>("DonGiaNhap")
            })
            .ToList<cSach>();
            cbTenSach.SelectedIndex = -1;
            txtBoxDongia.Text = null;
        }

        private void rjButton3_Click(object sender, EventArgs e)
        {
            int soLuongBan, soLuongTon;
            if (cbTenSach.SelectedItem != null && cbTheLoai.SelectedItem != null && txtBoxHoten.Texts != "" && txtBoxSoluong.Texts != "" && txtBoxDongia.Texts != "" && txtBoxSodienthoai.Texts != "")
            {

                // Nếu đã có sách trong list view thì tăng số lượng
                foreach (ListViewItem item in lvGio.Items)
                {
                    if (item.SubItems[5].Text == cbTenSach.SelectedValue.ToString())
                    {
                        soLuongBan = int.Parse(item.SubItems[3].Text) + int.Parse(txtBoxSoluong.Text);
                        soLuongTon = sach.Tables[0].Select("MaSach = " + item.SubItems[5].Text)[0].Field<int>("SoLuong");
                        if (soLuongTon - soLuongBan < Globals.Tonbanmin)
                        {
                            MessageBox.Show("Lượng tồn sau khi bán của đầu sách không thể bé hơn 20", "Thất bại", MessageBoxButtons.OK, MessageBoxIcon.Warning); ;
                            return;
                        }
                        item.SubItems[3].Text = soLuongBan.ToString();
                        dontHandle = true;
                        txtBoxSoluong.Text = "";
                        txtBoxDongia.Text = "";
                        cbTheLoai.SelectedItem = null;
                        cbTacGia.SelectedItem = null;
                        dontHandle = false;
                        cbTenSach.DataSource = CSachList(sach.Tables[0]);
                        cbTenSach.SelectedItem = null;
                        return;
                    }
                }

                // Nếu k có sách trong list view thì thêm
                soLuongBan = int.Parse(txtBoxSoluong.Texts);
                soLuongTon = sach.Tables[0].Select("MaSach = " + cbTenSach.SelectedValue.ToString())[0].Field<int>("SoLuong");
                if (soLuongTon - soLuongBan < Globals.Tonbanmin)
                {
                    MessageBox.Show("Lượng tồn sau khi bán của đầu sách không thể bé hơn 20", "Thất bại", MessageBoxButtons.OK, MessageBoxIcon.Error); ;
                    return;
                }

                string[] arr = new string[6];
                arr[0] = cbTenSach.Text;
                arr[1] = cbTheLoai.Text;
                arr[2] = cbTacGia.Text;
                arr[3] = txtBoxSoluong.Texts;
                arr[4] = txtBoxDongia.Texts;
                arr[5] = cbTenSach.SelectedValue.ToString();
                ListViewItem lst = new ListViewItem(arr);
                lvGio.Items.Add(lst);
                dontHandle = true;
                txtBoxSoluong.Text = "";
                txtBoxDongia.Text = "";
                cbTheLoai.SelectedItem = null;
                cbTacGia.SelectedItem = null;
                dontHandle = false;
                cbTenSach.DataSource = CSachList(sach.Tables[0]);
                cbTenSach.SelectedItem = null;
            }
            else
            {
                MessageBox.Show("Cần phải nhập tất cả các mục !");
            }
            tongTien = 0;
            foreach (ListViewItem item in lvGio.Items)
            {
                tongTien += int.Parse(item.SubItems[4].Text) * int.Parse(item.SubItems[3].Text);
            }
            lbltongTien.Text = tongTien.ToString();
        }

        private void cbTenSach_SelectionChangeCommitted(object sender, EventArgs e)
        {
            string strDonGiaNhap = sach.Tables[0].Select("MaSach = '" + cbTenSach.SelectedValue.ToString() + "'")[0]["DonGiaNhap"].ToString();
            int DonGiaBan = (int)(int.Parse(strDonGiaNhap) * 1.05f);
            dontHandle = true;
            cbTheLoai.Text = sach.Tables[0].Select("MaSach = '" + cbTenSach.SelectedValue.ToString() + "'")[0]["TheLoai"].ToString();
            cbTacGia.Text = sach.Tables[0].Select("MaSach = '" + cbTenSach.SelectedValue.ToString() + "'")[0]["TacGia"].ToString();
            txtBoxDongia.Texts = DonGiaBan.ToString();
            dontHandle = false;
        }

        private void txtBoxDongia_Load(object sender, EventArgs e)
        {

        }

        private void lvGio_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void rjButton4_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem item in lvGio.SelectedItems)
            {
                string query = "select * from SACH where SACH.MaSach = " + item.SubItems[5].Text;
                SqlDataAdapter sda = new SqlDataAdapter(query, Globals.sqlcon);
                System.Data.DataTable dt = new System.Data.DataTable();
                sda.Fill(dt);
                Globals.sqlcon.Close();
                try
                {
                    int soluong_co = int.Parse(dt.Rows[0].ItemArray[4].ToString());
                    int soluong_muonmua = int.Parse(item.SubItems[3].Text) + 1; ;
                    if (soluong_co - soluong_muonmua < Globals.Tonbanmin)
                    {
                        string m = "Số lượng sách tối đa có thể mua cho loại này là " + (soluong_co - Globals.Tonbanmin).ToString();
                        MessageBox.Show(m, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                }
                catch
                { }
                item.SubItems[3].Text = (int.Parse(item.SubItems[3].Text) + 1).ToString();
            }
            tongTien = 0;
            foreach (ListViewItem item in lvGio.Items)
            {
                tongTien += int.Parse(item.SubItems[4].Text) * int.Parse(item.SubItems[3].Text);
            }
            lbltongTien.Text = tongTien.ToString();
        }

        private void rjButton8_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem item in lvGio.SelectedItems)
            {
                if (int.Parse(item.SubItems[3].Text) > 1)
                    item.SubItems[3].Text = (int.Parse(item.SubItems[3].Text) - 1).ToString();
            }
            tongTien = 0;
            foreach (ListViewItem item in lvGio.Items)
            {
                tongTien += int.Parse(item.SubItems[4].Text) * int.Parse(item.SubItems[3].Text);
            }
            lbltongTien.Text = tongTien.ToString();
        }

        private void rjButton9_Click(object sender, EventArgs e)
        {

            for (int i = 0; i < lvGio.Items.Count; i++)
            {
                if (lvGio.Items[i].Selected)
                {
                    lvGio.Items[i].Remove();
                    i--;
                }
            }
            tongTien = 0;
            foreach (ListViewItem item in lvGio.Items)
            {
                tongTien += int.Parse(item.SubItems[4].Text) * int.Parse(item.SubItems[3].Text);
            }
            lbltongTien.Text = tongTien.ToString();
        }

        private void rjButton5_Click(object sender, EventArgs e)
        {
            lvGio.Items.Clear();
            lbltongTien.Text = "0";
        }

        private void rjButton7_Click(object sender, EventArgs e)
        {
            if (lvGio.Items.Count == 0)
            {
                MessageBox.Show("Vui lòng thêm sách", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            tongTien = 0;
            foreach (ListViewItem item in lvGio.Items)
            {
                tongTien += int.Parse(item.SubItems[4].Text) * int.Parse(item.SubItems[3].Text);
            }
            using FormXacnhanhoadon uf = new FormXacnhanhoadon(tongTien, txtBoxHoten.Texts, txtBoxSodienthoai.Texts, dtpNgay.Value, lvGio, this.taotaikhoan, diachi, email);
            uf.ShowDialog();
            maHD = uf.maHD;
            if (maHD != -1)
            {
                VietCTHD();
                lvGio.Items.Clear();
                lbltongTien.Text = "0";
            }
        }
        private void VietCTHD()
        {
            using SqlConnection con = new SqlConnection(Globals.sqlcon.ConnectionString);
            using SqlCommand command = con.CreateCommand();
            string insert = "insert into CTHD values(@mahd, @masach, @sl, @dongia)",
                modify = "update SACH " +
                "set SoLuong = SoLuong - @sl where MaSach = @masach";

            // định nghĩa các tham số trước
            command.Parameters.Add("@mahd", SqlDbType.Int);
            command.Parameters.Add("@masach", SqlDbType.Int);
            command.Parameters.Add("@sl", SqlDbType.Int);
            command.Parameters.Add("@dongia", SqlDbType.Int);

            con.Open();
            foreach (ListViewItem item in lvGio.Items)
            {
                command.CommandText = insert;
                command.Parameters["@mahd"].Value = maHD;
                command.Parameters["@masach"].Value = int.Parse(item.SubItems[5].Text);
                command.Parameters["@sl"].Value = int.Parse(item.SubItems[3].Text);
                command.Parameters["@dongia"].Value = int.Parse(item.SubItems[4].Text);

                command.ExecuteNonQuery();

                command.CommandText = modify;
                command.ExecuteNonQuery();

            }
            con.Close();
        }

        private void btnDoiThongTin_Click(object sender, EventArgs e)
        {
            dontHandle = true;
            dtpNgay.Enabled = false;
            cbTenSach.Enabled = false;
            cbTheLoai.Enabled = false;
            cbTacGia.Enabled = false;
            txtBoxSoluong.Enabled = false;
            cbTenSach.SelectedItem = null;
            txtBoxSoluong.Texts = "";
            txtBoxDongia.Texts = "";
            cbTheLoai.SelectedItem = null;
            cbTacGia.SelectedItem = null;
            lvGio.Items.Clear();
            dontHandle = false;

            txtBoxHoten.Enabled = true;
            txtBoxSodienthoai.Enabled = true;
            btnDoiThongTin.Enabled = false;
        }

        private void rjButton6_Click(object sender, EventArgs e)
        {
            using FormDSHoadon ds = new FormDSHoadon();
            ds.ShowDialog();
        }

        private void rjButton1_Click(object sender, EventArgs e)
        {
            bool isEligible = true, isFilled = true; // Biến kiểm tra điều kiện khách hàng
            Globals.sqlcon.Open();
            // Kiểm tra nợ của khách hàng

            string query = "select * from KHACHHANG where TenKH = N'" + txtBoxHoten.Texts + "' and DienThoai = '" + txtBoxSodienthoai.Texts + "' and SoTienNo > " + Globals.Nomax.ToString();
            SqlDataAdapter sda = new SqlDataAdapter(query, Globals.sqlcon);
            DataTable kh = new DataTable();
            sda.Fill(kh);

            if (kh.Rows.Count != 0)
                isEligible = false;

            query = "select * from KHACHHANG where TenKH = N'" + txtBoxHoten.Texts + "' and DienThoai = '" + txtBoxSodienthoai.Texts + "'";
            sda = new SqlDataAdapter(query, Globals.sqlcon);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            if (txtBoxHoten.Texts == "" || txtBoxSodienthoai.Texts == "")
                isFilled = false;

            if (isEligible && isFilled)
            {
                Color cl = Color.FromName("Green");
                lblCheck.ForeColor = cl;
                if (dt.Rows.Count != 0)
                {
                    lblCheck.Text = "✓ Khách hàng đủ điều kiện";
                }
                else
                {
                    DialogResult dialogResult = MessageBox.Show("Khách hàng chưa có trong CSDL \n Tạo tài khoản khách hàng mới?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (dialogResult == DialogResult.Yes)
                    {
                        lblCheck.Text = "✓ Khách hàng mới, sẽ tiến hành tạo tài khoản khách hàng";
                        this.taotaikhoan = dialogResult;
                        using (FormNhapthemthongtinkhachhang form = new FormNhapthemthongtinkhachhang())
                        {
                            form.ShowDialog();
                            if (form.cancel == true)
                            {
                                Globals.sqlcon.Close();
                                return;
                            }
                            diachi = form.diaChi;
                            email = form.email;
                        }
                    }
                    else
                    {
                        lblCheck.Text = "✓ Khách hàng mới, không tạo tài khoản khách hàng";
                        this.taotaikhoan = dialogResult;
                    }
                }
                lblCheck.Visible = true;


                dtpNgay.Enabled = true;
                cbTenSach.Enabled = true;
                cbTheLoai.Enabled = true;
                cbTacGia.Enabled = true;
                txtBoxSoluong.Enabled = true;
                btnDoiThongTin.Enabled = true;
                txtBoxHoten.Enabled = false;
                txtBoxSodienthoai.Enabled = false;
            }
            else
            {
                Color cl = Color.FromName("Red");
                lblCheck.ForeColor = cl;
                if (!isFilled)
                    lblCheck.Text = "Vui lòng nhập đủ các trường trên";
                else lblCheck.Text = "Khách hàng không đủ điều kiện để mua hàng";
                lblCheck.Visible = true; // Hiện "khách ko đủ đk"
            }

            Globals.sqlcon.Close();
        }
    }
}
