using System;

namespace ImplementedLinkedList_Homework
{
    class Program
    {
        static void Main(string[] args)
        {
            CustomLinkedLinkImplementation element = new CustomLinkedLinkImplementation();
            element.AddFirst("Box");
            element.AddLast("Inbox");
            element.RemoveFirst();
            element.RemoveLast();

        }
    }
}
