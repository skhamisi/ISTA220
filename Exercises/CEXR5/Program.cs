using System;

namespace CEXR5
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.WriteLine("Manipulating Arrays\n");
                Console.WriteLine("Array A: 0, 2, 4, 6, 8, 10");
                Console.WriteLine("Array B: 1, 3, 5, 7, 9");
                Console.WriteLine("Array C: 3, 1, 4, 1, 5, 9, 2, 6, 5, 3, 5, 9\n\n");

                {
                    Part1 start = new Part1();
                    Console.WriteLine();
                    Console.ReadLine();
                }

                {
                    Part2 start = new Part2();
                    Console.WriteLine();
                    Console.ReadLine();
                }

                {
                    Part3 start = new Part3();
                    Console.WriteLine();
                    Console.ReadLine();
                }

                {
                    Part4 start = new Part4();
                    Console.WriteLine();
                    Console.ReadLine();
                }
            }
            catch(Exception)
            {
                Console.WriteLine("Well, I guess try again");
            }
        }
    }
}
