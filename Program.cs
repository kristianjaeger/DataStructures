using System;

namespace DataStructures
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(DateTime.Now.Millisecond);

            var headNode = new Node(0);
            
            for (var loopCounter = 1; loopCounter <= 100; loopCounter++)
            {
                headNode.AppendToTail(loopCounter);
            }

            Console.WriteLine(DateTime.Now.Millisecond);

            Console.WriteLine(DateTime.Now.Millisecond);

            headNode.DeleteNode(headNode, 100);

            Console.WriteLine(DateTime.Now.Millisecond);

            var dummy = Console.ReadLine();
        }
    }
}