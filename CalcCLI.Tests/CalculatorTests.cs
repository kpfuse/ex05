namespace CalcCLI.Tests;

public class CalculatorTests
{
    private readonly Calculator _calc = new Calculator();

    [Theory]
    [InlineData(3.5f, 2.5f, 6.0f)]
    [InlineData(-1f, 1f, 0f)]
    public void Add_ReturnsCorrectResult(float a, float b, float expected)
    {
        Assert.Equal(expected, _calc.Add(a, b), precision: 7);
    }
    //----------------------
    // TO DO
    //----------------------
     [Fact]
        public void Calculate_ThrowsException_OnInvalidOperator()
        {
            Assert.Throws<ArgumentException>(() => _calc.Calculate(1, 2, '>'));
        }
}
