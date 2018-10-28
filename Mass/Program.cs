using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mass
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] arrayOfInt = new int[] { 5, 7, 1, 6, 8, 11, -5, -7, 3, -20 };
            Console.WriteLine("исходный массив:");
            for (int k = 0; k < arrayOfInt.Length; k++)
            {
                Console.Write(arrayOfInt[k] + " ");
            }

            //• Сумму элементов, находящихся между первым и последним отрицательными элементами.
            int SumBetween = 0;
            for (int i = 0; i < arrayOfInt.Length - 1; i++)
            {
                if (arrayOfInt[i] < 0)
                {
                    SumBetween += arrayOfInt[i + 1];
                }

            }
            Console.WriteLine("\n summ between first and last negative : " + SumBetween);


            int NegSumm = 0;
            // • Сумму отрицательных элементов.
            for (int i = 0; i < arrayOfInt.Length; i++)
            {
                if (arrayOfInt[i] < 0)
                {
                    NegSumm += arrayOfInt[i];
                }
            }
            Console.WriteLine("summ of negative numbers " + NegSumm);


            //• Произведение элементов с четными номерами.
            int even = 1;
            for (int i = 1; i < arrayOfInt.Length; i++) // нулевой индекс не берем
            {
                if (i % 2 != 0) //так как в массиве нумерация идет от нуля то обычная сверка не подойдет
                {
                    even *= arrayOfInt[i];
                }
            }
            Console.WriteLine("even numbers multiply  " + even);

            //• Произведение элементов, находящихся между min и max элементами.
            for (int i = 0; i < arrayOfInt.Length; i++)
            {

                for (int j = 0; j < arrayOfInt.Length; j++)
                {
                    int z;
                    if (arrayOfInt[i] < arrayOfInt[j])
                    {
                        z = arrayOfInt[i];
                        arrayOfInt[i] = arrayOfInt[j];
                        arrayOfInt[j] = z;
                    }
                }
            }
            int Multi = arrayOfInt[1];
            for (int i = 2; i < arrayOfInt.Length - 1; i++)
            {
                Multi *= arrayOfInt[i];
            }
            Console.WriteLine("multiplied elements between min and max" + Multi);


            Console.WriteLine("sorted mass: ");
            for (int k = 0; k < arrayOfInt.Length; k++)
            {
                Console.Write(arrayOfInt[k] + " ");
            }

            Console.ReadLine();



        }
    }
}
