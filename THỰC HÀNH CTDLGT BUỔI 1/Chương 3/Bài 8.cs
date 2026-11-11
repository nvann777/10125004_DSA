using System;

class Program
{
    static double Can(int i, int n)
    {
        if (i == n)
        {
            return Math.Sqrt(n);
        }
        else
        {
            return Math.Sqrt(i + Can(i + 1, n));
        }
    }

    static double S(int n)
    {
        return Can(1, n);
    }

    static void Main()
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        Console.Write("Nhập số nguyên dương n: ");
        if (int.TryParse(Console.ReadLine(), out int n) && n > 0)
        {
            double ketQua = S(n);
            Console.WriteLine($"-> Kết quả S({n}) = {ketQua:F4}");
        }
        else
        {
            Console.WriteLine("Vui lòng nhập một số nguyên dương hợp lệ!");
        }
    }
}