using System;

namespace task_9
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 7, 1, 6, 9, 15, 4, 2, 3, 8, 18 };
           
            for (int i = arr.Length - 1; i >= 0; i--)
            {
                Console.WriteLine(arr[i]);
            }
        }
    }
}
