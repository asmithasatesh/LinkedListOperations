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
            obj.InsertAtFirst(30);
            obj.InsertAtFirst(56);
            obj.Display();
            //Usecase 8
            int value=obj.InsertInBetween(30, 40);
            Console.WriteLine("Inserted Value {0} to linked List", value);

        }
    }
}
