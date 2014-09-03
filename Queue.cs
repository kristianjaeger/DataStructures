using System;

namespace DataStructures
{
    class Queue
    {
        private Node _first, _last;

        public void Enqueue(Object item)
        {
            if (_first == null)
            {
                _last = new Node((int)item);
                _first = _last;
            }
            else
            {
                _last.Next = new Node((int)item);
                _last = _last.Next;
            }
        }

        public Object Dequeue()
        {
            if (_first != null)
            {
                Object item = _first.Data;
                _first = _first.Next;

                if (_first == null)
                {
                    // Queue is empty
                    _last = null;
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