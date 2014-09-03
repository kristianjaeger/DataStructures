using System;

namespace DataStructures
{
    class Queue
    {
        private Node first, last;

        public void Enqueue(Object item)
        {
            if (first == null)
            {
                last = new Node((int)item);
                first = last;
            }
            else
            {
                last.Next = new Node((int)item);
                last = last.Next;
            }
        }

        public Object Dequeue()
        {
            if (first != null)
            {
                Object item = first.Data;
                first = first.Next;

                if (first == null)
                {
                    // Queue is empty
                    last = null;
                }

                return item;
            }

            return null;
        }

        /* Example code for Main method:
         * 
         *  Console.WriteLine(DateTime.Now.Millisecond);
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
         * 
         */
    }
}