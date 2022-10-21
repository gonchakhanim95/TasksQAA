namespace VeraibleQ
{
    public class VeraibleTest
    {
        [TestCase(5, 2, 2, 1)]
        public void DivisonTest(int a, int b, int expectedResult, int expectedFractionResult)
        {
            Veriables.Division(a, b, out int result, out int fractionResult);
            Assert.AreEqual(expectedResult, result);
            Assert.AreEqual(fractionResult, expectedFractionResult);
        }

        [TestCase(4, 5, 45)]
        [TestCase(2, 3, 19)]

        public void PowerEquationTest(int a, int b, double expected)
        {
            double actual = Veriables.PowerEquation(a, b);
            Assert.AreEqual(expected, actual);
        }
        [TestCase(2, 2, 4, 1)]
        [TestCase(2, 4, 2, -1)]


        public void EquationTest(int a, int b, int c, double expected)
        {
            double actual = Veriables.Equation(a, b, c);
            Assert.AreEqual(expected, actual);
        }
        [TestCase(6, 8, 2, 4, -4)]

        public void PointInThePlaneTest(int x1, int x2, int y1, int y2, double expected)
        {
            double actual = Veriables.PointInThePlane(x1, x2, y1, y2);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(7, 7)]
        public void PowerEquation_KoqdaAravnoBPolucaetsyaDelenyenanol(int a, int b)
        {
            Assert.Throws<DivideByZeroException>(() => Veriables.PowerEquation(a, b));
        }

        [TestCase(0, 4, 2)]
        public void Equation_PriARovnoNolPolucaetsyaDelenieNaNoll(int a, int b, int c)
        {
            Assert.Throws<DivideByZeroException>(() => Veriables.Equation(a, b, c));
        }

        [TestCase(7, 7, 5, 5)]

        public void PointInThePlane_SovpadayutTocki(int x1, int x2, int y1, int y2)
        {
            Assert.Throws<DivideByZeroException>(() => Veriables.PointInThePlane(x1, x2, y1, y2));
        }
    }
}
