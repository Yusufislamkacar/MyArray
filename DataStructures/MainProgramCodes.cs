using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataStructures.MyArray;

namespace DataStructuresLibrary
{
    internal class MainProgramCodes
    {
        static void Main(string[] args)
        {
            //FundamentalsCodesOfArray();
            //SerchingMethod();
        }

        private static void SerchingMethod()
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
