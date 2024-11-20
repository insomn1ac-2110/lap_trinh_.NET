using System.Drawing;
using System.Windows.Forms;
using System;

namespace MobileShop
{
    partial class DonHangForm
    {
        private System.ComponentModel.IContainer components = null;
        private DataGridView dataGridView1;
        private TextBox txtID;
        private TextBox txtKhachHangID;
        private TextBox txtSanPhamID;
        private TextBox txtSoLuong;
        private DateTimePicker dateTimePicker1;
        private Button btnAdd;
        private Button btnEdit;
        private Button btnDelete;
        private Button btnSearch;
        private TextBox txtSearch;

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
            this.dataGridView1 = new DataGridView();
            this.txtID = new TextBox();
            this.txtKhachHangID = new TextBox();
            this.txtSanPhamID = new TextBox();
            this.txtSoLuong = new TextBox();
            this.dateTimePicker1 = new DateTimePicker();
            this.btnAdd = new Button();
            this.btnEdit = new Button();
            this.btnDelete = new Button();
            this.btnSearch = new Button();
            this.txtSearch = new TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();

            // dataGridView1
            this.dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new Size(776, 300);
            this.dataGridView1.TabIndex = 0;

            // txtID
            this.txtID.Location = new Point(12, 330);
            this.txtID.Name = "txtID";
            this.txtID.Size = new Size(100, 20);
            this.txtID.TabIndex = 1;

            // txtKhachHangID
            this.txtKhachHangID.Location = new Point(12, 360);
            this.txtKhachHangID.Name = "txtKhachHangID";
            this.txtKhachHangID.Size = new Size(100, 20);
            this.txtKhachHangID.TabIndex = 2;

            // txtSanPhamID
            this.txtSanPhamID.Location = new Point(12, 390);
            this.txtSanPhamID.Name = "txtSanPhamID";
            this.txtSanPhamID.Size = new Size(100, 20);
            this.txtSanPhamID.TabIndex = 3;

            // txtSoLuong
            this.txtSoLuong.Location = new Point(12, 420);
            this.txtSoLuong.Name = "txtSoLuong";
            this.txtSoLuong.Size = new Size(100, 20);
            this.txtSoLuong.TabIndex = 4;

            // dateTimePicker1
            this.dateTimePicker1.Location = new Point(150, 360);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new Size(200, 20);
            this.dateTimePicker1.TabIndex = 5;

            // btnAdd
            this.btnAdd.Location = new Point(150, 390);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new Size(75, 23);
            this.btnAdd.TabIndex = 6;
            this.btnAdd.Text = "Thêm";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new EventHandler(this.btnAdd_Click);

            // btnEdit
            this.btnEdit.Location = new Point(275, 390);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new Size(75, 23);
            this.btnEdit.TabIndex = 7;
            this.btnEdit.Text = "Sửa";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new EventHandler(this.btnEdit_Click);

            // btnDelete
            this.btnDelete.Location = new Point(150, 420);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new Size(75, 23);
            this.btnDelete.TabIndex = 8;
            this.btnDelete.Text = "Xóa";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new EventHandler(this.btnDelete_Click);

            // btnSearch
            this.btnSearch.Location = new Point(275, 420);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new Size(75, 23);
            this.btnSearch.TabIndex = 9;
            this.btnSearch.Text = "Tìm kiếm";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new EventHandler(this.btnSearch_Click);

            // txtSearch
            this.txtSearch.Location = new Point(150, 450);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new Size(200, 20);
            this.txtSearch.TabIndex = 10;

            // DonHangForm
            this.ClientSize = new Size(800, 480);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.txtKhachHangID);
            this.Controls.Add(this.txtSanPhamID);
            this.Controls.Add(this.txtSoLuong);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtSearch);
            this.Name = "DonHangForm";
            this.Text = "Đơn hàng";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
