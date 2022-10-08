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
            //UC-2 Ability to create Linked List by adding 30 and 56 to 70
            Console.WriteLine("Welcome to Linked List Program");

            LinkedList list = new LinkedList();
            //list.AddLast(56);
            //list.AddLast(30);
            //list.AddLast(70);

            list.AddFirst(70);
            list.AddFirst(30);
            list.AddFirst(56);
            list.Display();
            Console.ReadLine();
        }
    }
}
