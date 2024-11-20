using System;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;

namespace MobileShop
{
    public partial class DanhMucSanPhamForm : Form
    {
        private SqlConnection connection;
        private SqlDataAdapter adapter;
        private DataTable table;

        public DanhMucSanPhamForm()
        {
            InitializeComponent();
            connection = new SqlConnection("Server=BaDo;Database=MobileShop;User Id=sa;Password=123456789;");
            LoadData();
        }

        private void LoadData()
        {
            connection.Open();
            adapter = new SqlDataAdapter("SELECT * FROM SanPham", connection);
            table = new DataTable();
            adapter.Fill(table);
            dataGridView1.DataSource = table;
            connection.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("INSERT INTO SanPham (tenSP, gia, hangSX) VALUES (@tenSP, @gia, @hangSX)", connection);
            command.Parameters.AddWithValue("@tenSP", txtTenSP.Text);
            command.Parameters.AddWithValue("@gia", txtGia.Text);
            command.Parameters.AddWithValue("@hangSX", txtHangSX.Text);
            connection.Open();
            command.ExecuteNonQuery();
            connection.Close();
            LoadData();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("UPDATE SanPham SET tenSP=@tenSP, gia=@gia, hangSX=@hangSX WHERE id=@id", connection);
            command.Parameters.AddWithValue("@id", txtID.Text);
            command.Parameters.AddWithValue("@tenSP", txtTenSP.Text);
            command.Parameters.AddWithValue("@gia", txtGia.Text);
            command.Parameters.AddWithValue("@hangSX", txtHangSX.Text);
            connection.Open();
            command.ExecuteNonQuery();
            connection.Close();
            LoadData();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("DELETE FROM SanPham WHERE id=@id", connection);
            command.Parameters.AddWithValue("@id", txtID.Text);
            connection.Open();
            command.ExecuteNonQuery();
            connection.Close();
            LoadData();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            DataView dv = table.DefaultView;
            dv.RowFilter = string.Format("tenSP LIKE '%{0}%'", txtSearch.Text);
            dataGridView1.DataSource = dv.ToTable();
        }
    }
}
