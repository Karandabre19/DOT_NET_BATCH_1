using System;

namespace NodeDataStructure
{
    internal class List
    {
        private Node headNode;

        public List()
        {
            headNode = new Node();
            headNode.Next = headNode;
            headNode.Prev = headNode;
        }

        public void InsertAtBegin(int Data)
        {
            Node newNode = new Node(Data);
            GenericInsert(headNode, newNode, headNode.Next);
        }

        public void InsertAtEnd(int Data)
        {
            Node newNode = new Node(Data);
            GenericInsert(headNode.Prev, newNode, headNode);
        }

        public void InsertAtPos(int Data, int pos)
        {
            Node newNode = new Node(Data);
            int Counter = 1;
            Node tempNode;

            tempNode = headNode.Next;
            while (tempNode != headNode && Counter < pos)
            {
                Counter += 1;
                tempNode = tempNode.Next;
            }
            GenericInsert(tempNode.Prev, newNode, tempNode);
        }

        public void InsertAfter(int Targeteddata, int insertingData)
        {
            if (headNode == null)
            {
                Console.WriteLine("List is Empty Cannot insert after the {0}", Targeteddata);
                return;
            }
            Node tempNode = headNode.Next;
            int count = 1;

            while (tempNode != null && tempNode.Data != Targeteddata)
            {
                tempNode = tempNode.Next;
                count++;
            }
            if (tempNode != null)
            {
                Node newNode = new Node(insertingData);

                GenericInsert(tempNode, newNode, tempNode.Next);
                Console.WriteLine("inserted {0} after {1}", insertingData, Targeteddata);
            }
            else
            {
                Console.WriteLine("Inserted data {0} is not found", Targeteddata);
            }

        }

        public int RemoveAtBegin()
        {
            int removedData;

            removedData = headNode.Next.Data;
            GenericDelete(headNode.Next);
            return removedData;
        }

        private static void GenericInsert(Node start, Node mid, Node end)
        {
            start.Next = mid;
            mid.Prev = start;
            mid.Next = end;
            end.Prev = mid;
        }

        private static void GenericDelete(Node deleteNode)
        {
            deleteNode.Prev.Next = deleteNode.Next;
            deleteNode.Next.Prev = deleteNode.Prev;
        }

        public int FindLenght()
        {
            int count = 0;
            Node tempNode = headNode.Next;

            while (tempNode != headNode)
            {
                count++;
                tempNode = tempNode.Next;
            }
            return count;
        }
        public void RemoveAtEnd()
        {
            int removedData = headNode.Prev.Data;
            GenericDelete(headNode.Prev);
            Console.WriteLine("The End data {0} has been Removed", +removedData);
        }
        public void FindData(int findData)
        {
            int count = 1;
            Node tempNode = headNode.Next;
            while (tempNode != headNode && tempNode.Data != findData)
            {
                count++;
                tempNode = tempNode.Next;
            }
            if (tempNode != headNode)
            {
                Console.WriteLine(" the data {0} found at the position {1}", findData, count);
            }
            else
            {
                Console.WriteLine(" the data {0} has not been found in the List", findData);
            }
        }
        public void printList()
        {
            Node tempNode = headNode.Next;
            while (tempNode != headNode)
            {
                Console.Write("[ " + tempNode.Data + " ]");
                tempNode = tempNode.Next;
            }
            Console.WriteLine("End");
        }
    }
}