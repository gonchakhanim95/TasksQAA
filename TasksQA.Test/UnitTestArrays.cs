namespace TasksQA.Tests
{
    public class Tests
    {
        [TestCase(new int[] { 3, 5, 77, 9, 11 }, 77)]
        public void FindMaxNumberTest(int[] myArray, int expected)
        {
            int actual = Arrays.FindMaxNumber(myArray);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[] { 3, 5, 6, 85, 2, 7 }, 2)]
        public void FindMinNumberTest(int[] myArray2, int expected)
        {
            int actual = Arrays.FindMinNumber(myArray2);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[] { 5, 95, 3, 65, 71, 10 }, 1)]
        public void FindMaxIndexTest(int[] myArray3, int expected)
        {
            int actual = Arrays.FindMaxIndex(myArray3);
            Assert.AreEqual(expected, actual);
        }
        [TestCase(new int[] { 8, 5, 44, 8, 99 }, 1)]
        public void FindMinIndexTest(int[] myArray4, int expected)
        {
            int actual = Arrays.FindMinIndex(myArray4);
            Assert.AreEqual(expected, actual);
        }
        [TestCase(new int[] { 3, 7, 9, 4, 5, 7, 4, 0 }, 18)]
        [TestCase(new int[] { 6, 9, 10, 8, 4, 1, 11, 5 }, 23)]
        public void SumOddIndexTest(int[] myArray5, int expected)
        {
            int actual = Arrays.SumOddIndex(myArray5);
            Assert.AreEqual(expected, actual);
        }
        [TestCase(new int[] { 2, 5, 8, 6, 4 }, new int[] { 4, 6, 8, 5, 2 })]
        public void ArrayReversedTest(int[] myArray6, int[] expected)
        {
            int[] actual = Arrays.ArrayReversed(myArray6);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[] {2,5,3,1,7,8}, new int[] { 1,2,3,5,7,8 })]
        [TestCase(new int[] {18,99,56,87,34,23}, new int[] {18,23,34,56,87,99})]
        public void BubbleSortTest(int[] myArray9, int[] expected)
        {
            int[] actual = Arrays.BubbleSort(myArray9);
            Assert.AreEqual(expected, actual);
        }
       

    }

}