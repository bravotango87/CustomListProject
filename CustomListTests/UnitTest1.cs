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
            
            int expected = 1;
            int actual;

            // act
            testList.Add(10);
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
            int actual;
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

            int numAdd = 32;
            int expected = 6;
            int actual;


            // act

            testList.Add(numAdd);
            testList.Add(numAdd);
            testList.Add(numAdd);
            testList.Add(numAdd);
            testList.Add(numAdd);
            testList.Add(numAdd);



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
            
            int expected = 32;
            int actual;

            // act

            testList.Add(24);
            testList.Add(32);
            testList.Add(20);
            testList.Add(32);
            testList.Add(25);

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
            int itemToAdd = 5;
            int itemToAddTwo = 7;
            int itemToAddThree = 8;
            int expected = 7;
            int actual;




            // act

            testList.Add(itemToAdd);
            testList.Add(itemToAddTwo);
            testList.Add(itemToAddThree);
            testList.Remove(itemToAdd);

            actual = testList[0];






            // assert

            Assert.AreEqual(expected, actual);
        }


        [TestMethod]

        public void Remove_RemovingOneValueToEmptyCustomList_CountOfCustomListDecrease()
        {
            // arrange

            CustomList<int> testList = new CustomList<int>();
            int itemToAdd = 10;
            int itemToAddTwo = 12;
            int itemToAddThree = 32;
            int itemToAddFour = 45;

            int expected = 3;
            int actual;




            // act

            testList.Add(itemToAdd);
            testList.Add(itemToAddTwo);
            testList.Add(itemToAddThree);
            testList.Add(itemToAddFour);
            testList.Remove(itemToAddThree);

            actual = testList.Count;

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
            int actual;

            // act

            testList.Add(itemToAdd);
            testList.Add(itemToAddTwo);
            testList.Add(itemToAddThree);
            testList.Remove(itemToAdd);
            actual = testList[1];

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

    }

}
