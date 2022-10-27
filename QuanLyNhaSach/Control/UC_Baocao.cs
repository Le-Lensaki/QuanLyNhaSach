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

namespace QuanLyNhaSach.Control
{
    public partial class UC_Baocao : UserControl
    {
        SqlDataAdapter sda;
        DataSet bcTon;
        DataSet bcCongNo;

        public void LoadBCTon(string month, string year)
        {
            Globals.sqlcon.Open();
            string thangNam = dtpThangNam.Text;
            string query = "select TenSach, TonDau, TonPhatSinh, TonCuoi from BAOCAOTON BC join SACH S on BC.MaSach = S.MaSach" +
                " where Thang = " + month + @" and NAM = " + year;
            SqlCommand sc = new SqlCommand(query, Globals.sqlcon);
            sc.CommandType = CommandType.Text;
            sda = new SqlDataAdapter(sc);
            bcTon = new DataSet();
            sda.Fill(bcTon, "BCT_Details");
            Globals.sqlcon.Close();
            dgvTon.DataSource = bcTon.Tables[0];
        }
        public void LoadBCCongNo(string month, string year)
        {
            Globals.sqlcon.Open();
            string query = "select TenKH, NoDau, PhatSinh, NoCuoi from BAOCAOCONGNO BC join KHACHHANG KH on BC.MaKH = KH.MaKH" +
                " where Thang = " + month + @" and NAM = " + year;
            SqlCommand sc = new SqlCommand(query, Globals.sqlcon);
            sc.CommandType = CommandType.Text;
            sda = new SqlDataAdapter(sc);
            bcCongNo = new DataSet();
            sda.Fill(bcCongNo, "BCCN_Details");
            Globals.sqlcon.Close();
            dgvCongno.DataSource = bcCongNo.Tables[0];
        }
        public UC_Baocao()
        {
            InitializeComponent();
            dtpThangNam.Value = System.DateTime.Now.AddMonths(-1);
            dtpThangNam.MaxDate = System.DateTime.Now.AddMonths(-1);
        }
        private bool IsDate(string tempDate)
        {
            DateTime fromDateValue;
            var formats = new[] { "MM/yyyy", "M/yyyy" };
            if (DateTime.TryParseExact(tempDate, formats, System.Globalization.CultureInfo.InvariantCulture, System.Globalization.DateTimeStyles.None, out fromDateValue))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void UC_Baocao_Load(object sender, EventArgs e)
        {

        }

        private void rjButton4_Click(object sender, EventArgs e)
        {
            if (chonDuongDan.ShowDialog() == DialogResult.OK)
            {
                string saveLocation = chonDuongDan.FileName;

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
                Excel.Range row1_TieuDe_Baocao = ws.get_Range("A1", "E1");
                row1_TieuDe_Baocao.Merge();
                row1_TieuDe_Baocao.Font.Size = fontSizeTieuDe;
                row1_TieuDe_Baocao.Font.Name = fontName;
                row1_TieuDe_Baocao.Cells.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
                if (dgvTon.Visible)
                    row1_TieuDe_Baocao.Value2 = "Báo cáo tồn";
                if (dgvCongno.Visible)
                    row1_TieuDe_Baocao.Value2 = "Báo cáo công nợ";

                //Tạo Ô Số Thứ Tự (STT)
                Excel.Range row2_STT = ws.get_Range("A2", "A2");//Cột A dòng 2
                row2_STT.Font.Size = fontSizeTenTruong;
                row2_STT.Font.Name = fontName;
                row2_STT.Cells.HorizontalAlignment = XlHAlign.xlHAlignCenter;
                row2_STT.Value2 = "STT";

                //Tạo Ô t1
                Excel.Range row2_col1 = ws.get_Range("B2", "B2");//Cột A dòng 2
                row2_col1.Font.Size = fontSizeTenTruong;
                row2_col1.Font.Name = fontName;
                row2_col1.Cells.HorizontalAlignment = XlHAlign.xlHAlignCenter;
                if (dgvTon.Visible)
                    row2_col1.Value2 = "Sách";
                if (dgvCongno.Visible)
                    row2_col1.Value2 = "Khách hàng";

                //Tạo Ô 
                Excel.Range row2_col2 = ws.get_Range("C2", "C2");//Cột B dòng 2
                row2_col2.Font.Size = fontSizeTenTruong;
                row2_col2.Font.Name = fontName;
                row2_col2.Cells.HorizontalAlignment = XlHAlign.xlHAlignCenter;
                if (dgvTon.Visible)
                    row2_col2.Value2 = "Tồn đầu";
                if (dgvCongno.Visible)
                    row2_col2.Value2 = "Nợ đầu";

                //Tạo Ô Thể loại
                Excel.Range row2_col3 = ws.get_Range("D2", "D2");//Cột C dòng 2
                row2_col3.Font.Size = fontSizeTenTruong;
                row2_col3.Font.Name = fontName;
                row2_col3.Cells.HorizontalAlignment = XlHAlign.xlHAlignCenter;
                row2_col3.Value2 = "Phát sinh";

                //Tạo Ô Tác giả
                Excel.Range row2_col4 = ws.get_Range("E2", "E2");//Cột D dòng 2
                row2_col4.Font.Size = fontSizeTenTruong;
                row2_col4.Font.Name = fontName;
                row2_col4.Cells.HorizontalAlignment = XlHAlign.xlHAlignCenter;
                if (dgvTon.Visible)
                    row2_col4.Value2 = "Tồn cuối";
                if (dgvCongno.Visible)
                    row2_col4.Value2 = "Nợ cuối";



                //Tô nền vàng các cột tiêu đề:
                Excel.Range row2_CotTieuDe = ws.get_Range("A2", "E2");
                //nền vàng
                row2_CotTieuDe.Interior.Color = ColorTranslator.ToOle(System.Drawing.Color.Yellow);
                //in đậm
                row2_CotTieuDe.Font.Bold = true;
                //chữ đen
                row2_CotTieuDe.Font.Color = ColorTranslator.ToOle(System.Drawing.Color.Black);

                int stt = 0;
                row = 2; // dữ liệu bắt đầu từ dòng số 3 trong file Excel
                if (dgvTon.Visible)
                {
                    foreach (DataRow baocao in bcTon.Tables[0].Rows)
                    {
                        stt++;
                        row++;
                        dynamic[] arr = { stt, baocao[0], baocao[1], baocao[2], baocao[3] };
                        Excel.Range rowData = ws.get_Range("A" + row, "E" + row); // Lấy dòng thứ row để đổ dữ liệu
                        rowData.Font.Size = fontSizeNoiDung;
                        rowData.Font.Name = fontName;
                        rowData.Value2 = arr;

                    }
                }
                if (dgvCongno.Visible)
                {
                    foreach (DataRow baocao in bcCongNo.Tables[0].Rows)
                    {
                        stt++;
                        row++;
                        dynamic[] arr = { stt, baocao[0], baocao[1], baocao[2], baocao[3] };
                        Excel.Range rowData = ws.get_Range("A" + row, "E" + row); // Lấy dòng thứ row để đổ dữ liệu
                        rowData.Font.Size = fontSizeNoiDung;
                        rowData.Font.Name = fontName;
                        rowData.Value2 = arr;

                    }
                }

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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void rjButton1_Click(object sender, EventArgs e)
        {
            //Báo cáo tồn thì bảng Công nợ ẩn đi
            dgvTon.Visible = true;
            dgvCongno.Visible = false;
            //Dùng SQL đưa vô Datagrid dgvTon
            string[] ThangNam = dtpThangNam.Text.Split("/");
            LoadBCTon(ThangNam[0], ThangNam[1]);
        }

        private void rjButton2_Click(object sender, EventArgs e)
        {
            //Báo cáo công nợ thì bảng Báo cáo tồn ẩn đi
            dgvTon.Visible = false;
            dgvCongno.Visible = true;
            //Dùng SQL đưa dữ liệu vào Datagrid dgvCongno
            string[] ThangNam = dtpThangNam.Text.Split("/");
            LoadBCCongNo(ThangNam[0], ThangNam[1]);
        }
        private void dgvCongno_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            dgvCongno.Rows[e.RowIndex].Cells[0].Value = (e.RowIndex + 1).ToString();
        }
        private void dgvTon_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            dgvTon.Rows[e.RowIndex].Cells[0].Value = (e.RowIndex + 1).ToString();
        }

        private void dgvTon_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
