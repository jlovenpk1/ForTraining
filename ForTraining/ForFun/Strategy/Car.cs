using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForTraining.ForFun.Strategy
{
    class Car : ACar, ICar
    {
        public void GetInfo()
        {
            Console.WriteLine("Name {0}\n Age {1}\n Power {2}\n DateBuild {3}\n", base.Name, base.Age, base.Power, base.DateBuild);
        }

        public void Settings()
        {
            Console.WriteLine("Settings");
        }

        public void Start()
        {
            Console.WriteLine("Wrum-Wrum");
        }

        public void Stop()
        {
            Console.WriteLine("Stop Car");
        }
    }
}
