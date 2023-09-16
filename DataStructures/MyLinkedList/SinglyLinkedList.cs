using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructuresLibrary.MyLinkedList
{
    public class SinglyLinkedList<T>:IEnumerable<T>
    {
        public SinglyLinkedList()
        {

        }
        public SinglyLinkedList(IEnumerable<T> arr)
        {
            foreach (T item in arr)
            {
                AddEnding(item);
            }
        }
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
        public void AddEnding(T item)
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
        public void RemoveFirst()
        {
            Head=Head.Next;
        }
        public void RemoveLast()
        {
            if (Head == null)
            {
                Console.WriteLine("The list already empty.");
                return;
            }
            SinglyLinkedListNode<T> prev = null;
            var current = Head;
            while (current.Next != null)
            {
                prev = current;
                current = current.Next;
            }
            if (prev == null)
            {
                Head = null;
            }else
                prev.Next = null;
        }
        public void Remove(T value)
        {
            if (Head == null)
            {
                Console.WriteLine("The list already empty.");
                return;
            }
            SinglyLinkedListNode<T> prev=null;
            var current = Head;
            
            while (!(current.Value.Equals(value)) && !(current.Next==null))
            {
                prev = current;
                current = current.Next;
            }
            if (!current.Value.Equals(value)) { Console.WriteLine("The item is not in list."); }
            if (current.Next == null && prev==null)
            {
                RemoveLast();
                return;
            }          
            else if (prev == null){
                Head = Head.Next;
                return;
            }else if(current.Next == null)
            {
                RemoveLast();
            }
            else
            {
                prev.Next = current.Next; 
            }
                

            

        }

        public IEnumerator<T> GetEnumerator()
        {
            return new SinglyLinkedListEnumerator<T>(Head);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
        
    
}
