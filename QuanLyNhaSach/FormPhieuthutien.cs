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
using Excel = Microsoft.Office.Interop.Excel;
using Microsoft.Office.Interop.Excel;
using System.Runtime.InteropServices;

namespace QuanLyNhaSach
{
    public partial class FormPhieuthutien : Form
    {
        private string hoTen, diaChi, dienThoai, email;
        private int soTienNo;
        private readonly int maKH;
        private DateTime ngay;
        public FormPhieuthutien(DataGridViewRow kh)
        {
            InitializeComponent();
            hoTen = kh.Cells["TenKH"].Value.ToString();
            diaChi = kh.Cells["DiaChi"].Value.ToString();
            dienThoai = kh.Cells["DienThoai"].Value.ToString();
            email = kh.Cells["Email"].Value.ToString();
            soTienNo = Convert.ToInt32(kh.Cells["SoTienNo"].Value);
            maKH = Convert.ToInt32(kh.Cells["MaKH"].Value);
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void FormPhieuthutien_Load_1(object sender, EventArgs e)
        {

        }

        private void rjTextBox3__TextChanged(object sender, EventArgs e)
        {
            if (txtBoxTienthu.Texts == "") txtBoxTiennomoi.Texts = txtBoxTienno.Texts;
            else txtBoxTiennomoi.Texts = (soTienNo - int.Parse(txtBoxTienthu.Texts)).ToString();
        }
        

        private void btnXong_Click(object sender, EventArgs e)
        {
            ngay = DateTime.Parse(dateTimePicker1.Text);
            if (txtBoxTienthu.Texts == "")
            {
                MessageBox.Show("Vui lòng nhập số tiền thu!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (Globals.tienthuvuottienno && int.Parse(txtBoxTienthu.Texts) > soTienNo)
            {
                MessageBox.Show("Số tiền thu không thể vượt số tiền nợ", "Thất bại", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            //Cập nhật CSDl
            Globals.sqlcon.Open();
            using SqlCommand command = Globals.sqlcon.CreateCommand();
            // Cập nhật bảng KHACHHANG
            command.CommandText = "update KHACHHANG " +
                "set SoTienNo = SoTienNo - " + txtBoxTienthu.Texts + " where MaKH = " + maKH.ToString();

            command.ExecuteNonQuery();

            // thêm vào bảng PHIEUTHUTIEN
            command.CommandText = "insert into PHIEUTHUTIEN values(@makh, @ngay, @tienthu)";
            command.Parameters.AddWithValue("@makh", maKH);
            command.Parameters.AddWithValue("@ngay", ngay);
            command.Parameters.AddWithValue("@tienthu", int.Parse(txtBoxTienthu.Texts));
            command.ExecuteNonQuery();

            Globals.sqlcon.Close();
            MessageBox.Show("Thu tiền thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);

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

                    string fontName = "Times New Roman";
                    int fontSizeTieuDe = 18;
                    int fontSizeTenTruong = 14;

                    //Xuất dòng Tiêu đề của File báo cáo: Lưu ý
                    Excel.Range row1_TieuDe = ws.get_Range("A1", "D1");
                    row1_TieuDe.Merge();
                    row1_TieuDe.Font.Size = fontSizeTieuDe;
                    row1_TieuDe.Font.Name = fontName;
                    row1_TieuDe.Cells.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
                    row1_TieuDe.Value2 = "Phiếu thu tiền";


                    //Tạo Ô "Ho va ten"
                    Excel.Range row2_Ten = ws.get_Range("A2", "A2");//Cột A dòng 2
                    row2_Ten.Font.Size = fontSizeTenTruong;
                    row2_Ten.Font.Name = fontName;
                    row2_Ten.Cells.HorizontalAlignment = XlHAlign.xlHAlignCenter;
                    row2_Ten.Value2 = "Họ và tên:";
                    //Tạo ô chứa tên:
                    Excel.Range row2_ten_vl = ws.get_Range("B2", "B2");//Cột A dòng 2
                    row2_ten_vl.Merge();
                    row2_ten_vl.Font.Size = fontSizeTenTruong;
                    row2_ten_vl.Font.Name = fontName;
                    row2_ten_vl.Cells.HorizontalAlignment = XlHAlign.xlHAlignCenter;
                    row2_ten_vl.Value2 = hoTen;
                    //Tạo Ô "Dia chi"
                    Excel.Range row_diachi = ws.get_Range("C2", "C2");//Cột A dòng 2
                    row_diachi.Font.Size = fontSizeTenTruong;
                    row_diachi.Font.Name = fontName;
                    row_diachi.Cells.HorizontalAlignment = XlHAlign.xlHAlignCenter;
                    row_diachi.Value2 = "Địa chỉ:";
                    //Tạo ô chứa Địa chỉ:
                    Excel.Range row_diachivl = ws.get_Range("D2", "D2");//Cột A dòng 2
                    row_diachivl.Font.Size = fontSizeTenTruong;
                    row_diachivl.Font.Name = fontName;
                    row_diachivl.Cells.HorizontalAlignment = XlHAlign.xlHAlignCenter;
                    row_diachivl.Value2 = diaChi;

                    //Tạo Ô "DT"
                    Excel.Range row_dt = ws.get_Range("A3", "A3");//Cột A dòng 2
                    row_dt.Font.Size = fontSizeTenTruong;
                    row_dt.Font.Name = fontName;
                    row_dt.Cells.HorizontalAlignment = XlHAlign.xlHAlignCenter;
                    row_dt.Value2 = "Điện thoại:";
                    //Tạo ô chứa ĐT:
                    Excel.Range row_dtvl = ws.get_Range("B3", "B3");//Cột A dòng 2
                    row_dtvl.Font.Size = fontSizeTenTruong;
                    row_dtvl.Font.Name = fontName;
                    row_dtvl.Cells.HorizontalAlignment = XlHAlign.xlHAlignCenter;
                    row_dtvl.Value2 = dienThoai;

                    //Tạo Ô "email"
                    Excel.Range row_email = ws.get_Range("C3", "C3");//Cột A dòng 2
                    row_email.Font.Size = fontSizeTenTruong;
                    row_email.Font.Name = fontName;
                    row_email.Cells.HorizontalAlignment = XlHAlign.xlHAlignCenter;
                    row_email.Value2 = "Email:";
                    //Tạo ô chứa email:
                    Excel.Range row_email_vl = ws.get_Range("D3", "D3");//Cột A dòng 2
                    row_email_vl.Font.Size = fontSizeTenTruong;
                    row_email_vl.Font.Name = fontName;
                    row_email_vl.Cells.HorizontalAlignment = XlHAlign.xlHAlignCenter;
                    row_email_vl.Value2 = email;

                    //Tạo Ô "ngaythutien"
                    Excel.Range row_ngay = ws.get_Range("A4", "A4");//Cột A dòng 2
                    row_ngay.Font.Size = fontSizeTenTruong;
                    row_ngay.Font.Name = fontName;
                    row_ngay.Cells.HorizontalAlignment = XlHAlign.xlHAlignCenter;
                    row_ngay.Value2 = "Ngày thu tiền:";
                    //Tạo ô chứa ngày:
                    Excel.Range row_ngayvl = ws.get_Range("B4", "B4");//Cột A dòng 2
                    row_ngayvl.Font.Size = fontSizeTenTruong;
                    row_ngayvl.Font.Name = fontName;
                    row_ngayvl.Cells.HorizontalAlignment = XlHAlign.xlHAlignCenter;
                    row_ngayvl.Value2 = ngay.ToString();

                    //Tạo Ô "số tiền thu"
                    Excel.Range row_tienthu = ws.get_Range("C4", "C4");//Cột A dòng 2
                    row_tienthu.Font.Size = fontSizeTenTruong;
                    row_tienthu.Font.Name = fontName;
                    row_tienthu.Cells.HorizontalAlignment = XlHAlign.xlHAlignCenter;
                    row_tienthu.Value2 = "Số tiền thu:";
                    //Tạo ô chứa tiền thu:
                    Excel.Range row_tienthuvl = ws.get_Range("D4", "D4");//Cột A dòng 2
                    row_tienthuvl.Font.Size = fontSizeTenTruong;
                    row_tienthuvl.Font.Name = fontName;
                    row_tienthuvl.Cells.HorizontalAlignment = XlHAlign.xlHAlignCenter;
                    row_tienthuvl.Value2 = int.Parse(txtBoxTienthu.Texts);

                    BorderAround(ws.get_Range("A2", "D4"));
                    ws.get_Range("A2", "D4").Columns.AutoFit();

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
            Dispose();
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

        private void txtBoxTienthu_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void rjButton2_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void rjButton3_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void FormPhieuthutien_Load(object sender, EventArgs e)
        {
            txtBoxHoten.Texts = hoTen;
            txtBoxDiachi.Texts = diaChi;
            txtBoxDienthoai.Texts = dienThoai;
            txtBoxEmail.Texts = email;
            txtBoxTienno.Texts = soTienNo.ToString();
        }
    }
}
