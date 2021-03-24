﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BinaryTree;

namespace EnumeratorTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Tree<int> tree1 = new Tree<int>(10);
            tree1.Insert(5);
            tree1.Insert(11);
            tree1.Insert(5);
            tree1.Insert(-12);
            tree1.Insert(15);
            tree1.Insert(0);
            tree1.Insert(14);
            tree1.Insert(-8);
            tree1.Insert(10);       
            
            foreach(int item in tree1)
            {
                Console.Write($"{item} ");
            }

            Console.WriteLine();

            Tree<char> samer = new Tree<char>(' ');
            samer.Insert('s');
            samer.Insert('a');
            samer.Insert('m');
            samer.Insert('e');
            samer.Insert('r');

            foreach (char letter in samer)
            {
                Console.Write($"{letter} ");
            }
        }
    }
}
