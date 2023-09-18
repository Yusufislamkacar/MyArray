using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructuresLibrary.MyStack
{
    public class MyStack<T>:IEnumerable<T>
    {
        public  StackNode<T> Head { get; set; }
        public int Count { get; set; }
        public MyStack() { 
            Count = 0;
        }
        public MyStack(IEnumerable<T> objects)
        {
            foreach (var obj in objects)
            {
                Push(obj);
            }
        }
        public Boolean IsEmpty() => Count == 0 ? true : false;
        public void Push(T newItem) { 
            var item = new StackNode<T>(newItem);
            if (IsEmpty())
            {
                Head = item;
                Count++;
            }
            else
            {
                item.Prev= Head;
                Head= item;
                Count++;
            }
        }
        public void peek()
        {
            Console.WriteLine(Head.Value);
        }
        public void Pop() {
            if (!IsEmpty())
            {
                Head = Head.Prev;
                Count--;
            }else Console.WriteLine("The stack already empty!");

        }
        public void Clear()
        {
            Head = null;
        }

        public IEnumerator<T> GetEnumerator()
        {
            return new StackEnumerator<T>(Head);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
