using DataStructures.MyArray;
using System.Security.AccessControl;

namespace MyArrayProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var names=new MyArray<string>();
            names.Add("Abdullah");
            names.Add("Mehmet");
            names.Add("Yusuf");
            names.Add("Hakan");

            Console.WriteLine(names.LinearSearch("Yusuf"));
            

        }
    }
}