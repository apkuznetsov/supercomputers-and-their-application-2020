using System.Diagnostics;

namespace lab.Tests
{
    public class BlockTests
    {
        public static double[] TestIntBlockMethod(int testArrSize, int[] testBlockSizes)
        {
            double[] resultsInSecs = new double[testBlockSizes.Length];

            for (int index = 0; index < testBlockSizes.Length; index++)
            {
                int[,] arr1 = Arrays.CreateRandNumsIntArr(testArrSize, testArrSize);
                int[,] arr2 = Arrays.CreateRandNumsIntArr(testArrSize, testArrSize);

                Stopwatch stopwatch = new Stopwatch();
                stopwatch.Start();

                IntBlockArrays.MultByBlockMethod(arr1, arr2, testBlockSizes[index], arr1.GetLength(0), 0, 0, 0, 0);

                stopwatch.Stop();

                resultsInSecs[index] = stopwatch.Elapsed.TotalSeconds;
            }

            return resultsInSecs;
        }

        public static double[] TestDoubleBlockMethod(int testArrSize, int[] testBlockSizes)
        {
            double[] resultsInSecs = new double[testBlockSizes.Length];

            for (int index = 0; index < testBlockSizes.Length; index++)
            {
                double[,] arr1 = Arrays.CreateRandNumsIntArr(testArrSize, testArrSize);
                double[,] arr2 = Arrays.CreateRandNumsIntArr(testArrSize, testArrSize);

                Stopwatch stopwatch = new Stopwatch();
                stopwatch.Start();

                DoubleBlockArrays.MultByBlockMethod(arr1, arr2, testBlockSizes[index], arr1.GetLength(0), 0, 0, 0, 0);

                stopwatch.Stop();

                resultsInSecs[index] = stopwatch.Elapsed.TotalSeconds;
            }

            return resultsInSecs;
        }
    }
}
