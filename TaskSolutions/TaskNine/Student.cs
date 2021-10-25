
namespace TaskSolutions.TaskNine
{
    public class Student : Person
    {
        public string GoToClasses()
        {
            return "I am going to class";
        }

        public string ShowAge()
        {
            var age = SetAge();

            return $"My age is: {age}";
        }

    }
}
