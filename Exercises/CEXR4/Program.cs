using System;

namespace CEXR4
{
    class AnimalFarm
    {
        static void Main(string[] args)
        {
            static void MeetTheFamily()
            {
                Console.BackgroundColor = ConsoleColor.White;
                Console.ForegroundColor = ConsoleColor.DarkMagenta;

                /// Liger ///
                {
                    Liger start = new Liger();
                    Console.WriteLine();
                }

                /// Ape ///
                {
                    Monkey start = new Monkey();
                    Console.WriteLine();
                }

                /// Pig ///
                {
                    Pig start = new Pig();
                    Console.WriteLine();
                }

                /// Horse ///
                {
                    Horse start = new Horse();
                    Console.WriteLine();
                }
            }
        
            try
            {
                MeetTheFamily();
            }

            catch (Exception)
            {
                Console.WriteLine("Well, that's unfortunate.");
            }
        }
    }
}
