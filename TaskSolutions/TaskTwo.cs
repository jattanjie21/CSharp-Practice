using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskSolutions
{
    public class TaskTwo
    {
        public int min { get; set; }
        public int max { get; set; }
        public TaskTwo(int min, int max)
        {
            this.min = min;
            this.max = max;
        }
        //public int RangeCalculator(int min, int max)
        //{
            
        //}

        public void MultiplyByTen()
        {
            Random rand = new Random();

            if ((rand.Next(min,max)) >= 1 && (rand.Next(min, max)) <= 3 )
            {
                Console.WriteLine((rand.Next(min, max)) * 10);
            }
        }
    }
}
