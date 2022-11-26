using Xunit;

namespace ExampleLibrary.Tests
{
    public class CalculatorTests
    {
        [Fact]
        public void AddTest()
        {
            var calculator = new Calculator();
            var results = calculator.Add(2, 2);
            Assert.Equal(4, results);
        }
    }
}