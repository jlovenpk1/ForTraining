using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForTraining.ForFun
{
    public class Event
    {
        public delegate void Notify(string message);

        public event Action<string> OnChange;
        public event Notify OnNotify;

        public void Execute()
        {

        }
    }
}
