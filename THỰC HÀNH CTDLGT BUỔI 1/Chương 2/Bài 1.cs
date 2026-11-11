using System;

class Program
{
    static void ThapHaNoi(int n, char cotNguon, char cotDich, char cotTrungGian)
    {
        if (n == 1)
        {
            Console.WriteLine($"Di chuyển đĩa 1 từ {cotNguon} sang {cotDich}");
            return;
        }
        ThapHaNoi(n - 1, cotNguon, cotTrungGian, cotDich);
        Console.WriteLine($"Di chuyển đĩa {n} từ {cotNguon} sang {cotDich}");
        ThapHaNoi(n - 1, cotTrungGian, cotDich, cotNguon);
    }

    static void Main()
    {
        Console.OutputEncoding = System.Text.Encoding.Unicode;
        Console.InputEncoding = System.Text.Encoding.Unicode;
        Console.WriteLine("--- BÀI 1: THÁP HÀ NỘI ---");
        ThapHaNoi(3, 'A', 'C', 'B');
    }
}