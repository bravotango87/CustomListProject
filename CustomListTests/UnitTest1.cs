using System;
using System.Configuration;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using UserList;

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
            int itemToAddThree = 9;
            int expected = 5;
            int actual;


            // act
            testList.Add(itemToAdd);
            testList.Add(itemToAddTwo);
            testList.Add(itemToAddThree);
            actual = testList[0];




            // assert

            Assert.AreEqual(expected, actual);

        }

        [TestMethod]

        public void Add_AddingMultipleValuesToEmptyCustomList_ValueOfOneStaysTheSame()
        {
            // arrange

            CustomList<int> testList = new CustomList<int>();
            int itemToAdd = 6;
            int itemToAddTwo = 2;
            int itemToAddThree = 4;
           
            int expected = 2;
            int actual;


            // act

            testList.Add(itemToAdd);
            testList.Add(itemToAddTwo);
            testList.Add(itemToAddThree);
           
            actual = testList[1];


            // assert

            Assert.AreEqual(expected, actual);

        }

        [TestMethod]

        public void Add_AddingMultipleValuesToEmptyCustomList_CheckCapacity()
        {
            // arrange 

            CustomList<int> testList = new CustomList<int>();
            int itemToAdd = 32;
            int expected = 8;
            int actual;



            // act
            testList.Add(itemToAdd);
            testList.Add(itemToAdd);
            testList.Add(itemToAdd);
            testList.Add(itemToAdd);
            testList.Add(itemToAdd);
            actual = testList.Capacity;

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

            int itemToAdd = 32;
            int expected = 5;
            int actual;


            // act

            testList.Add(itemToAdd);
            testList.Add(itemToAdd);
            testList.Add(itemToAdd);
            testList.Add(itemToAdd);
            testList.Add(itemToAdd);
            



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
            int itemToAdd = 32;
            int expected = 5;
            int actual;

            // act

            testList.Add(itemToAdd);
            testList.Add(itemToAdd);
            testList.Add(itemToAdd);
            testList.Add(itemToAdd);
            testList.Add(itemToAdd);

            actual = testList.Count;

            // assert

            Assert.AreEqual(expected, actual);
        }



        // Remove Test (Add items to list before removing them)

        [TestMethod]

        public void Remove_RemovingOneValueFromCustomList_RemainingValueGoesToIndexZero()
        {
            // arrange

            CustomList<int> testList = new CustomList<int>();
            int itemToAdd = 32;
            int expected = 32;
            int actual;




            // act

            testList.Add(itemToAdd);
            testList.Add(itemToAdd);
            testList.Add(itemToAdd);
            testList.Add(itemToAdd);
            testList.Remove(itemToAdd);

            actual = testList[0];






            // assert

            Assert.AreEqual(expected, actual);
        }


        [TestMethod]

        public void Remove_RemovingOneValueToEmptyCustomList_CountDecrease()
        {
            // arrange

            CustomList<int> testList = new CustomList<int>();
            int itemToAdd = 32;
            int expected = 3;
            int actual;


            // act


            
            testList.Add(itemToAdd);
            testList.Add(itemToAdd);
            testList.Add(itemToAdd);
            testList.Remove(itemToAdd);

            actual = testList[1];


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
            int itemToAddFour = 33;
            int itemToAddFive = 35;
            int itemToAddSix = 45;
            int expected = 32;
            int actual;

            // act

            testList.Add(itemToAdd);
            testList.Add(itemToAddTwo);
            testList.Add(itemToAddThree);
            testList.Add(itemToAddFour);
            testList.Add(itemToAddFive);
            testList.Add(itemToAddSix);
            testList.Remove(itemToAddFour);
            testList.Remove(itemToAddFive);
            testList.Remove(itemToAddSix);
           
            actual = testList[0];

            // assert

            Assert.AreEqual(expected, actual);

        }

        // Write a test where there are duplicate values and it only removes the first value it finds.

        [TestMethod]

        public void Remove_RemovingDuplicateValuesFromCustomList_ValueOfTwoIndexStaysTheSame()
        {
            // arrange

            CustomList<int> testList = new CustomList<int>();
            int itemToAdd = 9;
            int itemToAddTwo = 8;
            int itemToAddThree = 9;
            int expected = 8;
            

            // act

            testList.Add(itemToAdd);
            testList.Add(itemToAddTwo);
            testList.Add(itemToAddThree);
            testList.Remove(itemToAdd);
            int actual = testList[1];

            // assert

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]

        public void Remove_RemovingMultipleValuesToEmptyCustomList_CheckCapacity()
        {
            // arrange 

            CustomList<int> testList = new CustomList<int>();
            int itemToAdd = 9;
            int itemToAddTwo = 8;
            int itemToAddThree = 22;
            int itemToAddFour = 32;
            int itemToAddFive = 44;
            int itemToAddSix = 23;
            int itemToAddSeven = 64;
            int expected = 8;
            int actual;

            // act

            testList.Add(itemToAdd);
            testList.Add(itemToAddTwo);
            testList.Add(itemToAddThree);
            testList.Add(itemToAddFour);
            testList.Add(itemToAddFive);
            testList.Add(itemToAddSix);
            testList.Add(itemToAddSeven);
            testList.Remove(itemToAddSix);
            testList.Remove(itemToAddSeven);
            actual = testList.Capacity;


            // assert

            Assert.AreEqual(expected, actual);

        }

        // The remove method is used to remove a value from a list. We pass in the value we want to remove. 
        // If there are duplicate values that match what we are trying to remove, the remove method should only remove the first on it finds

        [TestMethod]
        public void Remove_RemovingDuplicateStringsFromCustomList_ValueOfTwoIndexStaysTheSame()
        {
            // arrange
            CustomList<string> testList = new CustomList<string>(); // Creating a list that holds strings

            string expected = "Moon";
            string actual;

            // act
            testList.Add("Moon");
            testList.Add("Sun");		// Adding the value "Sun"
            testList.Add("Moon");		// Adding the value "Moon"
            testList.Add("Earth");		// Adding the value "Earth" 
            testList.Add("Moon");       // Adding the value "Moon" for the second time

            // Currently our list holds the values: "Sun", "Moon", "Earth", "Moon"
            // Currently our list has a count of: 4

            testList.Remove("Moon");    // Calling the Remove method to remove the first "Moon" in the list

            // Assuming the remove method worked we expect:
           
        

            actual = testList[2]; // Grabbing the value at index 2, which now should be "Moon"

            // assert
            Assert.AreEqual(expected, actual);
        }








    }

    }


