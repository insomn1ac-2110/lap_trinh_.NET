namespace _30__10
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private Button btnRemoveFromCart;
        private Button btnCheckout;
        private Label lblTotal;
        private object btnAddToCart;
        private ListView listViewProducts;
        private ListView listViewCart;

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

        private void InitializeComponent()
        {
            this.listViewProducts = new System.Windows.Forms.ListView();
            this.listViewCart = new System.Windows.Forms.ListView();
            Button button = new System.Windows.Forms.Button();
            this.btnAddToCart_Click = button;
            this.btnRemoveFromCart = button;
            this.btnCheckout = button;
            this.lblTotal = new System.Windows.Forms.Label();

            // 
            // listViewProducts
            // 
            this.listViewProducts.Location = new System.Drawing.Point(12, 12);
            this.listViewProducts.Name = "listViewProducts";
            this.listViewProducts.Size = new System.Drawing.Size(200, 300);
            this.listViewProducts.View = System.Windows.Forms.View.Details;
            this.listViewProducts.Columns.Add("Tên sản phẩm", 120);
            this.listViewProducts.Columns.Add("Giá", 80);
            this.listViewProducts.TabIndex = 0;
            this.listViewProducts.FullRowSelect = true;

            // 
            // listViewCart
            // 
            this.listViewCart.Location = new System.Drawing.Point(220, 12);
            this.listViewCart.Name = "listViewCart";
            this.listViewCart.Size = new System.Drawing.Size(300, 300);
            this.listViewCart.View = System.Windows.Forms.View.Details;
            this.listViewCart.Columns.Add("Tên sản phẩm", 120);
            this.listViewCart.Columns.Add("Số lượng", 80);
            this.listViewCart.Columns.Add("Giá", 80);
            this.listViewCart.TabIndex = 1;
            this.listViewCart.FullRowSelect = true;

            // 
            // btnAddToCart
            // 
            this.btnAddToCart_Click = button;
            this.btnAddToCart.Location = new System.Drawing.Point(12, 320);
            this.btnAddToCart.Name = "btnAddToCart";
            this.btnAddToCart.Size = new System.Drawing.Size(200, 23);
            this.btnAddToCart.TabIndex = 2;
            this.btnAddToCart.Text = "Thêm vào giỏ hàng";
            this.btnAddToCart.UseVisualStyleBackColor = true;
            this.btnAddToCart.Click += new System.EventHandler(this.btnAddToCart_Click);

            // 
            // btnRemoveFromCart
            // 
            this.btnRemoveFromCart.Location = new System.Drawing.Point(220, 320);
            this.btnRemoveFromCart.Name = "btnRemoveFromCart";
            this.btnRemoveFromCart.Size = new System.Drawing.Size(300, 23);
            this.btnRemoveFromCart.TabIndex = 3;
            this.btnRemoveFromCart.Text = "Xóa khỏi giỏ hàng";
            this.btnRemoveFromCart.UseVisualStyleBackColor = true;
            this.btnRemoveFromCart.Click += new System.EventHandler(this.btnRemoveFromCart_Click);

            // 
            // btnCheckout
            // 
            this.btnCheckout.Location = new System.Drawing.Point(220, 360);
            this.btnCheckout.Name = "btnCheckout";
            this.btnCheckout.Size = new System.Drawing.Size(300, 23);
            this.btnCheckout.TabIndex = 4;
            this.btnCheckout.Text = "Thanh toán";
            this.btnCheckout.UseVisualStyleBackColor = true;
            this.btnCheckout.Click += new System.EventHandler(this.btnCheckout_Click);

            // 
            // lblTotal
            // 
            this.lblTotal.Location = new System.Drawing.Point(220, 390);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(300, 23);
            this.lblTotal.TabIndex = 5;
            this.lblTotal.Text = "Tổng giá trị: 0 VND";
            this.lblTotal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;

            // 
            // MainForm
            // 
            this.ClientSize = new System.Drawing.Size(540, 420);
            this.Controls.Add(this.listViewProducts);
            this.Controls.Add(this.listViewCart);
            this.Controls.Add(this.btnAddToCart);
            this.Controls.Add(this.btnRemoveFromCart);
            this.Controls.Add(this.btnCheckout);
            this.Controls.Add(this.lblTotal);
            this.Name = "MainForm";
            this.Text = "Ứng dụng bán hàng đơn giản";
        }
    }
}
