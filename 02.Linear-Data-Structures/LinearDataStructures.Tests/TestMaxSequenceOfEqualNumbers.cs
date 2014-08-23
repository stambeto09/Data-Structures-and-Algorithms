namespace LinearDataStructures.Tests
{
    using System;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using LinearDataStructures;
    using System.Collections.Generic;

    [TestClass]
    public class TestMaxSequenceOfEqualNumbers
    {
        [TestMethod]
        public void TestFindMaximalSequenceHappyPath()
        {
            List<int> expectedList = new List<int>();
            expectedList.Add(2);
            expectedList.Add(2);
            expectedList.Add(2);

            List<int> currentList = new List<int>() { 2, 2, 2, 3, 4, 2, 3, 6 };
            List<int> expectedSequence = MaxSequenceOfEqualNumbers.FindMaximalSequence(currentList);

            for (int index = 0; index <= expectedList.Count - 1; index++)
            {
                Assert.AreEqual(expectedSequence[index], expectedList[index]);
            }
        }
    }
}
