/*
 * Author: Allison Drake
 * CTEC 135 C# Programming
 * TASK: Programming Assignment Console Apps
 * Problem 1
 * 
 * This is a demonstration of command line arguments
 *
 * Create a Console App named "MyConsoleApp"
 * Write code in Main() that:
 * Tests the length of the args array. If the length is zero, output a message.
 * If the length is greater than zero, output each argument on a separate line in form of:
 * -> command: <command line argument>
 * Run the program to test. It should print your message that there are no arguments
 * Right-click the project and select the properties (at the bottom of the list)
 * In the dialog select the Debug tab on the left
 * In the Command Line Arguments field enter several words separated by spaces as well as 
 * several more words with double quotes at the beginning and end. Something of the form:
 * one two three "one two three"
 * Run the program again. You should see the individual arguments printed on separate lines
 * and the quoted string printed together on the same line.
 * As a separate test open a command window (cmd.exe), navigate to the location of your exe
 * for this project, then run the program with several words following the program name
 * >MyConsoleApp one two three "one two three"
 * You should get the same output, but this is an example of how your program would be used
 * in the field as compared to testing it in the development environment.
 * Take a screenshot of the command window after running your program. Save it in a Word 
 * file. Keep the file open as we will use it for prob 2.
 * 
 * 
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args.Length == 0) Console.WriteLine("There are zero args.");
            else
            {
                foreach (string s in args)
                {
                    Console.WriteLine(s);
                }
            }
        }
    }
}
