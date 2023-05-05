using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpGoFSample.Iterator
{
    internal class Main
    {
        public void Run()
        {
            Servos servos = new Servos();
            servos.Add(new Servo(1));
            servos.Add(new Servo(2));
            servos.Add(new Servo(3));

            IIterator<Servo> servoIterator = servos.Iterator();
            
            while(servoIterator.HasNext()) 
            {
                Console.WriteLine(servoIterator.Next());
            }
        }
    }

}
