using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CSharp_Code_Examples.Basic;

namespace CSharp_Code_Examples_Tests
{
    [TestClass]
    public class SortingAlgorithmsTests
    {
        [TestMethod]
        public void TestBubbleSort()
        {
            int[] array = { 5, 2, 9, 1, 5, 6 };
            SortingAlgorithms.BubbleSort(array);
            CollectionAssert.AreEqual(new int[] { 1, 2, 5, 5, 6, 9 }, array);
        }

        [TestMethod]
        public void TestQuickSort()
        {
            int[] array = { 5, 2, 9, 1, 5, 6 };
            SortingAlgorithms.QuickSort(array, 0, array.Length - 1);
            CollectionAssert.AreEqual(new int[] { 1, 2, 5, 5, 6, 9 }, array);
        }
    }
}
