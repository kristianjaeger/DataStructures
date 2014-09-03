using System;

namespace DataStructures
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(DateTime.Now.Millisecond);
            Console.WriteLine();

            var queue = new Queue();

            for (var loopCounter = 0; loopCounter < 100; loopCounter++)
            {
                queue.Enqueue(loopCounter);
                Console.WriteLine(loopCounter);
            }

            Console.WriteLine();

            for (var loopCounter = 0; loopCounter < 100; loopCounter++)
            {
                Console.WriteLine(queue.Dequeue().ToString());
            }

            Console.WriteLine();
            Console.WriteLine(DateTime.Now.Millisecond);

            var dummy = Console.ReadLine();
        }
    }
}