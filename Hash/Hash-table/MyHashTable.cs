using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Hash_table
{
    public class MyHashTable<T>
    {
        private List<T>[] table;
        private const int tablesize = 1000;

        public MyHashTable()
        {
            this.table = new List<T>[tablesize];
        }

        private int getHash(T element)
        {
            return element.GetHashCode() % tablesize;
        }

        public void add(T element)
        {
            int hash = getHash(element);
            if (table[hash] == null)
                table[hash] =  new List<T>();
            table[hash].Add(element);

        }

        public bool contain(T element) 
        {
            return table[getHash(element)].Contains(element);
        }

        public void delete(T element) 
        {
            if (table[getHash(element)] == null)
                return;

            if (!table[getHash(element)].Contains(element))
                return;

            table[getHash(element)].Remove(element);
        }
    }
}
