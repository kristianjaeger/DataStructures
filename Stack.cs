using System;

namespace DataStructures
{
    class Stack
    {
        private Node top;

        public Object Pop()
        {
            if (top != null)
            {
                Object item = top.Data;
                top = top.Next;

                return item;
            }

            return null;
        }

        public void Push(Object item)
        {
            var node = new Node((int)item);
            
            node.Next = top;
            top = node;
        }

        public Object Peek()
        {
            return top.Data;
        }

        /* Example code for Main method:
         * 
         *  Console.WriteLine(DateTime.Now.Millisecond);
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
         * 
         */
    }
}
