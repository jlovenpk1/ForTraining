using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForTraining.ForFun.Strategy
{
    class CarMagazine
    {
        ICar car;
        public CarMagazine(ICar _car)
        {
            car = _car;
        }
        public void Execute()
        {
            car.GetInfo();
            car.Settings();
            car.Start();
            car.Stop();
        }
    }
}
