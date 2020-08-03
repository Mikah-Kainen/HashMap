using System;

namespace HashMap
{
    class Program
    {
        int standardHash(string T)
        {
            return T.GetHashCode();
        }
        static void Main(string[] args)
        {
            //IHashFunction<string> StandardHash = new IHashFunction<string>(standardHash());


            HashDictionary<string, int> array = new HashDictionary<string, int>(new HashFunction<string>(), 10);
        
            for(int i = 0; i < 16; i ++)
            {
                array.Add("hi", i);
            }
            array.Add("bye", 6);
            //array.Add("bye", 3);

            bool rando = array.Remove("hi", 6);
            bool cuu = array.Remove("hi", 6);
            bool isTrue = array.Remove("bye", 6);
            bool thething = array.Remove("hi", 3);
            bool whonow = array.Remove("bye", 6);
            array.Add("bye", 57);
        }
    }
}
