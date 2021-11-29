using System;

namespace vusal
{
    class Program
    {
        static void Main(string[] args)
        {
            int reqem = 582;
            int say;
            int toplam = 0;
            while (reqem > 0)
            {
                say = reqem % 10;
                toplam = say + toplam;
                reqem = reqem / 10;
            }
            Console.WriteLine(toplam);

        }
    }
}
  




int season = 6;
    switch (season)
    {
    case 1:
    case 2:
            Console.WriteLine(yaz);
            break:
        case 3:
    case 4:
        Console.WriteLine(yay);
        break:
        case 5:
        Console.WiteLine(payiz);
        break:
        case 6:
        Console.WriteLine(qis);
    default:
        Console.WriteLine("duzgun daxil ediniz");
        break;
    }






int = eded;
int i;
if (eded=0)
{ Console.WriteLine("ne sadedir nede murekkebdir"); }
else if (eded < 0)
{ Console.WriteLine("musbet eded daxil edin"); }
else
{
    while(i<eded)
    {
        if (eded % i ==0)
        {
            bolen++;
            i++;
        }
        else
        {
            i++;
        }
    }
}
if (bolen >2)
{ Console.WriteLine("murekkeb ededdir"); }
else
{
    Console.WriteLine("sade ededdir");
}