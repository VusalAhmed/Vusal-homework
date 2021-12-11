using System;

namespace calisma_11
{
    interface IMinMaxArray
    {
        void CalculateMaxMin(int[] number);
    }
    class MinMaxArray : IMinMaxArray
    {
public void CalculateMaxMin(int[] number)
        {
            int Min = number[0];
            int Max = number[0];
            for (int i = 0; i < number.Length; i++ )
            {
                if (Min > number[1])
                    Min = number[1];
                else if (Max < number[1])
                    Max = number[1];
            }
            Console.WriteLine("Max" + " " + Max);
            Console.WriteLine("Min" + " " + Min);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            MinMaxArray minmax = new MinMaxArray();
            minmax.CalculateMaxMin(new int[] { 12, 56, 32, 87, 128 });
            Console.Read();

        }
    }
}
