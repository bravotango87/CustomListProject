﻿using System;
using System.Configuration;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Sandbox;

namespace CustomListTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Add_AddingOneValueToEmptyCustomList_AddedValueGoesToIndexZero()
        {
            // arrange
            CustomList<int> testList = new CustomList<int>();
            int itemToAdd = 10;
            int expected = 10;
            int actual;

            // act
            testList.Add(itemToAdd);
            actual = testList[0];

            // assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Add_AddingOneValueToEmptyCustomList_CountOfCustomListIncrements()
        {
            // arrange
            CustomList<int> testList = new CustomList<int>();
            int itemToAdd = 10;
            int expected = 1;
            int actual;

            // act
            testList.Add(itemToAdd);
            actual = testList.Count;

            // assert
            Assert.AreEqual(expected, actual);
        }

        // what happens if you add multiple things (or add to a CustomList that already has some values)?
        // what happens to the last-added item?
        // what happens to the Count?

        // what happens if you add more items than the initial Capacity of the CustomList?

        // Add 3 Add Test Methods


        [TestMethod]
        public void Add_AddingMultipleValuesToEmptyCustomList_ValueOfZeroIndexStaysTheSame()
        {
            // arrange
            CustomList<int> testList = new CustomList<int>();
            int itemToAdd = 5;
            int itemToAddTwo = 7;
            int expected = 5;
            int actual;


            // act
            testList.Add(itemToAdd);
            testList.Add(itemToAddTwo);
            actual = testList[0];




            // assert

            Assert.AreEqual(expected, actual);

        }

        [TestMethod]

        public void Add_AddingMultipleValuesToEmptyCustomList_ValueOfThreeIndexStaysTheSame()
        {
            // arrange

            CustomList<int> testList = new CustomList<int>();
            int itemToAdd = 9;
            int itemToAddTwo = 2;
            int itemToAddThree = 4;
            int expected = 4;
            int actual;


            // act

            testList.Add(itemToAdd);
            testList.Add(itemToAddTwo);
            testList.Add(itemToAddThree);
            actual = testList[2];


            // assert

            Assert.AreEqual(expected, actual);

        }

        [TestMethod]

        public void Add_AddingMultipleValuesToEmptyCustomList_CheckCapacity()
        {
            // arrange 

            CustomList<int> testList = new CustomList<int>();
            int itemToAdd = 3;
            int itemToAddTwo = 5;

            int expected = 2;

            // act

            testList.Add(itemToAdd);
            testList.Add(itemToAddTwo);
            actual = testList.Count;

            // assert

            Assert.AreEqual(expected, actual);

        }

        // Write a test where you add 5 or more things and check for increased capacity

        [TestMethod]

        public void Add_AddingFiveValuesCheckCapacity()
        {
            // arrange

            CustomList<int> testList = new CustomList<int>();

            int itemToAdd = 10;
            int expected = 8;
            int actual;


            // act

            testList.Add(itemToAdd);
            testList.Add(itemToAdd);
            testList.Add(itemToAdd);
            testList.Add(itemToAdd);
            testList.Add(itemToAdd);
            testList.Add(itemToAdd);

            actual = testList.Capacity;

            // assert

            Assert.AreEqual(expected, actual);


        }

        // Write a test where you add 5 or more things and check the count

        [TestMethod]

        public void Add_AddingFiveValuesAndCheckCount()
        {
            // arrange

            CustomList<int> testList = new CustomList<int>();

            int itemToAdd;
            int expected = 6;
            int actual;


            // act

            testList.Add(3);
            testList.Add(5);
            testList.Add(7);
            testList.Add(9);
            testList.Add(12);
            testList.Add(32);

            actual = testList.Count;

            // assert

            Assert.AreEqual(expected, actual);

        }
        
        // Write a test where you add 5 or more things and check a value at an index

        [TestMethod]

        public void Add_AddingFiveValuesCheckAtIndex()
        {
            // arrange

            CustomList<int> testList = new CustomList<int>();
            int itemToAdd;
            int expected = 32;
            int actual;

            // act

            testList.Add(24);
            testList.Add(32);
            testList.Add(20);
            testList.Add(32);
            testList.Add(25);

            actual = testList.index[1];

            // assert

            Assert.AreEqual(expected, actual);
        }



        // Remove Test (Add items to list before removing them)

        [TestMethod]

        public void Remove_RemovingOneValueFromCustomList_RemainingValueGoesToIndexZero()
        {
            // arrange

            CustomList<int> testList = new CustomList<int>();


            // act

            int itemToAdd = 10;
            int itemToAddTwo = 12;
            int itemToAddThree = 18;
            int itemToRemove = 12;

            // assert

            Assert.AreEqual(expected, actual);
        }


        [TestMethod]

        public void Remove_RemovingOneValueToEmptyCustomList_CountOfCustomListIncrements()
        {
            // arrange

            CustomList<int> testList = new CustomList<int>();



            // act

            int itemToAdd = 10;
            int itemToAddTwo = 12;
            int itemToAddThree = 15;
            int itemToRemove = 12;



            // assert

            Assert.AreEqual(expected, actual);
        }
        [TestMethod]

        public void Remove_RemovingMultipleValuesFromCustomList_ValueOfZeroIndexStaysTheSame()
        {
            // arrange

            CustomList<int> testList = new CustomList<int>();
            int itemToAdd = 32;
            int itemToAddTwo = 18;
            int itemToAddThree = 22;
            int expected = 22;
            int actual;

            // act

            testList.Add(itemToAdd);
            testList.Add(itemToAddTwo);
            testList.Add(itemToAddThree);
           
            actual = testList[2];

            // assert

            Assert.AreEqual(expected, actual);

        }
        [TestMethod]

        public void Remove_RemovingMultipleValuesFromCustomList_ValueOfThreeIndexStaysTheSame()
        {
            // arrange

            CustomList<int> testList = new CustomList<int>();
            int itemToAdd = 9;
            int itemToAddTwo = 2;
            int itemToAddThree = 4;
            int expected = 4;
            int actual;

            // act

            testList.Add(itemToAdd);
            testList.Add(itemToAddTwo);
            testList.Add(itemToAddThree);
            testList.Remove(4);
            actual = testList[2];

            // assert

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]

        public void Remove_RemovingMultipleValuesToEmptyCustomList_CheckCapacity()
        {
            // arrange 

            CustomList<int> testList = new CustomList<int>();
            int itemToAdd = 3;
            int itemToAddTwo = 5;

            int expected = 2;

            // act

            testList.Add(itemToAdd);
            testList.Add(itemToAddTwo);
            actual = testList.Count;

            // assert

            Assert.AreEqual(expected, actual);








        }

    }

}
