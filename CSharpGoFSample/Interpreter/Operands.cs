using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpGoFSample.Interpreter
{
    internal class IntOperand : Operand
    {
        public int Value { get; private set; }
        public IntOperand(int value)
        {
            Value = value;
        }
        public int GetValue()
        {
            return Value;
        }
    }
}
