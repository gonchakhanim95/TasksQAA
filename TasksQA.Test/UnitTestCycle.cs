namespace CycleQ.Tests
{
    public class Tests
    {
        public class CyclesTest
        {
            [TestCase(2, 3, 8)]
            [TestCase(4, 5, 1024)]
            [TestCase(2, -2, 0.25)]
            public void GetPowerTest(double number,double power ,double expected)
            {
                double actual = Cycles.GetPower( number, power );
                Assert.AreEqual( expected, actual );
            }

            [TestCase(10,4)]
            [TestCase(17,5)]
            public void PowerNumberTest(int a,int expected)
            {
                int actual = Cycles.PowerNumber( a );
                Assert.AreEqual( expected, actual );
            }

            [TestCase(11, 23, 35)]
            [TestCase(1, 19, 21)]
            [TestCase(6, 22, 42)]
            public void SumAllNumberTest(int a,int b,int expected)
            {
                double actual = Cycles.SumAllNumber(a, b);
                Assert.AreEqual( expected, actual );
            }

            [TestCase(5,5)]
            [TestCase(7,13)]
            public void Fibonacci(int n, int expected)
            {
                int actual = Cycles.Fibonacci(n);
                Assert.AreEqual(expected, actual);
            }

        }
    }
}