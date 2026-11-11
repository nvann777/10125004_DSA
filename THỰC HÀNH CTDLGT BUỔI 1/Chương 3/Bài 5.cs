using System;

class Program
{
    static int UocLeMax(int n)
    {

        if (n % 2 != 0)
        {
            return n;
        }

        return UocLeMax(n / 2);
    }

    static void Main()
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;

        Console.Write("Nhập số nguyên dương n: ");
        if (int.TryParse(Console.ReadLine(), out int n) && n > 0)
        {
            int ketQua = UocLeMax(n);
            Console.WriteLine($"-> Ước số lẻ lớn nhất của {n} là: {ketQua}");
        }
        else
        {
            Console.WriteLine("Vui lòng nhập một số nguyên dương hợp lệ!");
        }
    }
}