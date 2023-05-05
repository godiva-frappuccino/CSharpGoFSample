using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpGoFSample.Iterator
{
    internal class Servos : IAggrigate<Servo>
    {
        public List<Servo> ServoList;
        public void Add(Servo servo)
        {
            ServoList.Add(servo);
        }

        public IIterator<Servo> Iterator()
        {
            return new ServosIterator(this);
        }

    }

    internal class ServosIterator : IIterator<Servo> 
    {
        public Servos Servos { get; }
        public int Index { get; private set; } = 0;

        public ServosIterator(Servos servos)
        {
            Servos = servos;
        }

        public bool HasNext()
        {
            return (Index < this.Servos.ServoList.Count);
        }

        public Servo Next()
        {
            return this.Servos.ServoList[Index++];
        }
    }

    internal class Servo
    {
        public long Id { get; private set; }
        public Servo(long id)
        {
            Id = id;
        }
        
    }
}
