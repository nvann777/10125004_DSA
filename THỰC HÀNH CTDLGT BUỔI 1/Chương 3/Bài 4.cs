using System;

class Program
{
    static double LuyThua(double x, int n)
    {
        if (n == 0) return 1;

        return LuyThua(x, n - 1) * x;
    }

    static double S(double x, int n)
    {
        if (n < 0)
        {
            return 1.0 / LuyThua(x, -n);
        }
        else
        {
            return LuyThua(x, n);
        }
    }

    static void Main()
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;

        Console.Write("Nhập cơ số x: ");
        if (double.TryParse(Console.ReadLine(), out double x))
        {
            Console.Write("Nhập số mũ n: ");
            if (int.TryParse(Console.ReadLine(), out int n))
            {
                double ketQua = S(x, n);
                Console.WriteLine($"-> Kết quả S({x}, {n}) = {x}^{n} = {ketQua}");
            }
            else
            {
                Console.WriteLine("Số mũ n không hợp lệ!");
            }
        }
        else
        {
            Console.WriteLine("Cơ số x không hợp lệ!");
        }
    }
}