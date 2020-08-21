using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace PrintEvenNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            var nums = new Queue<int>(numbers);
            var count = 0;
            while (!nums.All(x => x % 2 == 0))
            {
                if (nums.Peek() % 2 == 0)
                {
                    Console.Write($"{nums.Dequeue()}, ");
                    continue;
                }
                else
                {
                    nums.Dequeue();
                }
            }
            Console.WriteLine(string.Join(", ", nums));
        }
    }
}
