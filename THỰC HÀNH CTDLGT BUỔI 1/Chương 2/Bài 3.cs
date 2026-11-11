using System;

class Program
{
    static bool KiemTraNguyenTo(int n)
    {
        if (n < 2) return false;
        for (int i = 2; i <= Math.Sqrt(n); i++)
        {
            if (n % i == 0) return false;
        }
        return true;
    }

    static void Main()
    {
        Console.OutputEncoding = System.Text.Encoding.Unicode;
        Console.InputEncoding = System.Text.Encoding.Unicode;
        Console.Write("Nhập số n: ");
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine($"Số {n} có phải số nguyên tố? {KiemTraNguyenTo(n)}");
    }
}