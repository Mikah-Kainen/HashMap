using System;
using System.Collections.Generic;

namespace HashMap
{
    class Program
    {
        //static int standardHash(string T)
        //{
        //    return T.GetHashCode();
        //}
        static void Main(string[] args)
        {
            //IHashFunction<string> StandardHash = new IHashFunction<string>(standardHash());


            //List<int> list = new List<int>();

            //while (true)
            //{
            //    Console.WriteLine($"Capacity: {list.Capacity}, Count: {list.Count}");
            //    list.Add(1);
            //}


            //HashDictionary<string, int> array = new HashDictionary<string, int>(new HashFunction<string>(), 10);

            //var array = new HashDictionary<string, int>(standardHash, 10);

            //for(int i = 0; i < 16; i ++)
            //{
            //    array.Add("hi", i);
            //}
            //array.Add("bye", 6);
            ////array.Add("bye", 3);

            //bool rando = array.Remove("hi", 6);
            //bool cuu = array.Remove("hi", 6);
            //bool isTrue = array.Remove("bye", 6);
            //bool thething = array.Remove("hi", 3);
            //bool whonow = array.Remove("bye", 6);
            //array.Add("bye", 57);

            var dict = new MyDictionary<string, string>();

            dict.Insert("apple", "a red fruit");
            dict.Insert("orange", "an orange fruit");
            dict.Insert("banana", "a yellow fruit");
            dict.Insert("mango", "a delicious fruit");
            dict.Insert("blueberry", "a blue fruit");
            dict.Insert("raspberry", "a red fruit");



        }
    }
}
