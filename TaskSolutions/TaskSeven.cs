using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskSolutions
{
    public class TaskSeven
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public char Gender { get; set; }

        private int employeeNumber;

        public int GetEmployeeNumber()
        {
            return employeeNumber;
        }

        public void SetEmployeeNumber(int value)
        {
            employeeNumber = value;
        }

        public TaskSeven(string name, int age, char gender)
        {
            this.Name = name;
            this.Age = age;
            this.Gender = gender;
            
        }

        //public TaskSeven AddEmployee()
        //{
        //https://www.geeksforgeeks.org/range-structure-in-c-sharp-8-0/
        //    SetEmployeeNumber(Range(27560000, 9999));
        //}
    }
}
