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



        private T[] items;
        private int count;
        private int capacity;



        // properties

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
            items = new T[capacity]; // array
            count = 0;
            capacity = 4;
        }

        // member methods (CAN DO) based of [TestMethod]s

        public T this[int index]
        {
            get
            {
                if (index < 0 && index >= capacity)
                {
                    return items[index];
                }
                else
                {
                    throw new ArgumentOutOfRangeException();
                }

            }
            set
            {
                items[index] = value;
            }

            




        }



        // add an object to an instance of custom-built list class by imitating the C# Add() method.

        public void Add(T item)
        {
            items[count] = item;
            count++;


            if (count == capacity) // capacity needs to double to 8
            {
                capacity = (capacity * 2);


                
                T[] tempArray = new T[capacity];

                for (int i = 0; i < count; i++)
                {
                    items[i] = tempArray[i];
                }
                items[count] = item;
                count++;

            }
        }
    }
}
     
       
