using System;
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
            list.PopLast();
            list.Display();
        }
    }
}
