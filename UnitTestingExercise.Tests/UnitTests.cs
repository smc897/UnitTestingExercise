using System;
using Xunit;

namespace UnitTestingExercise.Tests
{
    public class UnitTests
    {
        [Theory]
        [InlineData(2, 3, 5, 10)] //Add test data <-------
        public void AddTest(int num1, int num2, int num3, int expected)
        {
            //Start Step 3 here:

            //Arrange
            // create a Calculator object
            Calculator c = new Calculator();

            //Act
            // call the Add method that is located in the Calculator class
            // and store its result in a variable named actual
            var actual = c.Add(num1, num2, num3);

            //Assert
                Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(3,2,1)]//Add test data <-------
        [InlineData(10,8,2)]
        public void SubtractTest(int minuend, int subtrhend, int expected)
        {
            //Start Step 5 here:

            //Arrange
            Calculator c = new Calculator();

            //Act
            var actual = c.Subtract(minuend, subtrhend);

            //Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(3,5,15)]//Add test data <-------
        [InlineData(5,5,25)]
        public void MultiplyTest(int num1, int num2, int expected)
        {
            //Start Step 7 here:
            Calculator c = new Calculator();
            //Arrange
            var actual = c.Multiply(num1, num2);
            //Act

            //Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(5,3,1)]//Add test data <-------
        [InlineData(15,5,3)]
        public void DivideTest(int num1, int num2, int expected)
        {
            //Arrange
            Calculator c = new Calculator();
            //Act
            var actual = c.Divide(num1, num2);
            //Assert
            Assert.Equal(expected, actual);

        }

    }
}
