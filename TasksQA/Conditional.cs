using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConditionQ
{
    public class Conditional
    {
        public static int MoreLess(int a,int b)
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

        public static void AscendingOrder(int a, int b, int c)
        {
            if(a>b && a>c && b>c )
            {
                Console.WriteLine($"{a},{b},{c}");
            }
            if(a>c && b>c && b>a)
            {
                Console.WriteLine($"{b},{a},{c}");
            }
            if (c>a && c>b && b>a)
            {
                Console.WriteLine($"{c},{b},{a}");
            }
        }
    }
}
