using System;


namespace DataStructures
{
    class Node
    {
        private Node _next = null;
        private int _data;

        public Node(int d)
        {
            _data = d;
        }

        public void AppendToTail(int d)
        {
            var end = new Node(d);
            var node = this;

            while (node._next != null)
            {
                node = node._next;
            }

            node._next = end;
        }
    }

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

            var dummy = Console.ReadLine();
        }
    }
}