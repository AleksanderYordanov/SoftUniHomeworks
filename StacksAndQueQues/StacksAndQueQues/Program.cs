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
            
        }
    }
}
