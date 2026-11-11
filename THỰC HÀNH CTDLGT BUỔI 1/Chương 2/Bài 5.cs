using System;

class Program
{
    static void Main()
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;

        Console.Write("Nhập vị trí n cần tìm số Fibonacci (n >= 0): ");
        if (int.TryParse(Console.ReadLine(), out int n) && n >= 0)
        {
            long result = Fibonacci(n);
            Console.WriteLine($"-> Số Fibonacci thứ {n} là: {result}");
        }
        else
        {
            Console.WriteLine("Vui lòng nhập một số nguyên không âm hợp lệ!");
        }
    }

    static long Fibonacci(int n)
    {
        if (n <= 1) return n;
        long a = 0, b = 1;
        for (int i = 2; i <= n; i++)
        {
            long temp = a + b;
            a = b;
            b = temp;
        }
        return b;
    }
}