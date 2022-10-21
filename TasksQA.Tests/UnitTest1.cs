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
        public void SumOddIndexTest(int[] myArray5, int expected)
        {
            int actual = Arrays.SumOddIndex(myArray5);
            Assert.AreEqual(expected, actual);
        }

    }

}