namespace DataStructures
{
    class Node
    {
        private Node _next = null;
        private int _data;

        public Node(int number)
        {
            _data = number;
        }

        public void AppendToTail(int number)
        {
            var end = new Node(number);
            var node = this;

            while (node._next != null)
            {
                node = node._next;
            }

            node._next = end;
        }

        public Node DeleteNode(Node headNode, int number)
        {
            var node = headNode;

            if (node._data == number)
            {
                return headNode._next;
            }

            while (node._next != null)
            {
                if (node._next._data == number)
                {
                    node._next = node._next._next;
                    return headNode;
                }
                node = node._next;
            }

            return headNode;
        }
    }
}