using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataStructures.MyArray;
using DataStructuresLibrary.MyLinkedList;

namespace DataStructuresLibrary
{
    internal class MainProgramCodes
    {
        static void Main(string[] args)
        {
            //FundamentalsCodesOfArray();
            //SerchingOperation();
            //LinkedListBasicOperation();
            //ForeachOperation();
            //CollectionMethod();
            //RemoveLastOperation();
        }

        private static void RemoveLastOperation()
        {
            var arr = new SinglyLinkedList<int>();
            arr.AddBeginnig(1);
            arr.AddBeginnig(2);
            arr.AddBeginnig(3);
            arr.AddBeginnig(4);
            arr.AddBeginnig(5);
            arr.RemoveLast();
            arr.RemoveLast();
            arr.RemoveLast();
            arr.RemoveLast();

            foreach (int i in arr) { Console.WriteLine(i); }
        }

        private static void CollectionMethod()
        {
            MyArray<int> arr = new MyArray<int>(new int[] { 1, 2, 3, 4, 5, 6 });
            var arr2 = new SinglyLinkedList<int>(arr);
            foreach (int i in arr2) { Console.WriteLine(i); }
        }

        private static void ForeachOperation()
        {
            var list = new SinglyLinkedList<int>();
            list.AddBeginnig(10);
            list.AddBeginnig(20);
            list.AddBeginnig(30);
            foreach (int i in list)
            {
                Console.WriteLine(i);
            }
        }

        private static void LinkedListBasicOperation()
        {
            var arr = new SinglyLinkedList<int>();
            arr.AddBeginnig(5);
            arr.AddBeginnig(6);
            arr.AddEnding(10);
            arr.AddEnding(11);
            arr.AddAfter(arr.Head.Next, 99);
            arr.AddAfter(arr.Head, new SinglyLinkedListNode<int>(12));
            arr.AddBefore(arr.Head.Next.Next, 55);
            arr.AddBefore(arr.Head, new SinglyLinkedListNode<int>(88));
            Console.ReadKey();
            //88,6,12,55,5,99,10,11
        }

        private static void SerchingOperation()
        {
            var names = new MyArray<string>();
            names.Add("Abdullah");
            names.Add("Mehmet");
            names.Add("Yusuf");
            names.Add("Hakan");

            Console.WriteLine(names.LinearSearch("Yusuf"));
        }

        private static void FundamentalsCodesOfArray()
        {
            MyArray<int> firstArray = new MyArray<int>();
            firstArray.Add(1);
            firstArray.Add(2);
            firstArray.Add(3);
            firstArray.Add(4);
            firstArray.Add(5);

            foreach (int i in firstArray) { Console.WriteLine(i); }
            Console.WriteLine($"Removed item:{firstArray.RemoveAtLast()}");
            Console.WriteLine($"Removed item:{firstArray.RemoveAtLast()}");

            foreach (int i in firstArray) { Console.WriteLine(i); }




            Console.WriteLine($"Count:{firstArray.Count} / Capacity:{firstArray.Capacity}");
        }
    }
}
