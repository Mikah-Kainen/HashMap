using System;
using System.Collections.Generic;
using System.Text;

namespace HashMap
{
    public class HashSet<T>
    {
        public int Count { get; private set; }
        LinkedList<T>[] buckets;

        readonly double resizeFactor = 0.3;
        double currentLoadFactor => Count / (double)capacity;
        int capacity;

        public HashSet()
        {
            capacity = 4;
            Count = 0;

            buckets = new LinkedList<T>[capacity];

        }


        public void Insert(T value)
        {
            if (currentLoadFactor > resizeFactor)
            {
                Resize();
            }



            int bucketIndex = GetBucketIndex(value, capacity);

            if (buckets[bucketIndex] == null)
            {
                buckets[bucketIndex] = new LinkedList<T>();
            }

            // insert to end of bucket

            // also check to make sure no duplicate keys, we overwrite the value for the key

            // check to see if it exists first
            bool overrode = false;
            foreach (var T in buckets[bucketIndex])
            {
                if (T.Equals(value))
                {
                    // does exist, replace the value with the new value
                    overrode = true;
                    break;
                }
            }

            if (!overrode)
            {
                buckets[bucketIndex].AddLast(value);
                Count++;

            }
        }

        public bool Remove(T value)
        {
            LinkedList<T> targetBucket = buckets[GetBucketIndex(value, capacity)];

            if (targetBucket.Remove(value))
            {
                Count--;
                return true;
            }
            return false;
        }

        public void Resize()
        {
            int tempcapacity = capacity * 2;
            var newbuckets = new LinkedList<T>[tempcapacity];

            // go over each item that existed in the old bucket, rehash it and add it to new bucket

            foreach (LinkedList<T> bucket in buckets)
            {
                if (bucket != null)
                {
                    foreach (T value in bucket)
                    {
                        int newbucketIndex = GetBucketIndex(value, tempcapacity);

                        if (newbuckets[newbucketIndex] == null)
                        {
                            newbuckets[newbucketIndex] = new LinkedList<T>();
                        }

                        newbuckets[newbucketIndex].AddLast(value);
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

        private int GetBucketIndex(T value, int capacity)
        {
            return Math.Abs(value.GetHashCode()) % capacity;
        }

    }
}
