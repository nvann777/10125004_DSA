using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;

        Console.Write("Nhập số nguyên dương N: ");
        if (int.TryParse(Console.ReadLine(), out int N) && N > 0)
        {
            Console.WriteLine($"Các số hoàn hảo nhỏ hơn {N}:");
            List<int> danhSach = new List<int>();

            for (int num = 2; num < N; num++)
            {
                int tongUoc = 1;
                for (int i = 2; i * i <= num; i++)
                {
                    if (num % i == 0)
                    {
                        tongUoc += i;
                        if (i * i != num)
                            tongUoc += num / i;
                    }
                }

                if (tongUoc == num)
                {
                    danhSach.Add(num);
                }
            }

            if (danhSach.Count > 0)
                Console.WriteLine(string.Join(", ", danhSach));
            else
                Console.WriteLine("Không tìm thấy số hoàn hảo nào trong khoảng này.");
        }
        else
        {
            Console.WriteLine("Vui lòng nhập một số nguyên dương N hợp lệ!");
        }
    }
}
