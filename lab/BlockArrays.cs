namespace lab
{
    public class BlockArrays
    {
        private static int[,] MultByClassicMethod(int[,] a, int[,] b, int blockSize, int startRowA, int startColA, int startRowB, int startColB)
        {
            int[,] c = new int[blockSize, blockSize];

            for (int y = 0; y < blockSize; y++)
                for (int x = 0; x < blockSize; x++)
                {
                    c[y, x] = 0;

                    for (int k = 0; k < blockSize; k++)
                        c[y, x] += a[y + startRowA, k + startColA] * b[k + startRowB, x + startColB];
                }

            return c;
        }

        private static int[,] SumSquareArrs(int[,] a, int[,] b)
        {
            int blockSize = a.GetLength(0);
            int[,] c = new int[blockSize, blockSize];
        
            for (int y = 0; y < blockSize; y++)
                for (int x = 0; x < blockSize; x++)
                    c[y, x] = a[y, x] + b[y, x];

            return c;
    }
}
