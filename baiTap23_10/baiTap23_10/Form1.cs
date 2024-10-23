namespace baiTap23_10
{
    public partial class Form1 : Form
    {
        private List<SanPham> danhSachSanPham = new();
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            // dataGridView1.DataSource = laySanPham().Tables[0];
            dataGridView1.DataSource = danhSachSanPham;
        }
        private void button4_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                string maSPXoa = dataGridView1.SelectedRows[0].Cells["MaSP"].Value.ToString();
                var sanPhamXoa = danhSachSanPham.FirstOrDefault(sp => sp.MaSP == maSPXoa);

                if (sanPhamXoa != null)
                {
                    danhSachSanPham.Remove(sanPhamXoa);
                    // Đặt lại nguồn dữ liệu để làm mới
                    dataGridView1.DataSource = null;
                    dataGridView1.DataSource = danhSachSanPham;
                }
                else
                {
                    MessageBox.Show("Không tìm thấy sản phẩm để xóa.");
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn sản phẩm để xóa.");
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                // Lấy thông tin từ các TextBox và ComboBox
                string maSP = txtMa.Text; // Lấy mã sản phẩm từ TextBox
                string tenSP = txtTen.Text;
                decimal donGia;
                if (!decimal.TryParse(txtGia.Text, out donGia))
                {
                    MessageBox.Show("Đơn giá không hợp lệ.");
                    return;
                }
                string hinhAnh = txtAnh.Text;
                string moTaNgan = txtMota.Text;
                string moTaChiTiet = txtMota2.Text;
                string? loaiSP = cbLoai.SelectedItem?.ToString();

                if (string.IsNullOrEmpty(loaiSP))
                {
                    MessageBox.Show("Vui lòng chọn loại sản phẩm.");
                    return;
                }

                // Tạo đối tượng SanPham và thêm vào danh sách
                SanPham sanPham = new()
                {
                    MaSP = maSP,
                    TenSP = tenSP,
                    DonGia = donGia,
                    HinhAnh = hinhAnh,
                    MoTaNgan = moTaNgan,
                    MoTaChiTiet = moTaChiTiet,
                    LoaiSP = loaiSP
                };

                danhSachSanPham.Add(sanPham); // Thêm sản phẩm vào danh sách  
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        private void btnLMoi_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null; // Đặt lại nguồn dữ liệu để làm mới
            dataGridView1.DataSource = danhSachSanPham; // Cập nhật nguồn dữ liệu

            // Xóa các TextBox và ComboBox
            txtMa.Clear();
            txtTen.Clear();
            txtGia.Clear();
            txtAnh.Clear();
            txtMota.Clear();
            txtMota2.Clear();
            cbLoai.SelectedIndex = -1;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                string maSPSua = dataGridView1.SelectedRows[0].Cells["MaSP"].Value.ToString();
                var sanPhamSua = danhSachSanPham.FirstOrDefault(sp => sp.MaSP == maSPSua);

                if (sanPhamSua != null)
                {
                    // Lấy thông tin từ các TextBox và ComboBox
                    sanPhamSua.MaSP = txtMa.Text;
                    sanPhamSua.TenSP = txtTen.Text;
                    decimal donGia;
                    if (!decimal.TryParse(txtGia.Text, out donGia))
                    {
                        MessageBox.Show("Đơn giá không hợp lệ.");
                        return;
                    }
                    sanPhamSua.DonGia = donGia;
                    sanPhamSua.HinhAnh = txtAnh.Text;
                    sanPhamSua.MoTaNgan = txtMota.Text;
                    sanPhamSua.MoTaChiTiet = txtMota2.Text;
                    sanPhamSua.LoaiSP = cbLoai.SelectedItem?.ToString();

                    // Đặt lại nguồn dữ liệu để làm mới
                    dataGridView1.DataSource = null;
                    dataGridView1.DataSource = danhSachSanPham;
                }
                else
                {
                    MessageBox.Show("Không tìm thấy sản phẩm để sửa.");
                }
            }
        }
        private void btnTim_Click(object sender, EventArgs e)
        {
            string timKiem = txtTim.Text.ToLower();
            var ketQua = danhSachSanPham.Where(sp => sp.MaSP.ToLower().Contains(timKiem) ||
                                                      sp.TenSP.ToLower().Contains(timKiem) ||
                                                      sp.LoaiSP.ToLower().Contains(timKiem)).ToList();

            // Đặt lại nguồn dữ liệu để làm mới
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = ketQua;
        }
    }
}
