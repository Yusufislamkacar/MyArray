using Microsoft.VisualBasic;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures.MyArray
{
    public class Array<T> : IEnumerable<T>, ICloneable
    {
        private T[] InnerArray;
        public int Count { get; private set; }
        public int Capacity => InnerArray.Length; //Only readabe `=>`

        public Array()
        {
            InnerArray = new T[1];
            Count = 0;
        }
        public Array(params T[] array)
        {
            InnerArray = new T[array.Length];
            Count = 0;
            foreach (var item in array)
            {
                Add(item);
            }
        }

        public void Add(T data)
        {
            if (Capacity == Count)
            {
                IncreaseCapacity();
            }
            InnerArray[Count] = data;
            Count++;
        }
        public T RemoveAtLast()
        {
            if (Count == 0)
                throw new Exception("Already empty!");

            var temp = InnerArray[Count - 1];
            Count--;


            if (Capacity > Count * 2)
                DeclareCapacity();
            return temp;
        }

        private void DeclareCapacity()
        {
            var temp = new T[InnerArray.Length / 2];
            Array.Copy(InnerArray,temp,temp.Length);
            InnerArray = temp;
        }

        private void IncreaseCapacity()
        {
            var temp = new T[InnerArray.Length * 2];
            Array.Copy(InnerArray, temp, InnerArray.Length);
            InnerArray = temp;
        }

        public object Clone()
        {
            throw new NotImplementedException();
        }

        public IEnumerator<T> GetEnumerator()//IEnumerator interfacesi bize LINQ ifadelerini kullanabilme imkani verir. Foreach gibi.
        {
            return InnerArray.Take(Count).GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
