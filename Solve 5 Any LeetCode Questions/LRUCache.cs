namespace Solve_5_Any_LeetCode_Questions
{
    class LRUCache
    {

        private int capacity;
        private Dictionary<int, (LinkedListNode<int>,int)> dictionary;
        private LinkedList<int> List;

        public LRUCache(int capacity)
        {
            this.capacity = capacity;
            dictionary = new Dictionary<int, int>();
            List = new LinkedList<int>();
        }

        public int Get(int key)
        {
            if (!dictionary.ContainsKey(key))
                return -1;

            List.Remove(key);
            List.AddFirst(key);
            return dictionary[key];
        }

        public void Put(int key, int value)
        {
            if (dictionary.ContainsKey(key))
            {
                dictionary[key] = value;

                List.Remove(key);
                List.AddFirst(key);
            }
            else
            {
                if (dictionary.Count == capacity)
                {
                    dictionary.Remove(List.Last.Value);
                    List.RemoveLast();
                }
                dictionary.Add(key, value);
                List.AddFirst(key);
            }
        }
    }

}
