using System;

class Program
{
    static void Main()
    {
        Random rd = new Random();

        int[] a = new int[1000];

        for (int i = 0; i < 1000; i++)
        {
            a[i] = rd.Next(0, 1001);
        }

        Console.WriteLine("Mang ban dau:");

        for (int i = 0; i < 1000; i++)
        {
            Console.Write(a[i] + " ");
        }

        for (int i = 0; i < 999; i++)
        {
            for (int j = i + 1; j < 1000; j++)
            {
                if (a[i] > a[j])
                {
                    int tam = a[i];
                    a[i] = a[j];
                    a[j] = tam;
                }
            }
        }

        Console.WriteLine("\nMang sau khi sap xep:");

        for (int i = 0; i < 1000; i++)
        {
            Console.Write(a[i] + " ");
        }
    }
}