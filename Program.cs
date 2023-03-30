using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListProgram
{
    public class Program
    {
        static void Main(string[] args)
        {
            LinkedList<int> list = new LinkedList<int>();
            list.Append(56);
            list.Append(30);
            list.Append(70);

            list.Display();

            int valueToSearch = 30;
            LinkedList<int>.Node<int> nodeFound = list.Search(valueToSearch);

            if (nodeFound != null)
            {
                Console.WriteLine($"Node with value {valueToSearch} found!");
            }
            else
            {
                Console.WriteLine($"Node with value {valueToSearch} not found!");
            }
        }
    }
}
