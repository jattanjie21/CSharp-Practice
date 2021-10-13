using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskSolutions
{
    public class TaskTwo
    {
        public int RangeCalculator(int min, int max)
        {
            Random rand = new Random();
            return rand.Next(min, max);
        }
    }
}
