using System;
using System.Collections.Generic;

namespace MatchingBracets
{
    class Program
    {
        static void Main(string[] args)
        {
            var text = Console.ReadLine();
            var stack = new Stack<int>();

            for (int i = 0; i < text.Length; i++)
            {
                var symbol = text[i];
                if (symbol == '(')
                {
                    stack.Push(i);
                }
                else if (symbol == ')')
                {
                    int indexOfOpeningBreacket = stack.Pop();

                    var result = text.Substring(
                        indexOfOpeningBreacket,
                        i - indexOfOpeningBreacket + 1);
                    Console.WriteLine(result);
                }
            }
        }
    }
}
