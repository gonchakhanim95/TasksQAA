namespace ConditionQ
{
    public class Conditional
    {
        public static int MoreLess(int a, int b)
        {
            if (a > b)
            {
                int c = a + b;
                return c;
            }
            else if (a == b)
            {
                int c = a * b;
                return c;
            }
            else
            {
                int c = a - b;
                return c;
            }

        }

        public static int[] AscendingOrder(int a, int b, int c) // с помощью массива
        {
            int[] abc = new int[] { a, b, c };
            int[] bac = new int[] { b, a, c };
            int[] cab = new int[] { c, a, b };
            int[] cba = new int[] { c, b, a };
            int[] bca = new int[] { b, c, a };
            if (a > b && a > c && b > c)
            {
                return abc;
            }
            else if (a > c && b > c && b > a)
            {
                return bac;
            }
            else if (c > a && c > b && a > b)
            {
                return cab;
            }
            else if (c > b && c > a && b > a)
            {
                return cba;
            }
            else
                return bca;
        }

    }
}
