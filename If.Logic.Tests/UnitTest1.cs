using System;
using Xunit;
using If.Logic;

namespace If.Tests
{
    public class UnitTest1
    {
        [Theory]
        [InlineData(true, true)]
        [InlineData(true, false)]
        [InlineData(false, false)]
        [InlineData(false, true)]
        public void Test1(bool a, bool b)
        {
            // Arrange
            var classToTest = new Class1();
            string firstIf = string.Empty;
            string secondIf = string.Empty;

            // Act
            if (a)
            {
                if (b)
                {
                    firstIf = classToTest.x();
                }
            }
            else
            {
                firstIf = classToTest.y();
            }

            if (a && b)
            {
                secondIf = classToTest.x();
            }
            else
            {
                secondIf = classToTest.y();
            }

            // Assert
            Assert.Equal(firstIf, secondIf);
        }
    }
}
