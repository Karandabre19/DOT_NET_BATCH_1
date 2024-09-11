using System;

namespace NodeDataStructure
{
    internal class Node
    {
        private int data;
        private Node next;
        private Node prev;

        public Node()
        {
            data = 0;
            next = null;
            prev = null;
        }

        public Node(int _data)
        {
            data = _data;
            next = null;
            prev = null;
        }

        internal int Data
        {
            get => data;
            set => data = value;
        }

        internal Node Prev
        {
            get => prev;
            set => prev = value;
        }

        internal Node Next
        {
            get => next;
            set => next = value;
        }
    }
}