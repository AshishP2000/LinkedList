using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    public class LinkedList
    {
        public Node Head;

        public void AddLast(int data)
        {
            Node node = new Node(data);
            if (this.Head == null)
                this.Head = node;
            else
            {
                Node temp = Head;
                while (temp.Next != null)
                {
                    temp = temp.Next;
                }
                temp.Next = node;
            }

            //Console.WriteLine("{0} is inserted in Linked List",node.data);
        }
        public void AddFirst(int data)
        {
            Node newnode = new Node(data);
            newnode.Next = Head;
            Head = newnode;
        }

        public void Append(int data)
        {
            AddLast(data);
        }

        public void Display()
        {
            Console.WriteLine("Here's Elements in Linked List");
            Node temp = this.Head;
            if (temp == null)
                Console.WriteLine("list is Empty");
            while (temp != null)
            {
                Console.WriteLine(temp.data + " ");
                temp= temp.Next;
            }
        }
    }
}
