﻿using System;
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
            //UC-8 Ability to insert 40 after 30 sequence 56->30->70 final= 56->30->40->70
            Console.WriteLine("Welcome to Linked List Program");

            LinkedList list = new LinkedList();
            //list.AddLast(56);
            //list.AddLast(30);
            //list.AddLast(70);

            //list.AddFirst(70);
            //list.AddFirst(30);
            //list.AddFirst(56);

            list.AddLast(56);
            list.AddLast(30);
            list.AddLast(70);

            //list.InsertatPosition(3,50);


            //list.RemoveLast();

            list.InsertAfter(40,3);

            list.Display();
            Console.ReadLine();
        }
    }
}
