using System.Collections.Generic;

namespace TaskSolutions
{
    public class TaskOne
    {
        public int a { get; set; }
        public int b { get; set; }
        public int c { get; set; }
        public int d { get; set; }
        public List<int> collection { get; set; }

        public TaskOne(int a, int b, int c, int d)
        {
            this.a = a;
            this.b = b;
            this.c = c;
            this.d = d;

            collection = new List<int>();
            collection.Add(a);
            collection.Add(b);
            collection.Add(c);
            collection.Add(d);
        }
        public int SumDigits()
        {
            return a + b + c + d;
        }

        public List<int> ReverseDigits()
        {
            collection.Reverse();

            return collection;
        }

        public List<string> SwitchLastDigitToFirst()
        {       
            string last = collection[3].ToString();
            string first = collection[1].ToString();
            string second = collection[2].ToString();
            string third = collection[0].ToString();

            List<string> switchedDigits = new List<string> { last, first, second, third };

            return switchedDigits;
        }

        public List<string> SwitchThirdDigitToSecond()
        {
            string last = collection[3].ToString();
            string first = collection[0].ToString();
            string third = collection[2].ToString();
            string second = collection[1].ToString();

            List<string> switchedDigits = new List<string> { last, first, third, second };

            return switchedDigits;
        }
    }
}
