using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HashMap
{
    public class Pair<TKey, TValue>
    {
        public TKey Key { get; set; }
        public TValue Value { get; set; }
        public Pair(TKey key, TValue value)
        {
            Key = key;
            Value = value;
        }
    }


    public class MyDictionary<TKey, TValue>
    {

        public int Count { get; private set; }
        LinkedList<Pair<TKey, TValue>>[] buckets;

        readonly double resizeFactor = 0.3;
        double currentLoadFactor => Count / (double) capacity;
        int capacity;

        public MyDictionary()
        {
            capacity = 4;
            Count = 0;

            buckets = new LinkedList<Pair<TKey, TValue>>[capacity];

        }


        public void Insert(TKey key, TValue value)
        {
            if (currentLoadFactor > resizeFactor)
            {
                Resize();
            }



            int bucketIndex = GetBucketIndex(key, capacity);

            if (buckets[bucketIndex] == null)
            {
                buckets[bucketIndex] = new LinkedList<Pair<TKey, TValue>>();
            }

            // insert to end of bucket

            // also check to make sure no duplicate keys, we overwrite the value for the key

            // check to see if it exists first
            bool overrode = false;
            foreach (var pair in buckets[bucketIndex])
            {
                if (pair.Key.Equals(key))
                {
                    // does exist, replace the value with the new value
                    pair.Value = value;
                    overrode = true;
                    break;
                }
            }

            if (!overrode)
            {
                buckets[bucketIndex].AddLast(new Pair<TKey, TValue>(key, value));
                Count++;

            }


 

        }


        public void Resize()
        {
            int tempcapacity = capacity * 2;
            var newbuckets = new LinkedList<Pair<TKey, TValue>>[tempcapacity];

            // go over each item that existed in the old bucket, rehash it and add it to new bucket

            foreach (var bucket in buckets)
            {
                if (bucket != null)
                {
                    foreach (var pair in bucket)
                    {
                        int newbucketIndex = GetBucketIndex(pair.Key, tempcapacity);

                        if (newbuckets[newbucketIndex] == null)
                        {
                            newbuckets[newbucketIndex] = new LinkedList<Pair<TKey, TValue>>();
                        }

                        newbuckets[newbucketIndex].AddLast(pair);
                    }
                }
            }

            //for (int x = 0; x < buckets.Length; x ++)
            //{
            //    for (int i = 0; buckets[x] != null && i < buckets[x].Count; i++)
            //    {
            //        newbuckets[newindex].AddFirst(buckets[x].First.);
            //    }
            //}



            buckets = newbuckets;
            capacity *= 2;
        }

        private int GetBucketIndex(TKey key, int capacity)
        {
            return Math.Abs(key.GetHashCode()) % capacity;
        }
    }
}
