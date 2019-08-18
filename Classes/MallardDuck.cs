using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Classes
{
    class MallardDuck : Duck
    {
        public  MallardDuck()
        {
            quackBehaviour = new Quack();
            flyBehaviour = new FlyWithWings();
        }

        public override void Display()
        {
            throw new NotImplementedException();
        }
    }
}
