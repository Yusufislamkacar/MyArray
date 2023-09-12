using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures.MyArray
{
    internal class MainProgramCodes
    {
        static void Main(string[] args)
        {
            //FundamentalsCodesOfArray();
        }

        private static void FundamentalsCodesOfArray()
        {
            DataStructures.MyArray.MyArray<int> firstArray = new DataStructures.MyArray.MyArray<int>();
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
