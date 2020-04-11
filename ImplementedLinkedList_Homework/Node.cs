using System;

namespace ImplementedLinkedList_Homework
{
    public class Node 
    {
        public string Item { get; set; }
        public Node Next { get; set; }
        public Node Previous { get; set; }

        public Node(string item,Node next=null,Node previous=null)
        {
            Item = item;
            Next = next;
            Previous = previous;

        }

        public Node()
        {
        }
    }
}

       

        
