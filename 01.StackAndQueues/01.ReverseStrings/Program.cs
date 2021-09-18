using System;
using System.Collections.Generic;

namespace _01.ReverseStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Stack<char> reversingInput = new Stack<char>();
            foreach (var ch in input)
            {
                reversingInput.Push(ch);
            }

            foreach (var ch in input)
            {
                Console.Write(reversingInput.Pop());
            }
        }
    }
}
