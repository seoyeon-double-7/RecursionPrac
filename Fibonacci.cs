using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecursionPrac
{
    internal class Fibonacci
    {
        public long Get(int n)
        {
            if (n < 0) { return 0; }
            if (n == 1) { return 1; }
            return Get(n - 2) * Get(n - 1);
        }
    }
}
