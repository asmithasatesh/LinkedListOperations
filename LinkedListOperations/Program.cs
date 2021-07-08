using System;

namespace LinkedListOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            //UseCase 1
            OperationsOnLinkedList obj = new OperationsOnLinkedList();
            //Insertion Operation
            obj.InsertAtFirst(70);
            obj.InsertAtFirst(30);
            obj.InsertAtFirst(56);

            //Display Operation
            Console.WriteLine("*****Insertion at First*****");
            obj.Display();


        }
    }
}
