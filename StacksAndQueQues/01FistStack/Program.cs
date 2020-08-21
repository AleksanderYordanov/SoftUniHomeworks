﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace _01FistStack
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();

            var stack = new Stack<char>();
            foreach (var symbol in input)
            {
                stack.Push(symbol);
            }


            while (stack.Any())
            {
                Console.Write(stack.Pop());
            }
        }

       
    }
}
