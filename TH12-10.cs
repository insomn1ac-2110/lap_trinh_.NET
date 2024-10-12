abstract class PhuongTien
{
    public string TenPhuongTien { get; set; }
    public string LoaiNhienLieu { get; set; }

    public PhuongTien(string tenPhuongTien, string loaiNhienLieu)
    {
        TenPhuongTien = tenPhuongTien;
        LoaiNhienLieu = loaiNhienLieu;
    }

    public abstract void DiChuyen();
}

interface IThongTinThem
{
    int TocDoToiDa();
    double MucTieuThuNhienLieu();
}

class XeHoi : PhuongTien, IThongTinThem
{
    public int TocDoMax { get; set; }
    public double NhienLieuTieuThu { get; set; }

    public XeHoi(string tenPhuongTien, string loaiNhienLieu, int tocDoMax, double nhienLieuTieuThu)
        : base(tenPhuongTien, loaiNhienLieu)
    {
        TocDoMax = tocDoMax;
        NhienLieuTieuThu = nhienLieuTieuThu;
    }

    public override void DiChuyen()
    {
        Console.WriteLine($"{TenPhuongTien} dang di chuyen bang dong co {LoaiNhienLieu}.");
    }

    public int TocDoToiDa()
    {
        return TocDoMax;
    }

    public double MucTieuThuNhienLieu()
    {
        return NhienLieuTieuThu;
    }
}

class XeDap : PhuongTien, IThongTinThem
{
    public int TocDoMax { get; set; }

    public XeDap(string tenPhuongTien, int tocDoMax)
        : base(tenPhuongTien, "Khong co")
    {
        TocDoMax = tocDoMax;
    }

    public override void DiChuyen()
    {
        Console.WriteLine($"{TenPhuongTien} dang di chuyen bang suc nguoi.");
    }

    public int TocDoToiDa()
    {
        return TocDoMax;
    }

    public double MucTieuThuNhienLieu()
    {
        return 0;
    }
}

class Program
{
    static void Main(string[] args)
    {
        List<PhuongTien> danhSachPhuongTien = new List<PhuongTien>
        {
            new XeHoi("Xe hoi", "Xang", 180, 8.5),
            new XeDap("Xe dap", 25)
        };

        foreach (PhuongTien phuongTien in danhSachPhuongTien)
        {
            phuongTien.DiChuyen();

            if (phuongTien is IThongTinThem thongTinThem)
            {
                Console.WriteLine($"Toc do toi da: {thongTinThem.TocDoToiDa()} km/h");

                if (phuongTien is XeHoi)
                {
                    Console.WriteLine($"Muc tieu thu nhien lieu: {thongTinThem.MucTieuThuNhienLieu()} lit/100km");
                }
            }
            Console.WriteLine();
        }
    }
}
