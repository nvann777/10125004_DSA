using System;

class Program
{
    static int UCLN(int a, int b)
    {
        if (a % b == 0)
        {
            return b;
        }

        return UCLN(b, a % b);
    }

    static void Main()
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;

        Console.Write("Nhập số nguyên dương a: ");
        bool checkA = int.TryParse(Console.ReadLine(), out int a);

        Console.Write("Nhập số nguyên dương b: ");
        bool checkB = int.TryParse(Console.ReadLine(), out int b);

        if (checkA && checkB && a > 0 && b > 0)
        {
            int ketQua = UCLN(a, b);
            Console.WriteLine($"-> Ước chung lớn nhất của {a} và {b} là: {ketQua}");
        }
        else
        {
            Console.WriteLine("Vui lòng nhập hai số nguyên dương hợp lệ!");
        }
    }
}