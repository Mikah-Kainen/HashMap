using System;
using System.Collections.Generic;
using System.Text;

namespace HashMap
{
    class HashDictionary<keyType, T>
    {
        public int Count { get; private set; }
        public List<T>[] HashArray;
        public IHashFunction<keyType> HashFunction;
        public HashDictionary(IHashFunction<keyType> HashFunction, int count)
        {
            Count = count;
            HashArray = new List<T>[count];
            for(int i = 0; i < Count; i ++)
            {
                HashArray[i] = new List<T>();
            }
            this.HashFunction = HashFunction;
        }

        public void Add(keyType key, T value)
        {
            int index = HashFunction.GetHash(key) % Count;
            HashArray[index].Add(value);
        }

        public bool Remove(keyType key, T value)
        {
            int index = HashFunction.GetHash(key) % Count;
            if(!HashArray[index].Remove(value))
            {
                return false;
            }
            return true;
        }
    }
}
