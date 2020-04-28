﻿using System;
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



            // Remove Test Add items to list before removing them

           [TestMethod]

           public void Remove_RemovingOneValueFromCustomList_RemainingValueGoesToIndexZero()
        {
            // arrange

            CustomList<int> testList = new CustomList<int>();
            int itemToAdd = 32;
            int iteamToAddTwo = 12;
            int actual;

            // act

            testList.Add(iteamToAdd);
            testList.Add(iteamToAddTwo);
            testList.Remove(12);
            actual = testList[1];

            // assert

            Assert.AreEqual(expected, actual);
        }






    }

}
