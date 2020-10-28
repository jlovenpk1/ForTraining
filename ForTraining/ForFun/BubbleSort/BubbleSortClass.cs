using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForTraining.ForFun.BubbleSort
{
    public class BubbleSortClass
    {
        int temp; // хранилище для значений
        int sizeArray; // размер массива
        int[] array; // массив

        public void Execute()
        {
            Console.WriteLine("Введите размер массива: ");
            sizeArray = int.Parse(Console.ReadLine());
            array = new int[sizeArray];
            Console.WriteLine("Введите {0} чисел в массив с новой строки: ");
            for (int i = 0; i < sizeArray; i++)
            {
                array[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Старый массив: ");
            for (int i = 0; i < sizeArray; i++)
            {
                Console.WriteLine("Array[{0}] = {1}",i, array[i]);
            }
            BubbleSortMethod();
            Console.WriteLine("Новый массив: ");
            for (int i = 0; i < sizeArray; i++)
            {
                Console.WriteLine("Array[{0}] = {1}",i, array[i]);
            }
        }

        private void BubbleSortMethod()
        {
            for (int i = 0; i < sizeArray; i++)
            {
                for (int j = i + 1; j < sizeArray; j++)
                {
                    if (array[i] > array[j])
                    {
                        temp = array[i]; // заносим число
                        array[i] = array[j]; // заносим меньше числов в ячейку array[i]
                        array[j] = temp; // заносим большее числов в ячейку array[j]
                        
                    }
                }
            }
        }
    }
}
