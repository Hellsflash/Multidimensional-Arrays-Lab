using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sum_Matrix_Elements
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split(new string[] {", "}, StringSplitOptions.RemoveEmptyEntries);

            var row = int.Parse(input[0]);
            var col = int.Parse(input[1]);

            var matrix = new int[row, col];

            for (int i = 0; i < row; i++)
            {
                var inputRow = Console.ReadLine().Split(new string[] { ", " }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
                for (int j = 0; j < col; j++)
                {
                    matrix[i, j] = inputRow[j];
                }

            }
            int maxSum = 0;
            for (int i = 0; i < row; i++)
            {

                for (int j = 0; j < col; j++)
                {
                    maxSum += matrix[i, j];
                }

            }

            Console.WriteLine(row);
            Console.WriteLine(col);
            Console.WriteLine(maxSum);
        }
    }
}
