using System;
class 10-9
{
    static void Main()
    {
        Console.WriteLine("Bai1:");
        Bai1();

        Console.WriteLine("\nBai2:");
        Bai2();

        Console.WriteLine("\nBai3:");
        Bai3();

        Console.WriteLine("\nBai4:");
        Bai4();

        Console.WriteLine("\nBai5:");
        Bai5();

        Console.WriteLine("\nBai6:");
        Bai6();
    }
    static void Bai1()
    {
        Console.Write("Nhap so luong phan tu cua mang: ");
        int n = int.Parse(Console.ReadLine());

        int[] arr = new int[n];

        Console.WriteLine("Nhap cac phan tu:");
        for (int i = 0; i < n; i++)
        {
            Console.Write($"Phan tu thu {i + 1}: ");
            arr[i] = int.Parse(Console.ReadLine());
        }

        int sum = 0;
        for (int i = 0; i < n; i++)
        {
            sum += arr[i];
        }


        Console.WriteLine($"Tong cac phan tu: {sum}");
    }
    //bai2
    static void Bai2()
    {

        Console.Write("Nhap mot chuoi: ");
        string input = Console.ReadLine();

        char[] punctuation = { ' ', '.', ',', '!', '?', ';', ':', '-', '(', ')', '[', ']', '{', '}' };

        int count = 0;


        for (int i = 0; i < input.Length; i++)
        {
            if (!Array.Exists(punctuation, element => element == input[i]))
            {
                count++;
            }
        }

        Console.WriteLine($"So luong ky tu khong phai khoang trang va dau cau la: {count}");
    }
    //Bai3
    static void Bai3()
    {
        Console.Write("\nBai3\n");

        Console.Write("Nhap so phan tu: ");
        int n = int.Parse(Console.ReadLine());
        int[] arr = new int[n];

        Console.WriteLine("Nhap cac phan tu cua mang:");
        for (int i = 0; i < n; i++)
        {
            Console.Write($"Phan tu thu {i + 1}: ");
            arr[i] = int.Parse(Console.ReadLine());
        }

        int max = arr[0];
        for (int i = 1; i < n; i++)
        {
            if (arr[i] > max)
            {
                max = arr[i];
            }
        }

        Console.WriteLine($"Phan tu lon nhat trong mang la: {max}");
    }
    //bai 4
    static void Bai4()
    {


        Console.Write("Nhap 1 chuoi: ");
        string vao = Console.ReadLine();

        char[] charArray = vao.ToCharArray();
        Array.Reverse(charArray);

        string reversedString = new string(charArray);

        Console.WriteLine($"Chuoi dao nguoc la: {reversedString}");
    }

    //bai5
    static void Bai5()
    {

        Console.Write("Nhap so luong phan tu cua mang: ");
        int n = int.Parse(Console.ReadLine());
        int[] arr = new int[n];
        Console.WriteLine("Nhap cac phan tu cua mang:");
        for (int i = 0; i < n; i++)
        {
            Console.Write($"Phan tu thu {i + 1}: ");
            arr[i] = int.Parse(Console.ReadLine());
        }

        bool doixung = true;
        for (int i = 0; i < n / 2; i++)
        {
            if (arr[i] != arr[n - 1 - i])
            {
                doixung = false;
                break;
            }
        }

        if (doixung)
        {
            Console.WriteLine("Mang la mang doi xung (doixung).");
        }
        else
        {
            Console.WriteLine("Mang khong phai la mang doi xung (doixung).");
        }
    }
    //bai6
    static void Bai6()
    {

        Console.Write("Nhap chuoi: ");
        string inputString = Console.ReadLine();

        Console.Write("Nhap ky tu can dem: ");
        char charToCount = Console.ReadKey().KeyChar;
        Console.WriteLine();

        int dem = 0;
        foreach (char ch in inputString)
        {
            if (ch == charToCount)
            {
                dem++;
            }
        }

        Console.WriteLine($"Ky tu '{charToCount}' xuat hien {dem} lan trong chuoi.");
    }
}


