using System;
using TaskSolutions;

namespace ConsoleTesting
{
    class Program
    {
        static void Main(string[] args)
        {
            //TASKONE!
            //TaskOne taskOne = new TaskOne(2,0,1,1);

            //Console.WriteLine(taskOne.SumDigits());
            //Console.WriteLine("-----------------");

            //foreach (var c in taskOne.ReverseDigits())
            //{
            //    Console.Write(c);
            //    Console.WriteLine();
            //}

            //Console.WriteLine("-----------------");

            //foreach (var c in taskOne.SwitchLastDigitToFirst())
            //{
            //    Console.Write(c);
            //    Console.WriteLine();
            //}

            //Console.WriteLine("-----------------");

            //foreach (var c in taskOne.SwitchThirdDigitToSecond())
            //{
            //    Console.Write(c);
            //    Console.WriteLine();
            //}

            //Console.WriteLine("-----------------");

            //TASKTWO
            TaskTwo taskTwo = new TaskTwo();

            Console.WriteLine(taskTwo.RangeCalculator(0, 9));
            
        }
    }
}
