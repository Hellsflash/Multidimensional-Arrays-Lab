using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Group_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split(new string[] { ", " }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

            var firstGroup = new List<int>();
            var secondGroup = new List<int>();
            var thirdGroup = new List<int>();


            for (int i = 0; i < input.Length; i++)
            {
                if (Math.Abs(input[i] % 3) == 0)
                {
                    firstGroup.Add(input[i]);
                }
                else if (Math.Abs(input[i] % 3) == 1)
                {
                    secondGroup.Add(input[i]);
                }
                else if (Math.Abs(input[i] % 3) == 2)
                {
                   thirdGroup.Add(input[i]);
                }

            }
            foreach (var num in firstGroup)
            {
                Console.Write($"{num} ");
            }
            Console.WriteLine();
            foreach (var num in secondGroup)
            {
                Console.Write($"{num} ");
            }
            Console.WriteLine();
            foreach (var num in thirdGroup)
            {
                Console.Write($"{num} ");
            }
            Console.WriteLine();
        }
    }
}
