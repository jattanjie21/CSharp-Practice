using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskSolutions
{
    public class TaskOne
    {
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
