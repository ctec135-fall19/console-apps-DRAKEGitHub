/*
 * Author: Allison Drake
 * CTEC 135: C# Programming
 * Console Apps
 * Problem 2
 * 
 * Program CA1 outputs its results to "standard output". 
 * Program CA2 gets its input from "standard input" (Console.Readline())
 * The pipe symbol routes the standard output from CA1 to the standard input of CA2
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CA1
{
    class Program
    {
        static void Main(string[] args)
        {
            // several strings to print out
            Console.WriteLine("CA1 is reporting on args:");
            Console.WriteLine("--- wait for it ---");
            Console.WriteLine("If there is something in args, it will print here " +
                "or tell you that CA1 has zero args:");
            // if else with a foreach that reads the length and prints based on length
            if (args.Length == 0) Console.WriteLine("CA1 has zero args.");
            else
            {
                foreach(string s in args)
                {
                    Console.WriteLine(s);
                }
            }
            Console.WriteLine("Thanks for playing CA1 prints args.");
        }
    }
}
