using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpGoFSample.FactoryMethod
{
    internal abstract class Robot
    {
        public abstract void PrintInfo();
    }
    internal class RobotWithEye: Robot
    {
        public long Id { get; private set; }
        public Eye Eye { get; private set; }
        public override void PrintInfo()
        {
            Console.WriteLine(Eye.ToString());
        }

        public Eye CreateEye()
        {
            return new Eye();
        }

        public void SetEye(Eye eye)
        {
            this.Eye = eye;
        }
    }

    internal class Eye
    {

    }
}
