using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    public class Program
    {
        static void Main(string[] args)
        {
            //UC-7 Ability to search Linked list to find node with value 30
            Console.WriteLine("Welcome to Linked List Program");

            LinkedList list = new LinkedList();
            //list.AddLast(56);
            //list.AddLast(30);
            //list.AddLast(70);

            //list.AddFirst(70);
            //list.AddFirst(30);
            //list.AddFirst(56);

            list.Append(56);
            //list.Append(30);
            list.Append(70);

            list.InsertatPosition(2,30);


            //list.RemoveLast();

            list.Search(30);

            list.Display();
            Console.ReadLine();
        }
    }
}
