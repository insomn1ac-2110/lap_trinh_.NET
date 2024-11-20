using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace MobileShop
{
    public partial class DonHangForm : Form
    {
        private SqlConnection connection;
        private SqlDataAdapter adapter;
        private DataTable table;

        public DonHangForm()
        {
            InitializeComponent();
            connection = new SqlConnection("Server=BaDo;Database=MobileShop;User Id=sa;Password=123456789;");
            LoadData();
        }

        private void LoadData()
        {
            connection.Open();
            adapter = new SqlDataAdapter("SELECT * FROM DonHang", connection);
            table = new DataTable();
            adapter.Fill(table);
            dataGridView1.DataSource = table;
            connection.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("INSERT INTO DonHang (khachhangid, sanphamid, soluong, ngaymua) VALUES (@khachhangid, @sanphamid, @soluong, @ngaymua)", connection);
            command.Parameters.AddWithValue("@khachhangid", txtKhachHangID.Text);
            command.Parameters.AddWithValue("@sanphamid", txtSanPhamID.Text);
            command.Parameters.AddWithValue("@soluong", txtSoLuong.Text);
            command.Parameters.AddWithValue("@ngaymua", dateTimePicker1.Value);
            connection.Open();
            command.ExecuteNonQuery();
            connection.Close();
            LoadData();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("UPDATE DonHang SET khachhangid=@khachhangid, sanphamid=@sanphamid, soluong=@soluong, ngaymua=@ngaymua WHERE id=@id", connection);
            command.Parameters.AddWithValue("@id", txtID.Text);
            command.Parameters.AddWithValue("@khachhangid", txtKhachHangID.Text);
            command.Parameters.AddWithValue("@sanphamid", txtSanPhamID.Text);
            command.Parameters.AddWithValue("@soluong", txtSoLuong.Text);
            command.Parameters.AddWithValue("@ngaymua", dateTimePicker1.Value);
            connection.Open();
            command.ExecuteNonQuery();
            connection.Close();
            LoadData();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("DELETE FROM DonHang WHERE id=@id", connection);
            command.Parameters.AddWithValue("@id", txtID.Text);
            connection.Open();
            command.ExecuteNonQuery();
            connection.Close();
            LoadData();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            DataView dv = table.DefaultView;
            dv.RowFilter = string.Format("khachhangid LIKE '%{0}%'", txtSearch.Text);
            dataGridView1.DataSource = dv.ToTable();
        }
    }
}
