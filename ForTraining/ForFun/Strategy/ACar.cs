using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForTraining.ForFun.Strategy
{
    abstract class ACar
    {
        public string Name { get { return name; } set { name = value; } }
        private string name;
        public int Age { get { return age;  } set { age = value; } }
        private int age;
        public int Power { get { return power; } set { power = value; } }
        private int power;
        public DateTime DateBuild { get { return datebuild; } set { datebuild = value; } }
        private DateTime datebuild;
    }
}
