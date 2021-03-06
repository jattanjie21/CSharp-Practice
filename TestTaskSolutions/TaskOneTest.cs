using System.Collections.Generic;
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
            TaskOne taskOne = new TaskOne(2, 0, 1, 1);

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
            TaskOne taskOne = new TaskOne(2, 0, 1, 1);

            //Act
            List<int> expected = new List<int> { 1, 1, 0, 2 };

            List<int> actual = taskOne.ReverseDigits();

            //Assert
            Assert.Equal(expected, actual);

        }

        [Fact]
        public void TestingSwitchLastDigitToFirst()
        {
            //Arrange
            TaskOne taskOne = new TaskOne(2, 0, 1, 1);

            //Act
            List<int> expected = new List<int> { 1, 0, 1, 2 };

            List<int> actual = taskOne.SwitchLastDigitToFirst();

            //Assert
            Assert.Equal(expected, actual);

        }

        [Fact]
        public void TestingSwitchThirdDigitToSecond()
        {
            //Arrange
            TaskOne taskOne = new TaskOne(2, 0, 1, 1);

            //Act
            List<int> expected = new List<int> { 2, 1, 0, 1 };

            List<int> actual = taskOne.SwitchThirdDigitToSecond();

            //Assert
            Assert.Equal(expected, actual);

        }
    }
}
