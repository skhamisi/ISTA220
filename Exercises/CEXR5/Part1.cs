using System;

namespace CEXR5
{
    class Part1
    {
        private int[] A = { 0, 2, 4, 6, 8, 10 };
        private int[] B = { 1, 3, 5, 7, 9 };
        private int[] C = { 3, 1, 4, 1, 5, 9, 2, 6, 5, 3, 5, 9 };

        public Part1()
        {
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.Write("Counting, summing, computing the mean\n");
            Console.ReadLine();
            Console.ForegroundColor = ConsoleColor.White;

            Console.Write($"For Array A: "); 
            Console.ForegroundColor = ConsoleColor.DarkYellow; 
            CalculateMath(A);
            Console.ReadLine();
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.White;

            Console.Write($"For Array B: "); 
            Console.ForegroundColor = ConsoleColor.DarkYellow; 
            CalculateMath(B);
            Console.ReadLine();
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.White;

            Console.Write($"For Array C: "); Console.ForegroundColor = ConsoleColor.DarkYellow; 
            CalculateMath(C);
        }

        private void CalculateMath(int[] arr)
        {
            int count = 0;
            int sum = 0;
            double mean = 0.0;

            for (int i = 0; i < arr.Length; i++)
            {
                count = arr.Length;
                sum += arr[i];
                mean = (double)sum / count;
            }
            Console.Write($"The count is {count}, the sum is {sum}, and the average is {mean}");
        }

    }
}
