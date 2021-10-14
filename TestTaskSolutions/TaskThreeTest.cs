
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

        [Fact]
        public void TestComputeSumCheckTheSameNumbers()
        {
            //Arrange
            TaskThree taskThree = new();

            //Act
            int expected = 12;
            int actual = taskThree.ComputeSum(2, 2);

            //Assert
            Assert.Equal(expected, actual);
        }

    }
}
