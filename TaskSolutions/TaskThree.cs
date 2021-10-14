using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskSolutions
{
    public class TaskThree
    {

        public int ComputeSum(int a , int b)
        {
            if (a == b)
            {
                int val = (a + b) * 3;
                return val;
            }
            else
            {
                return a + b;
            }
        }
    }
}
