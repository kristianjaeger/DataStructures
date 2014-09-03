using System;

namespace DataStructures
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(DateTime.Now.Millisecond);
            Console.WriteLine();

            var stack = new Stack();
            for (var loopCounter = 0; loopCounter < 100; loopCounter++)
            {
                stack.Push(loopCounter);
                Console.WriteLine(stack.Peek());
            }

            for (var loopCounter = 0; loopCounter < 100; loopCounter++)
            {
                Console.WriteLine(stack.Pop().ToString());
            }

            Console.WriteLine();
            Console.WriteLine(DateTime.Now.Millisecond);

            var dummy = Console.ReadLine();
        }
    }
}