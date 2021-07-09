using System;

namespace LinkedListOperations
{
    class Program
    {
        static void Main(string[] args)
        {


            OperationsOnLinkedList obj = new OperationsOnLinkedList();
            //Insertion Operation
            Console.WriteLine("*****Insertion at First*****");
            obj.InsertAtFirst(70);
            obj.InsertAtFirst(40);
            obj.InsertAtFirst(30);
            obj.InsertAtFirst(56);
            obj.Display();


            //Usecase 9- Seach and delete an element
            int linkedListSize = obj.DeleteInBetween(40);
            Console.WriteLine("\nTotal size of Linked list is: {0}", linkedListSize);


        }
    }
}
