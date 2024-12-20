namespace ClassLibrary1
{
    public class Class1
    {

        public static int[,] CreateMatrix(int n, int m)
        {
            Random rand = new Random();
            int[,] matrix = new int[n, m];

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {

                    matrix[i, j] = rand.Next(1, 100);
                }
            }

            return matrix;
        }
        public static void PrintMatrix(double[,] matrix)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write($"{matrix[i, j]}"); 
                }
                Console.WriteLine();
            }
        }
        public static (int[], int) MaxSumRow(int[,] matrix)
        {
            int maxSum = int.MinValue;
            int[] maxRow = null;

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                int currentSum = 0;

                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    currentSum += matrix[i, j];
                }

                if (currentSum > maxSum)
                {
                    maxSum = currentSum;
                    maxRow = new int[matrix.GetLength(1)];

                    for (int k = 0; k < matrix.GetLength(1); k++)
                    {
                        maxRow[k] = matrix[i, k];
                    }
                }
            }

            return (maxRow, maxSum);
        }

        public static void PrintMatrix(int[,] matrix)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write($"{matrix[i, j]} "); 
                }
                Console.WriteLine();
            }
        }
    }
}

