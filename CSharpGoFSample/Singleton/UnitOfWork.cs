using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpGoFSample.Singleton
{
    internal class UnitOfWork
    {
        private LeftShoulderMotor? _leftShoulderMotor;
        private RightShoulderMotor? _rightShoulderMotor;
        public UnitOfWork() { }
        public LeftShoulderMotor LeftShoulderMotor
        {
            get
            {
                if(_leftShoulderMotor == null)
                {
                    _leftShoulderMotor= new LeftShoulderMotor();
                }
                return _leftShoulderMotor;
            }
        }

        public RightShoulderMotor RightShoulderMotor
        {
            get
            {
                if(_rightShoulderMotor == null)
                {
                    _rightShoulderMotor= new RightShoulderMotor();
                }
                return _rightShoulderMotor;
            }
        }
    }
}
