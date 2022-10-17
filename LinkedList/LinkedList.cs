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

        public Node InsertatPosition(int position,int data)
        {
            if (position < 1)
                Console.WriteLine("Invalid Position");
            if (position == 1)
            {
                var newNode = new Node(data);
                newNode.Next = Head;
                Head = newNode;
            }
            else
            {
                while (position-- != 0)
                {
                    if (position == 1)
                    {
                        Node node = new Node(data);
                        node.Next = this.Head.Next;
                        Head.Next = node;
                        break;
                    }
                }
                if (position != 1)
                {
                    Console.WriteLine("Position out of range");
                }
            }
            return Head;

        }

        public void RemoveFirst()
        {
            if (Head == null)
                Console.WriteLine("List is Empty");
            else
                Console.WriteLine("{0} is Removed", Head.data);
            Head = Head.Next;
        }

        public void RemoveLast()
        {
            Node temp = Head;
            if (Head == null)
                Console.WriteLine("List is Empty");
            if (temp.Next == null)
            {
                temp = null;
            }
            else
            {
                while (temp.Next.Next != null)
                {
                    temp = temp.Next;
                    Console.WriteLine("{0} is Removed", temp.Next.data);
                }
                temp.Next = null;

            }
            
        }

        public void Search(int data)
        {
            int count=0,count1=0;
            Node temp = Head;
            bool isFound = false;
            if (temp == null)
            {
                Console.WriteLine("Linked list is empty");
            }
            else
            {

                while (temp != null)
                {
                    if (data == temp.data)
                    {
                        Console.Write("{0} Given Node is present", data);
                        count1 = count + 1;
                        Console.WriteLine(" at the position of {0}", count1);
                        
                        isFound = true;

                        
                    }
                    temp = temp.Next;
                    count++;
                    
                }
                if (!isFound)
                {
                    Console.WriteLine("{0} Node is not Present", data);
                }
            }
        }

        public void InsertAfter(int data,int pos)
        {
            Node current = Head;
            pos= pos - 2;
            for (int i = 0; i < pos; i++)
            {
                current = current.Next;
                if (current == null)
                {
                    Console.WriteLine("Out range");
                    return;
                }
            }
            Node New = new Node(data); 
            New.Next = current.Next;
            current.Next = New;
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
