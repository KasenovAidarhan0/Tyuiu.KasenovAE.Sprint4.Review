using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint4;

namespace Tyuiu.KasenovAE.Sprint4.TaskReview.V7.Lib
{
    public class DataService
    {
        public int[,] TransformMatrix(string str)
        {
            int[,] res = new int[4, 2];
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    res[i, j] = Convert.ToInt32(Convert.ToString(str[i * 2 + j]));
                }
            }
            return res;
        }
        public int CountOdd(int[,] mtrx)
        {
            int res = 0;
            for (int i = 0; i < mtrx.GetLength(0); i++)
            {
                for (int j = 0; j < mtrx.GetLength(1); j++)
                {
                    if (mtrx[i, j] % 2 != 0)
                        res++;
                }
            }
            return res;
        }
    }
}
