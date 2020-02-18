using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForTraining.HackerRank
{
    class Sock_Merchant
    {
        public int n = 9;
        public int[] ar = new int[] { 10,20, 30, 10, 50, 30, 50, 10, 20 };
        
        /// <summary>
        /// Первый способ поиск пар
        /// </summary>
        /// <param name="n"></param>
        /// <param name="ar"></param>
        /// <returns></returns>
        public int sockMerchant(int n, int[] ar)
        {
            return ar.GroupBy(a => a).Sum(a => a.Count() / 2);
        }

        /// <summary>
        /// Второй способ Поиска пар 
        /// </summary>
        /// <param name="n"></param>
        /// <param name="ar"></param>
        /// <returns></returns>
        public int sockMerchant2(int n, int[]ar)
        {
            int _result = 0;
            Array.Sort(ar);
            for (int i = 0; i < ar.Length - 1; i++)
            {
                if (ar[i] == ar[i+1])
                {
                    _result++;
                    i++;
                }
            }
            return _result;

        }

        public void Main()
        {
            int result = sockMerchant(n, ar);
            int result2 = sockMerchant2(n, ar);
            Console.WriteLine("Первый способ: " + result + ";\nВторой способ: " + result2 + ";");
            Console.ReadKey();
        }
    }
}
