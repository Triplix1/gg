using System;

namespace Lab_3_sharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your E (0;1): ");

            double E = Convert.ToDouble(Console.ReadLine());

            while (E <= 0 || E >= 1)
            {
                Console.WriteLine("Enter your E (0;1) : ");

                E = Convert.ToDouble(Console.ReadLine());
            }

            Console.WriteLine("Enter your x [-1;0) : ");

            double x = Convert.ToDouble(Console.ReadLine());

            while (x < -1 || x >= 0)
            {
                Console.WriteLine("Enter your x [-1;0) : ");

                x = Convert.ToDouble(Console.ReadLine());
            }

            

            double result = 1;

            double resbef = 0;

            int m = 1;

            int i = m;

            while (Math.Abs(result - resbef) > E)
            {
                resbef = result;
                result = 1 ;

                while (i>0)
                {
                    result += (Fact(m) * Math.Pow(x, i)) / (Fact(m - i) * Fact(i));
                    i--;
                }
                m++;
                i = m;
            }

            Console.WriteLine(result);


            static int Fact(int n)
            {
                int fact = 1;

                for (int i = 2; i <= n; i++)
                {
                    fact *= i;
                }
                return fact;
            }
        }
    }
}
