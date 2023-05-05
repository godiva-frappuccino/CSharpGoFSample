using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpGoFSample.Interpreter
{
    internal class Main
    {
        public void Run()
        {
            IntOperand op1 = new IntOperand(2);
            IntOperand op2 = new IntOperand(3);
            Addition add = new Addition();
            Expression addExpression = new Expression(op1, add, op2);
            Console.WriteLine(addExpression.GetValue());
        }
    }
}
