using System.Collections.Generic;

namespace Solve_5_Any_LeetCode_Questions
{
    class LRUCache
    {

        private int capacity;
        private Dictionary<int, (LinkedListNode<int> node,int val)> dictionary;
        private LinkedList<int> List;

        public LRUCache(int capacity)
        {
            this.capacity = capacity;
            dictionary = new Dictionary<int, (LinkedListNode<int> node, int val)>();
            List = new LinkedList<int>();
        }

        public int Get(int key)
        {
            if (!dictionary.ContainsKey(key))
                return -1;

            List.Remove(dictionary[key].node);
            List.AddFirst(dictionary[key].node);
            return dictionary[key].val;
        }

        public void Put(int key, int value)
        {
            if (dictionary.ContainsKey(key))
            {
                List.Remove(dictionary[key].node);
                List.AddFirst(dictionary[key].node);
                dictionary[key] = (dictionary[key].node,value);
            }
            else
            {
                if (dictionary.Count == capacity)
                {
                    dictionary.Remove(List.Last.Value);
                    List.RemoveLast();
                }
                var newNode = List.AddFirst(key);
                dictionary.Add(key, (newNode,value));
            }
        }
    }

}
