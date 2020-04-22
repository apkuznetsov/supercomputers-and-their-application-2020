using System;

namespace lab
{
    public class Arrays
    {
        public static int[,] CreateRandNumsArr(int rowsNum, int colsNum)
        {
            int[,] arr = new int[rowsNum, colsNum];

            Random rand = new Random();

            for (int y = 0; y < rowsNum; y++)
            {
                for (int x = 0; x < colsNum; x++)
                {
                    arr[y, x] = rand.Next();
                }
            }

            return arr;
        }
    }
}
