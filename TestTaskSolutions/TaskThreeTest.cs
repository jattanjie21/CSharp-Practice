
using TaskSolutions;
using Xunit;

namespace TestTaskSolutions
{
    public class TaskThreeTest
    {
        [Fact]
        public void TestComputeSumCheckTwoDifferentNumbers()
        {
            //Arrange
            TaskThree taskThree = new();

            //Act
            int expected = 5;
            int actual = taskThree.ComputeSum(3, 2);

            //Assert
            Assert.Equal(expected, actual);
        }

    }
}
