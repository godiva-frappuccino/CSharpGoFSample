using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpGoFSample.State
{

    internal class State
    {
        public States CurrentState { get; private set; }
        public State(States state)
        {
            CurrentState = state;
        }

        public void SetState(States state)
        {
            CurrentState = state;
        }

        public States getCurrentState()
        {
            return CurrentState;
        }
    }

    enum States
    {
        Manual,
        Auto
    }

}
