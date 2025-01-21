namespace Tools.Tests;

public class CalculatorTests //: IDisposable
{

    private Calculator _calculator;

    // Setup
    public CalculatorTests()
    {
        _calculator = new Calculator();
    }

    //public void Dispose()
    //{
    //    _calculator = null;
    //}

    [Fact]
    public void Addition_ShouldReturnAGoodValue ()
    {
        double result = _calculator.Addition(5, 5);

        Assert.Equal(5, result);
    }

    [Fact]
    public void Addition_ShouldReturnAWrongValue()
    {
        double result = _calculator.Addition(5, 4);

        Assert.NotEqual(5, result);
    }
}
