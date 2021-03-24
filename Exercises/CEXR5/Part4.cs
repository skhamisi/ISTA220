using System;

namespace CEXR5
{
    class Part4
    {
        private int[] A = { 0, 2, 4, 6, 8, 10 };
        private int[] B = { 1, 3, 5, 7, 9 };
        private int[] C = { 3, 1, 4, 1, 5, 9, 2, 6, 5, 3, 5, 9 };

        public Part4()
        {
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.Write("Sorting arrays:\n");
            Console.ReadLine();
            Console.ForegroundColor = ConsoleColor.White;

            Console.Write("Sorted Array A is: "); 
            Console.ForegroundColor = ConsoleColor.DarkYellow; 
            Sort(A);
            Console.ReadLine();
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.White;

            Console.Write("Sorted Array B is: "); 
            Console.ForegroundColor = ConsoleColor.DarkYellow; 
            Sort(B);
            Console.ReadLine();
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.White;

            Console.Write("Sorted Array C is: "); 
            Console.ForegroundColor = ConsoleColor.DarkYellow; 
            Sort(C);
        }

        private static void Sort(int[] arr)
        {

            int temp;
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = i + 1; j < arr.Length; j++)
                    if (arr[i] > arr[j])
                    {
                        temp = arr[j];
                        arr[j] = arr[i];
                        arr[i] = temp;
                    }
                Console.Write(arr[i] + " ");
            }
        }
    }
}