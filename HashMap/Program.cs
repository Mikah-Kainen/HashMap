using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace HashMap
{
    class Test
    {
        int[] array = new int[] { 1, 2, 3, 4, 5, 6, 7 };

        public int this[int index]
        {
            get
            {
                //Make sure the key exist, throw if it doesnt
                return array[index];
            }
            set
            {
                //throw if key doesn't exist
                array[index] = value;
            }
        }
    }

    class Program
    {
        //static int standardHash(string T)
        //{
        //    return T.GetHashCode();
        //}
        static void Main(string[] args)
        {
            //var dict = new MyDictionary<string, string>();

            //dict.Insert("apple", "a red fruit");
            //dict.Insert("orange", "an orange fruit");
            //dict.Insert("banana", "a yellow fruit");
            //dict.Insert("mango", "a delicious fruit");
            //dict.Insert("blueberry", "a blue fruit");
            //dict.Insert("raspberry", "a red fruit");
            //dict["banana"] = "something else";

            //bool bool1 = dict.Remove("apple");
            //bool bool4 = dict.Remove("apple");
            //bool bool2 = dict.Remove("mango");
            //bool bool3 = dict.Remove("bla");

            ////Console.WriteLine($"{dict["mango"]}");
            //Console.WriteLine($"{dict["banana"]}");
            //Console.WriteLine($"{dict["blueberry"]}");
            //dict["blueberry"] = "blue";
            //Console.WriteLine($"{dict["blueberry"]}");

            //bool isTrue = dict.Contains("blueberry");
            //bool isFalse = dict.Contains("apple");



            HashSet<string> Set = new HashSet<string>();

            Set.Insert("blue");
            Set.Insert("yellow");
            Set.Insert("green");
            Set.Insert("red");
            Set.Insert("Bob");
            Set.Insert("purple");

            Set.Remove("green");
            Set.Remove("yellow");


        }
    }
}
