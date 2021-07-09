using System;
using System.Collections.Generic;
using System.Text;

namespace LinkedListOperations
{
    public class OperationsOnLinkedList
    {
        public Node head;
        //Insert data to First
        public void Add(int data)
        {
            Node newNode = new Node(data);
            Sorted(newNode);
            Display();

        }
        public void Sorted(Node newNode)
        {
            Node temp = head;
            if(temp==null || head.data >= newNode.data)
            {
                newNode.next = head;
                head = newNode;
            }
            else if (head.next==null && head.data < newNode.data)
            {
                head.next = newNode;
            }
            else
            {
                if(temp.next.data> newNode.data)
                {
                    newNode.next = temp.next;
                    temp.next = newNode;
                }
                else
                {
                    while(temp.next!=null && temp.next.data< newNode.data)
                    {
                        temp = temp.next;
                    }
                    newNode.next = temp.next;
                    temp.next = newNode;

                }
            }
        }

        public void Display()
        {
            int count = 1;
            Node temp = this.head;
            Console.WriteLine("\n*****DISPLAYING SORTED LINKED LIST VALUES*****");
            while (temp != null)
            {
                Console.WriteLine("Element {0} of Linked List: {1} ",count,temp.data);
                temp = temp.next;
                count++;
            }
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
