
namespace TaskSolutions.TaskNine
{
    public class Student : Person
    {
        public Student()
        {

        }
        public string GoToClasses()
        {
            return "I am going to class";
        }

        public string ShowAge(int n)
        {
            var age = SetAge(n);

            return $"My age is: {age}";
        }

    }
}
