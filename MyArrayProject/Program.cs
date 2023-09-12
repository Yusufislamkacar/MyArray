using DataStructures.MyArray;
using DataStructuresLibrary.MyLinkedList;
using System.Security.AccessControl;

namespace DataStructures
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var arr= new SinglyLinkedList<int>();
            arr.AddBeginnig(5);
            arr.AddBeginnig(6);
            arr.AddBeginnig(7);
                
            arr.AddBeginnig(8);
            arr.AddBeginnig(9);
            arr.AddEndnig(10);
            arr.AddEndnig(11);
            Console.ReadKey();
            

        }
    }
}