using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;

namespace CEXR9
{
    class Program : Authenticate
    {
        static void Main(string[] args)
        {
            Authenticate init = new();
            init.Startsystem();
        }
    }

    public class Authenticate
    {
        Dictionary<string, byte[]> UserCredentials = new();
        List<string> PassName = new();
        string UserName { get; set; }
        string Password { get; set; }
        byte[] HashedBytes { get; set; }

        public void Startsystem()
        {
            PrintUI();

            int userInput = int.Parse(Console.ReadLine());

            while (userInput != 0)
            {
                if (userInput == 1)
                {
                    GetNewUser();
                    Startsystem();
                }
                else if (userInput == 2)
                {
                    GetUser();
                    Startsystem();
                }
                else if (userInput == 3)
                {
                    PrintUsers();
                    Startsystem();
                }
                else
                {
                    Console.WriteLine("Invalid input, try again.");
                }
            }
            Console.WriteLine("\nGoodbye");
            Environment.Exit(0);
        }

        public static void PrintUI()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("PASSWORD AUTHENTICATION SYSTEM\n");
            Console.WriteLine("Please select an option and press [ENTER]:\n");
            Console.WriteLine("1. Establish an account\x0A" +
                "2. Authenticate a user\x0A" +
                "3. Print all users\x0A" +
                "4. Press [0] to exit");
            Console.ResetColor();
        }

        public void PrintUI2()
        {
            Console.WriteLine("\nPlease enter a [USERNAME], press [ENTER] when done");
            UserName = Console.ReadLine();
            Console.WriteLine("\nPlease enter a [PASSWORD], press [ENTER] when done");
            Password = Console.ReadLine();
        }

        public void GetNewUser()
        {
            PrintUI2();

            if (UserCredentials.ContainsKey(UserName))
            {
                Console.WriteLine("\nUsername already exists\x0A" +
                    "Press [ENTER] to try again");
                WaitForKey(ConsoleKey.Enter);
                GetNewUser();
            }
            else
            {
                PassName.Add(Password);
                HashPassword();
                UserCredentials.Add(UserName, HashedBytes);
            }
        }

        public void GetUser()
        {
            PrintUI2();

            if (UserCredentials.ContainsKey(UserName))
            {
                byte[] checkPassword = UserCredentials[UserName];

                if (checkPassword == HashedBytes)
                {
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    Console.WriteLine("\nUser authenticated\x0A");
                    Console.ResetColor();
                    Console.WriteLine("Press [ENTER] to continue");
                    WaitForKey(ConsoleKey.Enter);
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine("\nUsername or password is incorrect, press [ENTER] to try again");
                    Console.ResetColor();
                    WaitForKey(ConsoleKey.Enter);
                    GetUser();
                }
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("\n[USERNAME] or [PASSWORD] is incorrect, press [ENTER] to try again");
                Console.ResetColor();
                WaitForKey(ConsoleKey.Enter);
                GetUser();
            }
        }

        public void HashPassword()
        {
            using var sha256 = SHA256.Create();
            HashedBytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(Password));
        }

        public void PrintUsers()
        {
            int index = 0;

            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("\nUSERNAME || PASSWORD || HASHCODE");
            Console.WriteLine("---------++----------++---------\n");
            Console.ResetColor();

            foreach (KeyValuePair<string, byte[]> item in UserCredentials)
            {
                string userName = item.Key;
                string hashPassword = BitConverter.ToString(item.Value).Replace("-", "").ToLower();
                Console.WriteLine($"{userName} || {PassName[index]} || {hashPassword}");
                index++;
            }
            WaitForKey(ConsoleKey.Enter);
        }

        public static void WaitForKey(ConsoleKey key)
        {
            while (Console.ReadKey(true).Key != key)
            { }
        }
    }
}