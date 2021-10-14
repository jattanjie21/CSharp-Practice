using System;

namespace TaskSolutions
{
    public class TaskTwo
    {
        public int min { get; set; }
        public int max { get; set; }
        public int guess {get;set;}
        public TaskTwo(int min, int max)
        {
            this.min = min;
            this.max = max;
            Random rand = new Random();
            guess = rand.Next(min, max);
        }
        
        public void MultiplyByTen()
        {
            Random rand = new Random();

            if (guess >= 1 && guess <= 3 )
            {
                Console.WriteLine(guess * 10);
            }
            else if (guess >= 4 && guess <= 6)
            {
                Console.WriteLine(guess * 100);
            }
            else if (guess >= 7 && guess <= 9)
            {
                Console.WriteLine(guess * 1000);
            }
            else if (guess <= 0 && guess > 9)
            {
                Console.WriteLine("Error message");
            }
        }
    }
}
