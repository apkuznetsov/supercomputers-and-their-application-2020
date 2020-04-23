using System;

namespace lab
{
    public class Program
    {
        static void Main(string[] args)
        {
            //TestingClassicMethod();
            //TestingTransposeMethod();
            TestingBlockMethod();

            Console.ReadKey();
        }

        private static void TestingClassicMethod()
        {
            Console.WriteLine("КЛАССИЧЕСКОЕ ПЕРЕМНОЖЕНИЕ:\n");

            double[] resultsInSecs = Tests.TestClassicMethod(Tests.TestArrSizes);
            for (int index = 0; index < Tests.TestArrSizes.Length; index++)
                Console.WriteLine("измерение " + index + "\n" +
                    "размер матрицы = " + Tests.TestArrSizes[index] + "\n" +
                    "длительность расчёта = " + resultsInSecs[index] + " сек.\n");
        }

        private static void TestingTransposeMethod()
        {
            Console.WriteLine("КЛАССИЧЕСКОЕ ПЕРЕМНОЖЕНИЕ С ТРАНСПОНИРОВАНИЕМ:\n");

            double[] resultsInSecs = Tests.TestTransposeMethod(Tests.TestArrSizes);
            for (int index = 0; index < Tests.TestArrSizes.Length; index++)
                Console.WriteLine("измерение " + index + "\n" +
                    "размер матрицы = " + Tests.TestArrSizes[index] + "\n" +
                    "длительность расчёта = " + resultsInSecs[index] + " сек.\n");
        }

        private static void TestingBlockMethod()
        {
            const int blockSize = 1024;

            Console.WriteLine("БЛОЧНОЕ ПЕРЕМНОЖЕНИЕ ДЛЯ БЛОКА РАЗМЕРОМ " + blockSize + ":\n");

            double[] resultsInSecs = Tests.TestBlockMethod(blockSize, Tests.TestBlockSizes);
            for (int index = 0; index < Tests.TestArrSizes.Length; index++)
                Console.WriteLine("измерение " + index + "\n" +
                    "размер матрицы = " + Tests.TestArrSizes[index] + "\n" +
                    "длительность расчёта = " + resultsInSecs[index] + " сек.\n");
        }
    }
}
