using System;
using System.Linq;
using System.Collections.Generic;

namespace _06.Supermarket
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            Queue<string> clients = new Queue<string>();
            int counter = 0;

            while (input != "End")
            {
                if (input == "Paid")
                {
                    for (int i = 0; i < counter; i++)
                    {
                        Console.WriteLine(clients.Dequeue()); ;
                    }
                    counter = 0;
                }
                else
                {
                    clients.Enqueue(input);
                    counter++;
                }

                input = Console.ReadLine();
            }

            Console.WriteLine($"{clients.Count} people remaining.");
        }
    }
}
