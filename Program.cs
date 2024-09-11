using System;

namespace NodeDataStructure
{
    class mainClass
    {
        public static void Main(string[] args)
        {
            List list = new List();
            list.InsertAtBegin(10);
            list.InsertAtBegin(20);
            list.InsertAtBegin(30);
            list.InsertAtBegin(40);
            list.InsertAtBegin(50);
            list.InsertAtBegin(60);

            Console.WriteLine("List Length: " + list.FindLenght());  // Prints length
            list.FindData(40);
            Console.WriteLine("the data {0} has been founded at this position")

            list.printList();

            list.InsertAtEnd(100);
            Console.WriteLine("List Length: " + list.FindLenght());  // Prints length

            list.printList();

            list.InsertAtPos(70, 7);

            list.printList();

            list.InsertAfter(50, 60);
            Console.WriteLine("List Length: " + list.FindLenght());  // Prints length

            list.printList();

            list.RemoveAtEnd();
            Console.WriteLine(" List Length after removing the last data : is " + list.FindLenght());
            list.FindData(20);
            list.printList();

        }
    }
}
