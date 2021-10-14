using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskSolutions
{
    public class TaskFour
    {
        public bool CheckSumInput(int a, int b)
        {
            int sum = a + b;

            if ((a == 30) || (b == 30) || (sum == 30))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
