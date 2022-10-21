namespace VeraibleQ
{
    public class Veriables
    {
        public static void Division(int a, int b, out int result, out int fractionResult) //1
        {
            result = a / b;
            fractionResult = a % b;
        }
        public static double PowerEquation(int a, int b) // 2
        {

            int c = (5 * a + (b * b) / (b - a));
            return c;
        }

        public static double Equation(int a, int b, int c) // 4  
        {

            int x = (c - b) / a;
            return x;
        }

        public static double PointInThePlane(int x1, int x2, int y1, int y2) // 5
        {
            double a = (y2 - y1) / (x2 - x1);
            double b = y2 - a * x2;
            return b;

        }

        public static double PowerEquationNegative(int a, int b) 
        {
            if ( a==b)
            {
                throw new ArgumentException();
            }

            int c = (5 * a + (b * b) / (b - a));
            return c;
        }
        public static double EquationNegative(int a, int b, int c) // 4  
        {
            if (a==0)
            {
                throw new ArgumentException();
            }
            int x = (c - b) / a;
            return x;
        }

        public static double PointInThePlaneNegative(int x1, int x2, int y1, int y2) // 5
        {
            if (y1 == y2 && x1==x2)
            {throw new ArgumentException();

            }
            double a = (y2 - y1) / (x2 - x1);
            double b = y2 - a * x2;
            return b;

        }
    }




}
