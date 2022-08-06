﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListUsingGenerics
{
    internal class LinkedList<T>
    {
        public Node<T> head;

        //add element to last
        public void AddLast(T data)
        {   
            Node<T> newNode = new Node<T>(data);
            
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

            newNode.next = head; 
            head = newNode; 
            Console.WriteLine("{0} is added as a first element", data);
        }

        //append element
        public void Append(T data)
        {
            AddLast(data); //functionality is same as AddLast so calling the AddFirst method here
        }

    }
}
