namespace baiTap23_10
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtMa = new TextBox();
            txtAnh = new TextBox();
            txtGia = new TextBox();
            txtTen = new TextBox();
            txtMota = new TextBox();
            groupBox1 = new GroupBox();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            txtMota2 = new TextBox();
            cbLoai = new ComboBox();
            groupBox2 = new GroupBox();
            btnXoa = new Button();
            btnSua = new Button();
            btnThem = new Button();
            btnLMoi = new Button();
            groupBox3 = new GroupBox();
            dataGridView1 = new DataGridView();
            txtTim = new TextBox();
            btnTim = new Button();
            label8 = new Label();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // txtMa
            // 
            txtMa.Location = new Point(143, 64);
            txtMa.Name = "txtMa";
            txtMa.Size = new Size(269, 27);
            txtMa.TabIndex = 0;
            // 
            // txtAnh
            // 
            txtAnh.Location = new Point(143, 206);
            txtAnh.Name = "txtAnh";
            txtAnh.Size = new Size(269, 27);
            txtAnh.TabIndex = 1;
            // 
            // txtGia
            // 
            txtGia.Location = new Point(143, 158);
            txtGia.Name = "txtGia";
            txtGia.Size = new Size(269, 27);
            txtGia.TabIndex = 2;
            // 
            // txtTen
            // 
            txtTen.Location = new Point(143, 109);
            txtTen.Name = "txtTen";
            txtTen.Size = new Size(269, 27);
            txtTen.TabIndex = 3;
            // 
            // txtMota
            // 
            txtMota.Location = new Point(143, 255);
            txtMota.Name = "txtMota";
            txtMota.Size = new Size(269, 27);
            txtMota.TabIndex = 4;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(txtMota2);
            groupBox1.Controls.Add(cbLoai);
            groupBox1.Controls.Add(txtGia);
            groupBox1.Controls.Add(txtMota);
            groupBox1.Controls.Add(txtMa);
            groupBox1.Controls.Add(txtTen);
            groupBox1.Controls.Add(txtAnh);
            groupBox1.Location = new Point(41, 40);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(440, 515);
            groupBox1.TabIndex = 5;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông tin";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(28, 432);
            label7.Name = "label7";
            label7.Size = new Size(60, 20);
            label7.TabIndex = 13;
            label7.Text = "Loại SP:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(28, 311);
            label6.Name = "label6";
            label6.Size = new Size(100, 20);
            label6.TabIndex = 12;
            label6.Text = "Mô tả chi tiết:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(28, 258);
            label5.Name = "label5";
            label5.Size = new Size(88, 20);
            label5.TabIndex = 11;
            label5.Text = "Mô tả ngắn:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(28, 209);
            label4.Name = "label4";
            label4.Size = new Size(71, 20);
            label4.TabIndex = 10;
            label4.Text = "Hình ảnh:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(28, 161);
            label3.Name = "label3";
            label3.Size = new Size(65, 20);
            label3.TabIndex = 9;
            label3.Text = "Đơn giá:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(28, 112);
            label2.Name = "label2";
            label2.Size = new Size(55, 20);
            label2.TabIndex = 8;
            label2.Text = "Tên SP:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(28, 67);
            label1.Name = "label1";
            label1.Size = new Size(53, 20);
            label1.TabIndex = 7;
            label1.Text = "Mã SP:";
            // 
            // txtMota2
            // 
            txtMota2.Location = new Point(143, 308);
            txtMota2.Multiline = true;
            txtMota2.Name = "txtMota2";
            txtMota2.Size = new Size(269, 89);
            txtMota2.TabIndex = 6;
            // 
            // cbLoai
            // 
            cbLoai.FormattingEnabled = true;
            cbLoai.Items.AddRange(new object[] { "Áo", "Quần", "Đồ ăn" });
            cbLoai.Location = new Point(143, 429);
            cbLoai.Name = "cbLoai";
            cbLoai.Size = new Size(269, 28);
            cbLoai.TabIndex = 5;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btnXoa);
            groupBox2.Controls.Add(btnSua);
            groupBox2.Controls.Add(btnThem);
            groupBox2.Controls.Add(btnLMoi);
            groupBox2.Location = new Point(41, 555);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(440, 137);
            groupBox2.TabIndex = 6;
            groupBox2.TabStop = false;
            groupBox2.Text = "Chức năng";
            // 
            // btnXoa
            // 
            btnXoa.Location = new Point(243, 86);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(94, 29);
            btnXoa.TabIndex = 3;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += button4_Click;
            // 
            // btnSua
            // 
            btnSua.Location = new Point(90, 86);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(94, 29);
            btnSua.TabIndex = 2;
            btnSua.Text = "Sửa ";
            btnSua.UseVisualStyleBackColor = true;
            btnSua.Click += btnSua_Click;
            // 
            // btnThem
            // 
            btnThem.Location = new Point(243, 38);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(94, 29);
            btnThem.TabIndex = 1;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // btnLMoi
            // 
            btnLMoi.Location = new Point(90, 38);
            btnLMoi.Name = "btnLMoi";
            btnLMoi.Size = new Size(94, 29);
            btnLMoi.TabIndex = 0;
            btnLMoi.Text = "Làm mới";
            btnLMoi.UseVisualStyleBackColor = true;
            btnLMoi.Click += btnLMoi_Click;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(dataGridView1);
            groupBox3.Controls.Add(txtTim);
            groupBox3.Controls.Add(btnTim);
            groupBox3.Controls.Add(label8);
            groupBox3.Location = new Point(487, 40);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(577, 652);
            groupBox3.TabIndex = 7;
            groupBox3.TabStop = false;
            groupBox3.Text = "Dữ liệu";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(33, 109);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(506, 521);
            dataGridView1.TabIndex = 3;
            // 
            // txtTim
            // 
            txtTim.Location = new Point(112, 44);
            txtTim.Name = "txtTim";
            txtTim.Size = new Size(327, 27);
            txtTim.TabIndex = 2;
            // 
            // btnTim
            // 
            btnTim.Location = new Point(445, 44);
            btnTim.Name = "btnTim";
            btnTim.Size = new Size(94, 29);
            btnTim.TabIndex = 1;
            btnTim.Text = "Tìm kiếm";
            btnTim.UseVisualStyleBackColor = true;
            btnTim.Click += btnTim_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(33, 48);
            label8.Name = "label8";
            label8.Size = new Size(73, 20);
            label8.TabIndex = 0;
            label8.Text = "Tìm kiếm:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1076, 704);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TextBox txtMa;
        private TextBox txtAnh;
        private TextBox txtGia;
        private TextBox txtTen;
        private TextBox txtMota;
        private GroupBox groupBox1;
        private TextBox txtMota2;
        private ComboBox cbLoai;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Label label6;
        private Label label5;
        private Label label7;
        private Button btnXoa;
        private Button btnSua;
        private Button btnThem;
        private Button btnLMoi;
        private Button btnTim;
        private Label label8;
        private TextBox txtTim;
        private DataGridView dataGridView1;
    }
}
