using System;
using System.Collections.Generic;
using System.Text;

namespace CEXR3
{
    class Testing
    {
        public static void Test(string input)
        {
            try
            {
                int i = int.Parse(input);
            }
            catch (FormatException)
            {
                Console.WriteLine("Number cannot be a character");
            }
        }
    }
}
