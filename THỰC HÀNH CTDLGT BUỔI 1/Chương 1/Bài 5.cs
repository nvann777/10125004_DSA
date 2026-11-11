using System;

class Program
{
    static void Main()
    {
        Console.Write("Nhap n: ");
        int n = int.Parse(Console.ReadLine());

        int a = 0;
        int b = 1;

        if (n <= 0)
        {
            Console.WriteLine("Vui long nhap n > 0");
        }
        else if (n == 1)
        {
            Console.WriteLine("So Fibonacci thu n la: 0");
        }
        else if (n == 2)
        {
            Console.WriteLine("So Fibonacci thu n la: 1");
        }
        else
        {
            for (int i = 3; i <= n; i++)
            {
                int c = a + b;
                a = b;
                b = c;
            }

            Console.WriteLine("So Fibonacci thu n la: " + b);
        }
    }
}