using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListUsingGenerics
{
    internal class LinkedList<T>
    {
        public Node<T> head;
        int size;

        //add element to last
        public void AddLast(T data)
        {   
            Node<T> newNode = new Node<T>(data);
            size++;
            
            if(head == null)
            {
                head = newNode;
                Console.WriteLine("{0} is added to the LinkedList", data);
            }
            else
            {   
                Node<T> currentNode = this.head; //created current and assigned head node to traverse
                while(currentNode.next != null)
                {
                    currentNode = currentNode.next;
                }
                currentNode.next = newNode;
                Console.WriteLine("{0} is added to the LinkedList", data);
            }
               
        }

        //display data
        public void Display()
        {
            Node<T> currentNode = this.head;
            if(currentNode == null)
            {
                Console.WriteLine("Linked List is Empty!!!");
                return;
            }
            else
            {
                Console.WriteLine("Elements present in Linked List : ");
                while(currentNode.next != null)
                {
                    Console.Write(currentNode.data + " ");
                    currentNode = currentNode.next;
                }
                Console.WriteLine(currentNode.data);
            }
                    
        }

        //add element at first place
        public void AddFirst(T data)
        {
            Node<T> newNode = new Node<T>(data);
            size++;

            newNode.next = head; 
            head = newNode; 
            Console.WriteLine("{0} is added as a first element", data);
        }

        //append element
        public void Append(T data)
        {
            AddLast(data); //functionality is same as AddLast so calling the AddFirst method here
        }

        //insert in between or at position
        public void InsertElementInBetweenOrAtPosition(int position, T data)
        {
            Node<T> newNode = new Node<T>(data);

            if (position < 1 || position > size + 1)
            {
                Console.WriteLine("Invalid Position");
                return;
            }

            if (position == 1)
            {
                newNode.next = this.head;
                head = newNode;
                size++;
            }
            else
            {
                Node<T> temp = head;
                for (int i = 1; i < position - 1; i++)
                {
                    temp = temp.next;
                }
                newNode.next = temp.next;
                temp.next = newNode;
                size++;

            }
            Console.WriteLine("{0} is inserted at position {1}", data, position);
        }

        //delete first element
        public void DeleteFirst()
        {
            if (head == null)
                Console.WriteLine("LinkedList is Empty!!");
            else
            {
                T elementRemoved = head.data;
                head = head.next;
                size--;
                Console.WriteLine("First node element {0} is deleted from the Linked List", elementRemoved);
            }
        }

        //delete last element      
        public void DeleteLast()
        {
            Node<T> temp = head;
            if (temp == null)
                Console.WriteLine("LinkedList is Empty!!");
            if (temp.next == null)
            {
                T data = temp.data;
                temp = null;
                Console.WriteLine("Node element {0} is deleted ", data);
                size--;
            }
            else
            {
                while (temp.next.next != null) //searching for second last element
                { 
                    temp = temp.next;
                }
                T lastDeleteNode = temp.next.data;
                temp.next = null;
                Console.WriteLine("Last node element {0} is deleted ", lastDeleteNode);
                size--;
            }
        }

    }
}
