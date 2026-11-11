using System;
using System.Linq;

class Program
{
    static void BubbleSort(double[] arr)
    {
        int n = arr.Length;
        for (int i = 0; i < n - 1; i++)
        {
            bool swapped = false;
            for (int j = 0; j < n - i - 1; j++)
            {
                if (arr[j] > arr[j + 1])
                {
                    double temp = arr[j];
                    arr[j] = arr[j + 1];
                    arr[j + 1] = temp;
                    swapped = true;
                }
            }
            if (!swapped) break;
        }
    }

    static void QuickSort(double[] arr, int low, int high)
    {
        if (low < high)
        {
            int pi = Partition(arr, low, high);
            QuickSort(arr, low, pi - 1);
            QuickSort(arr, pi + 1, high);
        }
    }

    static int Partition(double[] arr, int low, int high)
    {
        double pivot = arr[high];
        int i = (low - 1);
        for (int j = low; j < high; j++)
        {
            if (arr[j] <= pivot)
            {
                i++;
                double temp = arr[i];
                arr[i] = arr[j];
                arr[j] = temp;
            }
        }
        double temp1 = arr[i + 1];
        arr[i + 1] = arr[high];
        arr[high] = temp1;
        return i + 1;
    }

    static void Main()
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;

        Console.Write("Nhập dãy số thực (cách nhau bằng khoảng trắng): ");
        string input = Console.ReadLine();

        try
        {
            double[] arr1 = input.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                                 .Select(double.Parse)
                                 .ToArray();

            double[] arr2 = (double[])arr1.Clone();

            Console.WriteLine($"\nDãy ban đầu: {string.Join(", ", arr1)}");

            BubbleSort(arr1);
            Console.WriteLine($"-> Sau khi sắp xếp (Bubble Sort): {string.Join(", ", arr1)}");

            QuickSort(arr2, 0, arr2.Length - 1);
            Console.WriteLine($"-> Sau khi sắp xếp (Quick Sort):  {string.Join(", ", arr2)}");
        }
        catch
        {
            Console.WriteLine("Dữ liệu nhập vào không hợp lệ! Vui lòng chỉ nhập số thực cách nhau bởi khoảng trắng.");
        }
    }
}