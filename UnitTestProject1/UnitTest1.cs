using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ConsoleApplication1;
using System.Collections.Generic;
//using ConsoleApplication1;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void testMyListToString()
        {
            string[] array = new string[]{"a", "c", "b"};
            List<string> list = new List<string>(array);
            MySortedList<string> ms = new MySortedList<string>();
            ms.Collection = list;
            Assert.AreEqual("a c b", ms.ToString());
        }

        [TestMethod]
        public void testMyListAddEmptyList()
        {
            MySortedList<int> ms = new MySortedList<int>();
            ms.Add(1);
            Assert.AreEqual("1", ms.ToString());
        }

        [TestMethod]
        public void testMyListAddOneElementInListAddSmaller()
        {
            int[] array = new int[] { 5 };
            List<int> list = new List<int>(array);
            MySortedList<int> ms = new MySortedList<int>();
            ms.Collection = list;
            ms.Add(1);
            Assert.AreEqual("1 5", ms.ToString());
        }

        [TestMethod]
        public void testMyListAddOneElementInListAddbigger()
        {
            int[] array = new int[] { 5 };
            List<int> list = new List<int>(array);
            MySortedList<int> ms = new MySortedList<int>();
            ms.Collection = list;
            ms.Add(8);
            Assert.AreEqual("5 8", ms.ToString());
        }

        [TestMethod]
        public void testMyListAddOneElementInListAddTheSame()
        {
            int[] array = new int[] { 5 };
            List<int> list = new List<int>(array);
            MySortedList<int> ms = new MySortedList<int>();
            ms.Collection = list;
            ms.Add(5);
            Assert.AreEqual("5 5", ms.ToString());
        }

        [TestMethod]
        public void testMyListAddTwoElementsInListAddSmaller()
        {
            int[] array = new int[] { 5, 7 };
            List<int> list = new List<int>(array);
            MySortedList<int> ms = new MySortedList<int>();
            ms.Collection = list;
            ms.Add(3);
            Assert.AreEqual("3 5 7", ms.ToString());
        }

        [TestMethod]
        public void testMyListAddTwoElementsInListAddBigger()
        {
            int[] array = new int[] { 5, 7 };
            List<int> list = new List<int>(array);
            MySortedList<int> ms = new MySortedList<int>();
            ms.Collection = list;
            ms.Add(9);
            Assert.AreEqual("5 7 9", ms.ToString());
        }

        [TestMethod]
        public void testMyListAddTwoElementsInListAddInMiddle()
        {
            int[] array = new int[] { 5, 7 };
            List<int> list = new List<int>(array);
            MySortedList<int> ms = new MySortedList<int>();
            ms.Collection = list;
            ms.Add(6);
            Assert.AreEqual("5 6 7", ms.ToString());
        }

        [TestMethod]
        public void testMyListAddTwoElementsInListAddSameAsFirst()
        {
            int[] array = new int[] { 5, 7 };
            List<int> list = new List<int>(array);
            MySortedList<int> ms = new MySortedList<int>();
            ms.Collection = list;
            ms.Add(5);
            Assert.AreEqual("5 5 7", ms.ToString());
        }

        [TestMethod]
        public void testMyListAddTwoElementsInListAddSameAsLast()
        {
            int[] array = new int[] { 5, 7 };
            List<int> list = new List<int>(array);
            MySortedList<int> ms = new MySortedList<int>();
            ms.Collection = list;
            ms.Add(7);
            Assert.AreEqual("5 7 7", ms.ToString());
        }

        [TestMethod]
        public void testMyListAddThreeElementsInList()
        {
            int[] array = new int[] { 5, 7, 9 };
            List<int> list = new List<int>(array);
            MySortedList<int> ms = new MySortedList<int>();
            ms.Collection = list;
            ms.Add(6);
            Assert.AreEqual("5 6 7 9", ms.ToString());
        }


        [TestMethod]
        public void testMyListAddThreeElementsInList1()
        {
            int[] array = new int[] { 5, 7, 9 };
            List<int> list = new List<int>(array);
            MySortedList<int> ms = new MySortedList<int>();
            ms.Collection = list;
            ms.Add(8);
            Assert.AreEqual("5 7 8 9", ms.ToString());
        }

        [TestMethod]
        public void testMyListAddThreeElementsInList2()
        {
            int[] array = new int[] { 5, 7, 9 };
            List<int> list = new List<int>(array);
            MySortedList<int> ms = new MySortedList<int>();
            ms.Collection = list;
            ms.Add(7);
            Assert.AreEqual("5 7 7 9", ms.ToString());
        }

        [TestMethod]
        public void testMyListAddFourElementsInList()
        {
            int[] array = new int[] { 1, 5, 7, 9 };
            List<int> list = new List<int>(array);
            MySortedList<int> ms = new MySortedList<int>();
            ms.Collection = list;
            ms.Add(8);
            Assert.AreEqual("1 5 7 8 9", ms.ToString());
        }


        [TestMethod]
        public void testMyListAddFourElementsInList1()
        {
            int[] array = new int[] { 1, 5, 7, 9 };
            List<int> list = new List<int>(array);
            MySortedList<int> ms = new MySortedList<int>();
            ms.Collection = list;
            ms.Add(3);
            Assert.AreEqual("1 3 5 7 9", ms.ToString());
        }

        [TestMethod]
        public void testMyListAddFourElementsInList2()
        {
            int[] array = new int[] { 1, 5, 7, 9 };
            List<int> list = new List<int>(array);
            MySortedList<int> ms = new MySortedList<int>();
            ms.Collection = list;
            ms.Add(6);
            Assert.AreEqual("1 5 6 7 9", ms.ToString());
        }

        [TestMethod]
        public void testMyListAddCustom()
        {
            int[] array = new int[] { 1, 2, 3, 3, 5, 6 };
            List<int> list = new List<int>(array);
            MySortedList<int> ms = new MySortedList<int>();
            ms.Collection = list;
            ms.Add(2);
            Assert.AreEqual("1 2 2 3 3 5 6", ms.ToString());
        }

    }
}
