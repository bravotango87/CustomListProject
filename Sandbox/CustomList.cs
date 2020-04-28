using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sandbox
{
    public class MyCustomList<T>
    {
        // member variables (Has a)


        private T[] items;
        private int count;
        private int capacity;


        public T this[int index]
        {
            get
            {
                if (index < count && index >= 0)
                {
                    return items[index];
                }
                else
                {
                    throw new IndexOutOfRangeException();
                }

            }
            set
            {
                items[index] = value;
            }
        }

        public int Count
        {
            get
            {
                return count;
            }
        }

        public int Capacity
        {
            get
            {
                return capacity;
            }
        }

        // constructor (Spawner)

        public MyCustomList()
        {
            count = 0;
            capacity = 4;
            items = new T[capacity];
        }

        // methods (Can do)
        public void Add(T item)
        {
            items[count] = item;
            count++;
        }






    }
}