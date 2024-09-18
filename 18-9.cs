using System;
using System.Collections.Generic;

class Product
{
    public string TenSanPham { get; set; }
    public double Gia { get; set; }
    public string MoTa { get; set; }
    public int SoLuong { get; set; }

    public Product(string tenSanPham, double gia, string moTa, int soLuong)
    {
        TenSanPham = tenSanPham;
        Gia = gia;
        MoTa = moTa;
        SoLuong = soLuong;
    }

    public virtual void HienThiThongTin()
    {
        Console.WriteLine($"Ten san pham: {TenSanPham}, Gia: {Gia}, So luong: {SoLuong}, Mo ta: {MoTa}");
    }
}

class Electronic : Product
{
    public int BaoHanh { get; set; }

    public Electronic(string tenSanPham, double gia, string moTa, int soLuong, int baoHanh)
        : base(tenSanPham, gia, moTa, soLuong)
    {
        BaoHanh = baoHanh;
    }

    public override void HienThiThongTin()
    {
        base.HienThiThongTin();
        Console.WriteLine($"Bao hanh: {BaoHanh} thang");
    }
}

class Clothing : Product
{
    public string KichThuoc { get; set; }
    public string MauSac { get; set; }

    public Clothing(string tenSanPham, double gia, string moTa, int soLuong, string kichThuoc, string mauSac)
        : base(tenSanPham, gia, moTa, soLuong)
    {
        KichThuoc = kichThuoc;
        MauSac = mauSac;
    }

    public override void HienThiThongTin()
    {
        base.HienThiThongTin();
        Console.WriteLine($"Kich thuoc: {KichThuoc}, Mau sac: {MauSac}");
    }
}

class Food : Product
{
    public DateTime NgayHetHan { get; set; }

    public Food(string tenSanPham, double gia, string moTa, int soLuong, DateTime ngayHetHan)
        : base(tenSanPham, gia, moTa, soLuong)
    {
        NgayHetHan = ngayHetHan;
    }

    public override void HienThiThongTin()
    {
        base.HienThiThongTin();
        Console.WriteLine($"Ngay het han: {NgayHetHan.ToShortDateString()}");
    }
}

class ShoppingCart
{
    private List<Product> danhSachSanPham = new List<Product>();

    public void ThemSanPham(Product sanPham)
    {
        danhSachSanPham.Add(sanPham);
        Console.WriteLine($"{sanPham.TenSanPham} da duoc them vao gio hang.");
    }

    public void XoaSanPham(Product sanPham)
    {
        danhSachSanPham.Remove(sanPham);
        Console.WriteLine($"{sanPham.TenSanPham} da duoc xoa khoi gio hang.");
    }

    public void HienThiGioHang()
    {
        Console.WriteLine("\nDanh sach san pham trong gio hang:");
        foreach (var sanPham in danhSachSanPham)
        {
            sanPham.HienThiThongTin();
            Console.WriteLine();
        }
    }

    public double TinhTongGiaTri()
    {
        double tong = 0;
        foreach (var sanPham in danhSachSanPham)
        {
            tong += sanPham.Gia * sanPham.SoLuong;
        }
        return tong;
    }
}

// Chuong trinh chinh
class Program
{
    static void Main(string[] args)
    {
        Electronic laptop = new Electronic("Laptop", 1500, "Laptop Dell", 1, 24);
        Clothing tshirt = new Clothing("Ao thun", 300, "Ao thun cotton", 2, "M", "Trang");
        Food apple = new Food("Tao", 20, "Tao do", 10, new DateTime(2024, 12, 31));

        ShoppingCart cart = new ShoppingCart();

        cart.ThemSanPham(laptop);
        cart.ThemSanPham(tshirt);
        cart.ThemSanPham(apple);

        cart.HienThiGioHang();

        double tongGiaTri = cart.TinhTongGiaTri();
        Console.WriteLine($"Tong gia tri don hang: {tongGiaTri} VND");
    }
}
