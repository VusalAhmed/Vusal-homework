 using System;

namespace calisma_12
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 10, 20, 50, 15, 27, 89, 26, 97, 7, 8 };
            int[] arrA = new int[arr.Length];
            int[] arrB = new int[arr.Length];
            int i;
            int x = 0;
            int y = 0;
            for (i = 0; i < arr.Length; i++)
            {
                if (arr[i] % 2 == 0)
                {
                    arrA[y] = arr[i];
                    y++;
                }
                else
                {
                    arrB[x] = arr[i];
                    x++;
                }
            }

            for (i = 0; i < y; i++)
            {
                Console.WriteLine($"even number" + " " + $"{arrA[i]}");
            }
            for (i = 0; i < x; i++)
            {
                Console.WriteLine($"odd number" + " " + $"{arrB[i]}");
            }
        }
    }
}
