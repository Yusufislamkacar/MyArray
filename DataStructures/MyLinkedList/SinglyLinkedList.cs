using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructuresLibrary.MyLinkedList
{
    public class SinglyLinkedList<T>
    {
        public SinglyLinkedListNode<T> Head { get; set; }

        public void AddBeginnig(T item)
        {
            var newNode = new SinglyLinkedListNode<T>(item);  
            Head = newNode;
        }
        public void AddEndnig(T item)
        {
            var A = Head;
            while (Head != null)
            {
                Head.Next = Head;
            }
            Head.Value=item;
            Head = A;
        }
        public void AddAfter(SinglyLinkedListNode<T> node, T item)
        {
            var newNode = new SinglyLinkedListNode<T>(item);
            var current = Head;
            while (Head != null)
            {
                if(Head == node)
                {
                    newNode.Next = Head.Next;
                    Head.Next= newNode;
                    Head = current;
                    return;
                }
                newNode.Next = Head;
            }
            
        }
    }
}
