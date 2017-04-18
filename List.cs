using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleLibrary1
{
    internal class Node
    {
        public int Value { get; set; }
        public Node Next { get; set; }

    }

    internal class LinkList
    {
        public void Push(int value)
        {
            Size++;
            var node = new Node() { Value = value };
            if (Head == null)
            {
                Head = node;
            }
            else
            {
                Current.Next = node;
            }
            Current = node;

        }


        public void ListNodes()
        {
            Node tempNode = Head;

            while (tempNode != null)
            {
                Console.WriteLine(tempNode.Value);
                tempNode = tempNode.Next;
            }
        }

        public int this[int position]
        {
            get
            {
                Node tempNode = Head;
                for (int i = 0; i < position; ++i)
                    tempNode = tempNode.Next;
                return tempNode.Value;
            }
        }
        private Node Head { get; set; }
        private Node Tails { get; set; }
        private Node Current { get; set; }
        private int Size { get; set; }
    }
    

}
