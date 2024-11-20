using System;
using System.Windows.Forms;

namespace MobileShop
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void sảnPhẩmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DanhMucSanPhamForm sanPhamForm = new DanhMucSanPhamForm();
            sanPhamForm.Show();
        }

        private void kháchHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DanhMucKhachHangForm khachHangForm = new DanhMucKhachHangForm();
            khachHangForm.Show();
        }

        private void đơnHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DonHangForm donHangForm = new DonHangForm();
            donHangForm.Show();
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
