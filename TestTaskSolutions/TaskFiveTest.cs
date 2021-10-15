using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using TaskSolutions;

namespace TestTaskSolutions
{
    public class TaskFiveTest
    {
        [Fact]
        public void TestPrintSomeText()
        {
            //Arrange
            TaskFive taskFive = new();

            //Act
            string expected = "if else"
            string actual = taskFive.PrintSomeText("if else");

            //Assert
            Assert.Equal(expected, actual);
        }
    }
}
