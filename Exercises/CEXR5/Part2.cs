using System;

namespace CEXR5
{
    class Part2
    {
        private int[] A = { 0, 2, 4, 6, 8, 10 };
        private int[] B = { 1, 3, 5, 7, 9 };
        private int[] C = { 3, 1, 4, 1, 5, 9, 2, 6, 5, 3, 5, 9 };

        public Part2()
        {
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.Write("Reversing Arrays:\n");
            Console.ReadLine();
            Console.ForegroundColor = ConsoleColor.White;
 
            Console.Write("Array A is: "); Console.ForegroundColor = ConsoleColor.DarkYellow; 
            reverseArray(A);
            Console.ReadLine();
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.White;

            Console.Write("Array B is: "); Console.ForegroundColor = ConsoleColor.DarkYellow; 
            reverseArray(B);
            Console.ReadLine();
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.White;

            Console.Write("Array C is: "); Console.ForegroundColor = ConsoleColor.DarkYellow; 
            reverseArray(C);
        }

        private static void reverseArray(int[] arr)
        {
            for (int i = arr.Length - 1; i >= 0; i--)
            {
                Console.Write(arr[i] + " ");
            }
        }
    }
}
