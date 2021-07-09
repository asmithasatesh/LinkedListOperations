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
            obj.Add(56);
            obj.Add(30);
            obj.Add(40); 
            obj.Add(70);


            ////Usecase 9- Seach and delete an element
            //int linkedListSize = obj.DeleteInBetween(40);
            //Console.WriteLine("\nTotal size of Linked list is: {0}", linkedListSize);


        }
    }
}
