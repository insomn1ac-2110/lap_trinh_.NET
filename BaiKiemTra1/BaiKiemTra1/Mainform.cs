using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaiKiemTra1
{
    public partial class MainForm : Form
    {
        private ShoppingCart shoppingCart;
        private List<Product> products;

        public MainForm()
        {
            InitializeComponent();
            shoppingCart = new ShoppingCart();
            products = new List<Product>
        {
            new Product("Sản phẩm 1", 100m, 1, Image.FromFile("path_to_image1")),
            new Product("Sản phẩm 2", 150m, 1, Image.FromFile("path_to_image2")),
            new Product("Sản phẩm 3", 200m, 1, Image.FromFile("path_to_image3"))
        };
            LoadProducts();
        }

        private void LoadProducts()
        {
            foreach (var product in products)
            {
                var item = new ListViewItem(product.Name);
                item.SubItems.Add(product.Price.ToString("C"));
                item.Tag = product;
                object value = (listViewProducts.Items as object).Add(item);
            }
        }

        private void btnAddToCart_Click(object sender, EventArgs e)
        {
            if (listViewProducts.SelectedItems.Count > 0)
            {
                Product selectedProduct = (Product)listViewProducts.SelectedItems[0].Tag;
                shoppingCart.AddProduct(selectedProduct);
                UpdateCartView();
            }
        }

        private void btnRemoveFromCart_Click(object sender, EventArgs e)
        {
            if (listViewCart.SelectedItems.Count > 0)
            {
                var selectedProduct = (Product)listViewCart.SelectedItems[0].Tag;
                shoppingCart.RemoveProduct(selectedProduct);
                UpdateCartView();
            }
        }

        private void UpdateCartView()
        {
            listViewCart.Items.Clear();
            foreach (var item in shoppingCart.GetCartItems())
            {
                var row = new ListViewItem(item.Name);
                row.SubItems.Add(item.Quantity.ToString());
                row.SubItems.Add(item.Price.ToString("C"));
                row.Tag = item;
                listViewCart.Items.Add(row);
            }
            lblTotal.Text = $"Tổng giá trị: {shoppingCart.GetTotalValue():C}";
        }

        private void btnCheckout_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Thanh toán thành công! Đơn hàng của bạn đã được xử lý.");
            shoppingCart.ClearCart();
            UpdateCartView();
        }
    }
}
