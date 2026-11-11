using System;
class Program
{
    static void Main()
    {
        Console.InputEncoding = System.Text.Encoding.Unicode;
        Console.OutputEncoding = System.Text.Encoding.Unicode;
        Console.Write("Nhập vào một chuỗi: ");
        string s = Console.ReadLine();
        char[] arr = s.ToCharArray();
        Array.Reverse(arr);
        string chuoiDaoNguoc = new string(arr);

        Console.WriteLine($"Chuỗi đảo ngược: {chuoiDaoNguoc}");
    }
}