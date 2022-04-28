using CalculationLibraries;
using NUnit.Framework;
using FluentAssertions;

namespace CalculatorProject.Tests
{
    public class CalculationsTests
    {
        [TestCase(2, 2, 4)]
        [TestCase(1, 1, 2)]
        [TestCase(3, 5, 8)]
        public void ReturnSumResult(int a, int b, int expected)
        {
            Calculations calculations = new Calculations();

            int actual = calculations.Sum(a, b);

            actual.Should().Be(expected);
        }
    }
}
