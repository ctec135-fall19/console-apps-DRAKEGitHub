﻿/*
 * Author: Allison Drake
 * CTEC 135: C# Programming
 * Console Apps
 * Problem 2
 * 
 * The pipe symbol routes the standard output from CA1 to the standard input of CA2
 */


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CA2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("CA2 is reporting:");
            Console.WriteLine();
            int i = 0;
            while (i < 4)
            {
                string userString;
                Console.WriteLine("Enter string '{0}' of 4: ", (i+1));
                userString = Console.ReadLine();
                Console.WriteLine("You entered '{0}'", userString);
                i++;
            }
        }
    }
}
