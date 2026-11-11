using System;

class Program
{
    static int SoChuSo(int n)
    {
        if (n == 0) return 0;

        return SoChuSo(n / 10) + 1;
    }

    static void Main()
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;

        Console.Write("Nhập số nguyên dương n: ");
        if (int.TryParse(Console.ReadLine(), out int n) && n >= 0)
        {
            int ketQua = (n == 0) ? 1 : SoChuSo(n);

            Console.WriteLine($"-> Số chữ số của {n} là: {ketQua}");
        }
        else
        {
            Console.WriteLine("Vui lòng nhập một số nguyên không âm hợp lệ!");
        }
    }
}