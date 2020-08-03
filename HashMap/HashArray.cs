using System;
using System.Collections.Generic;
using System.Text;

namespace HashMap
{
    class HashArray<T>
    {
        public int Count { get; private set; }
        public List<T>[] array;

        public HashArray(int count)
        {
            Count = count;
            array = new List<T>[Count];
            for(int i = 0; i < Count; i ++)
            {
                array[i] = new List<T>();
            }
        }

        public void Add(T Value)
        {
            int index = Value.GetHashCode() % Count;
            array[index].Add(Value);
        }

        public bool Remove(T Value)
        {
            int index = Value.GetHashCode() % Count;
            if(!array[index].Remove(Value))
            {
                return false;
            }
            return true;
        }
    }
}
