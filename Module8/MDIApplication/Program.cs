/*
 * Author: Allison Drake
 * CTEC 135: C# Programming
 * MDI Win App Using IDE
 * 
 * creates MDI with MainWindow as primary Form
 * adds a menustrip that creates a new window, and
 * has options to arrange in cascade, horizontal, or vertical in same menu
 * on load the date/time is commited to string and a new child is created
 * 
 * 
 * BONUS: Two buttons are available: one creates a new window in one click and
 * the other closes the other exits the program
 * 
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MDIApplication
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainWindow());
        }
    }
}
