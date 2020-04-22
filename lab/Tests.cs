using System.Diagnostics;

namespace lab
{
    public class Tests
    {
        public static readonly int[] TestArrSizes = { 32, 64, 128, 256, 512, 1024 };

        public static double[] TestClassicMethod(int[] testArrSizes)
        {
            double[] resultsInSecs = new double[testArrSizes.Length];

            for (int index = 0; index < testArrSizes.Length; index++)
            {
                int[,] arr1 = Arrays.CreateRandNumsArr(testArrSizes[index], testArrSizes[index]);
                int[,] arr2 = Arrays.CreateRandNumsArr(testArrSizes[index], testArrSizes[index]);

                Stopwatch stopwatchForClassic = new Stopwatch();
                stopwatchForClassic.Start();
                Arrays.MultByClassicMethod(arr1, arr2);
                stopwatchForClassic.Stop();

                resultsInSecs[index] = stopwatchForClassic.Elapsed.TotalSeconds;
            }

            return resultsInSecs;
        }

        public static double[] TestTransposeMethod(int[] testArrSizes)
        {
            double[] resultsInSecs = new double[testArrSizes.Length];

            for (int index = 0; index < testArrSizes.Length; index++)
            {
                int[,] arr1 = Arrays.CreateRandNumsArr(testArrSizes[index], testArrSizes[index]);
                int[,] arr2 = Arrays.Transpose(Arrays.CreateRandNumsArr(testArrSizes[index], testArrSizes[index]));

                Stopwatch stopwatchForClassic = new Stopwatch();
                stopwatchForClassic.Start();
                Arrays.MultByClassicMethod(arr1, arr2);
                stopwatchForClassic.Stop();

                resultsInSecs[index] = stopwatchForClassic.Elapsed.TotalSeconds;
            }

            return resultsInSecs;
        }
    }
}
