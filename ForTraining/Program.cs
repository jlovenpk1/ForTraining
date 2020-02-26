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
using ForTraining.ForFun.Delegate;
using ForTraining.ForFun.Factory_Method;
using ForTraining.ForFun.RegexSample;
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
            FactoryMethod fm = new FactoryMethod();
            fm.Execute();
            Console.ReadKey();
        }
       
    }
}
