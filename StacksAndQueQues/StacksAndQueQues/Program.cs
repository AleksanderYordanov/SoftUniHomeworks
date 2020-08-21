using System;
using System.Collections.Generic;
namespace StacksAndQueQues
{
    class Program
    {
        static void Main(string[] args)
        {
            var list = new List<string>();

            list.Add("First");
            list.Add("Second");
            
            var myStack = new Stack<string>();

            myStack.Push("Fist");
            myStack.Push("Leg");
            myStack.Push("Third");

            var PopItOutTheStack = myStack.Pop();
            var withoutDeletingLastInStack = myStack.Peek();
            var contains = myStack.Contains("Five");
            
            var newStack = new Stack<int>();
            newStack.Push(10);
            newStack.Push(20);
            newStack.Push(30);

            foreach (var item in newStack)
            {
                // print reversed!
                Console.WriteLine(item);
            }
            // newStack.TrimExcess(); clear empty entries in memory..(almost never used this days)

            
        }
    }
}
