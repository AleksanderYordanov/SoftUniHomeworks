using System;
using System.Collections.Generic;

namespace Supermarket
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            var clients = new Queue<string>();
            while (input != "End")
            {
                if (input == "Paid")
                {
                    for (int i = clients.Count - 1; i >= 0; i--)
                    {
                        Console.WriteLine(clients.Dequeue());
                    }
                }
                else
                {
                    clients.Enqueue(input);
                }

                input = Console.ReadLine();
            }
            
            Console.WriteLine($"{clients.Count} people remaining.");
        }
    }
}
