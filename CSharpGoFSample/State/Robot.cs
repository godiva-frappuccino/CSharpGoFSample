using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpGoFSample.State
{
    internal class Robot
    {
        public State CurrentState;
        public Robot() 
        {
            CurrentState = new State(States.Auto);
        }

        void SetState(States newState)
        {
            CurrentState.SetState(newState);
        }

        void PrintCurrentState()
        {
            Console.WriteLine(CurrentState.getCurrentState());
        }
    }
}
