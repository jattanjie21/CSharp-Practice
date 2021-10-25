
namespace TaskSolutions.TaskNine
{
    public class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public Person(string name, int age)
        {
            this.Name = name;
            this.Age = age;
        }
        public string Hello()
        {
            return "Hello " + Name;
        }
        public int SetAge()
        {
            return Age;
        }
    }
}
