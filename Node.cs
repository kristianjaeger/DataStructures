namespace DataStructures
{
    class Node
    {
        public Node Next = null;
        public int Data;

        public Node(int number)
        {
            Data = number;
        }

        public void AppendToTail(int number)
        {
            var end = new Node(number);
            var node = this;

            while (node.Next != null)
            {
                node = node.Next;
            }

            node.Next = end;
        }

        public Node DeleteNode(Node headNode, int number)
        {
            var node = headNode;

            if (node.Data == number)
            {
                return headNode.Next;
            }

            while (node.Next != null)
            {
                if (node.Next.Data == number)
                {
                    node.Next = node.Next.Next;
                    return headNode;
                }
                node = node.Next;
            }

            return headNode;
        }

        /* 
         * Example Main method code:
         *  Console.WriteLine(DateTime.Now.Millisecond);

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
         */
    }
}