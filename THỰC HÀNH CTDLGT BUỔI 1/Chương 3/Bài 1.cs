using System;

class Program
{
    static int TinhTong(int n)
    {

        if (n == 1) return 1;

        return TinhTong(n - 1) + n;
    }

    static void Main()
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;

        Console.Write("Nhập số nguyên dương n: ");
        if (int.TryParse(Console.ReadLine(), out int n) && n > 0)
        {
            int ketQua = TinhTong(n);
            Console.WriteLine($"-> Tổng S({n}) = 1 + 2 + ... + {n} = {ketQua}");
        }
        else
        {
            Console.WriteLine("Vui lòng nhập một số nguyên dương hợp lệ!");
        }
    }
}