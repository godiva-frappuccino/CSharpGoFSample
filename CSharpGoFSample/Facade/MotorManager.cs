using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpGoFSample.Facade
{
    internal class MotorManager
    {
        private Motor motor;
        private Sensor sensor;
        public MotorManager(Motor motor, Sensor sensor)
        {
            this.motor = motor;
            this.sensor = sensor;
        }

        public void Run()
        {
            double value = this.sensor.ReadValue();    
            this.motor.MockWrite(value);
        }
    }
}
