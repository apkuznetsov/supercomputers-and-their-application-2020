using System;

namespace lab
{
    public class Program
    {
        static void Main(string[] args)
        {
            TestingClassicMethod();
            TestingTransposeMethod();
        }
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

        }
    }
}
