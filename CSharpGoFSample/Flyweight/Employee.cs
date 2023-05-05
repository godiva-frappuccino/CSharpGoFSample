using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpGoFSample.Flyweight
{
    internal class Employee
    {
        public string Name { get; set; }
        public string Unit { get; set; }
        public Employee(string unit)
        {
            Unit = unit;
        }
    }
}
