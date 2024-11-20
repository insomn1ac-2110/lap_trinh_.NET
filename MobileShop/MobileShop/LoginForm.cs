using System;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace MobileShop
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string connectionString = "Server=BaDo;Database=MobileShop;User Id=sa;Password=123456789;";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT COUNT(1) FROM NguoiDung WHERE tendangnhap=@tendangnhap AND matkhau=@matkhau";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@tendangnhap", txtUsername.Text);
                command.Parameters.AddWithValue("@matkhau", txtPassword.Text);
                connection.Open();
                int count = Convert.ToInt32(command.ExecuteScalar());
                if (count == 1)
                {
                    this.Hide();
                    MainForm mainForm = new MainForm();
                    mainForm.Show();
                }
                else
                {
                    MessageBox.Show("Tên đăng nhập hoặc mật khẩu không đúng.");
                }
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
