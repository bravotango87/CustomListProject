using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserList
{
    public class CustomList<T> //generic class
    {
        // member variables (HAS A)

        // array

        private T[] items;
        private int count;
        private int capacity;

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
                return count;
            }
        }



        // constructor (SPAWNER)
        public CustomList()
        {
            items = new T[4];
            count = 0;
            capacity = 4;
        }

        // member methods (CAN DO)
        public void Add(T item)
        {

        }
    }
}
