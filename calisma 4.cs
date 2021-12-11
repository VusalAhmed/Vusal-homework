 using System;

namespace calisma_4
{
    class Program
    {
        static void Main()
        {
            int a = 0, Word = 1;
            string str = "Hello Everyone";
            while(a <= str.Length - 1)
            {
                if(str[a]==' ' || str[a]=='\n' || str[a]=='\t')
                {
                    Word++;
                }

                a++;
                
            }
            Console.WriteLine(Word);
        }

    }
}       
