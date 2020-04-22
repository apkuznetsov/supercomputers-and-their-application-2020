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
                for (int x = 0; x < colsNum; x++)
                    arr[y, x] = rand.Next();

            return arr;
        }

        public static int[,] MultByClassicMethod(int[,] arr1, int[,] arr2)
        {
            int rowsNumArr1 = arr1.GetLength(0);
            int colsNumArr1 = arr1.GetLength(1);
            int colsNumArr2 = arr2.GetLength(1);

            int[,] resArr = new int[rowsNumArr1, colsNumArr2];

            for (int rows1 = 0; rows1 < rowsNumArr1; rows1++)
                for (int cols2 = 0; cols2 < colsNumArr2; cols2++)
                {
                    resArr[rows1, cols2] = 0;

                    for (int cols1 = 0; cols1 < colsNumArr1; cols1++)
                        resArr[rows1, cols2] += arr1[rows1, cols1] * arr2[cols1, cols2];
                }

            return resArr;
        }

        public static int[,] Transpose(int[,] arr)
        {
            int rows = arr.GetLength(0);
            int cols = arr.GetLength(1);

            int[,] newArr = new int[cols, rows];

            for (int y = 0; y < rows; y++)
                for (int x = 0; x < cols; x++)
                    newArr[y, x] = arr[x, y];

            return newArr;
        }
    }
}
