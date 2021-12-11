using System;

namespace task_5
{
    class Program
    {
        static void Main(string[] args)
        {
            String Sentence = "The string where the world the present more than once the the the";
            string[] sozarr = Sentence.Split(" ");
            string search = "the";
            int count = 0;
            foreach (var item in sozarr)
            {
                if(item.ToLower() == search)
                {
                    count++;
                }
                
            }

            Console.WriteLine(count);
        }
    }
}
