using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace CSharpGoFSample.TemplateMethod
{
    internal class GazeProcess : GazeTemplate
    {
         protected override Vector2 GetHumanPosition(/*2Dカメラ画像*/)
        {
            return Vector2.Zero; // 処理は省略
        }
         protected override Vector2? GetAppliedCommand()
        {
            return null; // ここを書き換えて処理を追加したり変更する
        }
        protected override Vector2 DecideGazePosition(Vector2 HumanPosition, Vector2? Command)
        {
            return Vector2.Zero; // 処理は省略
        }
         protected override void Look(Vector2 DecidedPosition)
        {
            // 処理は省略
        }

    }
}
