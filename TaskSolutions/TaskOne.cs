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

        public List<int> ReverseDigits()
        {
            List<int> collection = new List<int>();

            collection.Add(a);
            collection.Add(b);
            collection.Add(c);
            collection.Add(d);

            collection.Reverse();

            return collection;
        }

        public List<string> SwitchLastDigitToFirst()
        {
            List<int> collection = new List<int>();

            collection.Add(a);
            collection.Add(b);
            collection.Add(c);
            collection.Add(d);

            string last =  collection[3].ToString();
            string first = collection[0].ToString();
            string second = collection[1].ToString();
            string third = collection[2].ToString();

            List<string> switchedDigits = new List<string> { last, first, second, third };

            return switchedDigits;
        }
    }
}
