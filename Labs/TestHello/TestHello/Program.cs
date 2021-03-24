using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestHello
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your name?!");
            string name = Console.ReadLine();
            Console.WriteLine($"Hello {name}!");
        } //Ends Main Program
    } //Ends class Program
} //Ends namespace block
