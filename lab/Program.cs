using System;

namespace lab
{
    public class Program
    {
        static void Main(string[] args)
        {
            TestingClassicMethod();
        }
        }

        private static void TestingClassicMethod()
        {
            Console.WriteLine("КЛАССИЧЕСКОЕ ПЕРЕМНОЖЕНИЕ:");

            double[] resultsInSecs = Tests.TestClassicMethod(Tests.TestArrSizes);
            for (int index = 0; index < Tests.TestArrSizes.Length; index++)
                Console.WriteLine("измерение " + index + " ... " + 
                    "размер матрицы = " + Tests.TestArrSizes[index] + " ... " + 
                    "длительность расчёта (сек.) = " + resultsInSecs[index]);

        }
        }
    }
}
