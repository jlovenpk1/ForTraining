using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForTraining.ForFun
{
    abstract class Animal
    {
        public abstract string Name { get; set; }

        public Animal()
        {
            Console.WriteLine("Make Animal");
        }
        public abstract void Roar();
        public abstract void GetInfo();
        public abstract void Eat();
        public abstract void Run();
        public abstract void Walk();
    }
}
