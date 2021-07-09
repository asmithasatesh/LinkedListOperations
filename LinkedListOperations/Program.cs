﻿using System;

namespace LinkedListOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("*****Insertion at First*****");

            OperationsOnLinkedList obj = new OperationsOnLinkedList();
            //Insertion Operation
            obj.InsertAtFirst(70);
            obj.InsertAtFirst(56);

            //Display Operation
            obj.Display();
            obj.InsertInBetween(2, 30);
            obj.Display();

            //Pop Last Node
            obj.pop();
            //Search value 30
            int searchValue = obj.SearchData(30);
            Console.WriteLine(searchValue);
        }
    }
}
