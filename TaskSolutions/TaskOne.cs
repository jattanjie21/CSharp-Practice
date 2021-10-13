using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskSolutions
{
    public class TaskOne
    {
        public int a { get; set; }
        public int b { get; set; }
        public int c { get; set; }
        public int d { get; set; }

        public TaskOne(int a,int b,int c,int d)
        {
            this.a = a;
            this.b = b;
            this.c = c;
            this.d = d;
        }
        public int SumDigits()
        {
            return a + b + c + d;
        }


    }
}
