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
        public int first { get; private set; }
        public int second { get; private set; }
        public int third { get; private set; }
        public int last { get; private set; }

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

            first = collection[0];
            second = collection[1];
            third = collection[2];
            last = collection[3];
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

        public List<int> SwitchLastDigitToFirst()
        {
            
            List<int> switchedDigits = new() { last, second, third, first };

            return switchedDigits;
        }

        //public List<string> SwitchThirdDigitToSecond()
        //{
        //    string first = collection[0].ToString();
        //    string third = collection[2].ToString();
        //    string second = collection[1].ToString();
        //    string last = collection[3].ToString();

        //    List<string> switchedDigits = new List<string> { first, third, second, last };

        //    return switchedDigits;
        //}
    }
}
