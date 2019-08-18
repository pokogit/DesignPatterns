using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns
{
    public abstract class Duck
    {
        public IFlyBehaviour flyBehaviour;
        public IQuackBehaviour quackBehaviour;

        public void PerformQuack()
        {
            quackBehaviour.Quack();
        }

        public void PerformFly()
        {
            flyBehaviour.Fly();
        }

        public void Swim()
        {
            Console.WriteLine("All ducks float, even decoys!");
            Console.ReadLine();
        }

        public abstract void Display();

        public void SetFlyBehaviour(IFlyBehaviour fb)
        {
            flyBehaviour = fb;
        }

        public void SetQuackBehaviour(IQuackBehaviour qb)
        {
            quackBehaviour = qb;
        }
    }
}
