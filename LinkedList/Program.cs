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
            Console.WriteLine("Welcome to Linked List Program");

            LinkedList list = new LinkedList();
            list.AddLast(56);
            list.AddLast(30);
            list.AddLast(70);

            Console.ReadLine();
        }
    }
}
