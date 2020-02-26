using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForTraining.ForFun.Singletone
{
    class Singletone
    {
        public readonly string conect = "Database: MySQL; Login: Admin; Password: qwerqwe9982-#12; host: Localhost;";
        public readonly string nameAdmin = "Аби-Абу-Альзес 5";
        private Singletone()
        {

        }

        private static Singletone _instance;

        public static Singletone GetInstance() => _instance == null ? new Singletone() : _instance;

        public void OpenConnect()
        {
            Console.WriteLine("Коннект открыт!");
        }
        public void CloseConnect()
        {
            Console.WriteLine("Коннект закрыт!");
        }

        public void GetInfoAdmin()
        {
            Console.WriteLine($"Имя админа: {nameAdmin}");
        }

    }

}
