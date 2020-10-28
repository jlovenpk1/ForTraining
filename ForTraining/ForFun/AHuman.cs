using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForTraining.ForFun
{
    public abstract class AHuman
    {
        public string Name { get; internal set; }
        public string SurName { get; internal set; }

        public virtual void GetInfo()
        {
            Console.WriteLine("Меня зовут {0} {1}", Name, SurName);
        }
    }

    public class Human: AHuman
    {
        public string National { get; set; }
        public string Country { get; set; }

        public Human(string Name, string SurName, string National, string Country)
        {
            base.Name = Name;
            base.SurName = SurName;
            this.National = National;
            this.Country = Country;
        }

        public virtual void SayHi()
        {
            Console.WriteLine("Hi-Hi, just Human!");
        }

        public virtual void YourFrom()
        {
            Console.WriteLine("Я с планеты зелмя");
        }

        public virtual void YourNational()
        {
            Console.WriteLine("Я человек, просто человек!");
        }

        public virtual void Language()
        {
            Console.WriteLine("Я говорю на всех языках!");
        }
    }

    public class Chiness: Human
    {
        public string _language { get; set; }
        public Chiness(string name, string surname, string nation, string country, string language) : base(name, surname, nation, country)
        {
            this.Name = name;
            this.SurName = surname;
            this.National = nation;
            this.Country = country;
            this._language = language;
        }

        public override void SayHi()
        {
            Console.WriteLine("Привет!");
        }
        public override void YourFrom()
        {
            Console.WriteLine("Я из Китая!");
        }

        public override void Language()
        {
            Console.WriteLine("Основной язык Китайский");
        }

        public override void YourNational()
        {
            Console.WriteLine("Моя национальность {0}", National);
        }
    }
}
