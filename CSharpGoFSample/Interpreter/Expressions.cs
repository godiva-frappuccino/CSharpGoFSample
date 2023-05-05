using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpGoFSample.Interpreter
{
    internal class Expression : Operand
    {
        public  Operand LeftOperand { get; private set; }
        public Operand RightOperand { get; private set;}
        public Operator Operator { get; private set; }

        public Expression(Operand leftOperand, Operator operator1, Operand rightOperand)
        {
            LeftOperand = leftOperand;
            RightOperand = rightOperand;
            Operator = operator1;

            Operator.SetLeftOperand(LeftOperand);
            Operator.SetRightOperand(RightOperand);
        }

        public int GetValue()
        {
            return Operator.Calc();
        }
    }

    internal class Addition : Operator
    {
        public Operand LeftOperand { get; private set; }
        public Operand RightOperand { get; private set;}

        public void SetLeftOperand(Operand leftOperand)
        {
            LeftOperand = leftOperand;
        }
        public void SetRightOperand(Operand rightOperand)
        {
            RightOperand = rightOperand;
        }

        public int Calc()
        {
            return LeftOperand.GetValue() + RightOperand.GetValue();
        }
    }
}
