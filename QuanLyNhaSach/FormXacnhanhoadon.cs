using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Microsoft.VisualBasic;
using Excel = Microsoft.Office.Interop.Excel;
using Microsoft.Office.Interop.Excel;
using System.Runtime.InteropServices;
using System.Drawing;

namespace QuanLyNhaSach
{
    public partial class FormXacnhanhoadon : Form
    {
        public int maHD;
        private int tongTien, thanhToan, tienTra;
        private string hoTen, sodienthoai, diaChi, email;
        private ListView cthd;
        private DialogResult taotk;
        DateTime ngay;
        public FormXacnhanhoadon(int uc_tongTien, string uc_hoten, string uc_sodienthoai, DateTime date, ListView uc_cthd, DialogResult taotaikhoan, string dc, string em)
        {
            InitializeComponent();
            tongTien = uc_tongTien;
            thanhToan = uc_tongTien;
            hoTen = uc_hoten;
            sodienthoai = uc_sodienthoai;
            ngay = date;
            cthd = uc_cthd;
            taotk = taotaikhoan;
            diaChi = dc;
            email = em;

        }


        private static void releaseObject(object obj)
        {
            try
            {
                System.Runtime.InteropServices.Marshal.ReleaseComObject(obj);
                obj = null;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                obj = null;
            }
            finally
            { GC.Collect(); }
        }
        private void BorderAround(Excel.Range range)
        {
            Borders borders = range.Borders;
            borders[XlBordersIndex.xlEdgeLeft].LineStyle = XlLineStyle.xlContinuous;
            borders[XlBordersIndex.xlEdgeTop].LineStyle = XlLineStyle.xlContinuous;
            borders[XlBordersIndex.xlEdgeBottom].LineStyle = XlLineStyle.xlContinuous;
            borders[XlBordersIndex.xlEdgeRight].LineStyle = XlLineStyle.xlContinuous;
            borders.Color = Color.Black;
            borders[XlBordersIndex.xlInsideVertical].LineStyle = XlLineStyle.xlContinuous;
            borders[XlBordersIndex.xlInsideHorizontal].LineStyle = XlLineStyle.xlContinuous;
            borders[XlBordersIndex.xlDiagonalUp].LineStyle = XlLineStyle.xlLineStyleNone;
            borders[XlBordersIndex.xlDiagonalDown].LineStyle = XlLineStyle.xlLineStyleNone;
        }

        private void txtBoxGiamgia_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtBoxSotiennhan__TextChanged(object sender, EventArgs e)
        {
            if (txtBoxSotiennhan.Texts != "") tienTra = int.Parse(txtBoxSotiennhan.Texts);
            else tienTra = 0;
            lblGiatritienthua.Text = (tienTra - thanhToan).ToString();
        }

        private void txtBoxGiamgia__TextChanged(object sender, EventArgs e)
        {
            if (txtBoxGiamgia.Texts != "")
                thanhToan = (int)(tongTien - tongTien * 0.01 * int.Parse(txtBoxGiamgia.Texts));
            else thanhToan = tongTien;
            txtBoxSotienphaitra.Texts = thanhToan.ToString();
        }

        private void txtBoxSotiennhan_Load(object sender, EventArgs e)
        {

        }

        private void btnHoantat_Click(object sender, EventArgs e)
        {
            Globals.sqlcon.Open();

            // Kiểm tra khách hàng có trong CSDL
            string query = "select * from KHACHHANG where TenKH = N'" + hoTen + "' and DienThoai = '" + sodienthoai + "'";
            SqlDataAdapter sda = new SqlDataAdapter(query, Globals.sqlcon);
            System.Data.DataTable dt = new System.Data.DataTable();
            sda.Fill(dt);

            // Nếu có thông tin khách hàng trong CSDL
            if (dt.Rows.Count != 0)
            {

                using SqlCommand command = Globals.sqlcon.CreateCommand();
                {
                    command.CommandText = "update KHACHHANG " +
                        "set SoTienNo = SoTienNo + " + (thanhToan - tienTra).ToString() + " where TenKH = N'" + hoTen + "' and DienThoai = '" + sodienthoai + "'";
                    command.ExecuteNonQuery();
                }
            }
            else
            {
                if (this.taotk == DialogResult.Yes)
                {
                    /*using (frmThongTinThem form = new frmThongTinThem())
                    {
                        form.ShowDialog();
                        if (form.cancel == true) return;
                        diaChi = form.diaChi;
                        email = form.email;
                    }*/
                    using SqlCommand command = Globals.sqlcon.CreateCommand();
                    command.CommandText = "insert into KHACHHANG values(@ten, @diachi, @sodt, @email, @tienno)";
                    command.Parameters.AddWithValue("@ten", hoTen);
                    command.Parameters.AddWithValue("@diachi", diaChi);
                    command.Parameters.AddWithValue("@sodt", sodienthoai);
                    command.Parameters.AddWithValue("@email", email);
                    command.Parameters.AddWithValue("@tienno", thanhToan - tienTra);
                    command.ExecuteNonQuery();
                }
                else
                {
                    if (thanhToan - tienTra > 0)
                    {
                        MessageBox.Show("Khách hàng nợ phải có tài khoản!", "Thất bại", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        maHD = -1;
                        Globals.sqlcon.Close();
                        this.Dispose();
                        return;
                    }
                }
            }
            Globals.sqlcon.Close();

            if (cboxXuat.Checked)
            {
                SaveFileDialog chonduongdan = Save;
                if (chonduongdan.ShowDialog() == DialogResult.OK)
                {
                    string saveLocation = chonduongdan.FileName;

                    Excel.Application xlApp = new Excel.Application();

                    if (xlApp == null)
                    {
                        MessageBox.Show("Không thể sử dụng thư viện Excel", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    xlApp.Visible = false;

                    object misValue = System.Reflection.Missing.Value;

                    Workbook wb = xlApp.Workbooks.Add(misValue);

                    Worksheet ws = (Worksheet)wb.Worksheets[1];

                    if (ws == null)
                    {
                        MessageBox.Show("Không thể tạo được WorkSheet", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    int row = 1;
                    string fontName = "Times New Roman";
                    int fontSizeTieuDe = 18;
                    int fontSizeTenTruong = 14;
                    int fontSizeNoiDung = 12;

                    //Xuất dòng Tiêu đề của File báo cáo: Lưu ý
                    Excel.Range row1_TieuDe = ws.get_Range("A1", "E1");
                    row1_TieuDe.Merge();
                    row1_TieuDe.Font.Size = fontSizeTieuDe;
                    row1_TieuDe.Font.Name = fontName;
                    row1_TieuDe.Cells.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
                    row1_TieuDe.Value2 = "Hoá đơn";

                    //Tạo Ô "Ho va ten"
                    Excel.Range row2_Ten = ws.get_Range("A2", "A2");//Cột A dòng 2
                    row2_Ten.Font.Size = fontSizeTenTruong;
                    row2_Ten.Font.Name = fontName;
                    row2_Ten.Cells.HorizontalAlignment = XlHAlign.xlHAlignCenter;
                    row2_Ten.Value2 = "Họ và tên:";
                    //Tạo ô chứa tên:
                    Excel.Range row2_ten_vl = ws.get_Range("B2", "C2");//Cột A dòng 2
                    row2_ten_vl.Merge();
                    row2_ten_vl.Font.Size = fontSizeTenTruong;
                    row2_ten_vl.Font.Name = fontName;
                    row2_ten_vl.Cells.HorizontalAlignment = XlHAlign.xlHAlignCenter;
                    row2_ten_vl.Value2 = hoTen;
                    //Tạo Ô Tên "Ngày"
                    Excel.Range row2_ngay = ws.get_Range("D2", "D2");//Cột B dòng 2
                    row2_ngay.Font.Size = fontSizeTenTruong;
                    row2_ngay.Font.Name = fontName;
                    row2_ngay.Cells.HorizontalAlignment = XlHAlign.xlHAlignCenter;
                    row2_ngay.Value2 = "Ngày";

                    //Tạo Ô chứa ngày
                    Excel.Range row2_ngay_vl = ws.get_Range("E2", "E2");//Cột C dòng 2
                    row2_ngay_vl.Font.Size = fontSizeTenTruong;
                    row2_ngay_vl.Font.Name = fontName;
                    row2_ngay_vl.Cells.HorizontalAlignment = XlHAlign.xlHAlignCenter;
                    row2_ngay_vl.Value2 = ngay.ToString();

                    //Tạo Ô Số Thứ Tự (STT)
                    Excel.Range row2_STT = ws.get_Range("A3", "A3");//Cột A dòng 3
                    row2_STT.Font.Size = fontSizeTenTruong;
                    row2_STT.Font.Name = fontName;
                    row2_STT.Cells.HorizontalAlignment = XlHAlign.xlHAlignCenter;
                    row2_STT.Value2 = "STT";

                    //Tạo Ô Tên sách
                    Excel.Range row2_TenSach = ws.get_Range("B3", "B3");//Cột B dòng 2
                    row2_TenSach.Font.Size = fontSizeTenTruong;
                    row2_TenSach.Font.Name = fontName;
                    row2_TenSach.Cells.HorizontalAlignment = XlHAlign.xlHAlignCenter;
                    row2_TenSach.Value2 = "Tên sách";

                    //Tạo Ô Thể loại
                    Excel.Range row2_TheLoai = ws.get_Range("C3", "C3");//Cột C dòng 2
                    row2_TheLoai.Font.Size = fontSizeTenTruong;
                    row2_TheLoai.Font.Name = fontName;
                    row2_TheLoai.Cells.HorizontalAlignment = XlHAlign.xlHAlignCenter;
                    row2_TheLoai.Value2 = "Thể loại";

                    //Tạo Ô Số lượng
                    Excel.Range row2_SL = ws.get_Range("D3", "D3");//Cột E dòng 2
                    row2_SL.Font.Size = fontSizeTenTruong;
                    row2_SL.Font.Name = fontName;
                    row2_SL.Cells.HorizontalAlignment = XlHAlign.xlHAlignCenter;
                    row2_SL.Value2 = "Số lượng";

                    //Tạo Ô Tác giả
                    Excel.Range row2_Dongia = ws.get_Range("E3", "E3");//Cột D dòng 2
                    row2_Dongia.Font.Size = fontSizeTenTruong;
                    row2_Dongia.Font.Name = fontName;
                    row2_Dongia.Cells.HorizontalAlignment = XlHAlign.xlHAlignCenter;
                    row2_Dongia.Value2 = "Đơn giá bán";

                    //Tô nền vàng các cột tiêu đề:
                    Excel.Range row2_CotTieuDe = ws.get_Range("A3", "E3");
                    //nền vàng
                    row2_CotTieuDe.Interior.Color = ColorTranslator.ToOle(System.Drawing.Color.Yellow);
                    //in đậm
                    row2_CotTieuDe.Font.Bold = true;
                    //chữ đen
                    row2_CotTieuDe.Font.Color = ColorTranslator.ToOle(System.Drawing.Color.Black);

                    int stt = 0;
                    row = 3;
                    foreach (ListViewItem item in cthd.Items)
                    {
                        stt++;
                        row++;
                        dynamic[] arr = { stt, item.SubItems[0].Text, item.SubItems[1].Text, item.SubItems[3].Text, item.SubItems[4].Text };
                        Excel.Range rowData = ws.get_Range("A" + row, "E" + row); // Lấy dòng thứ row để đổ dữ liệu
                        rowData.Font.Size = fontSizeNoiDung;
                        rowData.Font.Name = fontName;
                        rowData.Value2 = arr;

                    }
                    row++;
                    Excel.Range r_tongtien = ws.get_Range("D" + row, "D" + row);//Cột E dòng 2
                    r_tongtien.Font.Size = fontSizeTenTruong;
                    r_tongtien.Font.Name = fontName;
                    r_tongtien.Cells.HorizontalAlignment = XlHAlign.xlHAlignCenter;
                    r_tongtien.Value2 = "Tổng tiền: ";

                    Excel.Range r_tongtien_vl = ws.get_Range("E" + row, "E" + row);//Cột E dòng 2
                    r_tongtien_vl.Font.Size = fontSizeTenTruong;
                    r_tongtien_vl.Font.Name = fontName;
                    r_tongtien_vl.Cells.HorizontalAlignment = XlHAlign.xlHAlignCenter;
                    r_tongtien_vl.Value2 = tongTien.ToString();

                    row++;

                    Excel.Range r_tientra = ws.get_Range("D" + row, "D" + row);//Cột E dòng 2
                    r_tientra.Font.Size = fontSizeTenTruong;
                    r_tientra.Font.Name = fontName;
                    r_tientra.Cells.HorizontalAlignment = XlHAlign.xlHAlignCenter;
                    r_tientra.Value2 = "Số tiền trả: ";

                    Excel.Range r_tientra_vl = ws.get_Range("E" + row, "E" + row);//Cột E dòng 2
                    r_tientra_vl.Font.Size = fontSizeTenTruong;
                    r_tientra_vl.Font.Name = fontName;
                    r_tientra_vl.Cells.HorizontalAlignment = XlHAlign.xlHAlignCenter;
                    r_tientra_vl.Value2 = tienTra.ToString();

                    row++;

                    Excel.Range r_conlai = ws.get_Range("D" + row, "D" + row);//Cột E dòng 2
                    r_conlai.Font.Size = fontSizeTenTruong;
                    r_conlai.Font.Name = fontName;
                    r_conlai.Cells.HorizontalAlignment = XlHAlign.xlHAlignCenter;
                    r_conlai.Value2 = "Còn lại: ";

                    Excel.Range r_conlai_vl = ws.get_Range("E" + row, "E" + row);//Cột E dòng 2
                    r_conlai_vl.Font.Size = fontSizeTenTruong;
                    r_conlai_vl.Font.Name = fontName;
                    r_conlai_vl.Cells.HorizontalAlignment = XlHAlign.xlHAlignCenter;
                    r_conlai_vl.Value2 = (tienTra - tongTien).ToString();

                    //Kẻ khung toàn bộ
                    BorderAround(ws.get_Range("A2", "E" + row));
                    ws.get_Range("A1", "E" + row).Columns.AutoFit();

                    //Lưu file
                    wb.SaveAs(saveLocation);

                    //Đóng file để hoàn tất quá trình lưu trữ
                    wb.Close(true, misValue, misValue);
                    //thoát và thu hồi bộ nhớ COM
                    xlApp.Quit();
                    releaseObject(ws);
                    releaseObject(wb);
                    releaseObject(xlApp);

                    MessageBox.Show("Lưu thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }

            // }

            //Ghi vào CSDL
            using (SqlConnection con = new SqlConnection(Globals.sqlcon.ConnectionString))
            using (SqlCommand command = con.CreateCommand())
            {
                command.CommandText = "insert into HOADON values(@hoten, @sdt, @ngay, @tongtien, @sotientra)";
                command.Parameters.AddWithValue("@hoten", hoTen);
                command.Parameters.AddWithValue("@sdt", sodienthoai);
                command.Parameters.AddWithValue("@ngay", ngay);
                command.Parameters.AddWithValue("@tongtien", tongTien);
                command.Parameters.AddWithValue("@sotientra", tienTra);

                con.Open();
                command.ExecuteNonQuery();

                command.CommandText = "select max(MaHD) from HOADON";
                SqlDataReader dr = command.ExecuteReader();
                dr.Read();
                maHD = dr.GetInt32(0);
                con.Close();
            }


            MessageBox.Show("Ghi hoá đơn thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Dispose();
        }

        private void txtBoxGiamgia_Load(object sender, EventArgs e)
        {

        }

        private void txtBoxSotiennhan_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void FormXacnhanhoadon_Load(object sender, EventArgs e)
        {
            txtBoxTongtien.Texts = tongTien.ToString();
            txtBoxSotienphaitra.Texts = tongTien.ToString();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void rjButton1_Click(object sender, EventArgs e)
        {
            maHD = -1;
            Dispose();
        }

        private void rjButton2_Click(object sender, EventArgs e)
        {
            maHD = -1;
            Dispose();
        }
    }
}
