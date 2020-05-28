using System;

using Xunit;

namespace Sandbox.Tests
{
    public class CalculatorTests
    {
        [Fact]
        public void Add_2_plus_2_equals_4()
        {
            var calculator = new Calculator();
            Assert.Equal(4, calculator.Add(2, 2));
        }
    }
}
