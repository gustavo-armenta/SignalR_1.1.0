using System;
using Microsoft.AspNet.SignalR.Server;
using Microsoft.Owin.Hosting;

namespace Microsoft.AspNet.SignalR.Server.Self
{
    class Program
    {
        static void Main(string[] args)
        {
            using (WebApp.Start<Startup>("http://localhost:28155/"))
            {
                Console.WriteLine("Server running at http://localhost:28155/");
                Console.ReadLine();
            }
        }
    }
}
