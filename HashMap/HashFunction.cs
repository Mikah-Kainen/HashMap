using System;
using System.Collections.Generic;
using System.Text;

namespace HashMap
{
    class HashFunction<T> : IHashFunction<T>
    {
        public int GetHash(T value)
        {
            return Math.Abs(value.GetHashCode());
        }
    }
}
