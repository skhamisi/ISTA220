using System;

namespace ArrayDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Array Demo");

            int[] samer = { 1, 2, 65, 300, 700, 89, 1000, 3, 67 };
            for(int i = 0; i < samer.Length; i++)
            {
                Console.WriteLine($"{i}.  {samer[i]}"); /// This is how you de-reference an array, you pass it the index
            }
            Console.WriteLine("-----------------");

            foreach(int e in samer)
            {
                Console.WriteLine(e);
            }
        }
    }
}
