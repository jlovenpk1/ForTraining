using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using Dadata;
using Dadata.Model;
using ForTraining.CodeWars;
using ForTraining.ForFun;
using ForTraining.ForFun.BubbleSort;
using ForTraining.ForFun.Builder;
using ForTraining.ForFun.ClassED;
using ForTraining.ForFun.ClassPracticle;
using ForTraining.ForFun.Delegate;
using ForTraining.ForFun.Factory_Method;
using ForTraining.ForFun.RegexSample;
using ForTraining.ForFun.Singletone;
using ForTraining.ForFun.Strategy;
using ForTraining.HackerRank;
using ForTraining.Leetcode;

namespace ForTraining
{
    class Program
    {

        static void Main(string[] args)
        {
            //Find_Numbers_with_Even_Number_of_Digits task1 = new Find_Numbers_with_Even_Number_of_Digits();
            //task1.FindNumbers();
            //Sock_Merchant sm = new Sock_Merchant();
            //sm.Main();
            //ForFun.Delegate.Delegate dm = new ForFun.Delegate.Delegate();
            //dm.Execute();
            //FactoryMethod fm = new FactoryMethod();
            //fm.Execute();
            //Console.ReadKey();
            //Builder br = new Builder();
            //br.Execute();
            //Console.ReadKey();
            //Singletone s1 = Singletone.GetInstance();
            //s1.OpenConnect();
            //s1.CloseConnect();
            //s1.GetInfoAdmin();
            //Console.ReadKey();
            //JadeCase jade = new JadeCase();
            //jade.JadenCase();
            //Console.ReadKey();
            //Find_the_divisors ftd = new Find_the_divisors();
            //var x = ftd.FindTheDivisors(16);
            //MakeAnimal make = new MakeAnimal();
            //make.Run();
            //CarMagazine _cm = new CarMagazine(new Car { Name = "BMW", Age = 25, Power = 240, DateBuild = DateTime.Now });
            //_cm.Execute();
            Human china = new Chiness("Микао","Сан Ду","Китаец","Китай","Китайский");
            Human huma = new Human("Человек","Человеченский","Земля","Всеобщий");
            china.GetInfo();
            china.Language();
            china.YourFrom();
            china.YourNational();
            Console.WriteLine("________________________________");
            huma.GetInfo();
            huma.Language();
            huma.YourFrom();
            huma.YourNational();
            Console.ReadKey();
        }
       
    }
}
