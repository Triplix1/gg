using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int d1, d2, d3, d4;
            bool check;
            for (int a = 10; a < 100; a++)
            {
                d1 = a / 10;
                d2 = a % 10;

                for (int b = 10; b < 100; b++)
                {
                    d3 = b / 10;
                    d4 = b % 10;
                    check = d4 != d3 && d4 != d2 && d4 != d1 && d3 != d2 && d3 != d1 && d2 != d1;
                    if (check)
                    {
                        Console.WriteLine(d1 * 1000 + d2 * 100 + d3 * 10 + d4);
                    }
                }
            }
        }
    }
}
