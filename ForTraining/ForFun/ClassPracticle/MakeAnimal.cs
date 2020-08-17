using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace ForTraining.ForFun.ClassPracticle
{
    class MakeAnimal
    {
        public void Run()
        {

        }
    }

    class Cat : Animal
    {
        private string _name;
        public override string Name { get => _name; set => _name = value }

        public override void Eat()
        {
            Console.WriteLine("Nam Nam");
        }

        public override void GetInfo()
        {
            Console.WriteLine("Name: {0} ", Name);
        }

        public override void Roar()
        {
            Console.WriteLine("Nya-Nya");
        }

        public override void Run()
        {
            Console.WriteLine("{0} Run", Name);
        }

        public override void Walk()
        {
            Console.WriteLine("{0} Walk", Name);
        }
    }
}
