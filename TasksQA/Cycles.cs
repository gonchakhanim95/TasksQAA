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


        public static int Fibonacci(int n)
        {
            int a = 0;
            int b = 1;
            for (int i = 1; i < n; i++)
            {
                int c = a + b;
                a=b;
                b=c;

            }
            return b;
        }


    }
}
