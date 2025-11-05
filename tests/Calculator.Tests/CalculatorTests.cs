using CalculatorLib;
using Xunit;
namespace CalculatorTests
{
    public class CalculatorTests
    {
        private readonly Calculator _calculator;

        public CalculatorTests()
        {
            _calculator = new Calculator();
        }

        [Fact]
        public void Add_TwoNumbers_ReturnsSum()
        {
            int a = 5, b = 3;

            var result = _calculator.Add(a, b);

            Assert.Equal(8, result);
        }

        [Fact]
        public void Subtract_TwoNumbers_ReturnsDifference()
        {
            int a = 5, b = 3;

            var result = _calculator.Subtract(a, b);

            Assert.Equal(2, result);
        }
    }
}