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
    }
}
