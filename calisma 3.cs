using System;

namespace task_3
{
    class Program
    {
        static void Main(string[] args)
        {
            #region
            int[] arr = { 123, 64, 256, 33, 843 };
            int sum1 = 0;
            int sum2 = 0;
            for (int i = 0; i < arr.Length; i--)
            {
                if (i >= 100 || i <= 999)
                {
                    sum1 += (arr[i] % 10);
                    arr[i] /= 10;
                 
                }
                
                else
                {
                    sum2 += (arr[i] % 10);
                    arr[i] /= 10;
                    sum1 = sum2 - arr[i];
                }
                Console.WriteLine(sum1 - sum2);
            }
        }
    }
}


#endregion