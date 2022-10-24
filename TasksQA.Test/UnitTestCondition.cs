namespace ConditionQ.Tests
{
    public class Tests
    {

        public class ConditionalTest
        {
            [TestCase(7, 5, 12)]
            [TestCase(5, 5, 25)]
            public void MoreLessTest(int a, int b, int expected) // с помощью массива
            {
                int actual = Conditional.MoreLess(a, b);
                Assert.That(actual, Is.EqualTo(expected));
            }
            [TestCase(5, 7, 9, new int[] { 9, 7, 5 })]
            [TestCase(18, 6, 2, new int[] { 18, 6, 2 })]
            [TestCase(4, 8, 10, new int[] { 10, 8, 4 })]

            public void AscendingOrderTest(int a, int b, int c, int[] ecpected)
            {
                int[] actual = Conditional.AscendingOrder(a, b, c);
                Assert.That(actual, Is.EqualTo(ecpected));
            }
        }
    }
}