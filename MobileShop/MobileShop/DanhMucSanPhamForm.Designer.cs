using System.Drawing;
using System.Windows.Forms;
using System;

namespace MobileShop
{
    partial class DanhMucSanPhamForm
    {
        private System.ComponentModel.IContainer components = null;
        private DataGridView dataGridView1;
        private TextBox txtID;
        private TextBox txtTenSP;
        private TextBox txtGia;
        private TextBox txtHangSX;
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
            this.txtTenSP = new TextBox();
            this.txtGia = new TextBox();
            this.txtHangSX = new TextBox();
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

            // txtTenSP
            this.txtTenSP.Location = new Point(12, 360);
            this.txtTenSP.Name = "txtTenSP";
            this.txtTenSP.Size = new Size(100, 20);
            this.txtTenSP.TabIndex = 2;

            // txtGia
            this.txtGia.Location = new Point(12, 390);
            this.txtGia.Name = "txtGia";
            this.txtGia.Size = new Size(100, 20);
            this.txtGia.TabIndex = 3;

            // txtHangSX
            this.txtHangSX.Location = new Point(12, 420);
            this.txtHangSX.Name = "txtHangSX";
            this.txtHangSX.Size = new Size(100, 20);
            this.txtHangSX.TabIndex = 4;

            // btnAdd
            this.btnAdd.Location = new Point(150, 330);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new Size(75, 23);
            this.btnAdd.TabIndex = 5;
            this.btnAdd.Text = "Thêm";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new EventHandler(this.btnAdd_Click);

            // btnEdit
            this.btnEdit.Location = new Point(275, 330);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new Size(75, 23);
            this.btnEdit.TabIndex = 6;
            this.btnEdit.Text = "Sửa";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new EventHandler(this.btnEdit_Click);

            // btnDelete
            this.btnDelete.Location = new Point(150, 360);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new Size(75, 23);
            this.btnDelete.TabIndex = 7;
            this.btnDelete.Text = "Xóa";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new EventHandler(this.btnDelete_Click);

            // btnSearch
            this.btnSearch.Location = new Point(275, 360);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new Size(75, 23);
            this.btnSearch.TabIndex = 8;
            this.btnSearch.Text = "Tìm kiếm";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new EventHandler(this.btnSearch_Click);

            // txtSearch
            this.txtSearch.Location = new Point(150, 390);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new Size(200, 20);
            this.txtSearch.TabIndex = 9;

            // DanhMucSanPhamForm
            this.ClientSize = new Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.txtTenSP);
            this.Controls.Add(this.txtGia);
            this.Controls.Add(this.txtHangSX);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtSearch);
            this.Name = "DanhMucSanPhamForm";
            this.Text = "Danh mục sản phẩm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
