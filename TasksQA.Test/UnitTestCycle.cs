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
            [TestCase(28, 14)]
            [TestCase(30,15)]
            public void MaxDividerWithoutSelfTest(int a, int expected)
            {
                int actual = Cycles.MaxDividerWithoutSelf(a);
                Assert.AreEqual(expected, actual);
            }

            [TestCase(11, 23, 35)]
            [TestCase(1, 19, 21)]
            public void SumAllNumberTest(int a,int b,int expected)
            {
                double actual = Cycles.SumAllNumber(a, b);
                Assert.AreEqual( expected, actual );
            }

            [TestCase(5,5)]
            [TestCase(7,13)]
            
            public void FibonacciTest(int n, int expected)
            {
                int actual = Cycles.Fibonacci(n);
                Assert.AreEqual(expected, actual);
            }

            [TestCase(45,15,15)]
            [TestCase(24,16,8)]
            public void NODTest(int a,int b, int expected)
            {
                int actual = Cycles.NOD(a, b);
                Assert.AreEqual(expected, actual);
            }

            [TestCase(125,5)]
            [TestCase(27,3)]
            public void HalfDivisionTest(int n,int expected)
            {
                int actual = Cycles.HalfDivision(n);
                Assert.AreEqual(expected, actual);
            }

            [TestCase(235, 532)]
            [TestCase(1000, 1)]
            public void MirrorNumberTest(int a, int expected)
            {
                int actual = Cycles.MirrorNumber(a);
                Assert.AreEqual(expected, actual);
            }
        }
    }
}