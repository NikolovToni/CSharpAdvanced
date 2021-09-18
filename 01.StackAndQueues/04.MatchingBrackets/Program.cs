using System;
using System.Collections.Generic;

namespace _04.MatchingBrackets
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            Stack<int> indices = new Stack<int>();
            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] == '(')
                {
                    indices.Push(i);
                }
                else if (input[i] == ')')
                {
                    int openBracketIndex = indices.Pop();
                    int closedBrackerIndex = i;
                    Console.WriteLine(input.Substring(openBracketIndex, closedBrackerIndex - openBracketIndex + 1));
                }
            }

        }
    }
}
