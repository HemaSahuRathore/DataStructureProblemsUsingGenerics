using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListUsingGenerics
{
    public class SortedLinkedList<T> where T : IComparable
    {
        public Node<T> head;

        //Add
        public void Add(T data)
        {
            Node<T> newNode = new Node<T>(data);

            if (head == null || head.data.CompareTo(newNode.data) >= 0) //either head is null or null is greater than data
            {
                newNode.next = head;
                head = newNode;
                Console.WriteLine("{0} is added", data);
            }
            else
            {
                Node<T> currentNode = head;
                while (currentNode.next != null && currentNode.next.data.CompareTo(newNode.data) < 0)//false if data is greater than node next to current
                {
                    currentNode = currentNode.next;
                }
                newNode.next = currentNode.next;
                currentNode.next = newNode;
                Console.WriteLine("{0} is added", data);
            }
        }

        //display
        public void Display()
        {
            Console.WriteLine("Nodes Elements in Linked List : ");
            Node<T> currentNode = this.head;
            if (currentNode == null)
            {
                Console.WriteLine("Linked List is empty!!");
                return; //control returned to main method from where it came
            }
            else
            {
                while (currentNode.next != null)
                {
                    Console.Write(currentNode.data + " ");
                    currentNode = currentNode.next;
                }
                Console.WriteLine(currentNode.data);
            }

        }
    }
}
