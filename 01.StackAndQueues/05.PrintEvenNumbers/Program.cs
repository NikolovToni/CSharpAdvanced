using System;
using System.Linq;
using System.Collections.Generic;

namespace _05.PrintEvenNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            Queue<int> queueNumbers = new Queue<int>();

            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] % 2 == 0)
                {
                    queueNumbers.Enqueue(numbers[i]);
                }
            }

            Console.WriteLine(string.Join(", ", queueNumbers));
        }
    }
}
