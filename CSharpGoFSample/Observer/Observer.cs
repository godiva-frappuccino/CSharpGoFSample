using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpGoFSample.Observer
{
    internal class ClientObserver : IObserver
    {
        public void Notified(string message)
        {
            Console.WriteLine($"State Changed:{message}");
        }
    }

    internal class ServerObserver : IObserver
    {
        public void Notified(string message)
        {
            Console.WriteLine($"Motor Moved:{message}");
        }
    }
}
