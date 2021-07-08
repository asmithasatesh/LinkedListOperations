using System;
using System.Collections.Generic;
using System.Text;

namespace LinkedListOperations
{
    class OperationsOnLinkedList
    {
        public Node head;
        //Insert data to First
        public void InsertAtFirst(int data)
        {
            Node newNode = new Node(data);
            if(this.head==null)
            {
                head = newNode;
            }
            else
            {
                newNode.next = head;
                head = newNode;
            }

        }

        //Display Linked list Data
        public void Display()
        {
            int count = 1;
            Node temp = this.head;
            while (temp != null)
            {
                Console.WriteLine("Element {0} of Linked List: {1} ",count,temp.data);
                temp = temp.next;
                count++;
            }
        }
    }
}
