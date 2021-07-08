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
            obj.InsertAtFirst(56);



            //Display Operation
            Console.WriteLine("*****Insertion in Between two nodes*****");
            obj.Display();
            obj.InsertInBetween(2, 30);
            obj.Display();


        }
    }
}
