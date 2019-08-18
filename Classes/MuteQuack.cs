using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns
{
    class MuteQuack : IQuackBehaviour
    {
        public void Quack()
        {
            Console.WriteLine("<< Silence >>");
            Console.ReadLine();
        }
    }
}
