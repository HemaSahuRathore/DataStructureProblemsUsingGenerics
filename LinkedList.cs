using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListUsingGenerics
{
    internal class LinkedList<T> where T : IComparable
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

        //search element
        public void SearchElement(T searchElement)
        {
            int node = 1; //created node to display node position
            int elementfound = 0;
            if (head.data == null)
            {
                Console.WriteLine("Linked list is empty!!");
                return;
            }
            else
            {
                Node<T> temp = head;
                while (temp != null)
                {
                    if (temp.data.CompareTo(searchElement) == 0)
                    {
                        Console.WriteLine("Element {0} found at Node {1}", searchElement, node);
                        elementfound = 1;
                        return;
                    }
                    temp = temp.next;
                    node++;
                }
                if (elementfound == 0)
                    Console.WriteLine("Element {0} is not present in the Linked List", searchElement);
            }

        }

        //insert after element
        public void InsertDataAfterELement(T data, T element)
        {
            Node<T> newElement = new Node<T>(data);

            if (head == null) 
            {
                Console.WriteLine("Linked list is empty!!");
                return;
            }
            else
            {
                Node<T> temp = head;
                while (temp != null)
                {
                    if (temp.data.CompareTo(element) == 0)
                    {
                        Node<T> tempAdd = temp.next; //storing temp address to add it to newElement.next

                        temp.next = newElement;
                        newElement.next = tempAdd;
                        Console.WriteLine("{0} is inserted after {1}", data, element);
                        size++;
                        return;
                    }
                    temp = temp.next;
                }
             }
            Console.WriteLine("Element {0} is not present in the Linked List", element);
        }

        //Search for Node element and Delete
        public void SearchElementNDelete(T searchElement)
        {
            int node = 1;
            
            if (head == null)
            {
                Console.WriteLine("Linked list is empty!!");
                return;
            }
                
            else if (head.data.CompareTo(searchElement) == 0) //if element is found at head position
            {
                head = head.next;
                Console.WriteLine("Element {0} found at Node {1}", searchElement, node);
                Console.WriteLine("Element {0} deleted", searchElement);
                return;
            }

            Node<T> currentNode = head;
            Node<T> previousNode = head;
            while (currentNode != null)
            {
                if (currentNode.data.CompareTo(searchElement) == 0)
                {
                    Console.WriteLine("Element {0} found at Node {1}", searchElement, node);

                    for (int i = 1; i < node - 1; i++)
                    {
                        previousNode = previousNode.next;
                    }
                    previousNode.next = currentNode.next;
                    Console.WriteLine("Element {0} deleted", searchElement);
                    currentNode.next = null;
                    return;
                }
                currentNode = currentNode.next;
                node++;
            }
            Console.WriteLine("Element {0} is not present in the Linked List", searchElement);
        }

        //size
        public void Size()
        {
            int sizeOfLL = 1;

            Node<T> temp = this.head;
            if (temp == null)
            {
                Console.WriteLine("Linked List is empty!!");
                return; //control returned to main method from where it came
            }
            else
            {
                while (temp.next != null)
                {
                    temp = temp.next;
                    sizeOfLL++;
                }
                Console.WriteLine("Size of the Linked List is " + sizeOfLL);
            }

        }

    }
}
