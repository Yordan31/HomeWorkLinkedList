using System;
using System.Collections.Generic;
using System.Text;

namespace ImplementedLinkedList_Homework
{
   public class CustomLinkedLinkImplementation
    {
        public Node FirstElement { get; set; }
        public Node LastElement { get; set; }


        public void AddFirst(string item)
        {
            if (IsEmpty())
            {
                FirstElement = LastElement = new Node(item);
            }
            else
            {
                var itemToAdd = new Node(item, FirstElement);
                FirstElement.Previous = itemToAdd;
                FirstElement = itemToAdd;
            }
        }
       
        public void AddLast(string item)//тожа 
        {
            if (IsEmpty())
            {
                LastElement = FirstElement = new Node(item);
            }
            else
            {
                var lastItem = new Node(item, LastElement);
                LastElement.Next = lastItem;
                LastElement = lastItem;
            }
        }

        public void RemoveFirst()
        {
            switch (FirstElement)
            {
                case null:
                    return;
                default:
                    if (FirstElement == LastElement)
                    {
                        FirstElement = null;
                        LastElement = null;
                    }
                    else
                    {
                        FirstElement = FirstElement.Next;
                    }

                    break;
            }

        }
        public void RemoveLast()
        {
            switch (LastElement)
            {
                case null:
                    return;
                default:
                    if (LastElement == FirstElement)
                    {
                        LastElement = null;
                        FirstElement = null;
                    }
                    else
                    {
                        LastElement = LastElement.Previous;
                        LastElement.Next = null;
                    }
                    break;

            }


        }
        private bool IsEmpty() => FirstElement == null && LastElement == null;
        

    }
}
