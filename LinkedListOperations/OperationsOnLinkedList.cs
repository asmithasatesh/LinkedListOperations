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
            Console.WriteLine("\n*****DISPLAYING LINKED LIST VALUES*****");
            while (temp != null)
            {
                Console.WriteLine("Element {0} of Linked List: {1} ",count,temp.data);
                temp = temp.next;
                count++;
            }
        }
        public int DeleteInBetween(int data)
        {
            Node temp = SearchData(data);
            Console.WriteLine("\nData {0} has been deleted from linked list",temp.next.data);
            temp.next = temp.next.next;
            int sizeofList = SizeOfList();
            Display();
            return sizeofList;

        }
        public int SizeOfList()
        {
            Node temp = head;
            int count = 0;
            while(temp!=null)
            {
                count++;
                temp = temp.next;
            }
            return count;
        }
        //Search a particular data
        public Node SearchData(int value)
        {
            Node temp = head;
            while(temp!=null)
            {
                if(temp.next.data== value)
                {
                    return temp;
                }
                temp = temp.next;
            }
            Console.WriteLine("\nCould not find value in Linked List!");
            return default;
        }
    }
}
