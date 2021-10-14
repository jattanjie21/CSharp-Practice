
using TaskSolutions;
using Xunit;

namespace TestTaskSolutions
{
    public class TaskFourTest
    {
        [Fact]
        public void TestCheckSumInput()
        {
            //Arrange
            TaskFour taskFour = new();

            //Act
            bool expected = true;
            bool actual = taskFour.CheckSumInput(30, 0);

            //Assert
            Assert.Equal(expected, actual);
        }
    }
}
