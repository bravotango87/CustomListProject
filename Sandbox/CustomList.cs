using DocumentFormat.OpenXml.Office2013.PowerPoint.Roaming;
using DocumentFormat.OpenXml.Spreadsheet;
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


        // remove an object from an instance of my custom-built list class by imitating the C# Remove(/) method.

        public bool Remove(T item)
        {
            bool shiftValue = false;

            for (int i = 0; i < count; i++)
            {
                if (item.Equals(items[i]))
                {
                    count--;
                    items[i] = items[i + 1];
                    shiftValue = true;

                }

                else if (shiftValue == true)
                {
                    items[i] = items[i + 1];
                }

            }
            return shiftValue;
        }



        // override ToString

        public override string ToString()
        {
            string result = "";
            for (int i = 0; i < count; i++)
            {
                result += items[i].ToString();
            }
            return result;
        }

        // overload the + operator

        public static CustomList<T> operator +(CustomList<T> a, CustomList<T> b)
        {
            CustomList<T> newList = new CustomList<T>();
            for (int i = 0; i < a.count; i++)
            {
                newList.Add(a[i]);
            }
            for (int i = 0; i < b.count; i++)
            {
                newList.Add(b[i]);
            }

            return newList;
        }

        // Overload the – operator, so that I can subtract one instance

        public static CustomList<T> operator -(CustomList<T> a, CustomList<T> b)
        {
            CustomList<T> newList = new CustomList<T>();
            for (int i = 0; i < a.count; i++)
            {
                for (int j = 0; j < b.count; j++)
                {
                    if (a[i].Equals(b[j]))
                    {
                        a.Remove(a[i]);
                        b.Remove(b[j]);
                    }

                }
            }
            newList = a + b;

            return newList;
        }

        // Zip two custom list class instances together in the form of a zipper

        public CustomList<T> Zip(CustomList<T> list1, CustomList<T> list2)
        {
            CustomList<T> newList = new CustomList<T>();
            for (int i = 0; i < list1.count; i++)
            {
                newList.Add(list1[i]);
                newList.Add(list2[i]);
            }
            return newList;
        }
    }

   

    
}







