using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Drawing;

namespace SalesApp
{
    public partial class MainForm : Form
    {
        private List<Product> products;
        private ShoppingCart cart;

        // Các phần tử giao diện người dùng
        private ListView productList;
        private ListView cartList;
        private Button addToCartButton;
        private Button removeFromCartButton;
        private Button checkoutButton;
        private Label totalPriceLabel;

        public MainForm()
        {
            InitializeComponent();
            products = new List<Product>();
            cart = new ShoppingCart();
            InitializeUI();
        }

        private void InitializeUI()
        {
            // Khởi tạo và cấu hình các phần tử giao diện người dùng
            productList = new ListView
            {
                View = View.Details,
                FullRowSelect = true,
                Width = 400,
                Height = 200,
                Location = new Point(10, 10)
            };
            productList.Columns.Add("Hình ảnh", -2, HorizontalAlignment.Left);
            productList.Columns.Add("Tên", -2, HorizontalAlignment.Left);
            productList.Columns.Add("Giá", -2, HorizontalAlignment.Left);
            productList.Columns.Add("Số lượng", -2, HorizontalAlignment.Left);

            cartList = new ListView
            {
                View = View.Details,
                FullRowSelect = true,
                Width = 400,
                Height = 200,
                Location = new Point(10, 220)
            };
            cartList.Columns.Add("Tên", -2, HorizontalAlignment.Left);
            cartList.Columns.Add("Giá", -2, HorizontalAlignment.Left);
            cartList.Columns.Add("Số lượng", -2, HorizontalAlignment.Left);

            addToCartButton = new Button { Text = "Thêm vào giỏ hàng", Location = new Point(420, 10) };
            removeFromCartButton = new Button { Text = "Xóa khỏi giỏ hàng", Location = new Point(420, 40) };
            checkoutButton = new Button { Text = "Thanh toán", Location = new Point(420, 70) };
            totalPriceLabel = new Label { Text = "Tổng giá trị: 0", Location = new Point(420, 100) };

            // Thêm các sự kiện cho các nút
            addToCartButton.Click += AddToCartButton_Click;
            removeFromCartButton.Click += RemoveFromCartButton_Click;
            checkoutButton.Click += CheckoutButton_Click;

            // Thêm các phần tử vào form
            this.Controls.Add(productList);
            this.Controls.Add(cartList);
            this.Controls.Add(addToCartButton);
            this.Controls.Add(removeFromCartButton);
            this.Controls.Add(checkoutButton);
            this.Controls.Add(totalPriceLabel);

            // Tải sản phẩm vào danh sách sản phẩm
            LoadProducts();
        }

        private void LoadProducts()
        {
            // Sản phẩm ví dụ
            var sampleProduct = new Product
            {
                Name = "Sản phẩm mẫu",
                Price = 10,
                Quantity = 1,
                Image = null // Tải hình ảnh thực tế nếu có
            };
            products.Add(sampleProduct);

            // Thêm sản phẩm vào danh sách sản phẩm
            foreach (var product in products)
            {
                var listViewItem = new ListViewItem(new[]
                {
                    "", // Chỗ trống cho hình ảnh
                    product.Name,
                    product.Price.ToString(),
                    product.Quantity.ToString()
                });
                productList.Items.Add(listViewItem);
            }
        }

        // Sự kiện nút
        private void AddToCartButton_Click(object sender, EventArgs e)
        {
            if (productList.SelectedItems.Count > 0)
            {
                var selectedProduct = products[productList.SelectedItems[0].Index];
                cart.AddProduct(selectedProduct);
                UpdateCartUI();
            }
        }

        private void RemoveFromCartButton_Click(object sender, EventArgs e)
        {
            if (cartList.SelectedItems.Count > 0)
            {
                var selectedProduct = cart.Items[cartList.SelectedItems[0].Index];
                cart.RemoveProduct(selectedProduct);
                UpdateCartUI();
            }
        }

        private void CheckoutButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Đơn hàng đã được xác nhận!");
            cart.Clear();
            UpdateCartUI();
        }

        private void UpdateCartUI()
        {
            cartList.Items.Clear();
            foreach (var item in cart.Items)
            {
                var listViewItem = new ListViewItem(new[]
                {
                    item.Name,
                    item.Price.ToString(),
                    item.Quantity.ToString()
                });
                cartList.Items.Add(listViewItem);
            }
            totalPriceLabel.Text = $"Tổng giá trị: {cart.GetTotalPrice()}";
        }
    }
}
