using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructuresLibrary.MyStack
{
    public class StackNode<T>
    {
        public StackNode<T> Prev { get; set; }
        public T Value { get; set; }
        public StackNode(T value)
        {
            Value = value;
            
        }
    }
}
