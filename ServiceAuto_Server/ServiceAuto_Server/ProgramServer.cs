using ServiceAuto_Server.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceAuto_Server
{
    internal class ProgramServer
    {
        static void Main(string[] args)
        {
            CombinedServiceHost host = new CombinedServiceHost();
            host.Start();
            Console.WriteLine("Services are running. Press Enter to exit...");
            Console.ReadLine();
            host.Stop();
        }
    }
}
