﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Classes
{
    public class ModelDuck : Duck
    {
        public ModelDuck()
        {
            flyBehaviour = new FlyNoWay();
            quackBehaviour = new Quack();
        }
        public override void Display()
        {
            Console.WriteLine("I'm a model duck.");
        }
    }
}
