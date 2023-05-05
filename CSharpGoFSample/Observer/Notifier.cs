using CSharpGoFSample.Command;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpGoFSample.Observer
{
    internal class Notifier
    {
        public int Angle { get; set; }
        List<IObserver> Observers { get; } = new List<IObserver>();
        public void AddObserver(IObserver observer)
        {
            Observers.Add(observer);
        }

        void Move(int angle)
        {
            Angle = angle;
            foreach(IObserver observer in Observers)
            {
                observer.Notified(angle.ToString());
            }
            
        }
    }
}
