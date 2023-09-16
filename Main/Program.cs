using DataStructures.MyArray;
using DataStructuresLibrary.MyLinkedList;

namespace Main
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var arr = new SinglyLinkedList<int>();
            arr.AddEnding(1);
            arr.AddEnding(2);    
            arr.AddEnding(3);
            arr.AddEnding(4);
            arr.AddEnding(5);
            arr.AddEnding(6);

            foreach (var item in arr) {
                Console.Write(item);
            }

            Console.WriteLine();
            arr.Remove(2);
            foreach (var item in arr)
            {
                Console.Write(item);
            }

            Console.WriteLine();
            arr.Remove(3);
            foreach (var item in arr)
            {
                Console.Write(item);
            }

            Console.WriteLine();
            arr.Remove(5);
            foreach (var item in arr)
            {
                Console.Write(item);
            }
            Console.WriteLine();
            arr.Remove(6);
            foreach (var item in arr)
            {
                Console.Write(item);
            }
            Console.WriteLine();
            arr.Remove(1);
            foreach (var item in arr)
            {
                Console.Write(item);
            }
            Console.WriteLine();
            arr.Remove(4);
            //foreach (var item in arr)
            //{
            //    Console.Write(item);
            //}
            




        }
    }
}