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
            Animal aCat = new Cat("Bagira");
            aCat.Eat();
            aCat.GetInfo();
            aCat.Roar();
            aCat.Name = "Zotoshka";
            aCat.GetInfo();
            aCat.Run();
            aCat.Walk();
            Cat aKitty = new Kitty("Myokao");
            aKitty.Eat();
            Console.ReadKey();
        }
    }

    class Cat : Animal
    {
        private string _name;
        public override string Name { get => _name; set => _name = value; }

        public Cat(string name)
        {
            _name = name;
            Console.WriteLine("Make Cate");
        }

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

    class Kitty : Cat
    {
        
        public Kitty(string name):base(name)
        {

            Console.WriteLine("Make Kitty {0}",name);
        }
    }
}
