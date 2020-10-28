using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForTraining.ForFun.ClassED
{
    public class ClassED
    {
        public delegate void Message(string message);
        public delegate void BadCall();
        public event Message Notify;
        public string name;

        public void Execute()
        {
            Console.WriteLine("Попытка подключиться в комнату............");
            Notify += NotifySender;
            JoinRoom();
            BadCall YNCall;
            YNCall = CallError;
            YNCall();

        }

        private void JoinRoom()
        {
            Console.WriteLine("Введите имя пользователя..........");
            name = Console.ReadLine();
            Notify?.Invoke("Пользователь "+name+" подключился");
        }

        private void NotifySender(string Message)
        {
            Console.WriteLine(Message);
        }

        private void CallError()
        {
            Console.WriteLine("Связи нет.............");
        }
    }
}
