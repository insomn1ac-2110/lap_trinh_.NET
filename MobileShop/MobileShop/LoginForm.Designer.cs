using System.Drawing;
using System;
using System.Windows.Forms;

namespace MobileShop
{
    partial class LoginForm
    {
        private System.ComponentModel.IContainer components = null;
        private Label lblUsername;
        private TextBox txtUsername;
        private Label lblPassword;
        private TextBox txtPassword;
        private Button btnLogin;
        private Button btnExit;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.lblUsername = new Label();
            this.txtUsername = new TextBox();
            this.lblPassword = new Label();
            this.txtPassword = new TextBox();
            this.btnLogin = new Button();
            this.btnExit = new Button();
            this.SuspendLayout();

            // lblUsername
            this.lblUsername.AutoSize = true;
            this.lblUsername.Location = new Point(50, 50);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new Size(75, 13);
            this.lblUsername.Text = "Tên đăng nhập";

            // txtUsername
            this.txtUsername.Location = new Point(150, 50);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new Size(200, 20);

            // lblPassword
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new Point(50, 100);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new Size(52, 13);
            this.lblPassword.Text = "Mật khẩu";

            // txtPassword
            this.txtPassword.Location = new Point(150, 100);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new Size(200, 20);
            this.txtPassword.PasswordChar = '*';

            // btnLogin
            this.btnLogin.Location = new Point(150, 150);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new Size(75, 23);
            this.btnLogin.Text = "Đăng nhập";
            this.btnLogin.Click += new EventHandler(this.btnLogin_Click);

            // btnExit
            this.btnExit.Location = new Point(275, 150);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new Size(75, 23);
            this.btnExit.Text = "Thoát";
            this.btnExit.Click += new EventHandler(this.btnExit_Click);

            // LoginForm
            this.ClientSize = new Size(400, 250);
            this.Controls.Add(this.lblUsername);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.btnExit);
            this.Name = "LoginForm";
            this.Text = "Đăng nhập";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
