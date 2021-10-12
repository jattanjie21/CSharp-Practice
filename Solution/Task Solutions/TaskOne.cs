using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Solutions.Task_Solutions
{
    public class TaskOne
    {
        public int SumDigits(int a,int b,int c,int d)
        {
            return a + b + c + d;
        }

        public void ReverseOrder(int a, int b, int c, int d)
        {
            List<int> check = new List<int>();

            check.Add(a);
            check.Add(b);
            check.Add(c);
            check.Add(d);

            check.Reverse();
        }
    }
}