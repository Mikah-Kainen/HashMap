using System;
using System.Collections.Generic;
using System.Text;

namespace HashMap
{
    interface IHashFunction<T>
    {
        int GetHash(T value);
    }
}
