using System;
using System.Linq;

namespace HW_06
{
    class Program
    {
        static void Main(string[] args)
        {
            // Task1();
            Task2();
        }

        /* static void Task1()

         {
             Random rnd = new Random();
             int[] arrRand = new int[5];
             for (int i = 0; i < arrRand.Length; i++)
             {
                 arrRand[i] = rnd.Next(10);
                 Console.WriteLine(arrRand[i]);
             }

             var arr = new int[5];

             for (int i = 0; i < arr.Length; i++)
             {
                 Console.Write("Введите элементы массива {0}:", i + 1);
                 arr[i] = Convert.ToInt32(Console.ReadLine());
             }

             int[] result = new int[5];
             for (int index = 0; index < result.Length; index++)
             {
                 result[index] = arrRand[index] + arr[index];
             }

             for (int i = 0; i < result.Length; i++)
             {
                 Console.WriteLine("Элемент 3 массива {0}:", i + 1);
                 Console.WriteLine("Res = " + result[i]);
             }

         }*/

        static void Task2()
        {
            var p = new int[6];
            for (int i = 0; i < 5; i++) 
            {
                Console.WriteLine("Введите 5 чисел в массив {0}:", i+1);
                p[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("Введите 6 число:");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите позицию для нового числа:");
            int y = Convert.ToInt32(Console.ReadLine());

            for (int i = 4; i > y - 1; i--) 
            {
                p[i + 1] = p[i];
                p[y - 1] = n;
            }
            for (int i = 0; i < 6; i++) 
            {
                Console.WriteLine(p[i]);
            }

        }


    }
}
