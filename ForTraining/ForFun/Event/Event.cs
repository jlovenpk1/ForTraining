using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForTraining.ForFun
{
    public class Event
    {
        public delegate void Welcome(string message);
        public event Welcome Notify;
        public string name;

        public void Execute()
        {
            Console.WriteLine("Входим в комнату.....");
            Notify += NotifySender;
            JoinRoom();
            
        }
        
        private void JoinRoom()
        {
            Console.WriteLine("Введите Ваше имя: ");
            name = Console.ReadLine();
            Notify("Пользователь " + name + " зашёл в комнату; ");
        }

        private void NotifySender(string message)
        {
            Console.WriteLine(message);
        }
    }
}
