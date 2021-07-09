using System;
using System.Collections.Generic;
using System.Text;

namespace LinkedListOperations
{
    public class OperationsOnLinkedList
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
        //Insert a node between two nodes
        public int InsertInBetween(int searchdata,int data)
        {
            Node temp = SearchData(searchdata);
            Node newNode = new Node(data);
            newNode.next = temp.next;
            temp.next = newNode;
            Display();
            return (newNode.data);

        }
        //Reuse UC1 method which returns Last node
        public Node GetLastNode()
        {
            Node temp = this.head;
            while (temp.next.next != null)
            {
                temp = temp.next;
            }
            return temp;
        }
        //Pop first Node
        public void pop()
        {
            Console.WriteLine("\n*****Delete Last node*****");
            Node temp = GetLastNode();
            Console.WriteLine("Poped element is: {0}",temp.next.data);
            temp.next=null;
            Display();
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

        //Search a particular data
        public Node SearchData(int value)
        {
            Node temp = head;
            int count = 1;
            while(temp!=null)
            {
                if(temp.data== value)
                {
                    Console.WriteLine("\nFound {0} at index {1}", temp.data, count);
                    return temp;
                }
                temp = temp.next;
                count++;
            }
            Console.WriteLine("\nCould not find value in Linked List!");
            return default;
        }
    }
}
