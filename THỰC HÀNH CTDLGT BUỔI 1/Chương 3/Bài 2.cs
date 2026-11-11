using System;

class Program
{
    static int TinhTongBinhPhuong(int n)
    {
        if (n == 1) return 1;

        return TinhTongBinhPhuong(n - 1) + n * n;
    }

    static void Main()
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;

        Console.Write("Nhập số nguyên dương n: ");
        if (int.TryParse(Console.ReadLine(), out int n) && n > 0)
        {
            int ketQua = TinhTongBinhPhuong(n);
            Console.WriteLine($"-> Tổng S({n}) = 1^2 + 2^2 + ... + {n}^2 = {ketQua}");
        }
        else
        {
            Console.WriteLine("Vui lòng nhập một số nguyên dương hợp lệ!");
        }
    }
}