using System;

namespace EX02MaximalSum
{
    class SumCollector
    {
        static void Main()
        {
            // Parsing from string input with spaces to an int array
            string[] NM = Console.ReadLine().Split(' ');
            int N = int.Parse(NM[0]);
            int M = int.Parse(NM[1]);
            int[,] matrix = new int[N, M];

            for (int row = 0; row < N; row++)
            {
                string matrixInput = Console.ReadLine();
                string[] arrLine = new string[M];
                arrLine = matrixInput.Split(' ');

                for (int col = 0; col < M; col++)
                {
                    matrix[row, col] = int.Parse(arrLine[col]);
                }
            }

            int maxSum = int.MinValue;
            int currentSum = int.MinValue;

            for (int row = 0; row < N - 2; row++)
            {
                for (int col = 0; col < M - 2; col++)
                {
                    currentSum = matrix[row, col] + matrix[row + 1, col] + matrix[row + 2, col] + matrix[row, col + 1] + matrix[row, col + 2] + matrix[row + 1, col + 1] + matrix[row + 1, col + 2] + matrix[row + 2, col + 1] + matrix[row + 2, col + 2];
                    if (currentSum > maxSum)
                    {
                        maxSum = currentSum;
                    }
                }
            }
            Console.WriteLine(maxSum);
        }
    }
}
