using QuanLyKhachHang;
using System.Collections.Generic;
using System.Linq;

public class Invoice
{
    public int Id { get; set; }
    public Customer Customer { get; set; }
    public List<Service> Services { get; set; }

    public decimal TotalPrice
    {
        get
        {
            return Services.Sum(s => s.Price);
        }
    }
}
