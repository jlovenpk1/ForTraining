using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForTraining.Leetcode
{
    class Find_Numbers_with_Even_Number_of_Digits
    {

        private int[] nums = new int[] { 12, 345, 2, 6, 7896 }; // Изначальный массив
        private int result = 0; // результат

        /// <summary>
        /// Запустить тестовый поиск
        /// </summary>
        /// <returns></returns>
        public int FindNumbers()
        {
            result = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                int count = nums[i].ToString().Length;
                result = count >= 2 && (double)count % 2 == 0 ? result += 1 : result;
            }
            Console.WriteLine("Результат поиска: " + result);
            Console.ReadKey();
            return result;
            /*
             Runtime: 100 ms, faster than 44.73% of C# online submissions for Find Numbers with Even Number of Digits.
             Memory Usage: 26.4 MB, less than 100.00% of C# online submissions for Find Numbers with Even Number of Digits.
             */
        }

        /// <summary>
        /// Запустить поиск с входящим массивом
        /// </summary>
        /// <param name="nums"></param>
        /// <returns></returns>
        public int FindNumber(int[] nums)
        {
            result = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                int count = nums[i].ToString().Length;
                result = count >= 2 && (double)count % 2 == 0 ? result += 1 : result;
            }
            return result;

            /*
             Runtime: 100 ms, faster than 44.73% of C# online submissions for Find Numbers with Even Number of Digits.
             Memory Usage: 26.4 MB, less than 100.00% of C# online submissions for Find Numbers with Even Number of Digits.
             */
        }
    }
}
