using System;
using System.Diagnostics;
using System.Text;
using System.Threading.Tasks;

namespace CEXR15
{
    public class Util
    {
        readonly StringBuilder SB;
        readonly Random Ran = new();
        readonly string Alphabet = "abcdefghijklmnopqrstuvwxyzABCDEFGHijkLMNOPQRSUVWXYZ0123456789~!@#$%^&*()_+-=<>?[]',./";
        int Count;
        readonly string ToBeGuessed;
        readonly Stopwatch SW = new();

        public Util(string toBeGuessed)
        {
            ToBeGuessed = toBeGuessed;
            SB = new StringBuilder(ToBeGuessed.Length);
        }

        public void PasswordBuster()
        {
            SW.Start();
            for (int i = 0; i < ToBeGuessed.Length; i++)
            {
                SB.Append(Alphabet[Ran.Next(0, Alphabet.Length - 1)]);
                if (SB.ToString().Length == ToBeGuessed.Length && SB.ToString() != ToBeGuessed)
                {
                    i = -1;
                    SB.Clear();
                    Count++;
                }
            }
            SW.Stop();
            TimeSpan ts = SW.Elapsed;
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine($"Password = {ToBeGuessed}\x0A" +
                $"Password found in:\x0A" +
                $"Iterations: {Count}\x0A" +
                $"Time: {ts}");
        }

        public void FasterPasswordBuster()
        {
            SW.Start();
            Parallel.For(0, ToBeGuessed.Length, i =>
           {
               SB.Append(Alphabet[Ran.Next(0, Alphabet.Length - 1)]);
               if (SB.ToString().Length == ToBeGuessed.Length && SB.ToString() != ToBeGuessed)
               {
                   i = -1;
                   SB.Clear();
                   Count++;
               }
           });
            SW.Stop();
            TimeSpan ts = SW.Elapsed;
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine($"Password = {ToBeGuessed}\x0A" +
               $"Password found in:\x0A" +
               $"Iterations: {Count}\x0A" +
               $"Time: {ts}");
        }
    }

    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Password Cracker");
            Console.WriteLine("================");
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("Enter Your Password");
            Util crypt = new(Console.ReadLine());
            Console.WriteLine("\nCracking in progress...\n");
            crypt.PasswordBuster();

            Console.ResetColor();
            Console.WriteLine("\nFaster Password Cracker");
            Console.WriteLine("=========================");
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("Enter Your Password");
            Util crypt2 = new(Console.ReadLine());
            Console.WriteLine("\nCracking in progress...\n");
            crypt2.FasterPasswordBuster();
            Console.ResetColor();
            Console.ReadKey();
        }
    }
}

