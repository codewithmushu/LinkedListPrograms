using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListProgram
{
    public class LinkedList<T>
    {
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

        public T PopLast()
        {
            if (head == null)
            {
                throw new InvalidOperationException("Cannot pop from an empty list.");
            }

            if (head.Next == null)
            {
                T poppeddata = head.Data;
                head = null;
                return poppeddata;
            }

            Node<T> currentNode = head;
            while (currentNode.Next.Next != null)
            {
                currentNode = currentNode.Next;
            }

            T poppedData = currentNode.Next.Data;
            currentNode.Next = null;
            return poppedData;
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
