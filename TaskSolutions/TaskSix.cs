using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskSolutions
{
    public class TaskSix
    {
        public string CompanyName { get; set; }
        //public string Address { get; set; }
        //public int PhoneNumber { get; set; }
        //public int FaxNumber { get; set; }
        //public string WebsiteUrl { get; set; }
        public string Manager { get; set; }

        //List<TaskSix> CompanyDetails = new();
        public TaskSix(string company, string manager)
        {
            this.CompanyName = company;
            this.Manager = manager;
        }
        
        public string CompanySummary()
        {
            return CompanyName + " " + Manager;
        }
    }
}
