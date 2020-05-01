using DocumentFormat.OpenXml.Office2013.PowerPoint.Roaming;
using Syncfusion.Licensing.crypto;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UserList;

namespace UserList
{
    public class CustomList<T> : IEnumerable //generic class
    {
        // member variables (HAS A)

        private T[] items;
        private int capacity;
        private int count;
        private int index;
        private int i;

        public IEnumerator GetEnumerator()
        {
            for (int i = 0; i < count; i++)
            {
                yield return items[i];
            }
        }
      






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
                return capacity;
            }
        }

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
                    throw new ArgumentOutOfRangeException();
                }

            }
            set
            {
                items[index] = value;

            }
        }




        // constructor (SPAWNER)
        public CustomList()
        {
            
            count = 0;
            capacity = 4;
            items = new T[capacity]; // array
        }



        // member methods (CAN DO) based of [TestMethod]s

       
        // add an object to an instance of custom-built list class by imitating the C# Add() method.

        public void Add(T item)
        {
            if (count < capacity)
            {
                items[count] = item;
                count++;
            }


            else // capacity needs to double to 8
            {
                capacity = (capacity * 2);
                T[] tempArray = new T[capacity];
                for (int i = 0; i < count; i++)
                {
                    tempArray[i] = items[i];
                }
                items = tempArray;
                items[count] = item;
                count++;
                

            }

        }


        // remove an object from an instance of my custom-built list class by imitating the C# Remove() method.

        public bool Remove(T item)
        {
           
            for(int i = 0; i < count; i++)
            {
                if (item.Equals(items))
                {
                    count--;
                    items[count] = item;
                }

            }
            return false;
        }



        // override ToString

        public override string ToString()
        {
            string value;
            for (int i = 0; i < count; i++)
            {
                
            }
            return value;
        }
    }
}


       


       

