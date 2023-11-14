using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.KasenovAE.Sprint4.TaskReview.V7.Lib;

namespace Tyuiu.KasenovAE.Sprint4.TaskReview.V7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт #4 | Выполнил: Касенов А. Е. | ПКТб-23-2";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #4                                                               *");
            Console.WriteLine("* Задание по спринту                                                      *");
            Console.WriteLine("* Вариант #7                                                              *");
            Console.WriteLine("* Выполнил: Касенов Айдархан Есенаевич | ПКТб-23-2                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дана строка из одноразрядных цифр \"31415926\".                         *");
            Console.WriteLine("* Преобразуйте ее в матрицу 4 на 2                                        *");
            Console.WriteLine("* и подсчитайте количество нечетных чисел в матрице.                      *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            string str = "31415926";
            Console.WriteLine("Исходная строка: " + str);
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            DataService ds = new DataService();
            int[,] mtrx = ds.TransformMatrix(str);
            int count = ds.CountOdd(mtrx);
            Console.WriteLine("Матрица: ");
            for (int i = 0; i < mtrx.GetLength(0); i++)
            {
                for (int j = 0; j < mtrx.GetLength(1); j++)
                {
                    Console.Write(mtrx[i, j] + "\t");
                }
                Console.WriteLine();
            }
            Console.WriteLine("Количество нечетных чисел: " + count);
            Console.ReadKey();
        }
    }
}
