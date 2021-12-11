using System;

namespace task_10
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 7, 3, 2, 1 };
            int[] arrA = { 6, 8, 9, 10 };
            int[] arrB = new int[arr.Length + arrA.Length];
            for(int i = 0, n = 0; i < arrB.Length; i++)
            {
                if (i<arr.Length)
                {
                    arrB[i] = arr[i];
                }
                if (i==arr.Length || i>arr.Length)
                {
                    arrB[i] = arrA[n];
                    n++;
                }
            }
           
            foreach (var item in arrB)
            {

            }
            Array.Sort(arrB);
            Array.Reverse(arrB);
            foreach (int item in arrB)
            {

            }
            Console.WriteLine(string.Join(" ", arrB));
        }

        
    }
    
}
