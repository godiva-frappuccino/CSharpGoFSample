using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace CSharpGoFSample.Strategy
{
    internal interface IGazeStrategy
    {
        Vector2 Look(Vector2 humanPosition);
    }
}
