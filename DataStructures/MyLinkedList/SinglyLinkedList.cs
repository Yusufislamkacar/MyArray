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
            if (Head == null)
            {
                Head = newNode;
                return;
            }
            newNode.Next = Head;
            Head = newNode;
              
           
        }
        public void AddEndnig(T item)
        {
            var newNode = new SinglyLinkedListNode<T>(item);
            if (Head == null)
            {
                Head= newNode;
                return;
            }

            var current = Head;
            while (current.Next != null)
            {
                current = current.Next;
            }
            current.Next= newNode;
            
        }
        public void AddAfter(SinglyLinkedListNode<T> node, T item)
        {
            var newNode = new SinglyLinkedListNode<T>(item);
            var current = Head;
            while (current != null)
            {
                if(current == node)
                {
                    newNode.Next = current.Next;
                    current.Next= newNode;                    
                    return;
                }
                current = current.Next;
            }
            throw (new Exception("The reference node is not in this list."));
            
        }
        public void AddAfter(SinglyLinkedListNode<T> node, SinglyLinkedListNode<T> newNode)
        {
            var current = Head;
            while (current != null)
            {
                if (current == node)
                {
                    newNode.Next = current.Next;
                    current.Next = newNode;
                    return;
                }
                current = current.Next;
            }
            throw (new Exception("The reference node is not in this list."));
        }
        public void AddBefore(SinglyLinkedListNode<T> node, T item)
        {

            var newNode = new SinglyLinkedListNode<T>(item);
            var current = Head;

            if (current == Head)
            {
                newNode.Next = Head;
                Head = newNode;
            }

            while (current != null)
            {
                if (current.Next == node)
                {
                    newNode.Next = current.Next;
                    current.Next = newNode;
                    return;
                }
                current = current.Next;
            }
            throw (new Exception("The reference node is not in this list."));

        }
        public void AddBefore(SinglyLinkedListNode<T> node, SinglyLinkedListNode<T> newNode)
        {
            var current = Head;
            if (current == Head)
            {
                newNode.Next = Head;
                Head = newNode;
                return;
            }
                
            while (current != null)
            {
                if (current.Next == node)
                {   
                    newNode.Next = current.Next;
                    current.Next = newNode;
                    if (current==Head)
                        Head = newNode;
                    return;

                }
                current = current.Next;
            }
            throw (new Exception("The reference node is not in this list."));
        }
    }
        
    
}
