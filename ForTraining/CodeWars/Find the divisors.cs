using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForTraining.CodeWars
{
    class Find_the_divisors
    {
        /* Не закончил задачу, т.к решение требует что бы программы выполняла все быстро. Очевидное решение с большими числами занимает много времени */
        public int[] FindTheDivisors(int n)
        {
            if (n < 1) { return null; }
            int[] d = new int[n];
            HashSet<int> result = new HashSet<int>();
            for (int i = 1; i <= Math.Sqrt(n);
                                      i++)
            {
                if (n % i == 0)
                {
                        result.Add(i);
                    // If divisors are equal, 
                    // print only one 
                    if (n / i == i)
                        Console.Write(i + " ");

                    // Otherwise print both 
                    else
                        Console.Write(i + " "
                                + n / i + " ");
                }
            }
            return result.Count() == 0? null : result.ToArray();
        }
    }
}
