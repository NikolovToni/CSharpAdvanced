using System;
using System.Linq;
using System.Collections.Generic;

namespace _02.StackSum
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(' ');

            Stack<int> numbers = new Stack<int>();
            foreach (var item in input)
            {
                numbers.Push(int.Parse(item));
            }

            string command = Console.ReadLine().ToLower();
            while (command != "end")
            {
                string[] parts = command.Split(' ');
                if (parts[0] == "add")
                {
                    numbers.Push(int.Parse(parts[1]));
                    numbers.Push(int.Parse(parts[2]));
                }
                else if (parts[0] == "remove")
                {
                    if (int.Parse(parts[1]) < numbers.Count)
                    {
                        for (int i = 0; i < int.Parse(parts[1]); i++)
                        {
                            numbers.Pop();
                        }
                    }
                }
                command = Console.ReadLine().ToLower();
            }

            int sum = numbers.Sum();
            Console.WriteLine($"Sum: {sum}");
        }
    }
}
