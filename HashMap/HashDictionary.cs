using System;
using System.Collections.Generic;
using System.Text;

namespace HashMap
{
    class HashDictionary<keyType, T>
    {
        public int Count { get; private set; }
        public List<T>[] HashArray;
        public Func<keyType, int> HashFunction;
        //public HashDictionary(IHashFunction<keyType> HashFunction, int count)
        public HashDictionary(Func<keyType, int> hashFunc, int count)
        {
            Count = count;
            HashArray = new List<T>[count];
            for(int i = 0; i < Count; i ++)
            {
                HashArray[i] = new List<T>();
            }
            this.HashFunction = hashFunc;
        }

        public void Add(keyType key, T value)
        {
            int index = HashFunction(key) % Count;
            HashArray[index].Add(value);
        }

        public bool Remove(keyType key, T value)
        {
            int index = HashFunction(key) % Count;
            if(!HashArray[index].Remove(value))
            {
                return false;
            }
            return true;
        }
    }
}
