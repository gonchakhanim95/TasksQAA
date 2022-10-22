namespace CycleQ
{
    public class Cycles
    {
        public static double GetPower(double number, double power) // 1
        {
            double t = number;
            if (number == 0 && power == 1)
            {
                return number;
            }
            if (power == 0)
            {
                return 1;
            }
            if (power > 0)
            {
                for (int i = 1; i < power; i++)
                {
                    number *= t;
                }
                return number;
            }
            else
            {
                for (double i = power; i < (-1); i++)
                {
                    number *= t;
                }
                return 1 / number;
            }

        }
        public static int PowerNumber(int a) //3
        {
            int i = 1;
            while (i * i < a)
            {
                i++;
            }
            return i;
        }

        public static int MaxDividerWithoutSelf(int a) //4
        {
            int temp = 0;
            for (int i = 0; i <= a; i++)
            {
                temp = i / 2;
            }
            return temp;

        }

        public static int SumAllNumber(int a, int b) // 5
        {
            int sum = 0;
            for (int i = a + 1; i < b; i++)
            {

                if (i % 7 == 0)
                {
                    sum += i;
                }
                
            }
            return sum;
        }




        public static int Fibonacci(int n) //6
        {
            int a = 0;
            int b = 1;
            for (int i = 1; i < n; i++)
            {
                int c = a + b;
                a = b;
                b = c;

            }
            return b;
        }

        public static int NOD(int x, int y) // 7
        {
            while (x != y)
            {
                if (x > y)
                {
                    x = x - y;
                }
                else
                    y = y - x;
            }
            return x;
        }

        public static int HalfDivision(int n) //8
        {
            int left = 0;
            int right=n;
            int midle = (left + right)/2;
            while (Math.Pow(midle, 3)!=n)
            {
                if(Math.Pow(midle, 3)>n)
                {
                    right = midle;
                }
                else
                {
                    left = midle;
                }
                midle = (left + right)/2;
            }
            return midle;
        }

        public static int MirrorNumber(int a) //10
        {
            int result = 0;
            while(a%10>0 || a/10>0)
            {
                int b = a%10;
                result = result * 10 + b;
                a = a / 10;
            }
            return result;
        }
    }
}

