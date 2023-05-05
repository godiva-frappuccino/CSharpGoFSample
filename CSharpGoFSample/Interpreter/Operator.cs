using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpGoFSample.Interpreter
{
    internal interface Operator
    {
        void SetLeftOperand(Operand operand);
        void SetRightOperand(Operand operand);
        int Calc();
    }
}
