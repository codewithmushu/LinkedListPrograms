using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListProgram
{
    public class LinkedList<T>
    {
        public class Node<U>
        {
            public U Data { get; set; }
            public Node<U> Next { get; set; }

            public Node(U data)
            {
                Data = data;
                Next = null;
            }
        }

        private Node<T> head;

        public void Append(T data)
        {
            Node<T> newNode = new Node<T>(data);

            if (head == null)
            {
                head = newNode;
            }
            else
            {
                Node<T> currentNode = head;
                while (currentNode.Next != null)
                {
                    currentNode = currentNode.Next;
                }
                currentNode.Next = newNode;
            }
        }

        public Node<T> Search(T value)
        {
            if (head == null)
            {
                return null;
            }

            Node<T> currentNode = head;

            while (currentNode != null)
            {
                if (currentNode.Data.Equals(value))
                {
                    return currentNode;
                }
                currentNode = currentNode.Next;
            }

            return null;
        }

        public void Display()
        {
            Node<T> currentNode = head;

            while (currentNode != null)
            {
                Console.Write(currentNode.Data + " ");
                currentNode = currentNode.Next;
            }
            Console.WriteLine();
        }
    }






}
