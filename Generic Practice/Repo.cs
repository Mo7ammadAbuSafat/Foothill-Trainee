using System.Collections.Generic;

namespace Generic_Practice
{
    public class Repo<T> where T : BaseItem
    {
        private readonly List<T> array = new();
        private int count;
        private int Count { get => count; set => count = value; }


        public void Add(T item)
        {
            array.Add(item);
            Count++;
        }

        public void Remove(T item)
        {
            array.Remove(item);
            Count--;
        }

        public T? GetById(int id)
        {
            foreach (T item in array)
            {
                if (item.Id == id)
                {
                    return item;
                }
            }
            return null;
        }

        public void Save()
        {
            foreach (T item in array)
            {
                Console.WriteLine(item.ToString());
            }
        }
    }
}
