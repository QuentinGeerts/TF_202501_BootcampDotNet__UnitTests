namespace Tools;

public class Calculator
{
    public double Addition(double x, double y) => x + y;
    public double Division(double x, double y)
    {
        if (y == 0) throw new DivideByZeroException("Division par 0 impossible");
        return x / y;
    }
}
