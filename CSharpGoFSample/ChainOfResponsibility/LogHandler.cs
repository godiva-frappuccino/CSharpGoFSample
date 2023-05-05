using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpGoFSample.ChainOfResponsibility
{
    internal enum LogLevel
    {
        Info = 1,
        Warn = 2,
        Error = 3,
    }


    internal class InformationHandler : CustomLogger
    {
        private WarnHandler next;
        public InformationHandler() { next = new WarnHandler(); }
        public void Log(LogLevel level, string message)
        {
            if (level == LogLevel.Info)
            {
                Console.WriteLine($"Info:{message}");
            }
            else
            {
                next.Log(level, message);
            }
        }
    }

    internal class WarnHandler : CustomLogger
    {
        private ErrorHandler next;
        public WarnHandler() { next = new ErrorHandler(); }
        public void Log(LogLevel level, string message)
        {
            if (level == LogLevel.Info)
            {
                Console.WriteLine($"Info:{message}");
            }
            else
            {
                next.Log(level, message);
            }
        }
    }

    internal class ErrorHandler : CustomLogger
    {
        public ErrorHandler() { }
        public void Log(LogLevel level, string message)
        {
            if (level == LogLevel.Error)
            {
                Console.WriteLine($"Info:{message}");
            }
        }
    }
}
