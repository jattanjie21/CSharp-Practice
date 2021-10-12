using Solutions.Task_Solutions;
using System;

namespace Solution
{
    class Program
    {
        TaskOne taskOne = new TaskOne();

        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            Console.WriteLine(taskOne.SumDigits(2,0,1,1));
        }
    }
}
