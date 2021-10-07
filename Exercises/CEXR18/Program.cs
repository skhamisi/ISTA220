using System;

namespace CEXR18
{
    class Program : Util
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This is exercise 18");
            Console.WriteLine("===================\n");

            Console.WriteLine($"Method 1, finding square root of 2: {Math.Sqrt(2)}");
            double sqrt2 = FindingSqrt2();
            Console.WriteLine($"Calculated square root of 2 is {sqrt2}, " +
                $"error is {Math.Abs(sqrt2 - Math.Sqrt(2))}");

            Console.WriteLine($"\nMethod 2, Finding pi: {Math.PI}");
            double pi = FindingPi();
            Console.WriteLine($"\tCalculated pi is {pi} " +
                $"error is {Math.Abs(pi - Math.PI)}");

            Console.WriteLine($"\nMethod 3, finding e: {Math.E}");
            double e = FindingE();
            Console.WriteLine($"\tcalculated e is {e} " +
                $"error is {Math.Abs(e - Math.E)}");

            Console.WriteLine($"\nMethod 4, finding phi: {(1.0 + Math.Sqrt(5)) / 2.0 }");
            double phi = FindingPhi();
            Console.WriteLine($"\tcalculated phi is {phi} " +
                $"error is {Math.Abs(phi - ((1.0 + Math.Sqrt(5)) / 2.0))}");
        }
    }

    class Util
    {
        public static double FindingSqrt2()
        {
            double sqrtOf2 = 0;
            double n = 2;

            for(int i = 0; i < 5; i++)
            {
                sqrtOf2 = ((2 / n) + n) / 2;
                n = sqrtOf2;
            }
            return sqrtOf2;
        }

        public static double FindingPi()
        {
            double pi = 0;
            double temp;

            for (double i = 0; i < 100000; i++)
            {
                temp = (4 / ((i * 4) + 1)) - (4 / ((i * 4) + 3));
                pi += temp;
            }
            return pi;
        }

        public static double FindingE()
        {
            double e = 0;

            for (double i = 1; i < 100000; i++)
            {
                e = Math.Pow(1 + 1 / i, i);
            }
            return e;
        }

        public static double FindingPhi()
        {
            double phi = 0;

            for (double i = 0; i < 100000; i++)
            {
                phi = (1 + Math.Sqrt(5)) / 2;
            }
            return phi;
        }
    }
}
