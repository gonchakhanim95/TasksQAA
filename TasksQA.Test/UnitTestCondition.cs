namespace ConditionQ.Tests
{
    public class Tests
    {
        public class ConditionalTest
        {
            [TestCase(7, 5, 12)]
            [TestCase(5, 5, 25)]
            public void MoreLessTest(int a, int b, int expected)
            {
                int actual = Conditional.MoreLess(a, b);
                Assert.AreEqual(expected, actual);
            }
        }
    }
}