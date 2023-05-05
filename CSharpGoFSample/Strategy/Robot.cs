using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace CSharpGoFSample.Strategy
{
    internal class Robot
    {
        public IGazeStrategy GazeStrategy { get; private set; }
        public Robot(IGazeStrategy gazeStrategy)
        {
            GazeStrategy = gazeStrategy;
        }

        public void ChangeStrategy(IGazeStrategy gazeStrategy)
        {
            GazeStrategy = gazeStrategy;
        }

        public void RunTest()
        {
            int testTime = 10;
            Vector2 humanPosition = new Vector2(10, 10);
            ChangeStrategy(new GazeStrategy());

            DateTime startTime = DateTime.Now;
            while ((DateTime.Now - startTime).TotalSeconds < testTime)
            {
                GazeStrategy.Look(humanPosition);
            }
            ChangeStrategy(new NotGazeStrategy());

            while ((DateTime.Now - startTime).TotalSeconds < testTime)
            {
                GazeStrategy.Look(humanPosition);
            }
        }
    }
}
