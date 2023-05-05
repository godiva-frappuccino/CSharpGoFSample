using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpGoFSample.ChainOfResponsibility
{
    internal interface CustomLogger
    {
        void Log(LogLevel level, string message);
    }
}
