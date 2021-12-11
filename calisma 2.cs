using System;

namespace calisma_2
{
    class Program
    {
        static void Main(string [] args)
        {
            Random rnd = new Random();
            int[] numbers = new int[5];
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = rnd.Next(1,101);
            }
            Console.WriteLine(" the given arrey is: ");

            foreach (var number in numbers)

            {
                Console.WriteLine(numbers + " ");
            }
            Console.WriteLine();



            GetMin(int[] numbers);


            Console.ReadLine();
        }



        static void GetMin(int[] array)
        {
            int min = array[0];
            foreach (var number in array)
            {
                if(number > min)
                {
                    min = number;
                }
            }
            Console.WriteLine($"The min value in the array is:" +  min);
        }
            }
}
 