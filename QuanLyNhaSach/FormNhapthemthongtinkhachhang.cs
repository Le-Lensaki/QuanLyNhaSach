using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyNhaSach
{
    public partial class FormNhapthemthongtinkhachhang : Form
    {
        public string diaChi, email;
        public bool cancel = false;
        public FormNhapthemthongtinkhachhang()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
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

        private void rjButton3_Click(object sender, EventArgs e)
        {
            diaChi = txtBoxDiachi.Texts;
            email = txtBoxEmail.Texts;
            Dispose();
        }

        private void FormNhapthemthongtinkhachhang_Load(object sender, EventArgs e)
        {

        }
    }
}
