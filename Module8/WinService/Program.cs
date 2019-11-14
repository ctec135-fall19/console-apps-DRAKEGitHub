/*
 * Author: Allison Drake
 * CTEC 135: C# Programming
 * Windows Service
 * 
 * 
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;

namespace WinService
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        static void Main()
        {
            ServiceBase[] ServicesToRun;
            ServicesToRun = new ServiceBase[]
            {
                new WinService()
            };
            ServiceBase.Run(ServicesToRun);
        }
    }
}
