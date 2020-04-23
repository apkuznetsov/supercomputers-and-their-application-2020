using lab.Tests;
using System;

namespace lab
{
    public class Program
    {
        static void Main(string[] args)
        {
            TestingClassicMethod();
            TestingTransposeMethod();
            //TestingBlockMethod();

            Console.ReadKey();
        }

        private static void TestingClassicMethod()
        {
            Console.WriteLine("КЛАССИЧЕСКОЕ ПЕРЕМНОЖЕНИЕ:\n");

            double[] resultsInSecs = Tests.Tests.TestClassicMethod(Tests.Tests.TestArrSizes);
            for (int index = 0; index < Tests.Tests.TestArrSizes.Length; index++)
                Console.WriteLine("измерение " + index + "\n" +
                    "размер матрицы = " + Tests.Tests.TestArrSizes[index] + "\n" +
                    "длительность расчёта = " + resultsInSecs[index] + " сек.\n");
        }

        private static void TestingTransposeMethod()
        {
            Console.WriteLine("КЛАССИЧЕСКОЕ ПЕРЕМНОЖЕНИЕ С ТРАНСПОНИРОВАНИЕМ:\n");

            double[] resultsInSecs = Tests.Tests.TestTransposeMethod(Tests.Tests.TestArrSizes);
            for (int index = 0; index < Tests.Tests.TestArrSizes.Length; index++)
                Console.WriteLine("измерение " + index + "\n" +
                    "размер матрицы = " + Tests.Tests.TestArrSizes[index] + "\n" +
                    "длительность расчёта = " + resultsInSecs[index] + " сек.\n");
        }

        private static void TestingIntBlockMethod()
        {
            const int blockSize = 1024;

            Console.WriteLine("INTEGER -- БЛОЧНОЕ ПЕРЕМНОЖЕНИЕ ДЛЯ БЛОКА РАЗМЕРОМ " + blockSize + ":\n");

            double[] resultsInSecs = BlockTests.TestIntBlockMethod(blockSize, BlockTests.TestArrSizes);
            for (int index = 0; index < BlockTests.TestArrSizes.Length; index++)
                Console.WriteLine("измерение " + index + "\n" +
                    "размер матрицы = " + BlockTests.TestArrSizes[index] + "\n" +
                    "длительность расчёта = " + resultsInSecs[index] + " сек.\n");
        }
    }
}
