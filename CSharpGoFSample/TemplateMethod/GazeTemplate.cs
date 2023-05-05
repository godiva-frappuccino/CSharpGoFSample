using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace CSharpGoFSample.TemplateMethod
{
    internal abstract class GazeTemplate
    {
        abstract protected Vector2 GetHumanPosition(/*2Dカメラ画像*/);
        abstract protected Vector2? GetAppliedCommand();
        abstract protected Vector2 DecideGazePosition(Vector2 HumanPosition, Vector2? Command);
        abstract protected void Look(Vector2 DecidedPosition);

        public void Process(/*2Dカメラ画像*/)
        {
            Vector2 humanPosition = GetHumanPosition( );
            Vector2? appliedCommand = GetAppliedCommand();
            Vector2 decidedPosition = DecideGazePosition(humanPosition, appliedCommand);
            Look(decidedPosition);
        }

    }
}
