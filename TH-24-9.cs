using System;
using System.Collections.Generic;

class SinhVien
{
    public string HoTen { get; set; }
    public string MSSV { get; set; }
    public double DiemTrungBinh { get; set; }

    public void NhapThongTin()
    {
        Console.Write("Nhap ho va ten sinh vien: ");
        HoTen = Console.ReadLine();

        Console.Write("Nhap ma so sinh vien: ");
        MSSV = Console.ReadLine();

        Console.Write("Nhap diem trung binh: ");
        DiemTrungBinh = double.Parse(Console.ReadLine());
    }

    public void HienThiThongTin()
    {
        Console.WriteLine($"Ho ten: {HoTen}, MSSV: {MSSV}, Diem trung binh: {DiemTrungBinh}");
    }
}

class DanhSachSinhVien
{
    private List<SinhVien> sinhVienList = new List<SinhVien>();

    public void ThemSinhVien(SinhVien sv)
    {
        sinhVienList.Add(sv);
    }

    public void HienThiDanhSach()
    {
        Console.WriteLine("\nDanh sach sinh vien:");
        foreach (var sv in sinhVienList)
        {
            sv.HienThiThongTin();
        }
    }

    public SinhVien TimSinhVienTheoMSSV(string mssv)
    {
        foreach (var sv in sinhVienList)
        {
            if (sv.MSSV.Equals(mssv, StringComparison.OrdinalIgnoreCase))
            {
                return sv;
            }
        }
        return null; // Khong tim thay
    }

    public SinhVien TinhDiemTrungBinhCaoNhat()
    {
        if (sinhVienList.Count == 0) return null;

        SinhVien svCaoNhat = sinhVienList[0];
        foreach (var sv in sinhVienList)
        {
            if (sv.DiemTrungBinh > svCaoNhat.DiemTrungBinh)
            {
                svCaoNhat = sv;
            }
        }
        return svCaoNhat;
    }
}

class Program
{
    static void Main()
    {
        DanhSachSinhVien danhSach = new DanhSachSinhVien();

        Console.Write("Nhap so luong sinh vien: ");
        int soLuongSinhVien = int.Parse(Console.ReadLine());

        for (int i = 0; i < soLuongSinhVien; i++)
        {
            Console.WriteLine($"\nNhap thong tin cho sinh vien thu {i + 1}:");
            SinhVien sv = new SinhVien();
            sv.NhapThongTin();
            danhSach.ThemSinhVien(sv);
        }

        danhSach.HienThiDanhSach();

        SinhVien svCaoNhat = danhSach.TinhDiemTrungBinhCaoNhat();
        if (svCaoNhat != null)
        {
            Console.WriteLine("\nSinh vien co diem trung binh cao nhat:");
            svCaoNhat.HienThiThongTin();
        }

        Console.Write("\nNhap MSSV de tim kiem: ");
        string mssvTimKiem = Console.ReadLine();
        SinhVien svTimThay = danhSach.TimSinhVienTheoMSSV(mssvTimKiem);
        if (svTimThay != null)
        {
            Console.WriteLine("Thong tin sinh vien tim thay:");
            svTimThay.HienThiThongTin();
        }
        else
        {
            Console.WriteLine("Khong tim thay sinh vien voi MSSV nay.");
        }
    }
}
