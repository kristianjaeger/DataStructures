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
    }
}
