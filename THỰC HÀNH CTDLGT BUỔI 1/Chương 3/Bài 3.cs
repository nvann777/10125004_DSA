using System;

class Program
{
    static double TinhTongPhanSo(int n)
    {
        if (n == 1) return 1.0;

        return TinhTongPhanSo(n - 1) + 1.0 / n;
    }

    static void Main()
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;

        Console.Write("Nhập số nguyên dương n: ");
        if (int.TryParse(Console.ReadLine(), out int n) && n > 0)
        {
            double ketQua = TinhTongPhanSo(n);
            Console.WriteLine($"-> Tổng S({n}) = {ketQua:F4}");
        }
        else
        {
            Console.WriteLine("Vui lòng nhập một số nguyên dương hợp lệ!");
        }
    }
}