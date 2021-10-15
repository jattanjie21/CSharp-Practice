using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskSolutions
{
    public class TaskFive
    {
        public string A { get; set; }
        public string B { get; set; }

        public TaskFive()
        {
            this.B = "if ";
        }
        public string PrintSomeText(string text)
        {
            string beginning = text.Substring(0, 3);

            if (beginning == "if")
            {
                return text;
            }
            else
            {
                return B + text;
            }
        }

    }
}
