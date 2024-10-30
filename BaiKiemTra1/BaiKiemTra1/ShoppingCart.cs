using System.Collections.Generic;
using System.Linq;
namespace BaiKiemTra1
{
    public class ShoppingCart
    {
        private List<Product> cartItems = new List<Product>();

        public void AddProduct(Product product)
        {
            cartItems.Add(product);
        }

        public void RemoveProduct(Product product)
        {
            cartItems.Remove(product);
        }

        public decimal GetTotalValue()
        {
            return cartItems.Sum(p => p.Price * p.Quantity);
        }

        public List<Product> GetCartItems()
        {
            return cartItems;
        }

        public void ClearCart()
        {
            cartItems.Clear();
        }
    }

}
