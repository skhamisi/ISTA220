using System;

namespace CEXR5
{
    class Part3
    {
        private int[] A = { 0, 2, 4, 6, 8, 10 };
        private int[] B = { 1, 3, 5, 7, 9 };
        private int[] C = { 3, 1, 4, 1, 5, 9, 2, 6, 5, 3, 5, 9 };

        public Part3()
        {
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.Write("Rotating Arrays\n");
            Console.ReadLine();
            Console.ForegroundColor = ConsoleColor.White;

            Console.Write($"Array A rotated left 2 times is: "); 
            Console.ForegroundColor = ConsoleColor.DarkYellow; 
            RotateArray(0, 2, A);
            Console.ReadLine();
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.White;

            Console.Write("Array B rotated right 2 times is: "); 
            Console.ForegroundColor = ConsoleColor.DarkYellow; 
            RotateArray(1, 2, B);
            Console.ReadLine();
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.White;

            Console.Write("Array C rotated left 4 times is: "); 
            Console.ForegroundColor = ConsoleColor.DarkYellow; 
            RotateArray(0, 4, C);
        }

        private static void RotateArray(int dir, int dist, int[] arr)
        {
            int[] temp = new int[dist];

            if (dir == 0)
            {
                for (int i = 0; i < dist; i++)
                {
                    int tempInt = arr[0];

                    for (int j = 0; j < arr.Length - 1; j++)
                    {
                        arr[j] = arr[j + 1];
                    }
                    arr[arr.Length - 1] = tempInt;
                }

                for (int i = 0; i < arr.Length; i++)
                {
                    Console.Write(arr[i] + " ");
                }
            }

            if (dir == 1)
            {
                for (int i = 0; i < dist; i++)
                {
                    int j, last;
                    last = arr[arr.Length - 1];

                    for (j = arr.Length - 1; j > 0; j--)
                    {
                        arr[j] = arr[j - 1];
                    }
                    arr[0] = last;
                }

                for (int i = 0; i < arr.Length; i++)
                {
                    Console.Write(arr[i] + " ");
                }
            }
        }
    }
}
