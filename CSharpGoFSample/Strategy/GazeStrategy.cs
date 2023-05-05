using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace CSharpGoFSample.Strategy
{
    internal class GazeStrategy :IGazeStrategy
    {
        public Vector2 Look(Vector2 position)
        {
            // 処理は省略
            return position;
        }
    }

    internal class NotGazeStrategy : IGazeStrategy
    {
        public Vector2 Look(Vector2 position)
        {
            // 処理は省略
            return position;
        }
    }
}
