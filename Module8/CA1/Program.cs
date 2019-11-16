/*
 * Author: Allison Drake
 * CTEC 135: C# Programming
 * Console Apps
 * Problem 2
 * 
 * 
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
            Console.WriteLine("CA1 is reporting on args:");
            Console.WriteLine("--- wait for it ---");
            Console.WriteLine("If there is something in args, it will print here " +
                "or tell you that CA1 has zero args:");
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
