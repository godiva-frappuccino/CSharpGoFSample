using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpGoFSample.Memento
{
    internal class Memento
    {
        public int Angle { get; private set; }
        public Memento(int angle) { Angle = angle; }
    }

    internal class MementoTaker
    {
        List<Memento> pool = new List<Memento>();
        void Add(Memento memento)
        {
            pool.Add(memento);
        }
        Memento Get(int when)
        {
            return pool[pool.Count - 1 - when];
        }
    }
}
