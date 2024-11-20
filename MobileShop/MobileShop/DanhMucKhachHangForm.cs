using System;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;

namespace MobileShop
{
    public partial class DanhMucKhachHangForm : Form
    {
        private SqlConnection connection;
        private SqlDataAdapter adapter;
        private DataTable table;

        public DanhMucKhachHangForm()
        {
            InitializeComponent();
            connection = new SqlConnection("Server=BaDo;Database=MobileShop;User Id=sa;Password=123456789;");
            LoadData();
        }

        private void LoadData()
        {
            connection.Open();
            adapter = new SqlDataAdapter("SELECT * FROM KhachHang", connection);
            table = new DataTable();
            adapter.Fill(table);
            dataGridView1.DataSource = table;
            connection.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("INSERT INTO KhachHang (tenKH, diachi, sdt) VALUES (@tenKH, @diachi, @sdt)", connection);
            command.Parameters.AddWithValue("@tenKH", txtTenKH.Text);
            command.Parameters.AddWithValue("@diachi", txtDiaChi.Text);
            command.Parameters.AddWithValue("@sdt", txtSDT.Text);
            connection.Open();
            command.ExecuteNonQuery();
            connection.Close();
            LoadData();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("UPDATE KhachHang SET tenKH=@tenKH, diachi=@diachi, sdt=@sdt WHERE id=@id", connection);
            command.Parameters.AddWithValue("@id", txtID.Text);
            command.Parameters.AddWithValue("@tenKH", txtTenKH.Text);
            command.Parameters.AddWithValue("@diachi", txtDiaChi.Text);
            command.Parameters.AddWithValue("@sdt", txtSDT.Text);
            connection.Open();
            command.ExecuteNonQuery();
            connection.Close();
            LoadData();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("DELETE FROM KhachHang WHERE id=@id", connection);
            command.Parameters.AddWithValue("@id", txtID.Text);
            connection.Open();
            command.ExecuteNonQuery();
            connection.Close();
            LoadData();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            DataView dv = table.DefaultView;
            dv.RowFilter = string.Format("tenKH LIKE '%{0}%'", txtSearch.Text);
            dataGridView1.DataSource = dv.ToTable();
        }
    }
}
