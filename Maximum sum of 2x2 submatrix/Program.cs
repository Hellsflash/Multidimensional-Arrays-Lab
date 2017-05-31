using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maximum_sum_of_2x2_submatrix
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split(new string[] { ", " }, StringSplitOptions.RemoveEmptyEntries);

            var matrix = new int[int.Parse(input[0])][];

            for (int i = 0; i < matrix.Length; i++)
            {
                matrix[i] = Console.ReadLine().Split(new string[] { ", " }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();


            }

            var maxSqrRow = 0;
            var maxSqrCol = 0;
            var maxSum = int.MinValue;

            for (int i = 0; i < matrix.Length - 1; i++)
            {
                for (int j = 0; j < matrix[i].Length - 1; j++)
                {
                    var currSum = matrix[i][j] + matrix[i][j + 1] + matrix[i + 1][j] + matrix[i + 1][j + 1];

                    if (maxSum < currSum)
                    {
                        maxSum = currSum;

                        maxSqrRow = i;
                        maxSqrCol = j;
                    }
                }
            }

            Console.WriteLine($"{matrix[maxSqrRow][maxSqrCol]} {matrix[maxSqrRow][maxSqrCol + 1]}\n{matrix[maxSqrRow + 1][maxSqrCol]} {matrix[maxSqrRow + 1][maxSqrCol + 1]}");
            Console.WriteLine(maxSum);

        }
    }
}
