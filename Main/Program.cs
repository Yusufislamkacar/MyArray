using DataStructures.MyArray;
using DataStructuresLibrary.MyLinkedList;
using DataStructuresLibrary.MyStack;

namespace Main
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var linkedlist= new SinglyLinkedList<int>(new int[]{ 1,2,3,4,5});
            foreach(int i in linkedlist) { Console.WriteLine(i); }

            Console.WriteLine();
            var stack = new MyStack<int>(linkedlist);
            foreach (int i in stack) { Console.WriteLine(i); }


        }
    }
}