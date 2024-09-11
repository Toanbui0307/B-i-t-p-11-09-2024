using System;

class BaiTap
{
    // Bai 1: Tao mang so nguyen va tinh tong
    public void Bai1()
    {
        Console.Write("Bai 1: \n");
        Console.Write("Nhap so luong phan tu cua mang: ");
        int n = int.Parse(Console.ReadLine());
        int[] arr = new int[n];

        for (int i = 0; i < n; i++)
        {
            Console.Write($"Nhap phan tu thu {i + 1}: ");
            arr[i] = int.Parse(Console.ReadLine());
        }

        int tong = 0;
        for (int i = 0; i < n; i++)
        {
            tong += arr[i];
        }

        Console.WriteLine("Tong cac phan tu trong mang la: " + tong);
    }

    // Bai 2: Dem so luong ky tu trong chuoi (khong tinh khoang trang va dau cau)
    public void Bai2()
    {
        Console.Write("Bai 2: \n");
        Console.Write("Nhap mot chuoi: ");
        string chuoi = Console.ReadLine();
        int count = 0;

        foreach (char c in chuoi)
        {
            if (!char.IsWhiteSpace(c) && !char.IsPunctuation(c))
            {
                count++;
            }
        }

        Console.WriteLine("So luong ky tu trong chuoi (khong tinh khoang trang va dau cau) la: " + count);
    }

    // Bai 3: Tim phan tu lon nhat trong mang
    public void Bai3()
    {
        Console.Write("Bai 3: \n");
        Console.Write("Nhap so luong phan tu cua mang: ");
        int n = int.Parse(Console.ReadLine());
        int[] arr = new int[n];

        for (int i = 0; i < n; i++)
        {
            Console.Write($"Nhap phan tu thu {i + 1}: ");
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

        Console.WriteLine("Phan tu lon nhat trong mang la: " + max);
    }

    // Bai 4: Dao nguoc chuoi
    public void Bai4()
    {
        Console.Write("Bai 4: \n");
        Console.Write("Nhap mot chuoi: ");
        string chuoi = Console.ReadLine();
        char[] charArray = chuoi.ToCharArray();
        Array.Reverse(charArray);

        Console.WriteLine("Chuoi sau khi dao nguoc: " + new string(charArray));
    }

    // Bai 5: Kiem tra mang doi xung
    public void Bai5()
    {
        Console.Write("Bai 5: \n");
        Console.Write("Nhap so luong phan tu cua mang: ");
        int n = int.Parse(Console.ReadLine());
        int[] arr = new int[n];

        for (int i = 0; i < n; i++)
        {
            Console.Write($"Nhap phan tu thu {i + 1}: ");
            arr[i] = int.Parse(Console.ReadLine());
        }

        bool doiXung = true;
        for (int i = 0; i < n / 2; i++)
        {
            if (arr[i] != arr[n - i - 1])
            {
                doiXung = false;
                break;
            }
        }

        if (doiXung)
        {
            Console.WriteLine("Mang la doi xung.");
        }
        else
        {
            Console.WriteLine("Mang khong doi xung.");
        }
    }

    // Bai 6: Dem so lan xuat hien cua mot ky tu trong chuoi
    public void Bai6()
    {
        Console.Write("Bai 6: \n");
        Console.Write("Nhap mot chuoi: ");
        string chuoi = Console.ReadLine();
        Console.Write("Nhap ky tu can dem: ");
        char kyTu = char.Parse(Console.ReadLine());

        int count = 0;
        foreach (char c in chuoi)
        {
            if (c == kyTu)
            {
                count++;
            }
        }

        Console.WriteLine($"Ky tu '{kyTu}' xuat hien {count} lan trong chuoi.");
    }

    static void Main(string[] args)
    {
        BaiTap baiTap = new BaiTap();

        // Goi cac bai tap o day:
        baiTap.Bai1();  // Bai 1: Tao mang so nguyen va tinh tong
        baiTap.Bai2();  // Bai 2: Dem so luong ky tu trong chuoi
        baiTap.Bai3();  // Bai 3: Tim phan tu lon nhat trong mang
        baiTap.Bai4();  // Bai 4: Dao nguoc chuoi
        baiTap.Bai5();  // Bai 5: Kiem tra mang doi xung
        baiTap.Bai6();  // Bai 6: Dem so lan xuat hien cua mot ky tu trong chuoi
    }
}
