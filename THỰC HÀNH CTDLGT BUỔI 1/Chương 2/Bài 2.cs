using System;

class Program
{
    static int TimKiemNhiPhan(int[] arr, int left, int right, int x)
    {
        if (left > right) return -1;
        int mid = left + (right - left) / 2;
        if (arr[mid] == x) return mid;
        if (arr[mid] > x) return TimKiemNhiPhan(arr, left, mid - 1, x);
        return TimKiemNhiPhan(arr, mid + 1, right, x);
    }

    static void Main()
    {
        Console.OutputEncoding = System.Text.Encoding.Unicode;
        Console.InputEncoding = System.Text.Encoding.Unicode;
        Console.WriteLine("\n--- BÀI 2: TÌM KIẾM NHỊ PHÂN ---");
        int[] arr = { 2, 5, 8, 12, 16, 23, 38, 56, 72, 91 };
        int x = 23;
        int ketQua = TimKiemNhiPhan(arr, 0, arr.Length - 1, x);
        Console.WriteLine($"Phần tử {x} ở vị trí index: {ketQua}");
    }
}