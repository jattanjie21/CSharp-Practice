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

        public void MultiplyByTen()
        {
            Random rand = new Random();

            if ((rand.Next(min,max)) >= 1 && (rand.Next(min, max)) <= 3 )
            {
                Console.WriteLine((rand.Next(min, max)) * 10);
            }
            else if ((rand.Next(min, max)) >= 4 && (rand.Next(min, max)) <= 6)
            {
                Console.WriteLine((rand.Next(min, max)) * 100);
            }
            else if ((rand.Next(min, max)) >= 7 && (rand.Next(min, max)) <= 9)
            {
                Console.WriteLine((rand.Next(min, max)) * 1000);
            }
            else if ((rand.Next(min, max)) <= 0 && (rand.Next(min, max)) > 9)
            {
                Console.WriteLine("Error message");
            }
        }
    }
}
