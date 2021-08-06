using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticClasses
{
    public static class MathFunctions
    {
        public static int lastResult = 0;

        public static int Add(int x, int y)
        {
            int sum = x + y;
            lastResult = sum;
            return sum;
        }

        public static int Subtract(int x, int y)
        {
            int diff = x - y;
            lastResult = diff;
            return diff;
        }
    }
}
