using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStrUsingGenerics
{
    public class CreateLinkedList
    {
        public int Data;
        public Node Next;

        public CreateLinkedList(int data)
        {
            Data = data;
            Next = null;
        }
    }

    public class CreateLinkedList
    {
        public Node Head;

        public CreateLinkedList()
        {
            Head = null;
        }

        public void Add(int data)
        {
            Node newNode = new Node(data);

            if (Head == null)
            {
                Head = newNode;
            }
            else
            {
                newNode.Next = Head;
                Head = newNode;
            }
        }

        public void Display()
        {
            Node current = Head;
            while (current != null)
            {
                Console.Write(current.Data + " ");
                current = current.Next;
            }
            Console.WriteLine();
        }
    }

    
}
