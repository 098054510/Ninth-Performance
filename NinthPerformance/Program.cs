using System;

namespace NinthPerformance
{
    class Program
    {
        static void Main(string[] args)
        {
            int x, sqr;
            x = int.Parse(Console.ReadLine());
            sqr = x * x;
            Console.WriteLine(sqr);
            while(x != 0)
            {
                x = int.Parse(Console.ReadLine());
                sqr = x * x;
                Console.WriteLine(sqr);
            }
            Console.ReadLine();
        }
    }
}
