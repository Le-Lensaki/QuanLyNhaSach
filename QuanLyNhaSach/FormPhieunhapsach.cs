using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using Excel = Microsoft.Office.Interop.Excel;
using Microsoft.Office.Interop.Excel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace QuanLyNhaSach
{
    public partial class FormPhieunhapsach : Form
    {
        public FormPhieunhapsach()
        {
            InitializeComponent();
            txtBoxTensach.LostFocus += txtBoxTensach_LostFocus;
        }
        private void txtBoxTensach_LostFocus(object sender, EventArgs e)
        {
            Globals.sqlcon.Open();
            using (SqlCommand command = Globals.sqlcon.CreateCommand())
            {
                command.CommandText = "select * from SACH where TenSach = N'" + txtBoxTensach.Text + "'";
                SqlDataReader dr = command.ExecuteReader();
                if (dr.Read())
                {
                    txtBoxTheloai.Texts = dr["TheLoai"].ToString();
                    txtBoxTacgia.Texts = dr["TacGia"].ToString();
                    txtBoxDongianhap.Texts = dr["DonGiaNhap"].ToString();
                }
            }
            Globals.sqlcon.Close();

        }

        private void rjButton1_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void rjButton3_Click(object sender, EventArgs e)
        {
            try
            { lv_nhapSach.Items.RemoveAt(lv_nhapSach.SelectedIndices[0]); }
            catch
            {
                MessageBox.Show("Chọn Item muốn xóa!");
            }
        }

        private void rjButton4_Click(object sender, EventArgs e)
        {
            if (txtBoxTensach.Text != "" && txtBoxTheloai.Texts != "" && txtBoxTacgia.Texts != "" && txtBoxSoluong.Texts != "" && txtBoxDongianhap.Texts != "")
            {
                string[] arr = new string[5];
                ListViewItem itm;
                int soLuongTon;

                Globals.sqlcon.Open();
                using (SqlCommand command = Globals.sqlcon.CreateCommand())
                {
                    command.CommandText = "Select SoLuong from SACH " +
                        "where TenSach = @tensach and TheLoai = @theloai and TacGia = @tacgia";
                    command.Parameters.AddWithValue("@tensach", txtBoxTensach.Text);
                    command.Parameters.AddWithValue("@theloai", txtBoxTheloai.Texts);
                    command.Parameters.AddWithValue("@tacgia", txtBoxTacgia.Texts);
                    using (var reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            soLuongTon = Convert.ToInt32(reader[0]);
                        }
                        else soLuongTon = 0;
                    }
                }
                Globals.sqlcon.Close();

                // Kiểm tra số lượng tồn có đạt tiêu chuẩn
                if (soLuongTon > Globals.Luongtonmax)
                {
                    MessageBox.Show("Không thể nhập sách có lượng tồn trên " + Globals.Luongtonmax.ToString(), "Thất bại", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Kiểm tra số lượng nhập có đạt tiêu chuẩn
                if (int.Parse(txtBoxSoluong.Texts) < Globals.Slmin)
                {
                    MessageBox.Show("Số lượng sách nhập phải lớn hơn hoặc bằng " + Globals.Slmin.ToString(), "Thất bại", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // them Item vao ListView
                arr[0] = txtBoxTensach.Text;
                arr[1] = txtBoxTheloai.Texts;
                arr[2] = txtBoxTacgia.Texts;
                arr[3] = txtBoxSoluong.Texts;
                arr[4] = txtBoxDongianhap.Texts;

                itm = new ListViewItem(arr);
                lv_nhapSach.Items.Add(itm);

                txtBoxTensach.Text = "";
                txtBoxSoluong.Texts = "";
                txtBoxTacgia.Texts = "";
                txtBoxTheloai.Texts = "";
                txtBoxDongianhap.Texts = "";
            }
        }

        private void lv_nhapSach_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void rjButton2_Click(object sender, EventArgs e)
        {
            if (lv_nhapSach.Items.Count > 0)
            {
                    // Ghi vào CSDL
                    Globals.sqlcon.Open();
                    using (SqlCommand command = new SqlCommand("dbo.InsertNhapSach", Globals.sqlcon))
                    {
                        command.Parameters.AddWithValue("@NgayNhap", dtpNgay.Value);
                        command.Parameters.Add("@TenSach", SqlDbType.NVarChar);
                        command.Parameters.Add("@TheLoai", SqlDbType.NVarChar);
                        command.Parameters.Add("@TacGia", SqlDbType.NVarChar);
                        command.Parameters.Add("@SoLuong", SqlDbType.Int);
                        command.Parameters.Add("@DonGiaNhap", SqlDbType.Int);

                        foreach (ListViewItem item in lv_nhapSach.Items)
                        {
                            command.CommandType = CommandType.StoredProcedure;
                            command.Parameters["@TenSach"].Value = item.SubItems[0].Text;
                            command.Parameters["@TheLoai"].Value = item.SubItems[1].Text;
                            command.Parameters["@TacGia"].Value = item.SubItems[2].Text;
                            command.Parameters["@SoLuong"].Value = int.Parse(item.SubItems[3].Text);
                            command.Parameters["@DonGiaNhap"].Value = int.Parse(item.SubItems[4].Text);
                            command.ExecuteNonQuery();
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
                            int fontSizeNoiDung = 12;

                            //Xuất dòng Tiêu đề của File báo cáo: Lưu ý
                            Excel.Range row1_TieuDe = ws.get_Range("A1", "F1");
                            row1_TieuDe.Merge();
                            row1_TieuDe.Font.Size = fontSizeTieuDe;
                            row1_TieuDe.Font.Name = fontName;
                            row1_TieuDe.Cells.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
                            row1_TieuDe.Value2 = "Phiếu nhập sách";

                        //Ngay
                        Excel.Range row_ngay = ws.get_Range("A2", "A2");
                        row_ngay.Font.Size = fontSizeTieuDe;
                        row_ngay.Font.Name = fontName;
                        row_ngay.Cells.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignLeft;
                        row_ngay.Value2 = "Ngày";

                        Excel.Range row_ngay_vl = ws.get_Range("B2", "F2");
                        row_ngay_vl.Merge();
                        row_ngay_vl.Font.Size = fontSizeTieuDe;
                        row_ngay_vl.Font.Name = fontName;
                        row_ngay_vl.Cells.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignLeft;
                        row_ngay_vl.Value2 = dtpNgay.Value.ToString();

                        //Tieu de cot
                        Excel.Range stt = ws.get_Range("A3", "A3");
                        stt.Font.Size = fontSizeTieuDe;
                        stt.Font.Name = fontName;
                        stt.Cells.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
                        stt.Value2 = "STT";

                        Excel.Range tensach = ws.get_Range("B3", "B3");
                        tensach.Font.Size = fontSizeTieuDe;
                        tensach.Font.Name = fontName;
                        tensach.Cells.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
                        tensach.Value2 = "Sách";

                        Excel.Range theloai = ws.get_Range("C3", "C3");
                        theloai.Font.Size = fontSizeTieuDe;
                        theloai.Font.Name = fontName;
                        theloai.Cells.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
                        theloai.Value2 = "Thể loại";

                        Excel.Range tg = ws.get_Range("D3", "D3");
                        tg.Font.Size = fontSizeTieuDe;
                        tg.Font.Name = fontName;
                        tg.Cells.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
                        tg.Value2 = "Tác giả";

                        Excel.Range sl = ws.get_Range("E3", "E3");
                        sl.Font.Size = fontSizeTieuDe;
                        sl.Font.Name = fontName;
                        sl.Cells.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
                        sl.Value2 = "Số lượng";

                        Excel.Range dgn = ws.get_Range("F3", "F3");
                        dgn.Font.Size = fontSizeTieuDe;
                        dgn.Font.Name = fontName;
                        dgn.Cells.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
                        dgn.Value2 = "Đơn giá nhập";

                        Excel.Range row2_CotTieuDe = ws.get_Range("A3", "F3");
                        //nền vàng
                        row2_CotTieuDe.Interior.Color = ColorTranslator.ToOle(System.Drawing.Color.Yellow);
                        //in đậm
                        row2_CotTieuDe.Font.Bold = true;
                        //chữ đen
                        row2_CotTieuDe.Font.Color = ColorTranslator.ToOle(System.Drawing.Color.Black);

                        int i = 0;
                        row = 3;
                        foreach (ListViewItem item in lv_nhapSach.Items)
                        {
                            i++;
                            row++;
                            dynamic[] arr = { i, item.SubItems[0].Text, item.SubItems[1].Text, item.SubItems[2].Text, item.SubItems[3].Text, item.SubItems[4].Text };
                            Excel.Range rowData = ws.get_Range("A" + row, "F" + row); // Lấy dòng thứ row để đổ dữ liệu
                            rowData.Font.Size = fontSizeNoiDung;
                            rowData.Font.Name = fontName;
                            rowData.Value2 = arr;

                        }

                        //Kẻ khung toàn bộ
                        BorderAround(ws.get_Range("A2", "F" + row));
                        ws.get_Range("A1", "F" + row).Columns.AutoFit();

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

                    MessageBox.Show("Thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    lv_nhapSach.Items.Clear();
                this.Dispose();
            }
            else
            {
                MessageBox.Show("Danh sách nhập sách trống!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
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

        private void txtBoxTensach_Load(object sender, EventArgs e)
        {

        }

        private void FormPhieunhapsach_Load(object sender, EventArgs e)
        {
            // Tu dong dien ngay hien tai
            dtpNgay.Value = System.DateTime.Now;
            dtpNgay.MaxDate = System.DateTime.Now;

            // Autofill Tensach
            AutoCompleteStringCollection ascs = new AutoCompleteStringCollection();
            Globals.sqlcon.Open();
            using (SqlCommand command = Globals.sqlcon.CreateCommand())
            {
                command.CommandText = "select * from SACH";
                SqlDataReader dr = command.ExecuteReader();
                while (dr.Read())
                {
                    ascs.Add(dr["TenSach"].ToString());
                }
            }
            txtBoxTensach.AutoCompleteCustomSource = ascs;
            Globals.sqlcon.Close();
        }
    }
}
