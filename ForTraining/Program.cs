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
using ForTraining.ForFun.Builder;
using ForTraining.ForFun.Delegate;
using ForTraining.ForFun.Factory_Method;
using ForTraining.ForFun.RegexSample;
using ForTraining.ForFun.Singletone;
using ForTraining.HackerRank;
using ForTraining.Leetcode;
using ForTraining.StackOverflow.OpenFileInFolder;
using ForTraining.StackOverflow.ReadFileZipTxt;

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
            //ReadTxtInZip rtx = new ReadTxtInZip();
            //rtx.workWithZip2();
            FileFindFolder fff = new FileFindFolder(@"D:\test1", @"D:\test2");
            fff.Run();
            Console.ReadKey();
        }
       
    }
}
