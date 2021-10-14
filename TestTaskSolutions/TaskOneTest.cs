using TaskSolutions;
using Xunit;

namespace TestTaskSolutions
{
    public class TaskOneTest
    {
        [Fact]
        public void TestingSumDigits()
        {
            //Arrange
            TaskOne taskOne = new TaskOne(2,0,1,1);

            //Act
            int expected = 4;
            int actual = taskOne.SumDigits();

            //Assert
            Assert.Equal(expected, actual);
        }
        [Fact]
        public void TestingReverseDigits()
        {
            //Arrange

            //Act

            //Assert
        }
    }
}
