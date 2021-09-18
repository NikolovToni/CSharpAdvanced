using System;
using System.Linq;
using System.Collections.Generic;

namespace _03.SimpleCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Reverse()
                .ToArray();

            Stack<string> equation = new Stack<string>(input);

            while (equation.Count > 1)
            {
                int a = int.Parse(equation.Pop());
                string @operator = equation.Pop();
                int b = int.Parse(equation.Pop());

                if (@operator == "+")
                {
                    equation.Push((a + b).ToString());
                }
                else
                {
                    equation.Push((a - b).ToString());
                }
            }

            Console.WriteLine(equation.Pop());
        }
    }
}
