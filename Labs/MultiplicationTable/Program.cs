using System;

namespace MultiplicationTable
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Multiplication Table");
            for (int i = 1; i <= 12; i++) //Update variable can be re-written as "i + 1" or "i += 1"
            {
                for (int j = 1; j <= 12; j++) //Update variable can be re-written as "j + 1" or "j += 1"
                {

                    Console.Write($" {j * i} ");
                }

                Console.WriteLine();
            }
        }
    }
}
