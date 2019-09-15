using System;
using Xunit;


namespace Calculator1.Tests
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            // Arrange - setting up the test
            var calculator = new MyCalculator();
            decimal input1 = 3, input2 = 4, expectedOutput = 7; // need to know in advance what it is supposed to do

            // Act
            var output = calculator.Add(input1, input2);

            // Assert
            Assert.Equal(expectedOutput, output);
        }
    }
}
