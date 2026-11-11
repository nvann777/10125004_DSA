using System;
namespace Bai1
{
    class Program
    {
        static void Main()
        {
            Random rand = new Random();
            int[] so = new int[1000];
            for (int i = 0; i < so.Length; i++)
            {
                so[i] = rand.Next(0, 10001);
            }
            int max = so.Max();
            int min = so.Min();
            Console.OutputEncoding = System.Text.Encoding.Unicode;
            Console.WriteLine($"Số lớn nhất là: {max}");
            Console.WriteLine($"Số nhỏ nhất là: {min}");
        }
    }
}
