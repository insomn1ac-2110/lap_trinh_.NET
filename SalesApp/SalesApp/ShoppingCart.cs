using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesApp
{
    public class ShoppingCart { private List<Product> items; public ShoppingCart() { items = new List<Product>(); } public void AddProduct(Product product) { var existingProduct = items.FirstOrDefault(p => p.Name == product.Name); if (existingProduct != null) { existingProduct.Quantity += product.Quantity; } else { items.Add(new Product { Name = product.Name, Price = product.Price, Quantity = product.Quantity }); } } public void RemoveProduct(Product product) { var existingProduct = items.FirstOrDefault(p => p.Name == product.Name); if (existingProduct != null) { items.Remove(existingProduct); } } public decimal GetTotalPrice() { return items.Sum(item => item.Price * item.Quantity); } public void Clear() { items.Clear(); } public List<Product> Items => items; }

}
